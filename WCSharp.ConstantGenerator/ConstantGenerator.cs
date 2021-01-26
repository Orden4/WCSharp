using System;
using WCSharp.ConstantGenerator.Handlers;

namespace WCSharp.ConstantGenerator
{
	public class ConstantGenerator
	{
		public static void Run(string mapDirectory, string outputDirectory)
		{
			if (mapDirectory == null)
			{
				throw new ArgumentNullException(nameof(mapDirectory));
			}
			if (outputDirectory == null)
			{
				throw new ArgumentNullException(nameof(outputDirectory));
			}

			ConstantsHandler.Run(mapDirectory, outputDirectory);
			W3CHandler.Run(mapDirectory, outputDirectory);
			W3RHandler.Run(mapDirectory, outputDirectory);
		}
	}
}
