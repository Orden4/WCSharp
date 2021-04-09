using System;
using System.Text.RegularExpressions;

namespace WCSharp.ConstantGenerator.Extensions
{
	internal static class StringExtensions
	{
		private const string ALPHA_NUMERIC_FILTER = @"[^a-zA-Z\d]+";
		private const string UNDERSCORE_FILTER = @"_{2,}";

		public static string Escape(this string @string)
		{
			// Remove color codes
			var index = -1;
			while ((index = @string.IndexOf("|C", StringComparison.InvariantCultureIgnoreCase)) != -1)
			{
				@string = @string.Substring(0, index) + @string.Substring(index + 10);
			}
			while ((index = @string.IndexOf("|R", StringComparison.InvariantCultureIgnoreCase)) != -1)
			{
				@string = @string.Substring(0, index) + @string.Substring(index + 2);
			}

			// Remove non-alphanumeric characters
			@string = Regex.Replace(@string, ALPHA_NUMERIC_FILTER, "_", RegexOptions.CultureInvariant);

			if (@string.StartsWith("_"))
			{
				@string = @string.Substring(1);
			}

			if (@string.EndsWith("_"))
			{
				@string = @string.Substring(0, @string.Length - 1);
			}

			@string = Regex.Replace(@string, UNDERSCORE_FILTER, "_");

			return @string;
		}
	}
}
