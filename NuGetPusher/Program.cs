using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WCSharp.JassDoc;
using WCSharp.JassDoc.RoslynParsing;

namespace NuGetPusher
{
	internal class Program
	{
		private static List<string> Projects { get; } =
		[
			"Api",
			"CSharpLua.CoreSystem",
			"ConstantGenerator",
			"Shared",
			"W3MMD",
			"Json",
			"Events",
			"Sync",
			"Dummies",
			"Effects",
			"Knockbacks",
			"Lightnings",
			"Missiles",
			"Buffs",
			"DateTime",
			"SaveLoad",
		];

		public static string ApiKey { get; set; }
		public static string Source { get; set; }

		[STAThread]
		private static async Task Main()
		{
			Environment.CurrentDirectory = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.FullName;
			await CopyFiles();
			Environment.CurrentDirectory = new DirectoryInfo(Environment.CurrentDirectory).GetDirectories().FirstOrDefault(x => x.Name == "NuGet").FullName;

			var jassApi = await JassApiCollection.CreateAsync();
			var roslynProject = await RoslynParser.GetApiEntities(@"WCSharp.Api\WCSharp.Api.csproj", jassApi);
			await ApiDocumentationGenerator.Run(roslynProject, dry: false);

			ApiKey = ConfigurationManager.AppSettings["api-key"];
			Source = ConfigurationManager.AppSettings["source"];

			Console.WriteLine("Press enter to start.");
			Console.ReadLine();

			var runner = new Runner();
			foreach (var project in Projects)
			{
				await runner.Run($"WCSharp.{project}");
			}
		}

		private static async Task CopyFiles()
		{
			var startInfo = new ProcessStartInfo
			{
				FileName = "nuget-copy.bat"
			};
			using var process = Process.Start(startInfo);
			await process.WaitForExitAsync();
		}
	}
}
