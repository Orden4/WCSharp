using System;
using System.Collections.Generic;
using WCSharp.Events.EventHandlers.PlayerUnitEventHandlers;
using static War3Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Manager for all Warcraft III <see cref="playerunitevent"/>s. Will bundle together and is able to efficiently filter on specific data.
	/// </summary>
	public static class PlayerUnitEvents
	{
		private static readonly Dictionary<string, int> customEventIdsByIdentifier = new();
		private static readonly Dictionary<playerunitevent, IPlayerUnitEventHandler> playerUnitEventHandlers = new();
		private static readonly Dictionary<int, IPlayerUnitEventHandler> customPlayerUnitEventHandlers = new()
		{
			{ (int)UnitTypeEvent.IsCreated, null }
		};
		private static readonly Dictionary<int, playerunitevent> playerUnitEventNativesById = new()
		{
			{ (int)HeroEvent.BecomesRevivable, EVENT_PLAYER_HERO_REVIVABLE },
			{ (int)HeroEvent.CancelsRevive, EVENT_PLAYER_HERO_REVIVE_CANCEL },
			{ (int)HeroEvent.FinishesRevive, EVENT_PLAYER_HERO_REVIVE_FINISH },
			{ (int)HeroEvent.LearnsSpell, EVENT_PLAYER_HERO_SKILL },
			{ (int)HeroEvent.Levels, EVENT_PLAYER_HERO_LEVEL },
			{ (int)HeroEvent.StartsRevive, EVENT_PLAYER_HERO_REVIVE_START },
			{ (int)HeroTypeEvent.BecomesRevivable, EVENT_PLAYER_HERO_REVIVABLE },
			{ (int)HeroTypeEvent.CancelsRevive, EVENT_PLAYER_HERO_REVIVE_CANCEL },
			{ (int)HeroTypeEvent.FinishesRevive, EVENT_PLAYER_HERO_REVIVE_FINISH },
			{ (int)HeroTypeEvent.LearnsSpell, EVENT_PLAYER_HERO_SKILL },
			{ (int)HeroTypeEvent.Levels, EVENT_PLAYER_HERO_LEVEL },
			{ (int)HeroTypeEvent.StartsRevive, EVENT_PLAYER_HERO_REVIVE_START },
			{ (int)ItemEvent.IsAbsorbed, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)ItemEvent.IsDropped, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)ItemEvent.IsPawned, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)ItemEvent.IsPickedUp, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)ItemEvent.IsSold, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)ItemEvent.IsStacked, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)ItemEvent.IsUsed, EVENT_PLAYER_UNIT_USE_ITEM },
			{ (int)ItemTypeEvent.IsAbsorbed, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)ItemTypeEvent.IsDropped, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)ItemTypeEvent.IsPawned, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)ItemTypeEvent.IsPickedUp, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)ItemTypeEvent.IsSold, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)ItemTypeEvent.IsStacked, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)ItemTypeEvent.IsUsed, EVENT_PLAYER_UNIT_USE_ITEM },
			{ (int)PlayerEvent.DeselectsUnit, EVENT_PLAYER_UNIT_DESELECTED },
			{ (int)PlayerEvent.GainsOwnership, EVENT_PLAYER_UNIT_CHANGE_OWNER },
			{ (int)PlayerEvent.LosesOwnership, EVENT_PLAYER_UNIT_CHANGE_OWNER },
			{ (int)PlayerEvent.SelectsUnit, EVENT_PLAYER_UNIT_SELECTED },
			{ (int)ResearchEvent.IsCancelled, EVENT_PLAYER_UNIT_RESEARCH_CANCEL },
			{ (int)ResearchEvent.IsFinished, EVENT_PLAYER_UNIT_RESEARCH_FINISH },
			{ (int)ResearchEvent.IsStarted, EVENT_PLAYER_UNIT_RESEARCH_START },
			{ (int)SpellEvent.Cast, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)SpellEvent.Channel, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)SpellEvent.Effect, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)SpellEvent.EndCast, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)SpellEvent.Finish, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)SpellEvent.Learned, EVENT_PLAYER_HERO_SKILL },
			{ (int)UnitEvent.Attacks, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)UnitEvent.BuysUnit, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitEvent.CancelsBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)UnitEvent.CancelsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)UnitEvent.CancelsResearch, EVENT_PLAYER_UNIT_RESEARCH_CANCEL },
			{ (int)UnitEvent.CancelsTraining, EVENT_PLAYER_UNIT_TRAIN_CANCEL },
			{ (int)UnitEvent.CancelsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_CANCEL },
			{ (int)UnitEvent.ChangesOwner, EVENT_PLAYER_UNIT_CHANGE_OWNER },
			{ (int)UnitEvent.Damaging, EVENT_PLAYER_UNIT_DAMAGING },
			{ (int)UnitEvent.Decays, EVENT_PLAYER_UNIT_DECAY },
			{ (int)UnitEvent.Dies, EVENT_PLAYER_UNIT_DEATH },
			{ (int)UnitEvent.DropsItem, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)UnitEvent.FinishesBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)UnitEvent.FinishesConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)UnitEvent.FinishesResearch, EVENT_PLAYER_UNIT_RESEARCH_FINISH },
			{ (int)UnitEvent.FinishesTraining, EVENT_PLAYER_UNIT_TRAIN_FINISH },
			{ (int)UnitEvent.FinishesUpgrade, EVENT_PLAYER_UNIT_UPGRADE_FINISH },
			{ (int)UnitEvent.IsAttacked, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)UnitEvent.IsDamaged, EVENT_PLAYER_UNIT_DAMAGED },
			{ (int)UnitEvent.IsDeselected, EVENT_PLAYER_UNIT_DESELECTED },
			{ (int)UnitEvent.IsDetected, EVENT_PLAYER_UNIT_DETECTED },
			{ (int)UnitEvent.IsHidden, EVENT_PLAYER_UNIT_HIDDEN },
			{ (int)UnitEvent.IsLoaded, EVENT_PLAYER_UNIT_LOADED },
			{ (int)UnitEvent.IsRescued, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)UnitEvent.IsSelected, EVENT_PLAYER_UNIT_SELECTED },
			{ (int)UnitEvent.IsSold, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitEvent.Kills, EVENT_PLAYER_UNIT_DEATH },
			{ (int)UnitEvent.Loads, EVENT_PLAYER_UNIT_LOADED },
			{ (int)UnitEvent.PawnsItem, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)UnitEvent.PicksUpItem, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)UnitEvent.ReceivesOrder, EVENT_PLAYER_UNIT_ISSUED_ORDER },
			{ (int)UnitEvent.ReceivesPointOrder, EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER },
			{ (int)UnitEvent.ReceivesTargetOrder, EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER },
			{ (int)UnitEvent.ReceivesUnitTypeOrder, EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER },
			{ (int)UnitEvent.Rescues, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)UnitEvent.SellsItem, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)UnitEvent.SellsUnit, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitEvent.SpellCast, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)UnitEvent.SpellCastOn, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)UnitEvent.SpellChannel, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)UnitEvent.SpellChannelOn, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)UnitEvent.SpellEffect, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)UnitEvent.SpellEffectOn, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)UnitEvent.SpellEndCast, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)UnitEvent.SpellEndCastOn, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)UnitEvent.SpellFinish, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)UnitEvent.SpellFinishOn, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)UnitEvent.StacksItem, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)UnitEvent.StartsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_START },
			{ (int)UnitEvent.StartsResearch, EVENT_PLAYER_UNIT_RESEARCH_START },
			{ (int)UnitEvent.StartsTraining, EVENT_PLAYER_UNIT_TRAIN_START },
			{ (int)UnitEvent.StartsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_START },
			{ (int)UnitEvent.Summons, EVENT_PLAYER_UNIT_SUMMON },
			{ (int)UnitEvent.UsesItem, EVENT_PLAYER_UNIT_USE_ITEM },
			{ (int)UnitTypeEvent.Attacks, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)UnitTypeEvent.BuysUnit, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitTypeEvent.CancelsBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)UnitTypeEvent.CancelsBeingTrained, EVENT_PLAYER_UNIT_TRAIN_CANCEL },
			{ (int)UnitTypeEvent.CancelsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL },
			{ (int)UnitTypeEvent.CancelsResearch, EVENT_PLAYER_UNIT_RESEARCH_CANCEL },
			{ (int)UnitTypeEvent.CancelsTraining, EVENT_PLAYER_UNIT_TRAIN_CANCEL },
			{ (int)UnitTypeEvent.CancelsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_CANCEL },
			{ (int)UnitTypeEvent.ChangesOwner, EVENT_PLAYER_UNIT_CHANGE_OWNER },
			{ (int)UnitTypeEvent.Damaging, EVENT_PLAYER_UNIT_DAMAGING },
			{ (int)UnitTypeEvent.Decays, EVENT_PLAYER_UNIT_DECAY },
			{ (int)UnitTypeEvent.Dies, EVENT_PLAYER_UNIT_DEATH },
			{ (int)UnitTypeEvent.DropsItem, EVENT_PLAYER_UNIT_DROP_ITEM },
			{ (int)UnitTypeEvent.FinishesBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)UnitTypeEvent.FinishesBeingTrained, EVENT_PLAYER_UNIT_TRAIN_FINISH },
			{ (int)UnitTypeEvent.FinishesConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH },
			{ (int)UnitTypeEvent.FinishesResearch, EVENT_PLAYER_UNIT_RESEARCH_FINISH },
			{ (int)UnitTypeEvent.FinishesTraining, EVENT_PLAYER_UNIT_TRAIN_FINISH },
			{ (int)UnitTypeEvent.FinishesUpgrade, EVENT_PLAYER_UNIT_UPGRADE_FINISH },
			{ (int)UnitTypeEvent.IsAttacked, EVENT_PLAYER_UNIT_ATTACKED },
			{ (int)UnitTypeEvent.IsDamaged, EVENT_PLAYER_UNIT_DAMAGED },
			{ (int)UnitTypeEvent.IsDeselected, EVENT_PLAYER_UNIT_DESELECTED },
			{ (int)UnitTypeEvent.IsDetected, EVENT_PLAYER_UNIT_DETECTED },
			{ (int)UnitTypeEvent.IsHidden, EVENT_PLAYER_UNIT_HIDDEN },
			{ (int)UnitTypeEvent.IsLoaded, EVENT_PLAYER_UNIT_LOADED },
			{ (int)UnitTypeEvent.IsRescued, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)UnitTypeEvent.IsSelected, EVENT_PLAYER_UNIT_SELECTED },
			{ (int)UnitTypeEvent.IsSold, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitTypeEvent.IsSummoned, EVENT_PLAYER_UNIT_SUMMON },
			{ (int)UnitTypeEvent.Kills, EVENT_PLAYER_UNIT_DEATH },
			{ (int)UnitTypeEvent.Loads, EVENT_PLAYER_UNIT_LOADED },
			{ (int)UnitTypeEvent.PawnsItem, EVENT_PLAYER_UNIT_PAWN_ITEM },
			{ (int)UnitTypeEvent.PicksUpItem, EVENT_PLAYER_UNIT_PICKUP_ITEM },
			{ (int)UnitTypeEvent.ReceivesOrder, EVENT_PLAYER_UNIT_ISSUED_ORDER },
			{ (int)UnitTypeEvent.ReceivesPointOrder, EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER },
			{ (int)UnitTypeEvent.ReceivesTargetOrder, EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER },
			{ (int)UnitTypeEvent.ReceivesUnitTypeOrder, EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER },
			{ (int)UnitTypeEvent.Rescues, EVENT_PLAYER_UNIT_RESCUED },
			{ (int)UnitTypeEvent.SellsItem, EVENT_PLAYER_UNIT_SELL_ITEM },
			{ (int)UnitTypeEvent.SellsUnit, EVENT_PLAYER_UNIT_SELL },
			{ (int)UnitTypeEvent.SpellCast, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)UnitTypeEvent.SpellCastOn, EVENT_PLAYER_UNIT_SPELL_CAST },
			{ (int)UnitTypeEvent.SpellChannel, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)UnitTypeEvent.SpellChannelOn, EVENT_PLAYER_UNIT_SPELL_CHANNEL },
			{ (int)UnitTypeEvent.SpellEffect, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)UnitTypeEvent.SpellEffectOn, EVENT_PLAYER_UNIT_SPELL_EFFECT },
			{ (int)UnitTypeEvent.SpellEndCast, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)UnitTypeEvent.SpellEndCastOn, EVENT_PLAYER_UNIT_SPELL_ENDCAST },
			{ (int)UnitTypeEvent.SpellFinish, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)UnitTypeEvent.SpellFinishOn, EVENT_PLAYER_UNIT_SPELL_FINISH },
			{ (int)UnitTypeEvent.StacksItem, EVENT_PLAYER_UNIT_STACK_ITEM },
			{ (int)UnitTypeEvent.StartsBeingConstructed, EVENT_PLAYER_UNIT_CONSTRUCT_START },
			{ (int)UnitTypeEvent.StartsBeingTrained, EVENT_PLAYER_UNIT_TRAIN_START },
			{ (int)UnitTypeEvent.StartsConstruction, EVENT_PLAYER_UNIT_CONSTRUCT_START },
			{ (int)UnitTypeEvent.StartsResearch, EVENT_PLAYER_UNIT_RESEARCH_START },
			{ (int)UnitTypeEvent.StartsTraining, EVENT_PLAYER_UNIT_TRAIN_START },
			{ (int)UnitTypeEvent.StartsUpgrade, EVENT_PLAYER_UNIT_UPGRADE_START },
			{ (int)UnitTypeEvent.Summons, EVENT_PLAYER_UNIT_SUMMON },
			{ (int)UnitTypeEvent.UsesItem, EVENT_PLAYER_UNIT_USE_ITEM },
		};
		private static readonly Dictionary<int, Func<int>> filterFuncsByEvent = new()
		{
			{ (int)HeroEvent.BecomesRevivable, () => GetHandleId(GetRevivableUnit()) },
			{ (int)HeroEvent.CancelsRevive, () => GetHandleId(GetRevivingUnit()) },
			{ (int)HeroEvent.FinishesRevive, () => GetHandleId(GetRevivingUnit()) },
			{ (int)HeroEvent.LearnsSpell, () => GetHandleId(GetLearningUnit()) },
			{ (int)HeroEvent.Levels, () => GetHandleId(GetLevelingUnit()) },
			{ (int)HeroEvent.StartsRevive, () => GetHandleId(GetRevivingUnit()) },
			{ (int)HeroTypeEvent.BecomesRevivable, () => GetUnitTypeId(GetRevivableUnit()) },
			{ (int)HeroTypeEvent.CancelsRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ (int)HeroTypeEvent.FinishesRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ (int)HeroTypeEvent.LearnsSpell, () => GetUnitTypeId(GetLearningUnit()) },
			{ (int)HeroTypeEvent.Levels, () => GetUnitTypeId(GetLevelingUnit()) },
			{ (int)HeroTypeEvent.StartsRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ (int)ItemEvent.IsAbsorbed, () => GetHandleId(BlzGetAbsorbingItem()) },
			{ (int)ItemEvent.IsDropped, () => GetHandleId(GetManipulatedItem()) },
			{ (int)ItemEvent.IsPawned, () => GetHandleId(GetManipulatedItem()) },
			{ (int)ItemEvent.IsPickedUp, () => GetHandleId(GetManipulatedItem()) },
			{ (int)ItemEvent.IsSold, () => GetHandleId(GetSoldItem()) },
			{ (int)ItemEvent.IsStacked, () => GetHandleId(GetManipulatedItem()) },
			{ (int)ItemEvent.IsUsed, () => GetHandleId(GetManipulatedItem()) },
			{ (int)ItemTypeEvent.IsAbsorbed, () => GetItemTypeId(BlzGetAbsorbingItem()) },
			{ (int)ItemTypeEvent.IsDropped, () => GetItemTypeId(GetManipulatedItem()) },
			{ (int)ItemTypeEvent.IsPawned, () => GetItemTypeId(GetManipulatedItem()) },
			{ (int)ItemTypeEvent.IsPickedUp, () => GetItemTypeId(GetManipulatedItem()) },
			{ (int)ItemTypeEvent.IsSold, () => GetItemTypeId(GetSoldItem()) },
			{ (int)ItemTypeEvent.IsStacked, () => GetItemTypeId(GetManipulatedItem()) },
			{ (int)ItemTypeEvent.IsUsed, () => GetItemTypeId(GetManipulatedItem()) },
			{ (int)PlayerEvent.DeselectsUnit, () => GetPlayerId(GetTriggerPlayer()) },
			{ (int)PlayerEvent.GainsOwnership, () => GetPlayerId(GetOwningPlayer(GetTriggerUnit())) },
			{ (int)PlayerEvent.LosesOwnership, () => GetPlayerId(GetChangingUnitPrevOwner()) },
			{ (int)PlayerEvent.SelectsUnit, () => GetPlayerId(GetTriggerPlayer()) },
			{ (int)ResearchEvent.IsCancelled, () => GetResearched() },
			{ (int)ResearchEvent.IsFinished, () => GetResearched() },
			{ (int)ResearchEvent.IsStarted, () => GetResearched() },
			{ (int)SpellEvent.Cast, () => GetSpellAbilityId() },
			{ (int)SpellEvent.Channel, () => GetSpellAbilityId() },
			{ (int)SpellEvent.Effect, () => GetSpellAbilityId() },
			{ (int)SpellEvent.EndCast, () => GetSpellAbilityId() },
			{ (int)SpellEvent.Finish, () => GetSpellAbilityId() },
			{ (int)SpellEvent.Learned, () => GetLearnedSkill() },
			{ (int)UnitEvent.Attacks, () => GetHandleId(GetAttacker()) },
			{ (int)UnitEvent.BuysUnit, () => GetHandleId(GetBuyingUnit()) },
			{ (int)UnitEvent.CancelsBeingConstructed, () => GetHandleId(GetCancelledStructure()) },
			{ (int)UnitEvent.CancelsConstruction, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.CancelsResearch, () => GetHandleId(GetResearchingUnit()) },
			{ (int)UnitEvent.CancelsTraining, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.CancelsUpgrade, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.ChangesOwner, () => GetHandleId(GetChangingUnit()) },
			{ (int)UnitEvent.Damaging, () => GetHandleId(GetEventDamageSource()) },
			{ (int)UnitEvent.Decays, () => GetHandleId(GetDecayingUnit()) },
			{ (int)UnitEvent.Dies, () => GetHandleId(GetDyingUnit()) },
			{ (int)UnitEvent.DropsItem, () => GetHandleId(GetManipulatingUnit()) },
			{ (int)UnitEvent.FinishesBeingConstructed, () => GetHandleId(GetConstructedStructure()) },
			{ (int)UnitEvent.FinishesConstruction, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.FinishesResearch, () => GetHandleId(GetResearchingUnit()) },
			{ (int)UnitEvent.FinishesTraining, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.FinishesUpgrade, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsAttacked, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsDamaged, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsDeselected, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsDetected, () => GetHandleId(GetDetectedUnit()) },
			{ (int)UnitEvent.IsHidden, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsLoaded, () => GetHandleId(GetLoadedUnit()) },
			{ (int)UnitEvent.IsRescued, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsSelected, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.IsSold, () => GetHandleId(GetSoldUnit()) },
			{ (int)UnitEvent.Kills, () => GetHandleId(GetKillingUnit()) },
			{ (int)UnitEvent.Loads, () => GetHandleId(GetTransportUnit()) },
			{ (int)UnitEvent.PawnsItem, () => GetHandleId(GetManipulatingUnit()) },
			{ (int)UnitEvent.PicksUpItem, () => GetHandleId(GetManipulatingUnit()) },
			{ (int)UnitEvent.ReceivesOrder, () => GetHandleId(GetOrderedUnit()) },
			{ (int)UnitEvent.ReceivesPointOrder, () => GetHandleId(GetOrderedUnit()) },
			{ (int)UnitEvent.ReceivesTargetOrder, () => GetHandleId(GetOrderedUnit()) },
			{ (int)UnitEvent.ReceivesUnitTypeOrder, () => GetHandleId(GetOrderedUnit()) },
			{ (int)UnitEvent.Rescues, () => GetHandleId(GetRescuer()) },
			{ (int)UnitEvent.SellsItem, () => GetHandleId(GetSellingUnit()) },
			{ (int)UnitEvent.SellsUnit, () => GetHandleId(GetSellingUnit()) },
			{ (int)UnitEvent.SpellCast, () => GetHandleId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellCastOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellChannel, () => GetHandleId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellChannelOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellEffect, () => GetHandleId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellEffectOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellEndCast, () => GetHandleId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellEndCastOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellFinish, () => GetHandleId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.SpellFinishOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitEvent.StacksItem, () => GetHandleId(GetManipulatingUnit()) },
			{ (int)UnitEvent.StartsConstruction, () => GetHandleId(GetConstructingStructure()) },
			{ (int)UnitEvent.StartsResearch, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.StartsTraining, () => GetHandleId(GetResearchingUnit()) },
			{ (int)UnitEvent.StartsUpgrade, () => GetHandleId(GetTriggerUnit()) },
			{ (int)UnitEvent.Summons, () => GetHandleId(GetSummoningUnit()) },
			{ (int)UnitEvent.UsesItem, () => GetHandleId(GetManipulatingUnit()) },
			{ (int)UnitTypeEvent.Attacks, () => GetUnitTypeId(GetAttacker()) },
			{ (int)UnitTypeEvent.BuysUnit, () => GetUnitTypeId(GetBuyingUnit()) },
			{ (int)UnitTypeEvent.CancelsBeingConstructed, () => GetUnitTypeId(GetCancelledStructure()) },
			{ (int)UnitTypeEvent.CancelsBeingTrained, () => GetTrainedUnitType() },
			{ (int)UnitTypeEvent.CancelsConstruction, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.CancelsResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ (int)UnitTypeEvent.CancelsTraining, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.CancelsUpgrade, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.ChangesOwner, () => GetUnitTypeId(GetChangingUnit()) },
			{ (int)UnitTypeEvent.Damaging, () => GetUnitTypeId(GetEventDamageSource()) },
			{ (int)UnitTypeEvent.Decays, () => GetUnitTypeId(GetDecayingUnit()) },
			{ (int)UnitTypeEvent.Dies, () => GetUnitTypeId(GetDyingUnit()) },
			{ (int)UnitTypeEvent.DropsItem, () => GetUnitTypeId(GetManipulatingUnit()) },
			{ (int)UnitTypeEvent.FinishesBeingConstructed, () => GetUnitTypeId(GetConstructedStructure()) },
			{ (int)UnitTypeEvent.FinishesBeingTrained, () => GetUnitTypeId(GetTrainedUnit()) },
			{ (int)UnitTypeEvent.FinishesConstruction, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.FinishesResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ (int)UnitTypeEvent.FinishesTraining, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.FinishesUpgrade, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsAttacked, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsCreated, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsDamaged, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsDeselected, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsDetected, () => GetUnitTypeId(GetDetectedUnit()) },
			{ (int)UnitTypeEvent.IsHidden, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsLoaded, () => GetUnitTypeId(GetLoadedUnit()) },
			{ (int)UnitTypeEvent.IsRescued, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsSelected, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.IsSold, () => GetUnitTypeId(GetSoldUnit()) },
			{ (int)UnitTypeEvent.IsSummoned, () => GetUnitTypeId(GetSummonedUnit()) },
			{ (int)UnitTypeEvent.Kills, () => GetUnitTypeId(GetKillingUnit()) },
			{ (int)UnitTypeEvent.Loads, () => GetUnitTypeId(GetTransportUnit()) },
			{ (int)UnitTypeEvent.PawnsItem, () => GetUnitTypeId(GetManipulatingUnit()) },
			{ (int)UnitTypeEvent.PicksUpItem, () => GetUnitTypeId(GetManipulatingUnit()) },
			{ (int)UnitTypeEvent.ReceivesOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ (int)UnitTypeEvent.ReceivesPointOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ (int)UnitTypeEvent.ReceivesTargetOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ (int)UnitTypeEvent.ReceivesUnitTypeOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ (int)UnitTypeEvent.Rescues, () => GetUnitTypeId(GetRescuer()) },
			{ (int)UnitTypeEvent.SellsItem, () => GetUnitTypeId(GetSellingUnit()) },
			{ (int)UnitTypeEvent.SellsUnit, () => GetUnitTypeId(GetSellingUnit()) },
			{ (int)UnitTypeEvent.SpellCast, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellCastOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellChannel, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellChannelOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellEffect, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellEffectOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellEndCast, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellEndCastOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellFinish, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.SpellFinishOn, () => GetUnitTypeId(GetSpellAbilityUnit()) },
			{ (int)UnitTypeEvent.StacksItem, () => GetUnitTypeId(GetManipulatingUnit()) },
			{ (int)UnitTypeEvent.StartsBeingConstructed, () => GetUnitTypeId(GetConstructingStructure()) },
			{ (int)UnitTypeEvent.StartsBeingTrained, () => GetTrainedUnitType() },
			{ (int)UnitTypeEvent.StartsConstruction, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.StartsResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ (int)UnitTypeEvent.StartsTraining, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.StartsUpgrade, () => GetUnitTypeId(GetTriggerUnit()) },
			{ (int)UnitTypeEvent.Summons, () => GetUnitTypeId(GetSummoningUnit()) },
			{ (int)UnitTypeEvent.UsesItem, () => GetUnitTypeId(GetManipulatingUnit()) },
		};

		internal static bool Debug { get; private set; }

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="unit"/>.
		/// </summary>
		public static void Register(HeroEvent @event, Action action, unit unit)
		{
			Register((int)@event, action, GetHandleId(unit));
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any hero.
		/// </summary>
		public static void Register(HeroTypeEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any hero of <paramref name="unitTypeId"/>.
		/// </summary>
		public static void Register(HeroTypeEvent @event, Action action, int unitTypeId)
		{
			Register((int)@event, action, unitTypeId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="item"/>.
		/// </summary>
		public static void Register(ItemEvent @event, Action action, item item)
		{
			Register((int)@event, action, GetHandleId(item));
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any item.
		/// </summary>
		public static void Register(ItemTypeEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any item of <paramref name="itemTypeId"/>.
		/// </summary>
		public static void Register(ItemTypeEvent @event, Action action, int itemTypeId)
		{
			Register((int)@event, action, itemTypeId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any player.
		/// </summary>
		public static void Register(PlayerEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="player"/>.
		/// </summary>
		public static void Register(PlayerEvent @event, Action action, player player)
		{
			Register((int)@event, action, GetPlayerId(player));
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="playerId"/>.
		/// <para>Note: <paramref name="playerId"/> start at 0. So player 1 (red) is 0.</para>
		/// </summary>
		public static void Register(PlayerEvent @event, Action action, int playerId)
		{
			Register((int)@event, action, playerId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any research.
		/// </summary>
		public static void Register(ResearchEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any research of <paramref name="researchId"/>.
		/// </summary>
		public static void Register(ResearchEvent @event, Action action, int researchId)
		{
			Register((int)@event, action, researchId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any spell.
		/// </summary>
		public static void Register(SpellEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any spell of <paramref name="abilityId"/>.
		/// </summary>
		public static void Register(SpellEvent @event, Action action, int abilityId)
		{
			Register((int)@event, action, abilityId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="unit"/>.
		/// </summary>
		public static void Register(UnitEvent @event, Action action, unit unit)
		{
			Register((int)@event, action, GetHandleId(unit));
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit.
		/// </summary>
		public static void Register(UnitTypeEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit.
		/// </summary>
		public static void Register(UnitTypeEvent @event, Action action, int unitTypeId)
		{
			Register((int)@event, action, unitTypeId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when the custom event with <paramref name="identifier"/> is triggered for <paramref name="filterId"/>.
		/// </summary>
		public static void Register(string identifier, Action action, int filterId)
		{
			if (customEventIdsByIdentifier.TryGetValue(identifier, out var id))
			{
				Register(id, action, filterId);
			}
		}

		private static void Register(int @event, Action action, int? filterId = null)
		{
			Func<int> filterFunc = default;
			if (filterId.HasValue)
			{
				filterFunc = filterFuncsByEvent[@event];
			}
			else
			{
				filterId = 0; // Need to be assigned here because CSharpLua can't handle the decompiled filterId ?? 0 statement
			}

			var handler = GetOrCreateHandler(@event, action, filterId, filterFunc);
			handler?.Register(action, filterFunc, filterId.Value);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="unit"/>.
		/// </summary>
		public static void Unregister(HeroEvent @event, Action action, unit unit)
		{
			Unregister((int)@event, action, GetHandleId(unit));
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any hero.
		/// </summary>
		public static void Unregister(HeroTypeEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any hero of <paramref name="unitTypeId"/>.
		/// </summary>
		public static void Unregister(HeroTypeEvent @event, Action action, int unitTypeId)
		{
			Unregister((int)@event, action, unitTypeId);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="item"/>.
		/// </summary>
		public static void Unregister(ItemEvent @event, Action action, item item)
		{
			Unregister((int)@event, action, GetHandleId(item));
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any item.
		/// </summary>
		public static void Unregister(ItemTypeEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any item of <paramref name="itemTypeId"/>.
		/// </summary>
		public static void Unregister(ItemTypeEvent @event, Action action, int itemTypeId)
		{
			Unregister((int)@event, action, itemTypeId);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any player.
		/// </summary>
		public static void Unregister(PlayerEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="playerId"/>.
		/// </summary>
		public static void Unregister(PlayerEvent @event, Action action, int playerId)
		{
			Unregister((int)@event, action, playerId);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any research.
		/// </summary>
		public static void Unregister(ResearchEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any research of <paramref name="researchId"/>.
		/// </summary>
		public static void Unregister(ResearchEvent @event, Action action, int researchId)
		{
			Unregister((int)@event, action, researchId);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any spell.
		/// </summary>
		public static void Unregister(SpellEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any spell of <paramref name="abilityId"/>.
		/// </summary>
		public static void Unregister(SpellEvent @event, Action action, int abilityId)
		{
			Unregister((int)@event, action, abilityId);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="unit"/>.
		/// </summary>
		public static void Unregister(UnitEvent @event, Action action, unit unit)
		{
			Unregister((int)@event, action, GetHandleId(unit));
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any unit.
		/// </summary>
		public static void Unregister(UnitTypeEvent @event, Action action)
		{
			Unregister((int)@event, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any unit of <paramref name="unitTypeId"/>.
		/// </summary>
		public static void Unregister(UnitTypeEvent @event, Action action, int unitTypeId)
		{
			Unregister((int)@event, action, unitTypeId);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when the custom event with <paramref name="identifier"/> is triggered for <paramref name="filterId"/>.
		/// </summary>
		public static void Unregister(string identifier, Action action, int filterId)
		{
			if (customEventIdsByIdentifier.TryGetValue(identifier, out var id))
			{
				Unregister(id, action, filterId);
			}
		}

		private static void Unregister(int @event, Action action, int? filterId = null)
		{
			Func<int> filterFunc = default;
			if (filterId.HasValue)
			{
				filterFunc = filterFuncsByEvent[@event];
			}
			else
			{
				filterId = 0; // Need to be assigned here because CSharpLua can't handle the decompiled filterId ?? 0 statement
			}

			var handler = GetOrCreateHandler(@event, action, filterId, filterFunc);
			handler?.Unregister(action, filterFunc, filterId.Value);
		}

		private static IPlayerUnitEventHandler GetOrCreateHandler(int @event, Action action, int? filterId, Func<int> filterFunc)
		{
			if (customPlayerUnitEventHandlers.TryGetValue(@event, out var customHandler))
			{
				if (customHandler == null)
				{
					customHandler = CreateCustomHandler(@event);
				}

				return customHandler;
			}
			else if (playerUnitEventNativesById.TryGetValue(@event, out var playerUnitEventNative))
			{
				if (!playerUnitEventHandlers.TryGetValue(playerUnitEventNative, out var handler))
				{
					handler = new PlayerUnitEventHandler(playerUnitEventNative);
					playerUnitEventHandlers.Add(playerUnitEventNative, handler);
				}

				return handler;
			}

			return null;
		}

		/// <summary>
		/// Defines a custom event with the given <paramref name="identifier"/> and <paramref name="filter"/> that responds to events of
		/// the given <paramref name="nativeEvent"/>.
		/// </summary>
		public static void AddCustomEvent(string identifier, Func<int> filter, playerunitevent nativeEvent)
		{
			var id = customEventIdsByIdentifier.Count + 1001;
			customEventIdsByIdentifier.Add(identifier, id);
			playerUnitEventNativesById.Add(id, nativeEvent);
			filterFuncsByEvent.Add(id, filter);
		}

		private static IPlayerUnitEventHandler CreateCustomHandler(int @event)
		{
			var customHandler = @event switch
			{
				(int)UnitTypeEvent.IsCreated => new UnitCreatedHandler(),
				_ => throw new NotImplementedException($"Unexpected custom handler: {@event}"),
			};

			customPlayerUnitEventHandlers[@event] = customHandler;
			return customHandler;
		}

		/// <summary>
		/// Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to <see cref="PeriodicEvents"/> will automatically output
		/// information.
		/// <para>It is recommended to use compilation time conditions to not call this on release mode.</para>
		/// </summary>
		public static void EnableDebug()
		{
			Debug = true;
		}
	}
}
