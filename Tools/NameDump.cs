using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Tools
{
	public partial class NameDump
	{
		private static Regex GlobalFinder { get; } = GlobalFinderRegex();
		private static Regex FunctionFinder { get; } = FunctionFinderRegex();

		public static void Run(string[] files)
		{
			var names = new List<string>();
			foreach (var file in files)
			{
				var lines = File.ReadAllLines(file);
				names.AddRange(Parse(lines));
			}
			File.WriteAllLines("names.txt", names);
		}

		private static IEnumerable<string> Parse(string[] lines)
		{
			var globals = false;
			foreach (var line in lines)
			{
				if (line.Contains("bj_"))
				{

				}
				var match = FunctionFinder.Match(line);
				if (match.Success)
				{
					yield return match.Groups[2].Value;
					continue;
				}

				if (line.Trim().Equals("globals", StringComparison.InvariantCultureIgnoreCase))
				{
					globals = true;
				}

				if (globals)
				{
					if (line.Trim().Equals("endglobals", StringComparison.InvariantCultureIgnoreCase))
					{
						globals = false;
					}

					match = GlobalFinder.Match(line);
					if (match.Success)
					{
						yield return match.Groups[4].Value;
						continue;
					}
				}
			}
		}

		[GeneratedRegex(@"^\s*(constant\s+)?(\w*\s+)(array\s+)?(\w*)\b.*")]
		private static partial Regex GlobalFinderRegex();
		[GeneratedRegex(@"^\s*(function|native)\s+(\w*)\b.*")]
		private static partial Regex FunctionFinderRegex();
	}
}
