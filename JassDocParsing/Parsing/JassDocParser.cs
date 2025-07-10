using System.Net;
using JassDocParsing.Output;
using Pidgin;
using static Pidgin.Parser<char>;
using static Pidgin.Parser;

namespace JassDocParsing.Parsing
{
	public static class JassDocParser
	{
		public static async Task<JassApi> ParseDoc(Uri uri, string sourceFileName)
		{
			string content;

			if (uri.IsFile)
			{
				content = File.ReadAllText(uri.LocalPath);
			}
			else
			{
				using var httpClient = new HttpClient();
				using var response = await httpClient.GetAsync(uri);
				if (response.StatusCode != HttpStatusCode.OK)
					throw new InvalidOperationException($"Unable to retrieve jassdoc document at {uri} (status code: {response.StatusCode})");
				content = await response.Content.ReadAsStringAsync();
			}

			return ParseDoc(content, sourceFileName);
		}

		public static JassApi ParseDoc(string input, string sourceFileName)
		{
			const bool DEBUG_PARSE_SEQUENCE = false;

			var tokens = blocksParser.ParseOrThrow(input)
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Select(x => x.Trim());

			var lastDoc = Array.Empty<DocAnnotation>();
			var entities = new List<JassEntity>();
			var expectDoc = false;
			foreach (var token in tokens)
			{
				expectDoc = !expectDoc;

				var docResult = docParser.Parse(token);
				if (expectDoc && !docResult.Success && DEBUG_PARSE_SEQUENCE)
					throw new Exception();

				if (docResult.Success)
				{
					lastDoc = docResult.Value.ToArray();
					continue;
				}

				var entityResult = entityParser.Parse(token);
				if (!expectDoc && !entityResult.Success && DEBUG_PARSE_SEQUENCE)
					throw new Exception();

				if (entityResult.Success)
				{
					var entity = entityResult.Value;
					entity.SourceFile = sourceFileName;
					entity.Source = token;
					foreach (var doc in lastDoc)
					{
						doc.Value = doc.Value?.Trim();
						switch (doc.Identifier)
						{
							case "@patch":
								entity.Patch = doc.Value ?? "";
								break;
							case "@note":
								if (doc.Value != null)
									entity.Notes.Add(doc.Value);
								break;
							case "@bug":
								if (doc.Value != null)
									entity.Bugs.Add(doc.Value);
								break;
							case "@pure":
								((JassMethod)entity).IsPure = true;
								break;
							case "@async":
								((JassMethod)entity).IsAsync = true;
								break;
							case "@event":
								if (doc.Value != null)
									((JassMethod)entity).Events.Add(doc.Value);
								break;
							case "@param":
							{
								if (entity is not JassMethod method)
									throw new InvalidOperationException("@param annotation used for a non-function");
								if (doc.Value != null)
								{
									var parameterName = string.Concat(doc.Value.TakeWhile(x => !char.IsWhiteSpace(x)));
									var parameter = method.Parameters.First(x => x.Name == parameterName);
									parameter.Description = doc.Value.Substring(parameterName.Length).Trim();
								}
								break;
							}
							default:
								if (!string.IsNullOrEmpty(doc.Value))
									entity.Description = doc.Value;
								break;
						}
					}

					entities.Add(entity);
					lastDoc = [];
				}
			}

			return new JassApi
			{
				Methods = entities.OfType<JassMethod>().ToList(),
				Properties = entities.OfType<JassProperty>().ToList(),
				Types = entities.OfType<JassType>().ToList(),
			};
		}

		private static readonly Parser<char, char> equalsId = Char('=');
		private static readonly Parser<char, char> commaId = Char(',');

		private static readonly Parser<char, string> arrayId = String("array");
		private static readonly Parser<char, string> commentId = String("//");
		private static readonly Parser<char, string> constantId = String("constant");
		private static readonly Parser<char, string> docId = String("/**");
		private static readonly Parser<char, string> docEndId = String("*/");
		private static readonly Parser<char, string> extendsId = String("extends");
		private static readonly Parser<char, string> functionId = String("function");
		private static readonly Parser<char, string> functionEndId = String("endfunction");
		private static readonly Parser<char, string> nativeId = String("native");
		private static readonly Parser<char, string> nothingId = String("nothing");
		private static readonly Parser<char, string> returnsId = String("returns");
		private static readonly Parser<char, string> takesId = String("takes");
		private static readonly Parser<char, string> typeId = String("type");

		private static readonly Parser<char, char> nameToken = Token(x => char.IsLetterOrDigit(x) || x == '_');
		private static readonly Parser<char, string> untilEndOfLine = Any.Until(OneOf(EndOfLine, End.ThenReturn(string.Empty))).Select(x => string.Concat(x));

		#region Parse source into tokens
		private static readonly Parser<char, string> commentToken = Try(commentId)
			.Then(untilEndOfLine)
			.ThenReturn(string.Empty)
			.Labelled("comment");
		private static readonly Parser<char, string> docToken = Try(docId)
			.Then(Any.Until(Try(docEndId)))
			.Select(x => $"/**{string.Concat(x)}*/")
			.Labelled("doc");
		private static readonly Parser<char, string> functionToken = Try(functionId)
			.Then(Any.Until(Try(functionEndId)))
			.Select(x => $"function{string.Concat(x)}endfunction")
			.Labelled("function");
		private static readonly Parser<char, string> singleLineToken = Lookahead(Try(OneOf(constantId, nativeId, typeId)))
			.Then(untilEndOfLine)
			.Labelled("single line token");
		private static readonly Parser<char, string> fieldToken = Lookahead(Try(
			Letter.AtLeastOnce()
			.Then(SkipWhitespaces)
			.Then(nameToken.AtLeastOnce())
			.ThenReturn(string.Empty)
		)).Then(untilEndOfLine).Labelled("field");

