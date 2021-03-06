using War3Net.Build;
using War3Net.IO.Mpq;

namespace Launcher
{
	internal static class CompilerOptions
	{
		public static ScriptCompilerOptions GetCompilerOptions(string sourceDirectory, string outputDirectory)
		{
			var scriptCompilerOptions = new ScriptCompilerOptions(CSharpLua.CoreSystem.CoreSystemProvider.GetCoreSystemFiles())
			{
				SourceDirectory = sourceDirectory,
				OutputDirectory = outputDirectory,

				DefaultFileFlags = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti
			};
			scriptCompilerOptions.FileFlags[ListFile.FileName] = MpqFileFlags.Exists | MpqFileFlags.CompressedMulti | MpqFileFlags.Encrypted | MpqFileFlags.BlockOffsetAdjustedKey;

#if DEBUG
			scriptCompilerOptions.Debug = true;
#endif

			return scriptCompilerOptions;
		}
	}
}
