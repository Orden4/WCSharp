namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playerstate : handle
	{
		internal playerstate()
		{
		}

		/// @CSharpLua.Get = "PLAYER_STATE_GAME_RESULT"
		public static extern playerstate GameResult { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_GOLD"
		public static extern playerstate ResourceGold { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_LUMBER"
		public static extern playerstate ResourceLumber { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_HERO_TOKENS"
		public static extern playerstate ResourceHeroTokens { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_FOOD_CAP"
		public static extern playerstate ResourceFoodCap { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_FOOD_USED"
		public static extern playerstate ResourceFoodUsed { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_FOOD_CAP_CEILING"
		public static extern playerstate FoodCapCeiling { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GIVES_BOUNTY"
		public static extern playerstate GivesBounty { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_ALLIED_VICTORY"
		public static extern playerstate AlliedVictory { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_PLACED"
		public static extern playerstate Placed { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_OBSERVER_ON_DEATH"
		public static extern playerstate ObserverOnDeath { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_OBSERVER"
		public static extern playerstate Observer { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_UNFOLLOWABLE"
		public static extern playerstate Unfollowable { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GOLD_UPKEEP_RATE"
		public static extern playerstate GoldUpkeepRate { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_LUMBER_UPKEEP_RATE"
		public static extern playerstate LumberUpkeepRate { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GOLD_GATHERED"
		public static extern playerstate GoldGathered { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_LUMBER_GATHERED"
		public static extern playerstate LumberGathered { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_NO_CREEP_SLEEP"
		public static extern playerstate NoCreepSleep { get; }

		/// @CSharpLua.Template = "ConvertPlayerState({0})"
		public static extern playerstate Convert(int playerStateId);
	}
}
