using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerScore
	{
		internal PlayerScore()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playerscore(PlayerScore x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerScore(playerscore x);

		/// @CSharpLua.Get = "PLAYER_SCORE_UNITS_TRAINED"
		public static extern PlayerScore UnitsTrained { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_UNITS_KILLED"
		public static extern PlayerScore UnitsKilled { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_STRUCT_BUILT"
		public static extern PlayerScore StructuresBuilt { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_STRUCT_RAZED"
		public static extern PlayerScore StructuresRazed { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_TECH_PERCENT"
		public static extern PlayerScore TechPercent { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_FOOD_MAXPROD"
		public static extern PlayerScore FoodMaxProduced { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_FOOD_MAXUSED"
		public static extern PlayerScore FoodMaxUsed { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_HEROES_KILLED"
		public static extern PlayerScore HeroesKilled { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_ITEMS_GAINED"
		public static extern PlayerScore ItemsGained { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_MERCS_HIRED"
		public static extern PlayerScore MercsHired { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_MINED_TOTAL"
		public static extern PlayerScore GoldMinedTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_MINED_UPKEEP"
		public static extern PlayerScore GoldMinedUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_LOST_UPKEEP"
		public static extern PlayerScore GoldLostUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_LOST_TAX"
		public static extern PlayerScore GoldLostTax { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_GIVEN"
		public static extern PlayerScore GoldGiven { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_RECEIVED"
		public static extern PlayerScore GoldReceived { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_TOTAL"
		public static extern PlayerScore LumberTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_LOST_UPKEEP"
		public static extern PlayerScore LumberLostUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_LOST_TAX"
		public static extern PlayerScore LumberLostTax { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_GIVEN"
		public static extern PlayerScore LumberGiven { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_RECEIVED"
		public static extern PlayerScore LumberReceived { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_UNIT_TOTAL"
		public static extern PlayerScore UnitTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_HERO_TOTAL"
		public static extern PlayerScore HeroTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_RESOURCE_TOTAL"
		public static extern PlayerScore ResourceTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_TOTAL"
		public static extern PlayerScore Total { get; }

		/// @CSharpLua.Template = "ConvertPlayerScore({0})"
		public static extern PlayerScore Convert(int playerScoreId);
	}
}
