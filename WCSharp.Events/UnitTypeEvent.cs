namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in UnitTypeEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on an unit type id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum UnitTypeEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		Attacks = 1001,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		BuysUnit,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		CancelsBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		CancelsConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL
		/// </summary>
		CancelsResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		CancelsTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_CANCEL
		/// </summary>
		CancelsUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		ChangesOwner,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGING
		/// <para>Filters on the unit dealing damage.</para>
		/// <para>Runs before damage reductions.</para>
		/// </summary>
		Damaging,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGING
		/// <para>Filters on the unit taking damage.</para>
		/// <para>Runs before damage reductions.</para>
		/// </summary>
		DamagingTaken,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DECAY
		/// </summary>
		Decays,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Dies,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		DropsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		FinishesBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		FinishesConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH
		/// </summary>
		FinishesResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		FinishesTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_FINISH
		/// </summary>
		FinishesUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		IsAttacked,
		/// <summary>
		/// Identical to <c>Register(RegionUnitTypeEvent.Enters, action, Rectangle.WorldBounds.Region)</c>
		/// </summary>
		IsCreated,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// <para>Filters on the unit taking damage.</para>
		/// <para>Runs after damage reductions.</para>
		/// </summary>
		IsDamaged,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// <para>Filters on the unit dealing damage.</para>
		/// <para>Runs after damage reductions.</para>
		/// </summary>
		IsDamagedDealt,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		IsDeselected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DETECTED
		/// </summary>
		IsDetected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_HIDDEN
		/// </summary>
		IsHidden,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		IsLoaded,
		/// <summary>
		/// Identical to <c>Register(RegionUnitTypeEvent.Leaves, action, Rectangle.WorldBounds.Region)</c>
		/// </summary>
		IsRemoved,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		IsRescued,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		IsSelected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		IsSold,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		IsSummoned,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		Kills,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		Loads,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		PawnsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		PicksUpItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_ORDER
		/// </summary>
		ReceivesOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER
		/// </summary>
		ReceivesPointOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER
		/// </summary>
		ReceivesTargetOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER
		/// </summary>
		ReceivesUnitTypeOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		Rescues,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		SellsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		SellsUnit,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCastOn,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannel,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannelOn,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffect,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffectOn,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCastOn,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinish,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinishOn,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		StacksItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		StartsBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		StartsBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		StartsConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_START
		/// </summary>
		StartsResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		StartsTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_START
		/// </summary>
		StartsUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		Summons,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		UsesItem,

	}
}
