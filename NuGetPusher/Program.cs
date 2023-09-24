using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetPusher
{
	internal class Program
	{
		private static List<string> Projects { get; } = new List<string>
		{
			"ConstantGenerator",
			"Shared",
			"W3MMD",
			"Json",
			"Events",
			"Dummies",
			"Effects",
			"Sync",
			"SaveLoad",
			"Buffs",
			"DateTime",
			"Knockbacks",
			"Lightnings",
			"Missiles",
		};

		public static string ApiKey { get; set; }
		public static string Source { get; set; }

		[STAThread]
		private static async Task Main()
		{
			Environment.CurrentDirectory = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.FullName;
			await CopyFiles();
			Environment.CurrentDirectory = new DirectoryInfo(Environment.CurrentDirectory).GetDirectories().FirstOrDefault(x => x.Name == "NuGet").FullName;

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
