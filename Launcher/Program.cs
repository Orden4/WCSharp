using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using War3Net.Build;
using WCSharp.ConstantGenerator;

namespace Launcher
{
	internal static class Program
	{
		// Input
		private const string SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\Source";
		private const string ASSETS_FOLDER_PATH = @"..\..\..\..\Assets\";
		private const string BASE_MAP_PATH = @"..\..\..\..\source.w3x";

		// Output
		private const string OUTPUT_FOLDER_PATH = @"..\..\..\..\artifacts";
		private const string OUTPUT_MAP_NAME = @"target.w3x";

		// Warcraft III
		private const string GRAPHICS_API = "Direct3D9";
		private const bool PAUSE_GAME_ON_LOSE_FOCUS = false;

		private static void Main()
		{
			Console.WriteLine("The following actions are available:");
			Console.WriteLine("1. Generate constants");
			Console.WriteLine("2. Compile map");
			Console.WriteLine("3. Compile and run map");
			MakeDecision();
		}

		private static void MakeDecision()
		{
			Console.Write("Please type the number of your desired action: ");
			switch (Console.ReadKey().Key)
			{
				case ConsoleKey.D1:
					ConstantGenerator.Run(BASE_MAP_PATH, SOURCE_CODE_PROJECT_FOLDER_PATH);
					break;
				case ConsoleKey.D2:
					Build(false);
					break;
				case ConsoleKey.D3:
					Build(true);
					break;
				default:
					Console.WriteLine($"{Environment.NewLine}Invalid input. Please choose again.");
					MakeDecision();
					break;
			}
		}

		public static void Build(bool launch)
		{
			// Build and launch
			var mapBuilder = new MapBuilder(OUTPUT_MAP_NAME);
			var options = CompilerOptions.GetCompilerOptions(SOURCE_CODE_PROJECT_FOLDER_PATH, OUTPUT_FOLDER_PATH);
			var buildResult = mapBuilder.Build(options, ASSETS_FOLDER_PATH, BASE_MAP_PATH);

			if (buildResult.Success)
			{
				var mapPath = Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME);
				var absoluteMapPath = new FileInfo(mapPath).FullName;

				if (launch)
				{
					var wc3exe = ConfigurationManager.AppSettings["wc3exe"];
					if (wc3exe != null)
					{
						var commandLineArgs = new StringBuilder();
						var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(wc3exe).FileVersion) >= new Version(1, 32);
						if (isReforged)
						{
							commandLineArgs.Append("-launch ");
						}
						else if (GRAPHICS_API != null)
						{
							commandLineArgs.Append($"-graphicsapi {GRAPHICS_API} ");
						}

						if (!PAUSE_GAME_ON_LOSE_FOCUS)
						{
							commandLineArgs.Append("-nowfpause ");
						}

						commandLineArgs.Append($"-loadfile \"{absoluteMapPath}\"");

						Process.Start(wc3exe, commandLineArgs.ToString());
					}
				}
			}
			else
			{
				throw new Exception(buildResult.Diagnostics.First(x => x.Severity == DiagnosticSeverity.Error).GetMessage());
			}
		}
	}
}
