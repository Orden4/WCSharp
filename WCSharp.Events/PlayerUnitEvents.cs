using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Events.EventHandlers;
using static War3Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Manager for all Warcraft III <see cref="playerunitevent"/>s. Will bundle together and is able to efficiently filter on specific data.
	/// </summary>
	public static class PlayerUnitEvents
	{
		private static readonly Func<int> baseFunc = () => GetUnitTypeId(GetTriggerUnit());
		private static readonly List<CustomPlayerUnitEvent> customPlayerUnitEvents = new List<CustomPlayerUnitEvent>();
		private static readonly List<InternalPlayerUnitEventHandler> internalPlayerUnitEventHandlers = new List<InternalPlayerUnitEventHandler>();
		private static readonly Dictionary<playerunitevent, IPlayerUnitEventHandler> eventHandlers = new Dictionary<playerunitevent, IPlayerUnitEventHandler>();
		private static readonly Dictionary<PlayerUnitEvent, Func<int>> filterFuncsByPlayerUnitEvent = new Dictionary<PlayerUnitEvent, Func<int>>
		{
			{ PlayerUnitEvent.HeroTypeBecomesRevivable, () => GetUnitTypeId(GetRevivableUnit()) },
			{ PlayerUnitEvent.HeroTypeCancelsRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ PlayerUnitEvent.HeroTypeFinishesRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ PlayerUnitEvent.HeroTypeLearnsSpell, () => GetUnitTypeId(GetLearningUnit()) },
			{ PlayerUnitEvent.HeroTypeLevels, () => GetUnitTypeId(GetLevelingUnit()) },
			{ PlayerUnitEvent.HeroTypeStartsRevive, () => GetUnitTypeId(GetRevivingUnit()) },
			{ PlayerUnitEvent.ItemTypeIsDropped, () => GetItemTypeId(GetManipulatedItem()) },
			{ PlayerUnitEvent.ItemTypeIsPawned, () => GetItemTypeId(GetSoldItem()) },
			{ PlayerUnitEvent.ItemTypeIsPickedUp, () => GetItemTypeId(GetManipulatedItem()) },
			{ PlayerUnitEvent.ItemTypeIsSold, () => GetItemTypeId(GetSoldItem()) },
			{ PlayerUnitEvent.ItemTypeIsStacked, () => GetItemTypeId(GetManipulatedItem()) },
			{ PlayerUnitEvent.ItemTypeIsUsed, () => GetItemTypeId(GetManipulatedItem()) },
			{ PlayerUnitEvent.PlayerDeselectsUnitType, () => GetPlayerId(GetTriggerPlayer()) },
			{ PlayerUnitEvent.PlayerSelectsUnitType, () => GetPlayerId(GetTriggerPlayer()) },
			{ PlayerUnitEvent.ResearchIsCancelled, () => GetResearched() },
			{ PlayerUnitEvent.ResearchIsFinished, () => GetResearched() },
			{ PlayerUnitEvent.ResearchIsStarted, () => GetResearched() },
			{ PlayerUnitEvent.SpellCast, () => GetSpellAbilityId() },
			{ PlayerUnitEvent.SpellCastOnUnitType, () => GetUnitTypeId(GetSpellTargetUnit()) },
			{ PlayerUnitEvent.SpellChannel, () => GetSpellAbilityId() },
			{ PlayerUnitEvent.SpellChannelOnUnitType, () => GetUnitTypeId(GetSpellTargetUnit()) },
			{ PlayerUnitEvent.SpellEffect, () => GetSpellAbilityId() },
			{ PlayerUnitEvent.SpellEffectOnUnitType, () => GetUnitTypeId(GetSpellTargetUnit()) },
			{ PlayerUnitEvent.SpellEndCast, () => GetSpellAbilityId() },
			{ PlayerUnitEvent.SpellEndCastOnUnitType, () => GetUnitTypeId(GetSpellTargetUnit()) },
			{ PlayerUnitEvent.SpellFinish, () => GetSpellAbilityId() },
			{ PlayerUnitEvent.SpellFinishOnUnitType, () => GetUnitTypeId(GetSpellTargetUnit()) },
			{ PlayerUnitEvent.SpellLearnedByHeroType, () => GetLearnedSkill() },
			{ PlayerUnitEvent.UnitTypeAttacks, () => GetUnitTypeId(GetAttacker()) },
			{ PlayerUnitEvent.UnitTypeCancelsBeingConstructed, () => GetUnitTypeId(GetCancelledStructure()) },
			{ PlayerUnitEvent.UnitTypeCancelsBeingTrained, () => GetTrainedUnitType() },
			{ PlayerUnitEvent.UnitTypeCancelsResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ PlayerUnitEvent.UnitTypeChangesOwner, () => GetUnitTypeId(GetChangingUnit()) },
			{ PlayerUnitEvent.UnitTypeDamages, () => GetUnitTypeId(GetEventDamageSource()) },
			{ PlayerUnitEvent.UnitTypeDecays, () => GetUnitTypeId(GetDecayingUnit()) },
			{ PlayerUnitEvent.UnitTypeFinishesBeingConstructed, () => GetUnitTypeId(GetConstructedStructure()) },
			{ PlayerUnitEvent.UnitTypeFinishesBeingTrained, () => GetUnitTypeId(GetTrainedUnit()) },
			{ PlayerUnitEvent.UnitTypeFinishesResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ PlayerUnitEvent.UnitTypeIsDetected, () => GetUnitTypeId(GetDetectedUnit()) },
			{ PlayerUnitEvent.UnitTypeIsLoaded, () => GetUnitTypeId(GetLoadedUnit()) },
			{ PlayerUnitEvent.UnitTypeIsSold, () => GetUnitTypeId(GetSoldUnit()) },
			{ PlayerUnitEvent.UnitTypeIsSummoned, () => GetUnitTypeId(GetSummonedUnit()) },
			{ PlayerUnitEvent.UnitTypeKills, () => GetUnitTypeId(GetKillingUnit()) },
			{ PlayerUnitEvent.UnitTypeLoads, () => GetUnitTypeId(GetTransportUnit()) },
			{ PlayerUnitEvent.UnitTypeReceivesOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ PlayerUnitEvent.UnitTypeReceivesPointOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ PlayerUnitEvent.UnitTypeReceivesTargetOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ PlayerUnitEvent.UnitTypeReceivesUnitOrder, () => GetUnitTypeId(GetOrderedUnit()) },
			{ PlayerUnitEvent.UnitTypeRescues, () => GetUnitTypeId(GetRescuer()) },
			{ PlayerUnitEvent.UnitTypeSellsItem, () => GetUnitTypeId(GetSellingUnit()) },
			{ PlayerUnitEvent.UnitTypeStartsBeingConstructed, () => GetUnitTypeId(GetConstructingStructure()) },
			{ PlayerUnitEvent.UnitTypeStartsBeingTrained, () => GetTrainedUnitType() },
			{ PlayerUnitEvent.UnitTypeStartsResearch, () => GetUnitTypeId(GetResearchingUnit()) },
			{ PlayerUnitEvent.UnitTypeSummons, () => GetUnitTypeId(GetSummoningUnit()) },
		};

		/// <summary>
		/// Register the given action for execution whenever the given event fires.
		/// </summary>
		public static void Register(PlayerUnitEvent @event, Action action)
		{
			var handler = GetOrCreateEventHandler(@event);
			handler.Register(action);
		}

		/// <summary>
		/// Register the given action for execution whenever the given event fires.
		/// </summary>
		public static void Register(PlayerUnitEvent @event, Action action, int filterTypeId)
		{
			var handler = GetOrCreateEventHandler(@event);
			handler.Register(@event, action, filterTypeId);
		}

		/// <summary>
		/// Register the given action for execution whenever the given custom event fires.
		/// The identifier should be added via <see cref="AddCustomEventFilter(playerunitevent, string, Func{int})"/> prior to registration.
		/// </summary>
		public static void Register(string identifier, Action action, int filterTypeId)
		{
			var customEvent = customPlayerUnitEvents.FirstOrDefault(x => x.Identifier == identifier);
			if (customEvent != null)
			{
				var handler = GetOrCreateEventHandler(customEvent.NativeEvent);
				handler.Register(identifier, action, filterTypeId);
			}
			else
			{
				Console.WriteLine($"ERROR: Attempted to register to undefined custom event with identifier \"{identifier}\"");
			}
		}

		/// <summary>
		/// Unregisters a previously registered event.
		/// </summary>
		public static void Unregister(PlayerUnitEvent @event, Action action)
		{
			var nativeEvent = @event.GetNativeEvent();
			if (eventHandlers.TryGetValue(nativeEvent, out var handler))
			{
				handler.Unregister(action);
			}
		}

		/// <summary>
		/// Unregisters a previously registered event.
		/// </summary>
		public static void Unregister(PlayerUnitEvent @event, int filterTypeId)
		{
			var nativeEvent = @event.GetNativeEvent();
			if (eventHandlers.TryGetValue(nativeEvent, out var handler))
			{
				handler.Unregister(@event, filterTypeId);
			}
		}

		/// <summary>
		/// Unregisters a previously registered event.
		/// The identifier should be added via <see cref="AddCustomEventFilter(playerunitevent, string, Func{int})"/> prior to registration.
		/// </summary>
		public static void Unregister(string identifier, int filterTypeId)
		{
			var customEvent = customPlayerUnitEvents.FirstOrDefault(x => x.Identifier == identifier);
			if (customEvent != null)
			{
				if (eventHandlers.TryGetValue(customEvent.NativeEvent, out var handler))
				{
					handler.Unregister(identifier, filterTypeId);
				}
			}
			else
			{
				Console.WriteLine($"ERROR: Attempted to unregister from undefined custom event with identifier \"{identifier}\"");
			}
		}

		/// <summary>
		/// Adds a custom event. Custom events act as filters to a native playerunitevent. They will automatically be bundled with any other events
		/// attached to that same playerunitevent. Useful when you want multiple events for something not covered by the default provided
		/// <see cref="PlayerUnitEvent"/>s.
		/// <para>For example, the custom event equivalent of <see cref="PlayerUnitEvent.UnitTypeKills"/> would be 
		/// AddCustomEventFilter(<see cref="EVENT_PLAYER_UNIT_DEATH"/>, "SomeIdentifier", () => GetUnitTypeId(GetKillingUnit()))</para>
		/// </summary>
		/// <param name="wcEvent">The native WarCraft 3 event to base this custom event on</param>
		/// <param name="identifier">A unique identifier for this custom event</param>
		/// <param name="filterFunc">A function by which can be filtered</param>
		public static void AddCustomEventFilter(playerunitevent wcEvent, string identifier, Func<int> filterFunc)
		{
			var @event = customPlayerUnitEvents.FirstOrDefault(x => x.Identifier == identifier);
			if (@event == null)
			{
				customPlayerUnitEvents.Add(new CustomPlayerUnitEvent
				{
					Identifier = identifier,
					NativeEvent = wcEvent,
					Func = filterFunc
				});
			}
			else
			{
				Console.WriteLine($"ERROR: Duplicate custom event definition using identifier {identifier}");
			}
		}

		private static IPlayerUnitEventHandler GetOrCreateEventHandler(PlayerUnitEvent @event)
		{
			var nativeEvent = @event.GetNativeEvent();
			if (nativeEvent != null)
			{
				return GetOrCreateEventHandler(nativeEvent);
			}
			else
			{
				var handler = internalPlayerUnitEventHandlers.FirstOrDefault(x => x.Event == @event);
				if (handler != null)
				{
					return handler;
				}

				handler = @event switch
				{
					PlayerUnitEvent.UnitTypeIsCreated => new UnitCreatedHandler(),
					_ => null,
				};

				if (handler != null)
				{
					internalPlayerUnitEventHandlers.Add(handler);
					return handler;
				}
			}

			Console.WriteLine($"ERROR: Cannot handle PlayerUnitEvent {@event}");
			return null;
		}

		private static IPlayerUnitEventHandler GetOrCreateEventHandler(playerunitevent nativeEvent)
		{
			if (!eventHandlers.TryGetValue(nativeEvent, out var handler))
			{
				handler = new NativePlayerUnitEventHandler(nativeEvent);
			}

			return handler;
		}

		internal static Func<int> GetFunc(PlayerUnitEvent @event)
		{
			return filterFuncsByPlayerUnitEvent.TryGetValue(@event, out var func)
				? func
				: baseFunc;
		}

		internal static Func<int> GetFunc(string @event)
		{
			return customPlayerUnitEvents.First(x => x.Identifier == @event).Func;
		}
	}
}
