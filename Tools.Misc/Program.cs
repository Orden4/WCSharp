using System;
using Tools.ApiChecking;

namespace Tools
{
	internal class Program
	{
		private static void Main()
		{
			var action = default(Action);

			if (action == null)
			{
				var command = Console.ReadLine();
				action = command.ToLowerInvariant() switch
				{
					"ability-api" => RunAbilityApi,
					"unit-api" => RunUnitApi,
					"item-api" => RunItemApi,
					"camera-api" => RunCameraApi,
					"playerunitevents" => GeneratePlayerUnitEvents,
					"api-check" => ApiCheck,
					"name-dump" => DumpNames,
					_ => throw new NotImplementedException(),
				};
			}

			action?.Invoke();
			Console.ReadLine();
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

		private static void RunCameraApi()
		{
			BlzFieldTool.Run(
				BlzFieldToolArgs.CameraField
			);
		}

		private static void GeneratePlayerUnitEvents()
		{
			PlayerUnitEventGenerator.Run(@"Data\PlayerUnitEvents.json", "PlayerUnitEvents.txt");
		}

		private static void ApiCheck()
		{
			var jassTemplates = JassParser.ParseJassTemplates("data/common.j");
			var apiChecker = new ApiChecker("../../../../WCSharp.Api", jassTemplates);
			apiChecker.Run();
		}

		private static void DumpNames()
		{
			NameDump.Run(["data/common.j", "data/blizzard.j", "data/common.ai"]);
		}

	}
}
