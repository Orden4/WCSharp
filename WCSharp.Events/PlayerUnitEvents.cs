using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Events.EventHandlers.PlayerUnitEventHandlers;
using WCSharp.Shared.Data;
using WCSharp.Shared.Extensions;
using static WCSharp.Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Manager for all Warcraft III <see cref="playerunitevent"/>s. Will bundle together and is able to efficiently filter on specific data.
	/// </summary>
	public static partial class PlayerUnitEvents
	{
		private static int nextCustomEventId = 1_000_000;

		private static readonly List<Action> pendingUpdates = new();
		private static readonly Dictionary<string, int> customEventIdsByIdentifier = new();
		private static readonly Dictionary<Tuple<region, bool>, int> customEventIdsByRegion = new();
		private static readonly Dictionary<playerunitevent, IPlayerUnitEventHandler> playerUnitEventHandlers = new();
		private static readonly Dictionary<int, IPlayerUnitEventHandler> customPlayerUnitEventHandlers = new()
		{
			{ (int)UnitTypeEvent.IsCreated, null },
			{ (int)UnitTypeEvent.IsRemoved, null },
		};

		internal static bool Debug { get; private set; }

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for <paramref name="unit"/>.
		/// </summary>
		public static void Register(HeroEvent @event, Action action, unit unit)
		{
			Register((int)@event, action, unit);
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
			Register((int)@event, action, item);
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
			Register((int)@event, action, player);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit.
		/// </summary>
		public static void Register(RegionUnitEvent @event, Action action, region region, unit unit)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Register(id, action, unit);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit.
		/// </summary>
		public static void Register(RegionUnitTypeEvent @event, Action action, region region)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Register(id, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit of <paramref name="unitTypeId"/>.
		/// </summary>
		public static void Register(RegionUnitTypeEvent @event, Action action, region region, int unitTypeId)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Register(id, action, unitTypeId);
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
			Register((int)@event, action, unit);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit.
		/// </summary>
		public static void Register(UnitTypeEvent @event, Action action)
		{
			Register((int)@event, action);
		}

		/// <summary>
		/// Registers <paramref name="action"/> to fire when <paramref name="event"/> is triggered for any unit of <paramref name="unitTypeId"/>.
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

		private static void Register(int @event, Action action)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var handler = GetOrCreateHandler(@event);
				handler?.Register(action);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Register(@event, action));
			}
		}

		private static void Register(int @event, Action action, int filterId)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var filterFunc = filterFuncIdsByEvent[@event];
				var handler = GetOrCreateHandler(@event);
				handler?.Register(action, @event, filterFunc, filterId);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Register(@event, action, filterId));
			}
		}

		private static void Register(int @event, Action action, handle handle)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var filterFunc = filterFuncHandlesByEvent[@event];
				var handler = GetOrCreateHandler(@event);
				handler?.Register(action, @event, filterFunc, handle);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Register(@event, action, handle));
			}
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="unit"/>.
		/// </summary>
		public static void Unregister(HeroEvent @event, Action action, unit unit)
		{
			Unregister((int)@event, action, unit);
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
			Unregister((int)@event, action, item);
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
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for <paramref name="unit"/>.
		/// </summary>
		public static void Unregister(RegionUnitEvent @event, Action action, region region, unit unit)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Unregister(id, action, unit);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any unit.
		/// </summary>
		public static void Unregister(RegionUnitTypeEvent @event, Action action, region region)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Unregister(id, action);
		}

		/// <summary>
		/// Unregisters <paramref name="action"/> from <paramref name="event"/> for any unit of <paramref name="unitTypeId"/>.
		/// </summary>
		public static void Unregister(RegionUnitTypeEvent @event, Action action, region region, int unitTypeId)
		{
			var id = GetOrCreateRegionEventId(region, (int)@event);
			Unregister(id, action, unitTypeId);
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
			Unregister((int)@event, action, unit);
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

		private static void Unregister(int @event, Action action)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var handler = GetOrCreateHandler(@event);
				handler?.Unregister(action);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Unregister(@event, action));
			}
		}

		private static void Unregister(int @event, Action action, int filterId)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var filterFunc = filterFuncIdsByEvent[@event];
				var handler = GetOrCreateHandler(@event);
				handler?.Unregister(action, @event, filterFunc, filterId);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Unregister(@event, action, filterId));
			}
		}

		private static void Unregister(int @event, Action action, handle handle)
		{
			if (AbstractPlayerUnitEventHandler.Depth == 0)
			{
				var filterFunc = filterFuncHandlesByEvent[@event];
				var handler = GetOrCreateHandler(@event);
				handler?.Unregister(action, @event, filterFunc, handle);
			}
			else
			{
				AbstractPlayerUnitEventHandler.RequiresUpdate = true;
				pendingUpdates.DirectAdd(() => Unregister(@event, action, handle));
			}
		}

		private static IPlayerUnitEventHandler GetOrCreateHandler(int @event)
		{
			if (customPlayerUnitEventHandlers.TryGetValue(@event, out var customHandler))
			{
				return customHandler ?? CreateCustomHandler(@event);
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
			var id = ++nextCustomEventId;
			customEventIdsByIdentifier.Add(identifier, id);
			playerUnitEventNativesById.Add(id, nativeEvent);
			filterFuncIdsByEvent.Add(id, filter);
		}

		private static IPlayerUnitEventHandler CreateCustomHandler(int @event)
		{
			var eventId = @event switch
			{
				(int)UnitTypeEvent.IsCreated => GetOrCreateRegionEventId(Rectangle.WorldBounds.Region, (int)RegionUnitTypeEvent.Enters),
				(int)UnitTypeEvent.IsRemoved => GetOrCreateRegionEventId(Rectangle.WorldBounds.Region, (int)RegionUnitTypeEvent.Leaves),
				_ => throw new NotImplementedException($"Unexpected custom handler: {@event}"),
			};
			return customPlayerUnitEventHandlers[eventId];
		}

		private static int GetOrCreateRegionEventId(region region, int @event)
		{
			var enters = @event == (int)RegionUnitEvent.Enters || @event == (int)RegionUnitTypeEvent.Enters;
			var key = Tuple.Create(region, enters);
			if (!customEventIdsByRegion.TryGetValue(key, out var id))
			{
				id = ++nextCustomEventId;
				customEventIdsByRegion.Add(key, id);

				var eventHandler = enters
					? new RegionEnterHandler(region)
					: (IPlayerUnitEventHandler)new RegionLeaveHandler(region);
				customPlayerUnitEventHandlers[id] = eventHandler;
				filterFuncIdsByEvent[id] = () => GetUnitTypeId(GetTriggerUnit());
				filterFuncHandlesByEvent[id] = () => GetTriggerUnit();
			}

			return id;
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

		internal static void ResolvePendingUpdates()
		{
			foreach (var update in pendingUpdates)
			{
				update.Invoke();
			}
			pendingUpdates.Clear();
		}
	}
}
