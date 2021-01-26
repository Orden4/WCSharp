using CSharpLua.CoreSystem;
using War3Net.Build.Environment;
using War3Net.Build.Script;
using War3Net.IO.Mpq;

namespace Launcher
{
	internal static class CompilerOptions
	{
		public static ScriptCompilerOptions GetCompilerOptions(string sourceDirectory, string outputDirectory)
		{
			var scriptCompilerOptions = new ScriptCompilerOptions(CoreSystemProvider.GetCoreSystemFiles())
			{
				SourceDirectory = sourceDirectory,
				OutputDirectory = outputDirectory,
				MapRegions = new MapRegions(),
#if RELEASE
				Optimize = true,
#endif
				DefaultFileFlags = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti
			};
			scriptCompilerOptions.FileFlags[ListFile.Key] = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti | MpqFileFlags.Encrypted | MpqFileFlags.BlockOffsetAdjustedKey;
#if DEBUG
			scriptCompilerOptions.Debug = true;
#endif

			return scriptCompilerOptions;
		}
	}
}
