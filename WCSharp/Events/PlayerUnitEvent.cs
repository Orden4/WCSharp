using static War3Api.Common;

namespace WCSharp.Events
{
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
		public static playerunitevent GetNativeEvent(this PlayerUnitEvent @event)
		{
			return @event switch
			{
				PlayerUnitEvent.HeroTypeBecomesRevivable => EVENT_PLAYER_HERO_REVIVABLE,
				PlayerUnitEvent.HeroTypeCancelsRevive => EVENT_PLAYER_HERO_REVIVE_CANCEL,
				PlayerUnitEvent.HeroTypeFinishesRevive => EVENT_PLAYER_HERO_REVIVE_FINISH,
				PlayerUnitEvent.HeroTypeLearnsSpell => EVENT_PLAYER_HERO_SKILL,
				PlayerUnitEvent.HeroTypeLevels => EVENT_PLAYER_HERO_LEVEL,
				PlayerUnitEvent.HeroTypeStartsRevive => EVENT_PLAYER_HERO_REVIVE_START,
				PlayerUnitEvent.ItemTypeIsDropped => EVENT_PLAYER_UNIT_DROP_ITEM,
				PlayerUnitEvent.ItemTypeIsPawned => EVENT_PLAYER_UNIT_PAWN_ITEM,
				PlayerUnitEvent.ItemTypeIsPickedUp => EVENT_PLAYER_UNIT_PICKUP_ITEM,
				PlayerUnitEvent.ItemTypeIsSold => EVENT_PLAYER_UNIT_SELL_ITEM,
				PlayerUnitEvent.ItemTypeIsStacked => EVENT_PLAYER_UNIT_STACK_ITEM,
				PlayerUnitEvent.ItemTypeIsUsed => EVENT_PLAYER_UNIT_USE_ITEM,
				PlayerUnitEvent.PlayerDeselectsUnitType => EVENT_PLAYER_UNIT_DESELECTED,
				PlayerUnitEvent.PlayerSelectsUnitType => EVENT_PLAYER_UNIT_SELECTED,
				PlayerUnitEvent.ResearchIsCancelled => EVENT_PLAYER_UNIT_RESEARCH_CANCEL,
				PlayerUnitEvent.ResearchIsFinished => EVENT_PLAYER_UNIT_RESEARCH_FINISH,
				PlayerUnitEvent.ResearchIsStarted => EVENT_PLAYER_UNIT_RESEARCH_START,
				PlayerUnitEvent.SpellCast => EVENT_PLAYER_UNIT_SPELL_CAST,
				PlayerUnitEvent.SpellCastOnUnitType => EVENT_PLAYER_UNIT_SPELL_CAST,
				PlayerUnitEvent.SpellChannel => EVENT_PLAYER_UNIT_SPELL_CHANNEL,
				PlayerUnitEvent.SpellChannelOnUnitType => EVENT_PLAYER_UNIT_SPELL_CHANNEL,
				PlayerUnitEvent.SpellEffect => EVENT_PLAYER_UNIT_SPELL_EFFECT,
				PlayerUnitEvent.SpellEffectOnUnitType => EVENT_PLAYER_UNIT_SPELL_EFFECT,
				PlayerUnitEvent.SpellEndCast => EVENT_PLAYER_UNIT_SPELL_ENDCAST,
				PlayerUnitEvent.SpellEndCastOnUnitType => EVENT_PLAYER_UNIT_SPELL_ENDCAST,
				PlayerUnitEvent.SpellFinish => EVENT_PLAYER_UNIT_SPELL_FINISH,
				PlayerUnitEvent.SpellFinishOnUnitType => EVENT_PLAYER_UNIT_SPELL_FINISH,
				PlayerUnitEvent.SpellLearnedByHeroType => EVENT_PLAYER_HERO_SKILL,
				PlayerUnitEvent.UnitTypeAttacks => EVENT_PLAYER_UNIT_ATTACKED,
				PlayerUnitEvent.UnitTypeCancelsBeingConstructed => EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL,
				PlayerUnitEvent.UnitTypeCancelsBeingTrained => EVENT_PLAYER_UNIT_TRAIN_CANCEL,
				PlayerUnitEvent.UnitTypeCancelsConstruction => EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL,
				PlayerUnitEvent.UnitTypeCancelsResearch => EVENT_PLAYER_UNIT_RESEARCH_CANCEL,
				PlayerUnitEvent.UnitTypeCancelsTraining => EVENT_PLAYER_UNIT_TRAIN_CANCEL,
				PlayerUnitEvent.UnitTypeCancelsUpgrade => EVENT_PLAYER_UNIT_UPGRADE_CANCEL,
				PlayerUnitEvent.UnitTypeChangesOwner => EVENT_PLAYER_UNIT_CHANGE_OWNER,
				PlayerUnitEvent.UnitTypeDamages => EVENT_PLAYER_UNIT_DAMAGED,
				PlayerUnitEvent.UnitTypeDecays => EVENT_PLAYER_UNIT_DECAY,
				PlayerUnitEvent.UnitTypeDies => EVENT_PLAYER_UNIT_DEATH,
				PlayerUnitEvent.UnitTypeDropsItem => EVENT_PLAYER_UNIT_DROP_ITEM,
				PlayerUnitEvent.UnitTypeFinishesBeingConstructed => EVENT_PLAYER_UNIT_CONSTRUCT_FINISH,
				PlayerUnitEvent.UnitTypeFinishesBeingTrained => EVENT_PLAYER_UNIT_TRAIN_FINISH,
				PlayerUnitEvent.UnitTypeFinishesConstruction => EVENT_PLAYER_UNIT_CONSTRUCT_FINISH,
				PlayerUnitEvent.UnitTypeFinishesResearch => EVENT_PLAYER_UNIT_RESEARCH_FINISH,
				PlayerUnitEvent.UnitTypeFinishesTraining => EVENT_PLAYER_UNIT_TRAIN_FINISH,
				PlayerUnitEvent.UnitTypeFinishesUpgrade => EVENT_PLAYER_UNIT_UPGRADE_FINISH,
				PlayerUnitEvent.UnitTypeIsAttacked => EVENT_PLAYER_UNIT_ATTACKED,
				PlayerUnitEvent.UnitTypeIsDamaged => EVENT_PLAYER_UNIT_DAMAGED,
				PlayerUnitEvent.UnitTypeIsDeselected => EVENT_PLAYER_UNIT_DESELECTED,
				PlayerUnitEvent.UnitTypeIsDetected => EVENT_PLAYER_UNIT_DETECTED,
				PlayerUnitEvent.UnitTypeIsHidden => EVENT_PLAYER_UNIT_HIDDEN,
				PlayerUnitEvent.UnitTypeIsLoaded => EVENT_PLAYER_UNIT_LOADED,
				PlayerUnitEvent.UnitTypeIsRescued => EVENT_PLAYER_UNIT_RESCUED,
				PlayerUnitEvent.UnitTypeIsSelected => EVENT_PLAYER_UNIT_SELECTED,
				PlayerUnitEvent.UnitTypeIsSold => EVENT_PLAYER_UNIT_SELL,
				PlayerUnitEvent.UnitTypeIsSummoned => EVENT_PLAYER_UNIT_SUMMON,
				PlayerUnitEvent.UnitTypeKills => EVENT_PLAYER_UNIT_DEATH,
				PlayerUnitEvent.UnitTypeLoads => EVENT_PLAYER_UNIT_LOADED,
				PlayerUnitEvent.UnitTypePawnsItem => EVENT_PLAYER_UNIT_PAWN_ITEM,
				PlayerUnitEvent.UnitTypePicksUpItem => EVENT_PLAYER_UNIT_PICKUP_ITEM,
				PlayerUnitEvent.UnitTypeReceivesOrder => EVENT_PLAYER_UNIT_ISSUED_ORDER,
				PlayerUnitEvent.UnitTypeReceivesPointOrder => EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER,
				PlayerUnitEvent.UnitTypeReceivesTargetOrder => EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER,
				PlayerUnitEvent.UnitTypeReceivesUnitOrder => EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER,
				PlayerUnitEvent.UnitTypeRescues => EVENT_PLAYER_UNIT_RESCUED,
				PlayerUnitEvent.UnitTypeSellsItem => EVENT_PLAYER_UNIT_SELL_ITEM,
				PlayerUnitEvent.UnitTypeSellsUnit => EVENT_PLAYER_UNIT_SELL,
				PlayerUnitEvent.UnitTypeSpellCast => EVENT_PLAYER_UNIT_SPELL_CAST,
				PlayerUnitEvent.UnitTypeSpellChannel => EVENT_PLAYER_UNIT_SPELL_CHANNEL,
				PlayerUnitEvent.UnitTypeSpellEffect => EVENT_PLAYER_UNIT_SPELL_EFFECT,
				PlayerUnitEvent.UnitTypeSpellEndCast => EVENT_PLAYER_UNIT_SPELL_ENDCAST,
				PlayerUnitEvent.UnitTypeSpellFinish => EVENT_PLAYER_UNIT_SPELL_FINISH,
				//PlayerUnitEvent.UnitTypeStacksItem => EVENT_PLAYER_UNIT_STACK_ITEM,
				PlayerUnitEvent.UnitTypeStartsBeingConstructed => EVENT_PLAYER_UNIT_CONSTRUCT_START,
				PlayerUnitEvent.UnitTypeStartsBeingTrained => EVENT_PLAYER_UNIT_TRAIN_START,
				PlayerUnitEvent.UnitTypeStartsConstruction => EVENT_PLAYER_UNIT_CONSTRUCT_START,
				PlayerUnitEvent.UnitTypeStartsResearch => EVENT_PLAYER_UNIT_RESEARCH_START,
				PlayerUnitEvent.UnitTypeStartsTraining => EVENT_PLAYER_UNIT_TRAIN_START,
				PlayerUnitEvent.UnitTypeStartsUpgrade => EVENT_PLAYER_UNIT_UPGRADE_START,
				PlayerUnitEvent.UnitTypeSummons => EVENT_PLAYER_UNIT_SUMMON,
				PlayerUnitEvent.UnitTypeUsesItem => EVENT_PLAYER_UNIT_USE_ITEM,
				_ => null,
			};
		}
	}
}
