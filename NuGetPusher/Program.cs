using System;
using System.Collections.Generic;
using System.Configuration;
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
			"Events",
			"Json",
			"Sync",
			"SaveLoad",
			"Effects",
			"Dummies",
			"Buffs",
			"DateTime",
			"Knockbacks",
			"Lightnings",
			"Missiles",
		};

		public static string ApiKey { get; set; }
		public static string Source { get; set; }

		[STAThread]
		private static async Task Main(string[] args)
		{
			ApiKey = ConfigurationManager.AppSettings["api-key"];
			Source = ConfigurationManager.AppSettings["source"];
			var runner = new Runner(SOURCE);
			Environment.CurrentDirectory = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.Parent.GetDirectories().FirstOrDefault(x => x.Name == "NuGet").FullName;
			foreach (var project in Projects)
			{
				await runner.Run($"WCSharp.{project}");
			}
		}
	}
}
