using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using War3Net.IO.Slk;

namespace Tools
{
	internal class BlzFieldTool
	{
		private readonly BlzFieldToolArgs args;
		private readonly Regex nameRegex;
		private static readonly Regex suffixRegex = new(@".*\('(.*)'\)$");
		private static readonly Regex prefixRegex = new(@"");

		private static readonly Regex codeRegex = new(@"^(\s*)\[(.{4})\](\s*)$");
		private static readonly Regex codeNameRegex = new(@"^(\s*)Name(\s*)=(\s*)(.*?)(\s*)$");
		private readonly Dictionary<string, string> codeToLocalizedName = new()
		{
			{ "Ansp", "Spy" }
		};

		private static readonly HashSet<string> illegalCodes = new()
		{
			"Aspx", // Referenced but unused
			"Stpm", // Referenced but unused
			"Stpr", // Referenced but unused
			"AOwd", // Referenced but unused
			"Anwm", // Referenced but unused
			"Ahrs", // Referenced but unused
			"", // Mistake
		};
		private static readonly HashSet<string> illegalFields = new()
		{
			"ITEM_BF_CAN_BE_DROPPED",
			"ITEM_BF_CAN_BE_SOLD_TO_MERCHANTS",
			"ITEM_BF_DROPPED_WHEN_CARRIER_DIES",
			"ITEM_IF_HIT_POINTS",
			"ITEM_IF_LEVEL",
			"UNIT_IF_AGILITY",
			"UNIT_IF_AGILITY_PERMANENT",
			"UNIT_IF_AGILITY_WITH_BONUS",
			"UNIT_IF_INTELLIGENCE",
			"UNIT_IF_INTELLIGENCE_PERMANENT",
			"UNIT_IF_INTELLIGENCE_WITH_BONUS",
			"UNIT_IF_LEVEL",
			"UNIT_IF_STRENGTH",
			"UNIT_IF_STRENGTH_PERMANENT",
			"UNIT_IF_STRENGTH_WITH_BONUS",
			"UNIT_RF_ACQUISITION_RANGE",
			"UNIT_RF_FLY_HEIGHT",
			"UNIT_RF_HP",
			"UNIT_RF_MANA",
			"UNIT_RF_SPEED",
			"UNIT_RF_TURN_RATE",
			"UNIT_SF_NAME",
			"UNIT_SF_PROPER_NAMES",
			"UNIT_WEAPON_IF_ATTACK_DAMAGE_BASE",
			"UNIT_WEAPON_IF_ATTACK_DAMAGE_NUMBER_OF_DICE",
			"UNIT_WEAPON_IF_ATTACK_DAMAGE_SIDES_PER_DIE",
			"UNIT_WEAPON_RF_ATTACK_BASE_COOLDOWN",
		};

		public BlzFieldTool(BlzFieldToolArgs args)
		{
			this.args = args;
			this.nameRegex = new Regex(@$"^(\s*)constant (.*) {args.Identifier}_(.*?)_(.*?)(\s*)=.*");
			GenerateLocalizedNames();
		}

		public static void Run(params BlzFieldToolArgs[] args)
		{
			var lines = File.ReadAllLines("data/common.j")
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.ToList();

			var res = new List<string>();
			foreach (var arg in args)
			{
				res.AddRange(new BlzFieldTool(arg).Run());
			}

			File.WriteAllLines("fields_output.txt", res);
		}

		public IEnumerable<string> Run()
		{
			var lines = File.ReadAllLines("data/common.j")
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.ToList();

			return lines.SelectMany(x => Convert(x));
		}

		private void GenerateLocalizedNames()
		{
			foreach (var file in Directory.EnumerateFiles("_locales", "*.txt", SearchOption.AllDirectories))
			{
				FetchLocalizedNames(File.ReadAllLines(file));
			}
		}

		private IEnumerable<string> GetRelatedCodes(string codeId)
		{
			var file = File.OpenRead(this.args.SlkMetaData);
			var parser = new SylkParser();
			var table = parser.Parse(file);
			foreach (var row in table)
			{
				var rowId = row[0] as string;
				if (string.Equals(codeId, rowId))
				{
					return getRelatedCodes(row[22] as string);
				}
			}

			return Enumerable.Empty<string>();

			static IEnumerable<string> getRelatedCodes(string related)
			{
				return string.IsNullOrWhiteSpace(related) ? Enumerable.Empty<string>() : related.Split(',', '.').Where(x => !illegalCodes.Contains(x));
			}
		}


		private void FetchLocalizedNames(string[] lines)
		{
			var code = default(string);
			foreach (var line in lines)
			{
				if (codeRegex.IsMatch(line))
				{
					code = codeRegex.Match(line).Groups[2].Value;
				}
				else if (codeNameRegex.IsMatch(line))
				{
					this.codeToLocalizedName[code] = codeNameRegex.Match(line).Groups[4].Value;
				}
			}
		}

