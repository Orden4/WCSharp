namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in UnitEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a unit handle filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, War3Api.Common.playerunitevent)"/>.</para>
	/// </summary>
	public enum UnitEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		Attacks = 701,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		BuysUnit = 702,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsBeingConstructed = 703,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsConstruction = 704,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL
		/// </summary>
		CancelsResearch = 705,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		CancelsTraining = 706,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_CANCEL
		/// </summary>
		CancelsUpgrade = 707,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		ChangesOwner = 708,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGING
		/// </summary>
		Damaging = 709,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DECAY
		/// </summary>
		Decays = 710,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Dies = 711,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		DropsItem = 712,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesBeingConstructed = 713,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesConstruction = 714,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH
		/// </summary>
		FinishesResearch = 715,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		FinishesTraining = 716,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_FINISH
		/// </summary>
		FinishesUpgrade = 717,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		IsAttacked = 718,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// </summary>
		IsDamaged = 719,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		IsDeselected = 720,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DETECTED
		/// </summary>
		IsDetected = 721,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_HIDDEN
		/// </summary>
		IsHidden = 722,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		IsLoaded = 723,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		IsRescued = 724,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		IsSelected = 725,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		IsSold = 726,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Kills = 727,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		Loads = 728,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		PawnsItem = 729,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		PicksUpItem = 730,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_ORDER
		/// </summary>
		ReceivesOrder = 731,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER
		/// </summary>
		ReceivesPointOrder = 732,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER
		/// </summary>
		ReceivesTargetOrder = 733,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER
		/// </summary>
		ReceivesUnitTypeOrder = 734,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		Rescues = 735,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		SellsItem = 736,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		SellsUnit = 737,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCast = 738,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCastOn = 739,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannel = 740,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannelOn = 741,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffect = 742,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffectOn = 743,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCast = 744,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCastOn = 745,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinish = 746,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinishOn = 747,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		StacksItem = 748,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		StartsConstruction = 749,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_START
		/// </summary>
		StartsResearch = 750,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		StartsTraining = 751,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_START
		/// </summary>
		StartsUpgrade = 752,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		Summons = 753,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		UsesItem = 754,
	}
}
