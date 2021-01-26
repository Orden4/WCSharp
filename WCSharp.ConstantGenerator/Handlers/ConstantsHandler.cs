using System.IO;
using System.Reflection;

namespace WCSharp.ConstantGenerator.Handlers
{
	internal class ConstantsHandler
	{
		private const string W3WTS_INPUT = "war3map.wts";
		private const string W3WTS_OUTPUT = "Constants.cs";
		private const string ADDITIONAL_CONSTANTS_FILE = "WCSharp.ConstantGenerator.additional-constants.csv";

		public static void Run(string inputDirectory, string outputDirectory)
		{
			var input = Path.Combine(inputDirectory, W3WTS_INPUT);
			var output = Path.Combine(outputDirectory, W3WTS_OUTPUT);
			var constants = GenerateConstants(input);

			File.WriteAllText(output, constants.ToString());
		}

		private static ConstantsFile GenerateConstants(string file)
		{
			if (!File.Exists(file))
			{
				throw new FileNotFoundException($"Could not find file: {file}");
			}

			var constantsFile = new ConstantsFile();

			var w3s = File.ReadAllLines(file);
			constantsFile.ParseW3s(w3s);

			var assembly = Assembly.GetExecutingAssembly();
			using var stream = assembly.GetManifestResourceStream(ADDITIONAL_CONSTANTS_FILE);
			using var reader = new StreamReader(stream);
			var additionalConstants = reader.ReadToEnd().Split("\r\n");
			constantsFile.ParseAdditionalConstants(additionalConstants);

			return constantsFile;
		}
	}
}
