namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unitevent : eventid
	{
		internal unitevent()
		{
		}

		/// @CSharpLua.Get = "EVENT_UNIT_SELL"
		public static extern unitevent Sell { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CHANGE_OWNER"
		public static extern unitevent ChangeOwner { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SELL_ITEM"
		public static extern unitevent SellItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_CHANNEL"
		public static extern unitevent SpellChannel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_CAST"
		public static extern unitevent SpellCast { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_EFFECT"
		public static extern unitevent SpellEffect { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_FINISH"
		public static extern unitevent SpellFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SPELL_ENDCAST"
		public static extern unitevent SpellEndCast { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_PAWN_ITEM"
		public static extern unitevent PawnItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_STACK_ITEM"
		public static extern unitevent StackItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DAMAGED"
		public static extern unitevent Damaged { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DAMAGING"
		public static extern unitevent Damaging { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DEATH"
		public static extern unitevent Death { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DECAY"
		public static extern unitevent Decay { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DETECTED"
		public static extern unitevent Detected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HIDDEN"
		public static extern unitevent Hidden { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SELECTED"
		public static extern unitevent Selected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DESELECTED"
		public static extern unitevent Deselected { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_STATE_LIMIT"
		public static extern unitevent StateLimit { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ACQUIRED_TARGET"
		public static extern unitevent AcquiredTarget { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TARGET_IN_RANGE"
		public static extern unitevent TargetInRange { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ATTACKED"
		public static extern unitevent Attacked { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESCUED"
		public static extern unitevent Rescued { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CONSTRUCT_CANCEL"
		public static extern unitevent ConstructCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_CONSTRUCT_FINISH"
		public static extern unitevent ConstructFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_START"
		public static extern unitevent UpgradeStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_CANCEL"
		public static extern unitevent UpgradeCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_UPGRADE_FINISH"
		public static extern unitevent UpgradeFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_START"
		public static extern unitevent TrainStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_CANCEL"
		public static extern unitevent TrainCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_TRAIN_FINISH"
		public static extern unitevent TrainFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_START"
		public static extern unitevent ResearchStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_CANCEL"
		public static extern unitevent ResearchCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_RESEARCH_FINISH"
		public static extern unitevent ResearchFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_ORDER"
		public static extern unitevent IssuedOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_POINT_ORDER"
		public static extern unitevent IssuedPointOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_ISSUED_TARGET_ORDER"
		public static extern unitevent IssuedTargetOrder { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_LEVEL"
		public static extern unitevent HeroLevel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_SKILL"
		public static extern unitevent HeroSkill { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVABLE"
		public static extern unitevent HeroRevivable { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_START"
		public static extern unitevent HeroReviveStart { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_CANCEL"
		public static extern unitevent HeroReviveCancel { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_HERO_REVIVE_FINISH"
		public static extern unitevent HeroReviveFinish { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_SUMMON"
		public static extern unitevent Summon { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_DROP_ITEM"
		public static extern unitevent DropItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_PICKUP_ITEM"
		public static extern unitevent PickupItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_USE_ITEM"
		public static extern unitevent UseItem { get; }
		/// @CSharpLua.Get = "EVENT_UNIT_LOADED"
		public static extern unitevent Loaded { get; }

		/// @CSharpLua.Template = "ConvertUnitEvent({0})"
		public static extern unitevent Convert(int unitEventId);
	}
}