		private static readonly Parser<char, string> blockParser = OneOf(commentToken, docToken, functionToken, singleLineToken, fieldToken);
		private static readonly Parser<char, IEnumerable<string>> blocksParser = blockParser.Or(Any.ThenReturn(string.Empty)).Until(End);
		#endregion

		#region Parse token into doc
		private static readonly Parser<char, string> noteId = String("@note");
		private static readonly Parser<char, string> bugId = String("@bug");
		private static readonly Parser<char, string> paramId = String("@param");
		private static readonly Parser<char, string> pureId = String("@pure");
		private static readonly Parser<char, string> asyncId = String("@async");
		private static readonly Parser<char, string> eventId = String("@event");
		private static readonly Parser<char, string> patchId = String("@patch");

		private static readonly Parser<char, string> docOptions = Lookahead(OneOf(Try(noteId), Try(bugId), Try(paramId), Try(pureId),
			Try(asyncId), Try(eventId), Try(patchId), Try(docEndId)));

		private static readonly Parser<char, string> docValue = Any
			.Until(docOptions)
			.Select(x => string.Concat(x));
		private static readonly Parser<char, DocAnnotation> docAnnotation = Map(
			(identifier, value) => new DocAnnotation { Identifier = identifier, Value = string.Concat(value).Trim() },
			OneOf(Try(noteId), Try(bugId), Try(paramId), Try(pureId), Try(asyncId), Try(eventId), Try(patchId)),
			Any.Until(docOptions)
		);
		private static readonly Parser<char, IEnumerable<DocAnnotation>> docAnnotations = Map(
			(summary, docs) => summary.HasValue ? docs.Prepend(new DocAnnotation { Value = summary.Value }) : docs,
			docValue.Optional(),
			docAnnotation.Many()
		);
		private static readonly Parser<char, IEnumerable<DocAnnotation>> docParser = docId.Then(docAnnotations);
		#endregion

		#region Parse token into jass entity
		private static readonly Parser<char, JassType> jassType = Try(typeId).Then(Map(
			(name, extends) =>
			{
				var extendsValue = extends.GetValueOrDefault();
				if (string.Equals(extendsValue, "void", StringComparison.OrdinalIgnoreCase))
				{
					extendsValue = null;
				}
				return new JassType { Name = name, Extends = extendsValue };
			},
			SkipWhitespaces.Then(Letter.AtLeastOnceString()),
			SkipWhitespaces.Then(Try(extendsId)).Then(SkipWhitespaces).Then(Letter.AtLeastOnceString()).Optional()
		));
		private static readonly Parser<char, JassMethodParameter> jassParameter = Map(
			(type, name) => new JassMethodParameter { Name = name, Type = type },
			SkipWhitespaces.Then(nameToken.AtLeastOnceString()),
			SkipWhitespaces.Then(nameToken.AtLeastOnceString())
		);
		private static readonly Parser<char, IEnumerable<JassMethodParameter>> jassParameters = Try(nothingId.ThenReturn(Enumerable.Empty<JassMethodParameter>()))
			.Or(jassParameter.Separated(commaId));
		private static readonly Parser<char, JassMethod> jassFunctionDef = Map(
			(name, parameters, returnType) => new JassMethod { Name = name, Parameters = parameters.Select((x, i) => { x.Index = i; return x; }).ToList(), ReturnType = returnType },
			SkipWhitespaces.Then(nameToken.AtLeastOnceString()),
			SkipWhitespaces.Then(takesId).Then(SkipWhitespaces).Then(jassParameters),
			SkipWhitespaces.Then(returnsId).Then(SkipWhitespaces).Then(nameToken.AtLeastOnceString())
		);
		private static readonly Parser<char, JassMethod> jassNative = Try(nativeId).Then(jassFunctionDef);
		private static readonly Parser<char, JassProperty> jassField = Try(Map(
			(type, name, value) => new JassProperty { Name = name, Type = type, Value = value },
			SkipWhitespaces.Then(nameToken.AtLeastOnceString()),
			SkipWhitespaces.Then(nameToken.AtLeastOnceString()),
			SkipWhitespaces.Then(equalsId).Then(SkipWhitespaces).Then(Any.AtLeastOnceUntil(OneOf(End.ThenReturn(string.Empty), EndOfLine, Try(commentId)))).Select<string?>(x => string.Concat(x))
				.Or(Return<string?>(null))
		));
		private static readonly Parser<char, JassEntity> jassConstant = Try(constantId).Then(SkipWhitespaces.Then(OneOf(
			jassNative.Select(x => { x.IsConstant = true; return x; }).Cast<JassEntity>(),
			jassField.Select(x => { x.IsConstant = true; return x; }).Cast<JassEntity>()
		)));
		private static readonly Parser<char, JassProperty> jassArray = Try(Map(
			(type, name) => new JassProperty { Name = name, Type = type, IsArray = true },
			SkipWhitespaces.Then(nameToken.AtLeastOnceString()),
			SkipWhitespaces.Then(arrayId).Then(SkipWhitespaces).Then(nameToken.AtLeastOnceString())
		));
		private static readonly Parser<char, JassMethod> jassFunction = Try(functionId.Then(Whitespaces)).Then(jassFunctionDef);

		private static readonly Parser<char, JassEntity> entityParser = OneOf(
			jassType.Cast<JassEntity>(),
			jassConstant.Cast<JassEntity>(),
			jassNative.Cast<JassEntity>(),
			jassFunction.Cast<JassEntity>(),
			jassArray.Cast<JassEntity>(),
			jassField.Cast<JassEntity>()
		);

		#endregion
	}
}