		private string GetLocalizedName(string code)
		{
			if (!this.codeToLocalizedName.TryGetValue(code, out var name))
			{
				var file = File.OpenRead(this.args.SlkData);
				var parser = new SylkParser();
				var table = parser.Parse(file);
				foreach (var row in table)
				{
					var rowId = row[0] as string;
					if (string.Equals(code, rowId) && !string.Equals(code, row[1]))
					{
						this.codeToLocalizedName[code] = name = GetLocalizedName(row[1] as string);
					}
				}
			}

			return name ?? throw new Exception();
		}

		private IEnumerable<string> Convert(string line)
		{
			var nameMatch = this.nameRegex.Match(line);
			if (!nameMatch.Success || !Equals(this.args.Field, nameMatch.Groups[2].Value) || illegalFields.Any(x => line.Contains(x)))
				yield break;

			var name = nameMatch.Groups[4].Value;
			var cleanedNamed = CleanName(name, line);
			var pascalName = ConvertPascalCase(cleanedNamed);
			var camelName = ConvertCamelCase(cleanedNamed);

			var suffixMatch = suffixRegex.Match(line);
			var suffix = this.args.AddSuffix ? $"_{suffixMatch.Groups[1].Value}" : "";
			var relatedCodes = new List<string>();
			var relatedNames = new List<string>();
			if (suffixMatch.Success && this.args.Type == BlzFieldToolArgs.ArgType.Ability)
			{
				relatedCodes = GetRelatedCodes(suffixMatch.Groups[1].Value).ToList();
				relatedNames = relatedCodes.Select(x => GetLocalizedName(x)).ToList();
			}

			yield return "";

			if (this.args.Property)
			{
				yield return $"\t\t/// @CSharpLua.Get = \"{this.args.Get}({{0}}, {this.args.Identifier}_{nameMatch.Groups[3].Value}_{name})\"";
				yield return $"\t\t/// @CSharpLua.Set = \"{this.args.Set}({{0}}, {this.args.Identifier}_{nameMatch.Groups[3].Value}_{name}, {{1}})\"";
				yield return $"\t\tpublic extern {this.args.ObjectType} {pascalName}{suffix} {{ get; set; }}";
			}
			else
			{
				if (relatedNames.Count > 0)
				{
					yield return $"\t\t/// <summary>";
					yield return $"\t\t/// <para>Used by:</para>";
					yield return $"\t\t/// <list type=\"bullet\">";
					foreach (var consolidatedLine in ConsolidateUsedBy(relatedNames, relatedCodes))
					{
						yield return consolidatedLine;
					}
					yield return $"\t\t/// </list>";
					yield return $"\t\t/// </summary>";
				}
				else
				{

				}
				yield return $"\t\t/// @CSharpLua.Template = \"{this.args.Get}({{0}}, {this.args.Identifier}_{nameMatch.Groups[3].Value}_{name}, {{1}})\"";
				yield return $"\t\tpublic extern {this.args.ObjectType} Get{pascalName}{suffix}({this.args.MethodArgument});";
				if (relatedNames.Count > 0)
				{
					yield return $"\t\t/// <summary>";
					yield return $"\t\t/// <para>Used by:</para>";
					yield return $"\t\t/// <list type=\"bullet\">";
					foreach (var consolidatedLine in ConsolidateUsedBy(relatedNames, relatedCodes))
					{
						yield return consolidatedLine;
					}
					yield return $"\t\t/// </list>";
					yield return $"\t\t/// </summary>";
				}
				yield return $"\t\t/// @CSharpLua.Template = \"{this.args.Set}({{0}}, {this.args.Identifier}_{nameMatch.Groups[3].Value}_{name}, {{1}}, {{2}})\"";
				yield return $"\t\tpublic extern void Set{pascalName}{suffix}({this.args.MethodArgument}, {this.args.ObjectType} {camelName});";
			}
		}

		private static IEnumerable<string> ConsolidateUsedBy(List<string> relatedNames, List<string> relatedCodes)
		{
			return relatedNames
				.Select((x, i) => (x, i))
				.GroupBy(x => x.x)
				.Select(x => $"\t\t/// <item><term>{x.Key}</term> <description>{string.Join(", ", x.Select(y => relatedCodes[y.i]))}</description></item>")
				.OrderBy(x => x);
		}

		private static string CleanName(string name, string line)
		{
			var match = suffixRegex.Match(line);
			if (match.Success && name.EndsWith(match.Groups[1].Value, StringComparison.InvariantCultureIgnoreCase))
			{
				var index = name.LastIndexOf('_');
				name = name.Substring(0, index);
			}

			//if (this.args.Type == BlzFieldToolArgs.ArgType.UnitWeapon)
			//{
			//	var index = name.IndexOf('_');
			//	name = name.Substring(index + 1);
			//}

			return name;
		}

		private static string ConvertCamelCase(string name)
		{
			name = name.ToLower();

			for (var i = 0; i < name.Length; i++)
			{
				if (name[i] == '_')
				{
					name = name.Substring(0, i) + char.ToUpper(name[i + 1]) + name.Substring(i + 2);
				}
			}

			return name;
		}

		private static string ConvertPascalCase(string name)
		{
			name = ConvertCamelCase(name);
			return char.ToUpper(name[0]) + name.Substring(1);
		}
	}
}
