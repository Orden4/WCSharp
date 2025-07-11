using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Tools.JassDoc.Bridge;

namespace WCSharp.JassDoc.Bridge
{
	internal static partial class CSharpLuaUtils
	{
		public static Regex ParseAnnotation { get; } = ParseAnnotationRegex();
		public static Regex ParseTemplate { get; } = ParseTemplateRegex();
		public static Regex ParseArgumentOrdinal { get; } = ParseArgumentOrdinalRegex();

		public static string GetTemplate(ISymbol symbol)
		{
			return symbol.GetDocumentationCommentXml()
				?? throw new Exception($"Missing XML documentation: {symbol}");
		}

		public static IEnumerable<CSharpLuaAnnotation> GetAnnotations(ISymbol symbol)
		{
			return GetAnnotations(GetTemplate(symbol));
		}

		public static IEnumerable<CSharpLuaAnnotation> GetAnnotations(string metadata)
		{
			var matches = ParseAnnotation.Matches(metadata);
			foreach (var match in matches.Cast<Match>())
			{
				if (!Enum.TryParse<CSharpLuaAnnotationKind>(match.Groups[1].Value, ignoreCase: true, out var kind))
				{
					kind = CSharpLuaAnnotationKind.Unknown;
				}

				var value = match.Groups.Count > 2 ? match.Groups[3].Value : null;
				if (value == null && kind.HasValue())
					throw new Exception($"Invalid metadata detected. Annotation of kind {kind} should have a value but does not: {metadata}");

				yield return new CSharpLuaAnnotation
				{
					Kind = kind,
					KindValue = match.Groups[1].Value,
					Value = value,
				};
			}
		}

		/// <summary>
		/// Parses a method template that calls a single function and has only simple arguments ({0}, {this}, expressions)
		/// </summary>
		public static bool TryParseMethodBasic(string template, [NotNullWhen(true)] out string? methodName, [NotNullWhen(true)] out List<object>? arguments)
		{
			var match = ParseTemplate.Match(template);
			if (!match.Success)
			{
				methodName = null;
				arguments = null;
				return false;
			}

			methodName = match.Groups[1].Value;
			arguments = [];
			foreach (var argument in match.Groups[2].Value.Split(',', StringSplitOptions.TrimEntries))
			{
				var ordinalMatch = ParseArgumentOrdinal.Match(argument);
				if (ordinalMatch.Success)
				{
					arguments.Add(int.Parse(ordinalMatch.Groups[1].Value));
				}
				else if (!string.IsNullOrEmpty(argument))
				{
					arguments.Add(argument);
				}
			}
			return true;
		}

		[GeneratedRegex(@"@CSharpLua\.([\w-]+)(\s*=\s*\""(.*)"")?")]
		private static partial Regex ParseAnnotationRegex();
		[GeneratedRegex(@"^([a-zA-Z][\w]*)\(([^\(\)]*)\)$")]
		private static partial Regex ParseTemplateRegex();
		[GeneratedRegex(@"^{(\d+)}$")]
		private static partial Regex ParseArgumentOrdinalRegex();
	}
}
