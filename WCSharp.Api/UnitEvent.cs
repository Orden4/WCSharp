using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UnitEvent : EventId
	{
		internal UnitEvent()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unitevent(UnitEvent x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UnitEvent(unitevent x);

		/// @CSharpLua.Get = "EVENT_UNIT_SELL"
		public static extern UnitEvent Sell { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CHANGE_OWNER"
		public static extern UnitEvent ChangeOwner { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SELL_ITEM"
		public static extern UnitEvent SellItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_CHANNEL"
		public static extern UnitEvent SpellChannel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_CAST"
		public static extern UnitEvent SpellCast { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_EFFECT"
		public static extern UnitEvent SpellEffect { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_FINISH"
		public static extern UnitEvent SpellFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_ENDCAST"
		public static extern UnitEvent SpellEndCast { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_PAWN_ITEM"
		public static extern UnitEvent PawnItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_STACK_ITEM"
		public static extern UnitEvent StackItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DAMAGED"
		public static extern UnitEvent Damaged { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DAMAGING"
		public static extern UnitEvent Damaging { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DEATH"
		public static extern UnitEvent Death { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DECAY"
		public static extern UnitEvent Decay { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DETECTED"
		public static extern UnitEvent Detected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HIDDEN"
		public static extern UnitEvent Hidden { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SELECTED"
		public static extern UnitEvent Selected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DESELECTED"
		public static extern UnitEvent Deselected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_STATE_LIMIT"
		public static extern UnitEvent StateLimit { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ACQUIRED_TARGET"
		public static extern UnitEvent AcquiredTarget { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TARGET_IN_RANGE"
		public static extern UnitEvent TargetInRange { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ATTACKED"
		public static extern UnitEvent Attacked { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESCUED"
		public static extern UnitEvent Rescued { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CONSTRUCT_CANCEL"
		public static extern UnitEvent ConstructCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CONSTRUCT_FINISH"
		public static extern UnitEvent ConstructFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_START"
		public static extern UnitEvent UpgradeStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_CANCEL"
		public static extern UnitEvent UpgradeCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_FINISH"
		public static extern UnitEvent UpgradeFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_START"
		public static extern UnitEvent TrainStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_CANCEL"
		public static extern UnitEvent TrainCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_FINISH"
		public static extern UnitEvent TrainFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_START"
		public static extern UnitEvent ResearchStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_CANCEL"
		public static extern UnitEvent ResearchCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_FINISH"
		public static extern UnitEvent ResearchFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_ORDER"
		public static extern UnitEvent IssuedOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_POINT_ORDER"
		public static extern UnitEvent IssuedPointOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_TARGET_ORDER"
		public static extern UnitEvent IssuedTargetOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_LEVEL"
		public static extern UnitEvent HeroLevel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_SKILL"
		public static extern UnitEvent HeroSkill { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVABLE"
		public static extern UnitEvent HeroRevivable { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_START"
		public static extern UnitEvent HeroReviveStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_CANCEL"
		public static extern UnitEvent HeroReviveCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_FINISH"
		public static extern UnitEvent HeroReviveFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SUMMON"
		public static extern UnitEvent Summon { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DROP_ITEM"
		public static extern UnitEvent DropItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_PICKUP_ITEM"
		public static extern UnitEvent PickupItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_USE_ITEM"
		public static extern UnitEvent UseItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_LOADED"
		public static extern UnitEvent Loaded { get; }

		/// @CSharpLua.Template = "ConvertUnitEvent({0})"
		public static extern UnitEvent Convert(int unitEventId);
	}
}
