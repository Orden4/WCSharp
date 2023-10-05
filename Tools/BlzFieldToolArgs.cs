using System;

namespace Tools
{
	internal class BlzFieldToolArgs
	{
		public enum ArgType
		{
			Ability,
			Unit,
			UnitWeapon,
			Item
		}

		public ArgType Type { get; }

		public string Field { get; }
		public string Get { get; }
		public string Set { get; }
		public string SlkData { get; }
		public string SlkMetaData { get; }
		public string ObjectType { get; }
		public string ClassType { get; init; }
		public string Identifier { get; init; }

		public string MethodArgument { get; init; }

		public bool Property => string.IsNullOrWhiteSpace(MethodArgument);
		public bool AddSuffix => Type == ArgType.Ability && !Property;

		public static BlzFieldToolArgs AbilityBooleanField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilitybooleanfield");
		public static BlzFieldToolArgs AbilityIntegerField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilityintegerfield");
		public static BlzFieldToolArgs AbilityRealField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilityrealfield");
		public static BlzFieldToolArgs AbilityStringField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilitystringfield");

		public static BlzFieldToolArgs AbilityBooleanLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilitybooleanlevelfield")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityIntegerLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilityintegerlevelfield")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityRealLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilityreallevelfield")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityStringLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "abilitystringlevelfield")
		{
			MethodArgument = "int level"
		};

		public static BlzFieldToolArgs UnitBooleanField { get; } = new BlzFieldToolArgs(ArgType.Unit, "unitbooleanfield");
		public static BlzFieldToolArgs UnitIntegerField { get; } = new BlzFieldToolArgs(ArgType.Unit, "unitintegerfield");
		public static BlzFieldToolArgs UnitRealField { get; } = new BlzFieldToolArgs(ArgType.Unit, "unitrealfield");
		public static BlzFieldToolArgs UnitStringField { get; } = new BlzFieldToolArgs(ArgType.Unit, "unitstringfield");

		public static BlzFieldToolArgs UnitWeaponBooleanField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "unitweaponbooleanfield")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponIntegerField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "unitweaponintegerfield")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponRealField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "unitweaponrealfield")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponStringField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "unitweaponstringfield")
		{
			MethodArgument = "int attackIndex"
		};

		public static BlzFieldToolArgs ItemBooleanField { get; } = new BlzFieldToolArgs(ArgType.Item, "itembooleanfield");
		public static BlzFieldToolArgs ItemIntegerField { get; } = new BlzFieldToolArgs(ArgType.Item, "itemintegerfield");
		public static BlzFieldToolArgs ItemRealField { get; } = new BlzFieldToolArgs(ArgType.Item, "itemrealfield");
		public static BlzFieldToolArgs ItemStringField { get; } = new BlzFieldToolArgs(ArgType.Item, "itemstringfield");

		public BlzFieldToolArgs(ArgType type, string value)
		{
			switch (type)
			{
				case ArgType.Ability:
					ClassType = "ability";
					Identifier = "ABILITY";
					SlkData = "units/abilitydata.slk";
					SlkMetaData = "units/abilitymetadata.slk";
					break;
				case ArgType.Unit:
					ClassType = "unit";
					Identifier = "UNIT";
					break;
				case ArgType.UnitWeapon:
					ClassType = "unit";
					Identifier = "UNIT_WEAPON";
					break;
				case ArgType.Item:
					ClassType = "item";
					Identifier = "ITEM";
					break;
			}

			Type = type;
			Field = value.ToLower();
			Get = $"Get{value}";
			Set = $"Set{value}";

			if (value.Contains("boolean", StringComparison.InvariantCultureIgnoreCase))
			{
				ObjectType = "bool";
			}
			else if (value.Contains("integer", StringComparison.InvariantCultureIgnoreCase))
			{
				ObjectType = "int";
			}
			else if (value.Contains("real", StringComparison.InvariantCultureIgnoreCase))
			{
				ObjectType = "float";
			}
			else if (value.Contains("string", StringComparison.InvariantCultureIgnoreCase))
			{
				ObjectType = "string";
			}
		}
	}
}
