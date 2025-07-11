using Tools.JassDoc.RoslynParsing;
using WCSharp.JassDoc;

namespace Tools.JassDoc
{
	internal class Program
	{
		private static async Task Main(string[] args)
		{
			if (args.Length == 0)
				return;

			Console.WriteLine("Retrieving JassDoc API.");
			var jassApi = await JassApiCollection.CreateAsync();
			foreach (var csproj in args)
			{
				Console.WriteLine($"Adding JassDoc documentation to {csproj}.");
				var roslynProject = await RoslynParser.GetApiEntities(csproj, jassApi);
				await ApiDocumentationGenerator.Run(roslynProject, dry: false);
			}
		}
	}
}
