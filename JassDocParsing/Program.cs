using System.Text.Json;
using JassDocParsing.Configuration;
using JassDocParsing.Parsing;
using Microsoft.Extensions.Configuration;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<char>;

namespace JassDocParsing
{
	internal class Program
	{
		public static async Task Main()
		{
			var configurationBuilder = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();
			var appSettings = configurationBuilder.Get<AppSettings>()
				?? throw new InvalidOperationException("appsettings.json file is required.");

			var serializerOptions = new JsonSerializerOptions
			{
				WriteIndented = true
			};

			foreach (var uri in appSettings.Input)
			{
				var path = uri.ToString();
				path = path.Substring(path.LastIndexOf('/') + 1);
				var doc = await JassDocParser.ParseDoc(uri, path);
				await File.WriteAllTextAsync(path, JsonSerializer.Serialize(doc, serializerOptions));
			}
		}

		private static readonly Parser<char, string> noteId = Try(String("@note"));
		private static readonly Parser<char, string> bugId = Try(String("@bug"));
		private static readonly Parser<char, string> paramId = Try(String("@param"));
		private static readonly Parser<char, string> pureId = Try(String("@pure"));
		private static readonly Parser<char, string> asyncId = Try(String("@async"));
		private static readonly Parser<char, string> eventId = Try(String("@event"));
		private static readonly Parser<char, string> patchId = Try(String("@patch"));
		private static readonly Parser<char, string> valueParser = Any
			.Until(Lookahead(OneOf(noteId, bugId, paramId, pureId, asyncId, eventId, patchId, End.ThenReturn(string.Empty))))
			.Select(x => string.Concat(x));
		private static readonly Parser<char, DocAnnotation> docToken = Map(
			(identifier, value) => new DocAnnotation { Identifier = identifier, Value = string.Concat(value).Trim() },
			OneOf(noteId, bugId, paramId, pureId, asyncId, eventId, patchId),
			Any.Until(Lookahead(OneOf(noteId, bugId, paramId, pureId, asyncId, eventId, patchId, End.ThenReturn(string.Empty))))
		);
		private static readonly Parser<char, IEnumerable<DocAnnotation>> docTokens = Map(
			(summary, docs) => summary.HasValue ? docs.Prepend(new DocAnnotation { Value = summary.Value }) : docs,
			valueParser.Optional(),
			docToken.Many()
		);
	}
}
