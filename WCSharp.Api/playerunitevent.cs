namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playerunitevent : eventid
	{
		internal playerunitevent()
		{
		}

		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_ATTACKED"
		public static extern playerunitevent Attacked { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_RESCUED"
		public static extern playerunitevent Rescued { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DEATH"
		public static extern playerunitevent Death { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DECAY"
		public static extern playerunitevent Decay { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DETECTED"
		public static extern playerunitevent Detected { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_HIDDEN"
		public static extern playerunitevent Hidden { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SELECTED"
		public static extern playerunitevent Selected { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DESELECTED"
		public static extern playerunitevent Deselected { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_CONSTRUCT_START"
		public static extern playerunitevent ConstructStart { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL"
		public static extern playerunitevent ConstructCancel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_CONSTRUCT_FINISH"
		public static extern playerunitevent ConstructFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_UPGRADE_START"
		public static extern playerunitevent UpgradeStart { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_UPGRADE_CANCEL"
		public static extern playerunitevent UpgradeCancel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_UPGRADE_FINISH"
		public static extern playerunitevent UpgradeFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_TRAIN_START"
		public static extern playerunitevent TrainStart { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_TRAIN_CANCEL"
		public static extern playerunitevent TrainCancel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_TRAIN_FINISH"
		public static extern playerunitevent TrainFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_RESEARCH_START"
		public static extern playerunitevent ResearchStart { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_RESEARCH_CANCEL"
		public static extern playerunitevent ResearchCancel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_RESEARCH_FINISH"
		public static extern playerunitevent ResearchFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_ISSUED_ORDER"
		public static extern playerunitevent IssuedOrder { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER"
		public static extern playerunitevent IssuedPointOrder { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER"
		public static extern playerunitevent IssuedTargetOrder { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER"
		public static extern playerunitevent IssuedUnitOrder { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_LEVEL"
		public static extern playerunitevent HeroLevel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_SKILL"
		public static extern playerunitevent HeroSkill { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_REVIVABLE"
		public static extern playerunitevent HeroRevivable { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_REVIVE_START"
		public static extern playerunitevent HeroReviveStart { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_REVIVE_CANCEL"
		public static extern playerunitevent HeroReviveCancel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_HERO_REVIVE_FINISH"
		public static extern playerunitevent HeroReviveFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SUMMON"
		public static extern playerunitevent Summon { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DROP_ITEM"
		public static extern playerunitevent DropItem { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_PICKUP_ITEM"
		public static extern playerunitevent PickupItem { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_USE_ITEM"
		public static extern playerunitevent UseItem { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_LOADED"
		public static extern playerunitevent Loaded { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DAMAGED"
		public static extern playerunitevent Damaged { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_DAMAGING"
		public static extern playerunitevent Damaging { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SELL"
		public static extern playerunitevent Sell { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_CHANGE_OWNER"
		public static extern playerunitevent ChangeOwner { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SELL_ITEM"
		public static extern playerunitevent SellItem { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SPELL_CHANNEL"
		public static extern playerunitevent SpellChannel { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SPELL_CAST"
		public static extern playerunitevent SpellCast { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SPELL_EFFECT"
		public static extern playerunitevent SpellEffect { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SPELL_FINISH"
		public static extern playerunitevent SpellFinish { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_SPELL_ENDCAST"
		public static extern playerunitevent SpellEndCast { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_PAWN_ITEM"
		public static extern playerunitevent PawnItem { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_UNIT_STACK_ITEM"
		public static extern playerunitevent StackItem { get; }

		/// @CSharpLua.Template = "ConvertPlayerUnitEvent({0})"
		public static extern playerunitevent Convert(int playerUnitEventId);
	}
}
