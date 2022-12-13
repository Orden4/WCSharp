using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UnitType
	{
		internal UnitType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unittype(UnitType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UnitType(unittype x);

		/// @CSharpLua.Get = "UNIT_TYPE_HERO"
		public static extern UnitType Hero { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_DEAD"
		public static extern UnitType Dead { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_STRUCTURE"
		public static extern UnitType Structure { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_FLYING"
		public static extern UnitType Flying { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_GROUND"
		public static extern UnitType Ground { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ATTACKS_FLYING"
		public static extern UnitType AttacksFlying { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ATTACKS_GROUND"
		public static extern UnitType AttacksGround { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MELEE_ATTACKER"
		public static extern UnitType MeleeAttacker { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_RANGED_ATTACKER"
		public static extern UnitType RangedAttacker { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_GIANT"
		public static extern UnitType Giant { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SUMMONED"
		public static extern UnitType Summoned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_STUNNED"
		public static extern UnitType Stunned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_PLAGUED"
		public static extern UnitType Plagued { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SNARED"
		public static extern UnitType Snared { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_UNDEAD"
		public static extern UnitType Undead { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MECHANICAL"
		public static extern UnitType Mechanical { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_PEON"
		public static extern UnitType Peon { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SAPPER"
		public static extern UnitType Sapper { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_TOWNHALL"
		public static extern UnitType TownHall { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ANCIENT"
		public static extern UnitType Ancient { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_TAUREN"
		public static extern UnitType Tauren { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_POISONED"
		public static extern UnitType Poisoned { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_POLYMORPHED"
		public static extern UnitType Polymorphed { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_SLEEPING"
		public static extern UnitType Sleeping { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_RESISTANT"
		public static extern UnitType Resistant { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_ETHEREAL"
		public static extern UnitType Ethereal { get; }
		/// @CSharpLua.Get = "UNIT_TYPE_MAGIC_IMMUNE"
		public static extern UnitType MagicImmune { get; }

		/// @CSharpLua.Template = "ConvertUnitType({0})"
		public static extern UnitType Convert(int unitTypeId);
	}
}
