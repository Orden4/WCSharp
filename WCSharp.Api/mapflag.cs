namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class mapflag : handle
	{
		internal mapflag()
		{
		}

		/// @CSharpLua.Get = "MAP_FOG_HIDE_TERRAIN"
		public static extern mapflag FogHideTerrain { get; }
		/// @CSharpLua.Get = "MAP_FOG_MAP_EXPLORED"
		public static extern mapflag FogMapExplored { get; }
		/// @CSharpLua.Get = "MAP_FOG_ALWAYS_VISIBLE"
		public static extern mapflag FogAlwaysVisible { get; }
		/// @CSharpLua.Get = "MAP_USE_HANDICAPS"
		public static extern mapflag UseHandicaps { get; }
		/// @CSharpLua.Get = "MAP_OBSERVERS"
		public static extern mapflag Observers { get; }
		/// @CSharpLua.Get = "MAP_OBSERVERS_ON_DEATH"
		public static extern mapflag ObserversOnDeath { get; }
		/// @CSharpLua.Get = "MAP_FIXED_COLORS"
		public static extern mapflag FixedColors { get; }
		/// @CSharpLua.Get = "MAP_LOCK_RESOURCE_TRADING"
		public static extern mapflag LockResourceTrading { get; }
		/// @CSharpLua.Get = "MAP_RESOURCE_TRADING_ALLIES_ONLY"
		public static extern mapflag ResourceTradingAlliesOnly { get; }
		/// @CSharpLua.Get = "MAP_LOCK_ALLIANCE_CHANGES"
		public static extern mapflag LockAllianceChanges { get; }
		/// @CSharpLua.Get = "MAP_ALLIANCE_CHANGES_HIDDEN"
		public static extern mapflag AllianceChangesHidden { get; }
		/// @CSharpLua.Get = "MAP_CHEATS"
		public static extern mapflag Cheats { get; }
		/// @CSharpLua.Get = "MAP_CHEATS_HIDDEN"
		public static extern mapflag CheatsHidden { get; }
		/// @CSharpLua.Get = "MAP_LOCK_SPEED"
		public static extern mapflag LockSpeed { get; }
		/// @CSharpLua.Get = "MAP_LOCK_RANDOM_SEED"
		public static extern mapflag LockRandomSeed { get; }
		/// @CSharpLua.Get = "MAP_SHARED_ADVANCED_CONTROL"
		public static extern mapflag SharedAdvancedControl { get; }
		/// @CSharpLua.Get = "MAP_RANDOM_HERO"
		public static extern mapflag RandomHero { get; }
		/// @CSharpLua.Get = "MAP_RANDOM_RACES"
		public static extern mapflag RandomRaces { get; }
		/// @CSharpLua.Get = "MAP_RELOADED"
		public static extern mapflag Reloaded { get; }

		/// @CSharpLua.Template = "ConvertMapFlag({0})"
		public static extern mapflag Convert(int mapFlagId);
	}
}
