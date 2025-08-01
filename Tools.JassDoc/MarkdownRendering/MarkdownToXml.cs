using System.Xml.Linq;
using Markdig;
using Markdig.Extensions.Tables;
using Markdig.Helpers;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Tools.JassDoc.Bridge;
using Tools.JassDoc.Bridge.Parameters;
using Tools.JassDoc.Bridge.Properties;
using Tools.JassDoc.RoslynParsing;
using WCSharp.IO.JassDoc.Output;

namespace Tools.JassDoc.MarkdownRendering
{
	public class MarkdownToXml
	{
		private readonly MarkdownPipeline markdownPipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
		private readonly JassApiCollection jassApi;
		private readonly RoslynProject roslynProject;

		public MarkdownToXml(JassApiCollection jassApi, RoslynProject roslynProject)
		{
			this.jassApi = jassApi;
			this.roslynProject = roslynProject;
		}

		public string ToXml(string markdown)
		{
			var element = new XElement("empty");
			ToXml(element, markdown);
			return element.Value;
		}

		public void ToXml(XElement element, string markdown)
		{
			var doc = Markdown.Parse(markdown, this.markdownPipeline);
			FormatBlocks(element, doc);
		}

		public string ToXmlDocumentation(IApiEntity entity)
		{
			return entity switch
			{
				ApiProperty property => ToXmlDocumentation(property),
				ApiMethodBasic method => ToXmlDocumentation(method),
				ApiType type => ToXmlDocumentation(type),
				ApiField field => ToXmlDocumentation(field),
				_ => throw new NotImplementedException(),
			};
		}

		public string ToXmlDocumentation(ApiMethodBasic method)
		{
			var jassMethod = method.JassMethod;
			var doc = new List<XElement>();

			var summary = new XElement("summary");

			var native = new XElement("para", "Translates to: ");
			native.Add(new XElement("c", method.FormatNative()));
			summary.Add(native);

			FormatJassEntity(summary, method.JassMethod);

			if (method.JassMethod.Events.Count > 0)
			{
				var eventDescriptor = method.JassMethod.Events.Count > 1 ? "Events" : "Event";
				var events = new XElement("para");
				events.Add(new XElement("b", $"{eventDescriptor}:"));
				events.Add(" ");

				for (var i = 0; i < method.JassMethod.Events.Count; i++)
				{
					var @event = method.JassMethod.Events[i];
					if (this.jassApi.TryGetJassEntity<JassProperty>(@event, out var jassProperty) && this.roslynProject.TryFindApiEntity(jassProperty, out var apiEntity))
					{
						var see = new XElement("see");
						see.SetAttributeValue("cref", EscapeEvent(apiEntity.See()));
						events.Add(see);
					}
					else
					{
						events.Add(new XElement("c", @event));
					}

					if (i < method.JassMethod.Events.Count - 1)
						events.Add(", ");
				}
			}

			doc.Add(summary);

			foreach (var parameter in method.Parameters.OfType<ApiParameterSymbol>().OrderBy(x => x.Ordinal))
			{
				var param = new XElement("param");
				param.SetAttributeValue("name", parameter.Parameter.Name);
				if (!string.IsNullOrWhiteSpace(parameter.JassParameter.Description))
					ToXml(param, parameter.JassParameter.Description);
				doc.Add(param);
			}

			return string.Join(Environment.NewLine, doc.Select(x => x.ToString())).Trim();
		}

		public string ToXmlDocumentation(ApiProperty property)
		{
			var doc = new XDocument();
			var summary = new XElement("summary");

			FormatProperty(summary, property, property.Get);
			if (property.Set != null)
			{
				summary.Add(new XElement("para", new XElement("c", "_________________________")));
				FormatProperty(summary, property, property.Set);
			}

			doc.Add(summary);
			return doc.ToString().Trim();
		}

		public string ToXmlDocumentation(ApiField field)
		{
			var doc = new XDocument();
			var summary = new XElement("summary");

			FormatJassEntity(summary, field.JassProperty);

			doc.Add(summary);
			return doc.ToString().Trim();
		}

		public string ToXmlDocumentation(ApiType type)
		{
			var doc = new XDocument();
			var summary = new XElement("summary");

			if (!string.IsNullOrEmpty(type.JassType.Extends))
			{
				var extends = new XElement("para", "Extends ");
				var see = new XElement("see");
				see.SetAttributeValue("cref", EscapeEvent(type.JassType.Extends));
				extends.Add(see);
				summary.Add(extends);
			}
			FormatJassEntity(summary, type.JassType);

			doc.Add(summary);
			return doc.ToString().Trim();
		}

		private void FormatJassEntity(XElement element, JassEntity entity)
		{
			if (!string.IsNullOrEmpty(entity.Description))
				ToXml(element, entity.Description!);

			foreach (var item in entity.Bugs)
			{
				ToXml(element, $"**Bug:** {item}");
			}

			foreach (var item in entity.Notes)
			{
				ToXml(element, $"**Note:** {item}");
			}

			if (!string.IsNullOrEmpty(entity.Patch))
				ToXml(element, $"**Patch:** {entity.Patch}");
		}

