using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCSharp.ConstantGenerator
{
	internal class ConstantsFile
	{
		public Dictionary<string, Thing> Things { get; set; }

		public ConstantsFile()
		{
			Things = new Dictionary<string, Thing>();
		}

		public void ParseW3s(string[] w3s)
		{
			var output = new StringBuilder();

			output.Append("\tpublic static class Constants" + Environment.NewLine);

			for (var i = 0; i < w3s.Length; i++)
			{
				var line = w3s[i];
				if (line.StartsWith("// Abilities"))
				{
					HandleThing(w3s.Skip(i), Type.ABILITY);
				}
				else if (line.StartsWith("// Buffs/Effects: "))
				{
					HandleThing(w3s.Skip(i), Type.BUFF);
				}
				else if (line.StartsWith("// Units: "))
				{
					HandleThing(w3s.Skip(i), Type.UNIT);
				}
				else if (line.StartsWith("// Upgrades: "))
				{
					HandleThing(w3s.Skip(i), Type.UPGRADE);
				}
				else if (line.StartsWith("// Items: "))
				{
					HandleThing(w3s.Skip(i), Type.ITEM);
				}
			}
		}

		public void ParseAdditionalConstants(string[] additionalConstants)
		{
			foreach (var line in additionalConstants)
			{
				var split = line.Split(',');
				var thing = new Thing()
				{
					Type = Type.ADDITIONAL,
					Identifier = split[1],
					Code = split[2]
				};
				Things.Add(split[1], thing);
			}
		}

		private void HandleThing(IEnumerable<string> lines, Type type)
		{
			var line = lines.First();
			line = line.Substring(type.GetCharactersToSkip());
			var code = NextToken(ref line, " ");
			var name = lines.ElementAt(2);
			if (!Things.TryGetValue(code, out var thing))
			{
				thing = new Thing
				{
					Type = type,
					Code = code
				};
				NextToken(ref line, "(");
				thing.Identifier = NextToken(ref line, ")");
				Things.Add(code, thing);
			}

			if (line.EndsWith("(Name)") | line.EndsWith("Bufftip (Tooltip)"))
			{
				thing.Name = lines.ElementAt(2);
			}
			else if (line.EndsWith("Editor Suffix)"))
			{
				thing.Suffix = lines.ElementAt(2);
			}
		}

		private static string NextToken(ref string line, string symbol)
		{
			var index = line.IndexOf(symbol);
			var output = line.Substring(0, index);
			line = line.Substring(index + symbol.Length);
			return output;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine("public static class Constants");
			sb.AppendLine("{");

			foreach (var thing in Things.Values.OrderBy(x => x.Type))
			{
				try
				{
					sb.AppendLine($"\tpublic const int {thing};");
				}
				catch (Exception ex)
				{
					throw new Exception($"Exception on {thing.Type} {thing.Name ?? thing.Identifier}. Suffix: {thing.Suffix}, FourCC: ({thing.Code})", ex);
				}
			}

			sb.AppendLine("}");
			return sb.ToString();
		}
	}
}
