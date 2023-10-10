namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playerscore : handle
	{
		internal playerscore()
		{
		}

		/// @CSharpLua.Get = "PLAYER_SCORE_UNITS_TRAINED"
		public static extern playerscore UnitsTrained { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_UNITS_KILLED"
		public static extern playerscore UnitsKilled { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_STRUCT_BUILT"
		public static extern playerscore StructuresBuilt { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_STRUCT_RAZED"
		public static extern playerscore StructuresRazed { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_TECH_PERCENT"
		public static extern playerscore TechPercent { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_FOOD_MAXPROD"
		public static extern playerscore FoodMaxProduced { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_FOOD_MAXUSED"
		public static extern playerscore FoodMaxUsed { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_HEROES_KILLED"
		public static extern playerscore HeroesKilled { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_ITEMS_GAINED"
		public static extern playerscore ItemsGained { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_MERCS_HIRED"
		public static extern playerscore MercsHired { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_MINED_TOTAL"
		public static extern playerscore GoldMinedTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_MINED_UPKEEP"
		public static extern playerscore GoldMinedUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_LOST_UPKEEP"
		public static extern playerscore GoldLostUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_LOST_TAX"
		public static extern playerscore GoldLostTax { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_GIVEN"
		public static extern playerscore GoldGiven { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_GOLD_RECEIVED"
		public static extern playerscore GoldReceived { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_TOTAL"
		public static extern playerscore LumberTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_LOST_UPKEEP"
		public static extern playerscore LumberLostUpkeep { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_LOST_TAX"
		public static extern playerscore LumberLostTax { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_GIVEN"
		public static extern playerscore LumberGiven { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_LUMBER_RECEIVED"
		public static extern playerscore LumberReceived { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_UNIT_TOTAL"
		public static extern playerscore UnitTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_HERO_TOTAL"
		public static extern playerscore HeroTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_RESOURCE_TOTAL"
		public static extern playerscore ResourceTotal { get; }
		/// @CSharpLua.Get = "PLAYER_SCORE_TOTAL"
		public static extern playerscore Total { get; }

		/// @CSharpLua.Template = "ConvertPlayerScore({0})"
		public static extern playerscore Convert(int playerScoreId);
	}
}
