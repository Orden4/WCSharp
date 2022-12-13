using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerState
	{
		internal PlayerState()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playerstate(PlayerState x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerState(playerstate x);

		/// @CSharpLua.Get = "PLAYER_STATE_GAME_RESULT"
		public static extern PlayerState GameResult { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_GOLD"
		public static extern PlayerState ResourceGold { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_LUMBER"
		public static extern PlayerState ResourceLumber { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_HERO_TOKENS"
		public static extern PlayerState ResourceHeroTokens { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_FOOD_CAP"
		public static extern PlayerState ResourceFoodCap { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_RESOURCE_FOOD_USED"
		public static extern PlayerState ResourceFoodUsed { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_FOOD_CAP_CEILING"
		public static extern PlayerState FoodCapCeiling { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GIVES_BOUNTY"
		public static extern PlayerState GivesBounty { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_ALLIED_VICTORY"
		public static extern PlayerState AlliedVictory { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_PLACED"
		public static extern PlayerState Placed { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_OBSERVER_ON_DEATH"
		public static extern PlayerState ObserverOnDeath { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_OBSERVER"
		public static extern PlayerState Observer { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_UNFOLLOWABLE"
		public static extern PlayerState Unfollowable { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GOLD_UPKEEP_RATE"
		public static extern PlayerState GoldUpkeepRate { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_LUMBER_UPKEEP_RATE"
		public static extern PlayerState LumberUpkeepRate { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_GOLD_GATHERED"
		public static extern PlayerState GoldGathered { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_LUMBER_GATHERED"
		public static extern PlayerState LumberGathered { get; }
		/// @CSharpLua.Get = "PLAYER_STATE_NO_CREEP_SLEEP"
		public static extern PlayerState NoCreepSleep { get; }

		/// @CSharpLua.Template = "ConvertPlayerState({0})"
		public static extern PlayerState Convert(int playerStateId);
	}
}
