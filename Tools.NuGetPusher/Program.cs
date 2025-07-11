using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using Tools.JassDoc;
using Tools.JassDoc.RoslynParsing;
using WCSharp.JassDoc;

namespace NuGetPusher
{
	internal class Program
	{
		[STAThread]
		private static async Task Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration()
				.WriteTo.Console()
				.CreateLogger();

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appSettings.json")
				.AddCommandLine(args)
				.Build();
			var appSettings = configuration.Get<AppSettings>()
				?? throw new InvalidOperationException("No AppSettings found.");

			await DocumentProjects(appSettings);

			var runner = new Runner(appSettings);
			foreach (var project in appSettings.Projects)
			{
				await runner.Run(project, appSettings.PackageVersion);
			}
		}

		private static async Task DocumentProjects(AppSettings appSettings)
		{
			if (appSettings.JassDocProjects.Count == 0)
				return;

			var jassApi = await JassApiCollection.CreateAsync();
			foreach (var project in appSettings.JassDocProjects)
			{
				Log.Information("Adding JassDoc documentation to {Project}.", project);
				var roslynProject = await RoslynParser.GetApiEntities(Path.Combine(project, $"{project}.csproj"), jassApi);
				await ApiDocumentationGenerator.Run(roslynProject, dry: false);
			}
		}
	}
}
