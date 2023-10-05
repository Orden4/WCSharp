namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class subanimtype
	{
		internal subanimtype()
		{
		}

		/// @CSharpLua.Get = "SUBANIM_TYPE_ROOTED"
		public static extern subanimtype Rooted { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ALTERNATE_EX"
		public static extern subanimtype AlternateEx { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LOOPING"
		public static extern subanimtype Looping { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SLAM"
		public static extern subanimtype Slam { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THROW"
		public static extern subanimtype Throw { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SPIKED"
		public static extern subanimtype Spiked { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FAST"
		public static extern subanimtype Fast { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SPIN"
		public static extern subanimtype Spin { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_READY"
		public static extern subanimtype Ready { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CHANNEL"
		public static extern subanimtype Channel { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_DEFEND"
		public static extern subanimtype Defend { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_VICTORY"
		public static extern subanimtype Victory { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TURN"
		public static extern subanimtype Turn { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LEFT"
		public static extern subanimtype Left { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_RIGHT"
		public static extern subanimtype Right { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIRE"
		public static extern subanimtype Fire { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FLESH"
		public static extern subanimtype Flesh { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_HIT"
		public static extern subanimtype Hit { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_WOUNDED"
		public static extern subanimtype Wounded { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LIGHT"
		public static extern subanimtype Light { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_MODERATE"
		public static extern subanimtype Moderate { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SEVERE"
		public static extern subanimtype Severe { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CRITICAL"
		public static extern subanimtype Critical { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_COMPLETE"
		public static extern subanimtype Complete { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_GOLD"
		public static extern subanimtype Gold { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LUMBER"
		public static extern subanimtype Lumber { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_WORK"
		public static extern subanimtype Work { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TALK"
		public static extern subanimtype Talk { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIRST"
		public static extern subanimtype First { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SECOND"
		public static extern subanimtype Second { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THIRD"
		public static extern subanimtype Third { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FOURTH"
		public static extern subanimtype Fourth { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIFTH"
		public static extern subanimtype Fifth { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ONE"
		public static extern subanimtype One { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TWO"
		public static extern subanimtype Two { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THREE"
		public static extern subanimtype Three { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FOUR"
		public static extern subanimtype Four { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIVE"
		public static extern subanimtype Five { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SMALL"
		public static extern subanimtype Small { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_MEDIUM"
		public static extern subanimtype Medium { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LARGE"
		public static extern subanimtype Large { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_UPGRADE"
		public static extern subanimtype Upgrade { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_DRAIN"
		public static extern subanimtype Drain { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FILL"
		public static extern subanimtype Fill { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CHAINLIGHTNING"
		public static extern subanimtype ChainLightning { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_EATTREE"
		public static extern subanimtype EatTree { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_PUKE"
		public static extern subanimtype Puke { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FLAIL"
		public static extern subanimtype Flail { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_OFF"
		public static extern subanimtype Off { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SWIM"
		public static extern subanimtype Swim { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ENTANGLE"
		public static extern subanimtype Entangle { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_BERSERK"
		public static extern subanimtype Berserk { get; }

		/// @CSharpLua.Template = "ConvertSubAnimType({0})"
		public static extern subanimtype Convert(int subAnimTypeId);
	}
}
