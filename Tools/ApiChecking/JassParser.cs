using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tools.ApiChecking
{
	public static partial class JassParser
	{
		private static readonly Regex nativeRegex = NativeRegex();

		public static IEnumerable<JassTemplate> ParseJassTemplates(string file)
		{
			var lines = File.ReadAllLines(file);
			foreach (var line in lines)
			{
				var match = nativeRegex.Match(line);
				if (!match.Success)
					continue;

				var arguments = new List<string>();
				foreach (var arg in match.Groups[2].Value.Split(',').Select(x => x.Trim()))
				{
					if (arg == "nothing")
						break;

					arguments.Add(arg.Split(' ')[0].Trim());
				}

				yield return new JassTemplate
				{
					Name = match.Groups[1].Value,
					ArgumentTypes = arguments,
					ReturnType = match.Groups[3].Value
				};
			}
		}

		[GeneratedRegex(@"^[^/]*native\s+([a-zA-Z]+)\s+takes\s+(.*)\s+returns\s+([a-zA-Z]+).*$")]
		private static partial Regex NativeRegex();
	}
}
