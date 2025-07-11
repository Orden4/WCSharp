using Tools.JassDoc.RoslynParsing;
using WCSharp.JassDoc;

namespace Tools.JassDoc
{
	internal class Program
	{
		private static async Task Main()
		{
			var dirInfo = new DirectoryInfo(Environment.CurrentDirectory);
			while (!string.Equals(dirInfo.Name, "WCSharp", StringComparison.OrdinalIgnoreCase))
			{
				dirInfo = dirInfo.Parent;
				if (dirInfo == null)
					throw new Exception("Could not find base directory");
			}
			Environment.CurrentDirectory = dirInfo.FullName;
			var jassApi = await JassApiCollection.CreateAsync();
			var roslynProject = await RoslynParser.GetApiEntities(@"WCSharp.Api\WCSharp.Api.csproj", jassApi);
			await ApiDocumentationGenerator.Run(roslynProject);
			await Task.Delay(Timeout.Infinite);
		}
	}
}
