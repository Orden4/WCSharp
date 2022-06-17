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

		public static BlzFieldToolArgs AbilityBooleanField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityBooleanField");
		public static BlzFieldToolArgs AbilityIntegerField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityIntegerField");
		public static BlzFieldToolArgs AbilityRealField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityRealField");
		public static BlzFieldToolArgs AbilityStringField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityStringField");

		public static BlzFieldToolArgs AbilityBooleanLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityBooleanLevelField")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityIntegerLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityIntegerLevelField")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityRealLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityRealLevelField")
		{
			MethodArgument = "int level"
		};
		public static BlzFieldToolArgs AbilityStringLevelField { get; } = new BlzFieldToolArgs(ArgType.Ability, "AbilityStringLevelField")
		{
			MethodArgument = "int level"
		};

		public static BlzFieldToolArgs UnitBooleanField { get; } = new BlzFieldToolArgs(ArgType.Unit, "UnitBooleanField");
		public static BlzFieldToolArgs UnitIntegerField { get; } = new BlzFieldToolArgs(ArgType.Unit, "UnitIntegerField");
		public static BlzFieldToolArgs UnitRealField { get; } = new BlzFieldToolArgs(ArgType.Unit, "UnitRealField");
		public static BlzFieldToolArgs UnitStringField { get; } = new BlzFieldToolArgs(ArgType.Unit, "UnitStringField");

		public static BlzFieldToolArgs UnitWeaponBooleanField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "UnitWeaponBooleanField")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponIntegerField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "UnitWeaponIntegerField")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponRealField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "UnitWeaponRealField")
		{
			MethodArgument = "int attackIndex"
		};
		public static BlzFieldToolArgs UnitWeaponStringField { get; } = new BlzFieldToolArgs(ArgType.UnitWeapon, "UnitWeaponStringField")
		{
			MethodArgument = "int attackIndex"
		};

		public static BlzFieldToolArgs ItemBooleanField { get; } = new BlzFieldToolArgs(ArgType.Item, "ItemBooleanField");
		public static BlzFieldToolArgs ItemIntegerField { get; } = new BlzFieldToolArgs(ArgType.Item, "ItemIntegerField");
		public static BlzFieldToolArgs ItemRealField { get; } = new BlzFieldToolArgs(ArgType.Item, "ItemRealField");
		public static BlzFieldToolArgs ItemStringField { get; } = new BlzFieldToolArgs(ArgType.Item, "ItemStringField");

		public BlzFieldToolArgs(ArgType type, string value)
		{
			switch (type)
			{
				case ArgType.Ability:
					ClassType = "Ability";
					Identifier = "ABILITY";
					SlkData = "units/abilitydata.slk";
					SlkMetaData = "units/abilitymetadata.slk";
					break;
				case ArgType.Unit:
					ClassType = "Unit";
					Identifier = "UNIT";
					break;
				case ArgType.UnitWeapon:
					ClassType = "Unit";
					Identifier = "UNIT_WEAPON";
					break;
				case ArgType.Item:
					ClassType = "Item";
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
