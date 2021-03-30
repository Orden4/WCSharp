using System;
using WCSharp.ConstantGenerator.Handlers;

namespace WCSharp.ConstantGenerator
{
	public class ConstantGenerator
	{
		internal static ConstantGeneratorOptions Options { get; set; }

		public static void Run(string mapDirectory, string outputDirectory, ConstantGeneratorOptions options = null)
		{
			if (mapDirectory == null)
			{
				throw new ArgumentNullException(nameof(mapDirectory));
			}
			if (outputDirectory == null)
			{
				throw new ArgumentNullException(nameof(outputDirectory));
			}

			Options = options ?? new ConstantGeneratorOptions();

			ConstantsHandler.Run(mapDirectory, outputDirectory);
			W3CHandler.Run(mapDirectory, outputDirectory);
			W3RHandler.Run(mapDirectory, outputDirectory);
		}
	}
}