		private void FormatProperty(XElement element, ApiProperty property, IApiPropertyPart part)
		{
			var header = new XElement("b", property.Get == part ? "GET:" : "SET:");
			var native = new XElement("para", header);
			native.Add(new XElement("c", part.FormatNative()));
			element.Add(native);

			switch (part)
			{
				case ApiPropertyMethod method:
					FormatJassEntity(element, method.JassMethod);
					break;
				case ApiPropertyValue value:
					FormatJassEntity(element, value.JassProperty);
					break;
				default:
					break;
			}
		}

		private void FormatBlocks(XElement sb, IEnumerable<Block> blocks)
		{
			foreach (var node in blocks)
			{
				switch (node)
				{
					case ParagraphBlock paragraphBlock:
						FormatParagraphBlock(sb, paragraphBlock);
						break;
					case CodeBlock codeBlock:
						FormatCodeBlock(sb, codeBlock);
						break;
					case ListBlock listBlock:
						FormatListBlock(sb, listBlock);
						break;
					case Table table:
						FormatTable(sb, table);
						break;
					default:
						throw new NotImplementedException();
				}
			}
		}

		private void FormatParagraphBlock(XElement element, ParagraphBlock block)
		{
			var para = new XElement("para");
			FormatInlines(para, block.Inline!.AsEnumerable());
			element.Add(para);
		}

		private static void FormatCodeBlock(XElement element, CodeBlock codeBlock)
		{
			var code = new XElement("code");
			foreach (var line in codeBlock.Lines.Cast<StringLine>())
			{
				code.Add(new string(line.Slice.AsSpan()));
				code.Add(Environment.NewLine);
			}
			element.Add(code);
		}

		private void FormatListBlock(XElement element, ListBlock listBlock)
		{
			string listType;
			if (char.IsNumber(listBlock.BulletType))
			{
				listType = "number";
			}
			else if (listBlock.BulletType is '*' or '-')
			{
				listType = "bullet";
			}
			else
			{
				throw new NotImplementedException();
			}

			var list = new XElement("list");
			list.SetAttributeValue("type", listType);
			foreach (var item in listBlock.Cast<ListItemBlock>())
			{
				var description = new XElement("description");
				FormatBlocks(description, item.Cast<Block>());
				list.Add(new XElement("item", description));
			}
			element.Add(list);
		}

		private void FormatTable(XElement element, Table table)
		{
			var rows = table.Cast<TableRow>();
			var list = new XElement("list");
			list.SetAttributeValue("type", "bullet");

			foreach (var row in rows)
			{
				FormatTableRow(element, row);
			}
		}

		private void FormatTableRow(XElement element, TableRow row)
		{
			var inlines = row
				.Cast<TableCell>()
				.SelectMany(x => x.Cast<ParagraphBlock>().Single().Inline!)
				.ToList();

			var description = new XElement("description");

			for (var i = 0; i < inlines.Count; i++)
			{
				var inline = inlines[i];
				FormatInlines(description, [inline]);
				if (i < inlines.Count - 1)
					description.Add(" — ");
			}

			element.Add(new XElement("item", description));
		}

		private void FormatInlines(XElement element, IEnumerable<Inline> inlines)
		{
			foreach (var inline in inlines)
			{
				switch (inline)
				{
					case LiteralInline literalInline:
						element.Add(new string(literalInline.Content.AsSpan()));
						continue;
					case LineBreakInline:
						element.Add(new XElement("br"));
						continue;
					case EmphasisInline emphasisInline:
						FormatEmphasis(element, emphasisInline);
						continue;
					case CodeInline codeInline:
					{
						if (this.jassApi.TryGetJassEntity<JassEntity>(codeInline.Content, out var jassEntity) && this.roslynProject.TryFindApiEntity(jassEntity, out var apiEntity))
						{
							var see = new XElement("see");
							see.SetAttributeValue("cref", EscapeEvent(apiEntity.See()));
							element.Add(see);
							continue;
						}
						element.Add(new XElement("c", codeInline.Content));
						continue;
					}
					case AutolinkInline autolinkInline:
					{
						var a = new XElement("a");
						a.SetAttributeValue("href", autolinkInline.Url);
						element.Add(a);
						continue;
					}
					case LinkInline linkInline:
					{
						var a = new XElement("a");
						a.SetAttributeValue("href", linkInline.Url);
						FormatInlines(element, linkInline.Descendants().Cast<Inline>());
						element.Add(a);
						continue;
					}
					case LinkDelimiterInline:
						// skip for now
						continue;
					case ContainerInline containerInline:
						element.Add("|");
						FormatInlines(element, containerInline);
						continue;
					default:
						throw new NotImplementedException();
				}
			}
		}

		private void FormatEmphasis(XElement element, EmphasisInline emphasisInline)
		{
			string? elementType = default;

			if (emphasisInline.DelimiterChar == '*')
			{
				if (emphasisInline.DelimiterCount == 1)
				{
					elementType = "i";
				}
				else if (emphasisInline.DelimiterCount == 2)
				{
					elementType = "b";
				}
			}

			if (elementType == default)
				throw new NotImplementedException();

			var emphasis = new XElement(elementType);
			FormatInlines(emphasis, emphasisInline.Descendants().Cast<Inline>());
			element.Add(emphasis);
		}

		private static string EscapeEvent(string s)
		{
			// Very lazy solution but going out of my way to get a list of all conflicting keywords is way more of a hassle
			if (s == "event")
			{
				return "@event";
			}
			else
			{
				return s.Replace(".event", ".@event");
			}
		}
	}
}
