using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using CSharpLua;
using Microsoft.CodeAnalysis;
using War3Net.Build;
using War3Net.Build.Extensions;
using War3Net.IO.Mpq;
using WCSharp.ConstantGenerator;

namespace Launcher
{
	internal static class Program
	{
		// Input
		private const string SOURCE_CODE_PROJECT_FOLDER_PATH = @"..\..\..\..\Source";
		private const string BASE_MAP_PATH = @"..\..\..\..\source.w3x";

		// Output
		private const string OUTPUT_FOLDER_PATH = @"..\..\..\..\artifacts";
		private const string OUTPUT_SCRIPT_NAME = @"war3map.lua";
		private const string OUTPUT_MAP_NAME = @"target.w3x";

		// Warcraft III
		private const string GRAPHICS_API = "Direct3D9";
		private const bool PAUSE_GAME_ON_LOSE_FOCUS = false;
#if DEBUG
		private const bool DEBUG = true;
#else
		private const bool DEBUG = false;
#endif

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
					ConstantGenerator.Run(BASE_MAP_PATH, SOURCE_CODE_PROJECT_FOLDER_PATH, new ConstantGeneratorOptions
					{
						IncludeCode = false
					});
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
			// Ensure these folders exist
			Directory.CreateDirectory(OUTPUT_FOLDER_PATH);

			// Load existing map data
			var map = Map.Open(BASE_MAP_PATH);
			var builder = new MapBuilder(map);
			builder.AddFiles(BASE_MAP_PATH, "*", SearchOption.AllDirectories);

			// Set debug options if necessary, configure compiler
			var csc = DEBUG ? "-debug -define:DEBUG" : null;
			var csproj = Directory.EnumerateFiles(SOURCE_CODE_PROJECT_FOLDER_PATH, "*.csproj", SearchOption.TopDirectoryOnly).Single();
			var compiler = new Compiler(csproj, OUTPUT_FOLDER_PATH, string.Empty, null, "War3Api.*;WCSharp.*", "", csc, false, null, string.Empty)
			{
				IsExportMetadata = true,
				IsModule = false,
				IsInlineSimpleProperty = false,
				IsPreventDebugObject = true,
				IsCommentsDisabled = !DEBUG,
			};

			// Collect required paths and compile
			var coreSystemFiles = CSharpLua.CoreSystem.CoreSystemProvider.GetCoreSystemFiles()
				.Where(x => !x.EndsWith("Common.lua"))
				.Concat(new[] { "CoreSystem/WCSharp.lua", "PriorityQueue.lua", "SortedDictionary.lua", "SortedList.lua" });
			var blizzardJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Warcraft III/JassHelper/Blizzard.j");
			var commonJ = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Warcraft III/JassHelper/common.j");
			var compileResult = map.CompileScript(compiler, coreSystemFiles, blizzardJ, commonJ);

			// If compilation failed, output an error
			if (!compileResult.Success)
			{
				throw new Exception(compileResult.Diagnostics.First(x => x.Severity == DiagnosticSeverity.Error).GetMessage());
			}

			// Update war3map.lua so you can inspect the generated Lua code easily
			File.WriteAllText(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_SCRIPT_NAME), map.Script);

			// Build w3x file
			var archiveCreateOptions = new MpqArchiveCreateOptions
			{
				ListFileCreateMode = MpqFileCreateMode.Overwrite,
				AttributesCreateMode = MpqFileCreateMode.Prune,
				BlockSize = 3,
			};

			builder.Build(Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME), archiveCreateOptions);

			// Launch if that option was selected
			if (launch)
			{
				var wc3exe = ConfigurationManager.AppSettings["wc3exe"];
				if (File.Exists(wc3exe))
				{
					var commandLineArgs = new StringBuilder();
					var isReforged = Version.Parse(FileVersionInfo.GetVersionInfo(wc3exe).FileVersion) >= new Version(1, 32);
					if (isReforged)
					{
						commandLineArgs.Append(" -launch");
					}
					else if (GRAPHICS_API != null)
					{
						commandLineArgs.Append($" -graphicsapi {GRAPHICS_API}");
					}

					if (!PAUSE_GAME_ON_LOSE_FOCUS)
					{
						commandLineArgs.Append(" -nowfpause");
					}

					var mapPath = Path.Combine(OUTPUT_FOLDER_PATH, OUTPUT_MAP_NAME);
					var absoluteMapPath = new FileInfo(mapPath).FullName;
					commandLineArgs.Append($" -loadfile \"{absoluteMapPath}\"");

					Process.Start(wc3exe, commandLineArgs.ToString());
				}
				else
				{
					throw new Exception("Please set wc3exe in Launcher/app.config to the path of your Warcraft III executable.");
				}
			}
		}
	}
}
