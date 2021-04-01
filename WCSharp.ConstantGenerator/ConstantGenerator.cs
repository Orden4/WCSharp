using System;
using WCSharp.ConstantGenerator.Handlers;

namespace WCSharp.ConstantGenerator
{
	/// <summary>
	/// Entry point for generated WCSharp constant files.
	/// </summary>
	public class ConstantGenerator
	{
		internal static ConstantGeneratorOptions Options { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mapDirectory">The directory containing the map source files (source.w3x by default)</param>
		/// <param name="outputDirectory">The output directory (the Source project folder by default)</param>
		/// <param name="options">Optional settings for the constant generation.</param>
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
