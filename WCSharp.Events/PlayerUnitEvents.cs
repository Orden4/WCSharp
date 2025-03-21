using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Events.EventHandlers.PlayerUnitEventHandlers;
using static WCSharp.Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Manager for all Warcraft III <see cref="playerunitevent"/>s. Will bundle together and is able to efficiently filter on specific data.
	/// </summary>
	public static partial class PlayerUnitEvents
	{
		private static readonly Dictionary<string, int> customEventIdsByIdentifier = new();
		private static readonly List<IPlayerUnitEventHandler> eventHandlers = new();
		private static readonly Dictionary<playerunitevent, IPlayerUnitEventHandler> playerUnitEventHandlers = new();
		private static readonly Dictionary<int, IPlayerUnitEventHandler> customPlayerUnitEventHandlers = new()
		{
			{ (int)UnitTypeEvent.IsCreated, null }
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

		private static void Register(int @event, Action action)
		{
			var handler = GetOrCreateHandler(@event);
			handler?.Register(action);
		}

		private static void Register(int @event, Action action, int filterId)
		{
			var filterFunc = filterFuncIdsByEvent[@event];
			var handler = GetOrCreateHandler(@event);
			handler?.Register(action, @event, filterFunc, filterId);
		}

		private static void Register(int @event, Action action, handle handle)
		{
			var filterFunc = filterFuncHandlesByEvent[@event];
			var handler = GetOrCreateHandler(@event);
			handler?.Register(action, @event, filterFunc, handle);
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
			var handler = GetOrCreateHandler(@event);
			handler?.Unregister(action);
		}

		private static void Unregister(int @event, Action action, int filterId)
		{
			var filterFunc = filterFuncIdsByEvent[@event];
			var handler = GetOrCreateHandler(@event);
			handler?.Unregister(action, @event, filterFunc, filterId);
		}

		private static void Unregister(int @event, Action action, handle handle)
		{
			var filterFunc = filterFuncHandlesByEvent[@event];
			var handler = GetOrCreateHandler(@event);
			handler?.Unregister(action, @event, filterFunc, handle);
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
					eventHandlers.Add(handler);
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
			filterFuncIdsByEvent.Add(id, filter);
		}

		private static IPlayerUnitEventHandler CreateCustomHandler(int @event)
		{
			var customHandler = @event switch
			{
				(int)UnitTypeEvent.IsCreated => new UnitCreatedHandler(),
				_ => throw new NotImplementedException($"Unexpected custom handler: {@event}"),
			};

			customPlayerUnitEventHandlers[@event] = customHandler;
			eventHandlers.Add(customHandler);
			return customHandler;
		}

		internal static void Clean()
		{
			foreach (var eventHandler in eventHandlers)
			{
				eventHandler.Clean();
			}
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
