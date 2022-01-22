namespace Tools
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//BlzFieldTool.Run(
			//	BlzFieldToolArgs.AbilityBooleanField, BlzFieldToolArgs.AbilityIntegerField,
			//	BlzFieldToolArgs.AbilityRealField, BlzFieldToolArgs.AbilityStringField,
			//	BlzFieldToolArgs.AbilityBooleanLevelField, BlzFieldToolArgs.AbilityIntegerLevelField,
			//	BlzFieldToolArgs.AbilityRealLevelField, BlzFieldToolArgs.AbilityStringLevelField
			//);
			//BlzFieldTool.Run(
			//	BlzFieldToolArgs.UnitBooleanField, BlzFieldToolArgs.UnitIntegerField,
			//	BlzFieldToolArgs.UnitRealField, BlzFieldToolArgs.UnitStringField,
			//	BlzFieldToolArgs.UnitWeaponBooleanField, BlzFieldToolArgs.UnitWeaponIntegerField,
			//	BlzFieldToolArgs.UnitWeaponRealField, BlzFieldToolArgs.UnitWeaponStringField
			//);
			BlzFieldTool.Run(
				BlzFieldToolArgs.ItemBooleanField, BlzFieldToolArgs.ItemIntegerField,
				BlzFieldToolArgs.ItemRealField, BlzFieldToolArgs.ItemStringField
			);
		}
	}
}
