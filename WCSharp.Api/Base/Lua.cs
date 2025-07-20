using WCSharp.Api.Enums;

namespace WCSharp.Api
{
	public static partial class Common
	{
		/// @CSharpLua.Template = "FourCC({0})"
		public static extern int FourCC(string value);
		/// @CSharpLua.Template = "BlzGetUnitArmorType({0})"
		public static extern ArmorType BlzGetUnitArmorType(unit unit);
		/// @CSharpLua.Template = "BlzDeleteHeroAbility({0}, {1})"
		public static extern void BlzDeleteHeroAbility(unit unit, int abilityId);
		/// @CSharpLua.Template = "BlzGetHeroPrimaryStat({0})"
		public static extern HeroAttribute BlzGetHeroPrimaryStat(unit unit);
		/// @CSharpLua.Template = "BlzSetHeroPrimaryStat({0}, {1})"
		public static extern void BlzSetHeroPrimaryStat(unit unit, int value);
		/// @CSharpLua.Template = "BlzGetHeroStat({0}, {1}, false)"
		public static extern int BlzGetHeroStat(unit unit, HeroAttribute heroAttributeId);
		/// @CSharpLua.Template = "BlzSetHeroStatEx({0}, {1}, {2}, false)"
		public static extern void BlzSetHeroStatEx(unit unit, HeroAttribute heroAttributeId, int value);
		/// @CSharpLua.Template = "BlzGetUnitMovementType({0})"
		public static extern MoveTypes BlzGetUnitMovementType(unit unit);
		/// @CSharpLua.Template = "BlzSetUnitMovementType({0}, {1})"
		public static extern void BlzSetUnitMovementType(unit unit, MoveTypes movementType);
	}
}
