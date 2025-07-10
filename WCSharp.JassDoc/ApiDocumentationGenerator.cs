using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using WCSharp.JassDoc.Bridge;
using WCSharp.JassDoc.MarkdownRendering;
using WCSharp.JassDoc.RoslynParsing;

namespace WCSharp.JassDoc
{
	public partial class ApiDocumentationGenerator
	{
		private static Regex IsDocumentation { get; } = IsDocumentationRegex();

		public static async Task Run(RoslynProject project, bool dry = true)
		{
			var generator = new ApiDocumentationGenerator(project, dry);
			await generator.Run();
		}

		private readonly RoslynProject project;
		private readonly bool dry;
		private readonly MarkdownToXml markdownToXml;

		public ApiDocumentationGenerator(RoslynProject project, bool dry)
		{
			this.project = project;
			this.dry = dry;
			this.markdownToXml = new MarkdownToXml(project.JassApi, project);
		}

		public async Task Run()
		{
			var fileCache = new Dictionary<string, List<string>>();

			foreach (var entity in GetOrderedEntities())
			{
				if (entity.Symbol.GetDocumentationCommentXml()!.Contains("<summary>"))
					continue;

				var filePath = entity.SyntaxNode.SyntaxTree.FilePath;
				if (!fileCache.TryGetValue(filePath, out var lines))
				{
					fileCache[filePath] = lines = [.. await File.ReadAllLinesAsync(filePath)];
				}

				var span = entity.SyntaxNode.SyntaxTree.GetLineSpan(entity.SyntaxNode.Span);
				var insertIndex = GetInsertIndex(lines, span);
				var xml = this.markdownToXml.ToXmlDocumentation(entity);
				var indentation = $"{string.Concat(Enumerable.Repeat('\t', span.StartLinePosition.Character))}/// ";
				lines.InsertRange(insertIndex, xml.Split(Environment.NewLine).Select(x => string.Concat(indentation, x)));
			}

			if (!this.dry)
			{
				foreach (var (filePath, lines) in fileCache)
				{
					await File.WriteAllLinesAsync(filePath, lines);
				}
			}
		}

		private static int GetInsertIndex(List<string> lines, FileLinePositionSpan span)
		{
			var insertIndex = span.StartLinePosition.Line - 1;
			while (IsDocumentation.IsMatch(lines[insertIndex]))
			{
				insertIndex--;
			}
			return insertIndex + 1;
		}

		private IEnumerable<IApiEntity> GetOrderedEntities()
		{
			return this.project.ApiEntities
				.OrderBy(x => x.SyntaxNode.SyntaxTree.FilePath)
				.ThenByDescending(x => x.SyntaxNode.Span.Start);
		}

		[GeneratedRegex(@"^\s*///")]
		private static partial Regex IsDocumentationRegex();
	}
}
