namespace WCSharp.Api
{
	public static partial class Common
	{
		/// @CSharpLua.Template = "GetUnitCount({0})"
		public static extern int GetUnitCount(int unitid);
		/// @CSharpLua.Template = "GetPlayerUnitTypeCount({0}, {1})"
		public static extern int GetPlayerUnitTypeCount(player p, int unitid);
		/// @CSharpLua.Template = "GetUnitCountDone({0})"
		public static extern int GetUnitCountDone(int unitid);
		/// @CSharpLua.Template = "GetTownUnitCount({0}, {1}, {2})"
		public static extern int GetTownUnitCount(int id, int tn, bool dn);
		/// @CSharpLua.Template = "GetUnitGoldCost({0})"
		public static extern int GetUnitGoldCost(int unitid);
		/// @CSharpLua.Template = "GetUnitWoodCost({0})"
		public static extern int GetUnitWoodCost(int unitid);
		/// @CSharpLua.Template = "GetUnitBuildTime({0})"
		public static extern int GetUnitBuildTime(int unitid);
		/// @CSharpLua.Template = "UnitAlive({0})"
		public static extern bool UnitAlive(unit id);
		/// @CSharpLua.Template = "UnitInvis({0})"
		public static extern bool UnitInvis(unit id);
	}
}
