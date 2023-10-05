namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unittype
	{
		internal unittype()
		{
		}

		/// @CSharpLua.Get = "UNIT_TYPE_HERO"
		public static extern unittype Hero { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_DEAD"
		public static extern unittype Dead { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_STRUCTURE"
		public static extern unittype Structure { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_FLYING"
		public static extern unittype Flying { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_GROUND"
		public static extern unittype Ground { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ATTACKS_FLYING"
		public static extern unittype AttacksFlying { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ATTACKS_GROUND"
		public static extern unittype AttacksGround { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MELEE_ATTACKER"
		public static extern unittype MeleeAttacker { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_RANGED_ATTACKER"
		public static extern unittype RangedAttacker { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_GIANT"
		public static extern unittype Giant { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SUMMONED"
		public static extern unittype Summoned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_STUNNED"
		public static extern unittype Stunned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_PLAGUED"
		public static extern unittype Plagued { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SNARED"
		public static extern unittype Snared { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_UNDEAD"
		public static extern unittype Undead { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MECHANICAL"
		public static extern unittype Mechanical { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_PEON"
		public static extern unittype Peon { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SAPPER"
		public static extern unittype Sapper { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_TOWNHALL"
		public static extern unittype TownHall { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ANCIENT"
		public static extern unittype Ancient { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_TAUREN"
		public static extern unittype Tauren { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_POISONED"
		public static extern unittype Poisoned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_POLYMORPHED"
		public static extern unittype Polymorphed { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SLEEPING"
		public static extern unittype Sleeping { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_RESISTANT"
		public static extern unittype Resistant { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ETHEREAL"
		public static extern unittype Ethereal { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MAGIC_IMMUNE"
		public static extern unittype MagicImmune { get; }

		/// @CSharpLua.Template = "ConvertUnitType({0})"
		public static extern unittype Convert(int unitTypeId);
	}
}
