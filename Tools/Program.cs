using System;

namespace Tools
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var command = Console.ReadLine();
			Action action = command.ToLowerInvariant() switch
			{
				"ability-api" => RunAbilityApi,
				"unit-api" => RunUnitApi,
				"item-api" => RunItemApi,
				"playerunitevents" => GeneratePlayerUnitEvents,
				_ => throw new NotImplementedException(),
			};
			action?.Invoke();
		}

		private static void RunAbilityApi()
		{
			BlzFieldTool.Run(
				BlzFieldToolArgs.AbilityBooleanField, BlzFieldToolArgs.AbilityIntegerField,
				BlzFieldToolArgs.AbilityRealField, BlzFieldToolArgs.AbilityStringField,
				BlzFieldToolArgs.AbilityBooleanLevelField, BlzFieldToolArgs.AbilityIntegerLevelField,
				BlzFieldToolArgs.AbilityRealLevelField, BlzFieldToolArgs.AbilityStringLevelField
			);
		}

		private static void RunUnitApi()
		{
			BlzFieldTool.Run(
				BlzFieldToolArgs.UnitBooleanField, BlzFieldToolArgs.UnitIntegerField,
				BlzFieldToolArgs.UnitRealField, BlzFieldToolArgs.UnitStringField,
				BlzFieldToolArgs.UnitWeaponBooleanField, BlzFieldToolArgs.UnitWeaponIntegerField,
				BlzFieldToolArgs.UnitWeaponRealField, BlzFieldToolArgs.UnitWeaponStringField
			);
		}

		private static void RunItemApi()
		{
			BlzFieldTool.Run(
				BlzFieldToolArgs.ItemBooleanField, BlzFieldToolArgs.ItemIntegerField,
				BlzFieldToolArgs.ItemRealField, BlzFieldToolArgs.ItemStringField
			);
		}

		private static void GeneratePlayerUnitEvents()
		{
			PlayerUnitEventGenerator.Run(@"Data\PlayerUnitEvents.json", "PlayerUnitEvents.txt");
		}
	}
}
