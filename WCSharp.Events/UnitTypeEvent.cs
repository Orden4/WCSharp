namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in UnitTypeEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on an unit type id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, WCSharp.Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum UnitTypeEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		Attacks = 801,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		BuysUnit = 802,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsBeingConstructed = 803,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		CancelsBeingTrained = 804,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsConstruction = 805,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL
		/// </summary>
		CancelsResearch = 806,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		CancelsTraining = 807,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_CANCEL
		/// </summary>
		CancelsUpgrade = 808,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		ChangesOwner = 809,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGING
		/// </summary>
		Damaging = 810,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DECAY
		/// </summary>
		Decays = 811,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Dies = 812,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		DropsItem = 813,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesBeingConstructed = 814,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		FinishesBeingTrained = 815,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesConstruction = 816,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH
		/// </summary>
		FinishesResearch = 817,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		FinishesTraining = 818,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_FINISH
		/// </summary>
		FinishesUpgrade = 819,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		IsAttacked = 820,
		/// <summary>
		/// Based on TriggerRegisterEnterRegion using GetWorldBounds
		/// </summary>
		IsCreated = 821,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// </summary>
		IsDamaged = 822,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		IsDeselected = 823,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DETECTED
		/// </summary>
		IsDetected = 824,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_HIDDEN
		/// </summary>
		IsHidden = 825,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		IsLoaded = 826,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		IsRescued = 827,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		IsSelected = 828,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		IsSold = 829,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		IsSummoned = 830,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Kills = 831,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		Loads = 832,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		PawnsItem = 833,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		PicksUpItem = 834,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_ORDER
		/// </summary>
		ReceivesOrder = 835,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER
		/// </summary>
		ReceivesPointOrder = 836,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER
		/// </summary>
		ReceivesTargetOrder = 837,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER
		/// </summary>
		ReceivesUnitTypeOrder = 838,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		Rescues = 839,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		SellsItem = 840,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		SellsUnit = 841,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCast = 842,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCastOn = 843,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannel = 844,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannelOn = 845,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffect = 846,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffectOn = 847,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCast = 848,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCastOn = 849,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinish = 850,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinishOn = 851,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		StacksItem = 852,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		StartsBeingConstructed = 853,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		StartsBeingTrained = 854,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		StartsConstruction = 855,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_START
		/// </summary>
		StartsResearch = 856,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		StartsTraining = 857,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_START
		/// </summary>
		StartsUpgrade = 858,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		Summons = 859,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		UsesItem = 860,
	}
}
