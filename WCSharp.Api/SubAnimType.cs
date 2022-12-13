using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class SubAnimType
	{
		internal SubAnimType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator subanimtype(SubAnimType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator SubAnimType(subanimtype x);

		/// @CSharpLua.Get = "SUBANIM_TYPE_ROOTED"
		public static extern SubAnimType Rooted { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ALTERNATE_EX"
		public static extern SubAnimType AlternateEx { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LOOPING"
		public static extern SubAnimType Looping { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SLAM"
		public static extern SubAnimType Slam { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THROW"
		public static extern SubAnimType Throw { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SPIKED"
		public static extern SubAnimType Spiked { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FAST"
		public static extern SubAnimType Fast { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SPIN"
		public static extern SubAnimType Spin { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_READY"
		public static extern SubAnimType Ready { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CHANNEL"
		public static extern SubAnimType Channel { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_DEFEND"
		public static extern SubAnimType Defend { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_VICTORY"
		public static extern SubAnimType Victory { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TURN"
		public static extern SubAnimType Turn { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LEFT"
		public static extern SubAnimType Left { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_RIGHT"
		public static extern SubAnimType Right { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIRE"
		public static extern SubAnimType Fire { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FLESH"
		public static extern SubAnimType Flesh { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_HIT"
		public static extern SubAnimType Hit { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_WOUNDED"
		public static extern SubAnimType Wounded { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LIGHT"
		public static extern SubAnimType Light { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_MODERATE"
		public static extern SubAnimType Moderate { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SEVERE"
		public static extern SubAnimType Severe { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CRITICAL"
		public static extern SubAnimType Critical { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_COMPLETE"
		public static extern SubAnimType Complete { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_GOLD"
		public static extern SubAnimType Gold { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LUMBER"
		public static extern SubAnimType Lumber { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_WORK"
		public static extern SubAnimType Work { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TALK"
		public static extern SubAnimType Talk { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIRST"
		public static extern SubAnimType First { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SECOND"
		public static extern SubAnimType Second { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THIRD"
		public static extern SubAnimType Third { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FOURTH"
		public static extern SubAnimType Fourth { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIFTH"
		public static extern SubAnimType Fifth { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ONE"
		public static extern SubAnimType One { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_TWO"
		public static extern SubAnimType Two { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_THREE"
		public static extern SubAnimType Three { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FOUR"
		public static extern SubAnimType Four { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FIVE"
		public static extern SubAnimType Five { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SMALL"
		public static extern SubAnimType Small { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_MEDIUM"
		public static extern SubAnimType Medium { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_LARGE"
		public static extern SubAnimType Large { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_UPGRADE"
		public static extern SubAnimType Upgrade { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_DRAIN"
		public static extern SubAnimType Drain { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FILL"
		public static extern SubAnimType Fill { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_CHAINLIGHTNING"
		public static extern SubAnimType ChainLightning { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_EATTREE"
		public static extern SubAnimType EatTree { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_PUKE"
		public static extern SubAnimType Puke { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_FLAIL"
		public static extern SubAnimType Flail { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_OFF"
		public static extern SubAnimType Off { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_SWIM"
		public static extern SubAnimType Swim { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_ENTANGLE"
		public static extern SubAnimType Entangle { get; }
		/// @CSharpLua.Get = "SUBANIM_TYPE_BERSERK"
		public static extern SubAnimType Berserk { get; }

		/// @CSharpLua.Template = "ConvertSubAnimType({0})"
		public static extern SubAnimType Convert(int subAnimTypeId);
	}
}
