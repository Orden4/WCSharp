using System.IO;
using System.Text;
using WCSharp.ConstantGenerator.Extensions;
using WCSharp.ConstantGenerator.Handlers.WcObjects;

namespace WCSharp.ConstantGenerator
{
	internal class W3RHandler
	{
		private const string W3R_INPUT = "war3map.w3r";
		private const string W3R_OUTPUT = "Regions.cs";

		private const string FILE = @"using WCSharp.Utils.Data;

public static class Regions
{{
{0}
}}";

		public static void Run(string inputDirectory, string outputDirectory)
		{
			var input = Path.Combine(inputDirectory, W3R_INPUT);
			var output = Path.Combine(outputDirectory, W3R_OUTPUT);

			if (!File.Exists(input))
			{
				Abort(output);
				return;
			}

			var reader = new BinaryReader(File.OpenRead(input));
			var version = reader.ReadInt32(); // Should be 5
			var count = reader.ReadInt32();
			var variables = new StringBuilder();

			if (count == 0)
			{
				Abort(output);
				return;
			}

			for (var i = 0; i < count; i++)
			{
				var region = new Region(reader);
				var name = region.Name.Escape();
				variables.Append($"\tpublic static Rectangle {name} {{ get; set; }} = new Rectangle({region.Left}f, {region.Bottom}f, {region.Right}f, {region.Top}f);\r\n");
			}

			File.WriteAllText(output, string.Format(FILE, variables.ToString()));
		}

		private static void Abort(string output)
		{
			if (File.Exists(output))
			{
				File.Delete(output);
			}
		}
	}
}
