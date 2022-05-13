using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in PlayerUnitEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEventFilter(playerunitevent, string, System.Func{int})"/>.</para>
	/// </summary>
	public enum PlayerUnitEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVABLE
		/// </summary>
		HeroTypeBecomesRevivable,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_CANCEL
		/// </summary>
		HeroTypeCancelsRevive,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_FINISH
		/// </summary>
		HeroTypeFinishesRevive,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		HeroTypeLearnsSpell,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_LEVEL
		/// </summary>
		HeroTypeLevels,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_START
		/// </summary>
		HeroTypeStartsRevive,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		ItemTypeIsDropped,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		ItemTypeIsPawned,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		ItemTypeIsPickedUp,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		ItemTypeIsSold,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		ItemTypeIsStacked,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		ItemTypeIsUsed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		PlayerDeselectsUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		PlayerSelectsUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL
		/// </summary>
		ResearchIsCancelled,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH
		/// </summary>
		ResearchIsFinished,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_START
		/// </summary>
		ResearchIsStarted,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		SpellCastOnUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannel,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		SpellChannelOnUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffect,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		SpellEffectOnUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		SpellEndCastOnUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinish,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		SpellFinishOnUnitType,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		SpellLearnedByHeroType,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		UnitTypeAttacks,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		UnitTypeCancelsBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		UnitTypeCancelsBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL
		/// </summary>
		UnitTypeCancelsConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_CANCEL
		/// </summary>
		UnitTypeCancelsResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_CANCEL
		/// </summary>
		UnitTypeCancelsTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_CANCEL
		/// </summary>
		UnitTypeCancelsUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		UnitTypeChangesOwner,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// </summary>
		UnitTypeDamages,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DECAY
		/// </summary>
		UnitTypeDecays,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		UnitTypeDies,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		UnitTypeDropsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		UnitTypeFinishesBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		UnitTypeFinishesBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_FINISH
		/// </summary>
		UnitTypeFinishesConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_FINISH
		/// </summary>
		UnitTypeFinishesResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_FINISH
		/// </summary>
		UnitTypeFinishesTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_FINISH
		/// </summary>
		UnitTypeFinishesUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ATTACKED
		/// </summary>
		UnitTypeIsAttacked,
		/// <summary>
		/// Based on 
		/// </summary>
		UnitTypeIsCreated,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DAMAGED
		/// </summary>
		UnitTypeIsDamaged,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		UnitTypeIsDeselected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DETECTED
		/// </summary>
		UnitTypeIsDetected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_HIDDEN
		/// </summary>
		UnitTypeIsHidden,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		UnitTypeIsLoaded,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		UnitTypeIsRescued,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		UnitTypeIsSelected,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		UnitTypeIsSold,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		UnitTypeIsSummoned,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DEATH
		/// </summary>
		UnitTypeKills,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_LOADED
		/// </summary>
		UnitTypeLoads,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		UnitTypePawnsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		UnitTypePicksUpItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_ORDER
		/// </summary>
		UnitTypeReceivesOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER
		/// </summary>
		UnitTypeReceivesPointOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER
		/// </summary>
		UnitTypeReceivesTargetOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER
		/// </summary>
		UnitTypeReceivesUnitOrder,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESCUED
		/// </summary>
		UnitTypeRescues,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		UnitTypeSellsItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL
		/// </summary>
		UnitTypeSellsUnit,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		UnitTypeSpellCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		UnitTypeSpellChannel,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		UnitTypeSpellEffect,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		UnitTypeSpellEndCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		UnitTypeSpellFinish,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		UnitTypeStacksItem,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		UnitTypeStartsBeingConstructed,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		UnitTypeStartsBeingTrained,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CONSTRUCT_START
		/// </summary>
		UnitTypeStartsConstruction,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_RESEARCH_START
		/// </summary>
		UnitTypeStartsResearch,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_TRAIN_START
		/// </summary>
		UnitTypeStartsTraining,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_UPGRADE_START
		/// </summary>
		UnitTypeStartsUpgrade,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SUMMON
		/// </summary>
		UnitTypeSummons,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		UnitTypeUsesItem,
	}

	internal static class PlayerUnitEventExtensions
	{
		private static readonly Dictionary<int, playerunitevent> mapping = new()
		{
			{ (int)PlayerUnitEvent.HeroTypeBecomesRevivable, EVENT_PLAYER_HERO_REVIVABLE },
			{ (int)PlayerUnitEvent.HeroTypeCancelsRevive, EVENT_PLAYER_HERO_REVIVE_CANCEL },
			{ (int)PlayerUnitEvent.HeroTypeFinishesRevive, EVENT_PLAYER_HERO_REVIVE_FINISH },
			{ (int)PlayerUnitEvent.HeroTypeLearnsSpell, EVENT_PLAYER_HERO_SKILL },
			{ (int)PlayerUnitEvent.HeroTypeLevels, EVENT_PLAYER_HERO_LEVEL },
			{ (int)PlayerUnitEvent.HeroTypeStartsRevive, EVENT_PLAYER_HERO_REVIVE_START },
			{ (int)PlayerUnitEvent.ItemTypeIsDropped, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)PlayerUnitEvent.ItemTypeIsPawned, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)PlayerUnitEvent.ItemTypeIsPickedUp, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)PlayerUnitEvent.ItemTypeIsSold, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)PlayerUnitEvent.ItemTypeIsStacked, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)PlayerUnitEvent.ItemTypeIsUsed, EVENT_PLAYER_UNIT_USE_ITEM },
			{ (int)PlayerUnitEvent.PlayerDeselectsUnitType, EVENT_PLAYER_UNIT_DESELECTED },
			{ (int)PlayerUnitEvent.PlayerSelectsUnitType, EVENT_PLAYER_UNIT_SELECTED },
			{ (int)PlayerUnitEvent.ResearchIsCancelled, EVENT_PLAYER_UNIT_RESEARCH_CANCEL },
			{ (int)PlayerUnitEvent.ResearchIsFinished, EVENT_PLAYER_UNIT_RESEARCH_FINISH },
			{ (int)PlayerUnitEvent.ResearchIsStarted, EVENT_PLAYER_UNIT_RESEARCH_START },
			{ (int)PlayerUnitEvent.SpellCast, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)PlayerUnitEvent.SpellCastOnUnitType, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)PlayerUnitEvent.SpellChannel, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)PlayerUnitEvent.SpellChannelOnUnitType, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)PlayerUnitEvent.SpellEffect, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)PlayerUnitEvent.SpellEffectOnUnitType, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)PlayerUnitEvent.SpellEndCast, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)PlayerUnitEvent.SpellEndCastOnUnitType, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)PlayerUnitEvent.SpellFinish, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)PlayerUnitEvent.SpellFinishOnUnitType, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)PlayerUnitEvent.SpellLearnedByHeroType, EVENT_PLAYER_HERO_SKILL },
			{ (int)PlayerUnitEvent.UnitTypeAttacks, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)PlayerUnitEvent.UnitTypeCancelsBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeCancelsBeingTrained, EVENT_PLAYER_UNIT_TRAIN_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeCancelsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeCancelsResearch, EVENT_PLAYER_UNIT_RESEARCH_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeCancelsTraining, EVENT_PLAYER_UNIT_TRAIN_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeCancelsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_CANCEL },
			{ (int)PlayerUnitEvent.UnitTypeChangesOwner, EVENT_PLAYER_UNIT_CHANGE_OWNER },
			{ (int)PlayerUnitEvent.UnitTypeDamages, EVENT_PLAYER_UNIT_DAMAGED },
			{ (int)PlayerUnitEvent.UnitTypeDecays, EVENT_PLAYER_UNIT_DECAY },
			{ (int)PlayerUnitEvent.UnitTypeDies, EVENT_PLAYER_UNIT_DEATH },
			{ (int)PlayerUnitEvent.UnitTypeDropsItem, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)PlayerUnitEvent.UnitTypeFinishesBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeFinishesBeingTrained, EVENT_PLAYER_UNIT_TRAIN_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeFinishesConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeFinishesResearch, EVENT_PLAYER_UNIT_RESEARCH_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeFinishesTraining, EVENT_PLAYER_UNIT_TRAIN_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeFinishesUpgrade, EVENT_PLAYER_UNIT_UPGRADE_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeIsAttacked, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)PlayerUnitEvent.UnitTypeIsDamaged, EVENT_PLAYER_UNIT_DAMAGED },
			{ (int)PlayerUnitEvent.UnitTypeIsDeselected, EVENT_PLAYER_UNIT_DESELECTED },
			{ (int)PlayerUnitEvent.UnitTypeIsDetected, EVENT_PLAYER_UNIT_DETECTED },
			{ (int)PlayerUnitEvent.UnitTypeIsHidden, EVENT_PLAYER_UNIT_HIDDEN },
			{ (int)PlayerUnitEvent.UnitTypeIsLoaded, EVENT_PLAYER_UNIT_LOADED },
			{ (int)PlayerUnitEvent.UnitTypeIsRescued, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)PlayerUnitEvent.UnitTypeIsSelected, EVENT_PLAYER_UNIT_SELECTED },
			{ (int)PlayerUnitEvent.UnitTypeIsSold, EVENT_PLAYER_UNIT_SELL },
			{ (int)PlayerUnitEvent.UnitTypeIsSummoned, EVENT_PLAYER_UNIT_SUMMON },
			{ (int)PlayerUnitEvent.UnitTypeKills, EVENT_PLAYER_UNIT_DEATH },
			{ (int)PlayerUnitEvent.UnitTypeLoads, EVENT_PLAYER_UNIT_LOADED },
			{ (int)PlayerUnitEvent.UnitTypePawnsItem, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)PlayerUnitEvent.UnitTypePicksUpItem, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)PlayerUnitEvent.UnitTypeReceivesOrder, EVENT_PLAYER_UNIT_ISSUED_ORDER },
			{ (int)PlayerUnitEvent.UnitTypeReceivesPointOrder, EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER },
			{ (int)PlayerUnitEvent.UnitTypeReceivesTargetOrder, EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER },
			{ (int)PlayerUnitEvent.UnitTypeReceivesUnitOrder, EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER },
			{ (int)PlayerUnitEvent.UnitTypeRescues, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)PlayerUnitEvent.UnitTypeSellsItem, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)PlayerUnitEvent.UnitTypeSellsUnit, EVENT_PLAYER_UNIT_SELL },
			{ (int)PlayerUnitEvent.UnitTypeSpellCast, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)PlayerUnitEvent.UnitTypeSpellChannel, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)PlayerUnitEvent.UnitTypeSpellEffect, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)PlayerUnitEvent.UnitTypeSpellEndCast, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)PlayerUnitEvent.UnitTypeSpellFinish, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)PlayerUnitEvent.UnitTypeStacksItem, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)PlayerUnitEvent.UnitTypeStartsBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_START },
			{ (int)PlayerUnitEvent.UnitTypeStartsBeingTrained, EVENT_PLAYER_UNIT_TRAIN_START },
			{ (int)PlayerUnitEvent.UnitTypeStartsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_START },
			{ (int)PlayerUnitEvent.UnitTypeStartsResearch, EVENT_PLAYER_UNIT_RESEARCH_START },
			{ (int)PlayerUnitEvent.UnitTypeStartsTraining, EVENT_PLAYER_UNIT_TRAIN_START },
			{ (int)PlayerUnitEvent.UnitTypeStartsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_START },
			{ (int)PlayerUnitEvent.UnitTypeSummons, EVENT_PLAYER_UNIT_SUMMON },
			{ (int)PlayerUnitEvent.UnitTypeUsesItem, EVENT_PLAYER_UNIT_USE_ITEM },
		};

		public static playerunitevent GetNativeEvent(this PlayerUnitEvent @event)
		{
			return mapping.TryGetValue((int)@event, out var nativeEvent)
				? nativeEvent
				: null;
		}
	}
}
