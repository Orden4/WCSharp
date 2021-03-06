using System;
using System.Collections.Generic;
using System.Linq;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers
{
	internal class NativePlayerUnitEventHandler : IPlayerUnitEventHandler
	{
		private class InternalHandler
		{
			public PlayerUnitEvent PlayerUnitEvent { get; set; }
			public string Identifier { get; set; }
			public Func<int> Func { get; set; }
			public Dictionary<int, Action> ActionsByType { get; set; } = new Dictionary<int, Action>();

			public InternalHandler(PlayerUnitEvent @event)
			{
				PlayerUnitEvent = @event;
				Func = PlayerUnitEvents.GetFunc(@event);
			}

			public InternalHandler(string @event)
			{
				Identifier = @event;
				Func = PlayerUnitEvents.GetFunc(@event);
			}

			public void Handle()
			{
				if (ActionsByType.TryGetValue(Func(), out var action))
				{
					action();
				}
			}
		}

		public playerunitevent NativeEvent { get; set; }
		public trigger Trigger { get; set; }
		public List<Action> BaseActions { get; set; }
		private List<InternalHandler> Handlers { get; set; }

		public NativePlayerUnitEventHandler(playerunitevent @event)
		{
			NativeEvent = @event;
			BaseActions = new List<Action>();
			Handlers = new List<InternalHandler>();
		}

		public void Register(Action action)
		{
			BaseActions.Add(action);
			if (BaseActions.Count <= 2)
			{
				RegisterEvent();
			}
		}

		public void Register(PlayerUnitEvent @event, Action action, int filterId)
		{
			var handler = Handlers.FirstOrDefault(x => x.Identifier == null && x.PlayerUnitEvent == @event);
			if (handler != null)
			{
				handler.ActionsByType.Add(filterId, action);
			}
			else
			{
				handler = new InternalHandler(@event);
				handler.ActionsByType.Add(filterId, action);
				AddHandler(handler);
			}
		}

		public void Register(string @event, Action action, int filterId)
		{
			var handler = Handlers.FirstOrDefault(x => x.Identifier == @event);
			if (handler != null)
			{
				handler.ActionsByType.Add(filterId, action);
			}
			else
			{
				handler = new InternalHandler(@event);
				handler.ActionsByType.Add(filterId, action);
				AddHandler(handler);
			}
		}

		public void Unregister(Action action)
		{
			if (BaseActions.Remove(action) && BaseActions.Count <= 2)
			{
				RegisterEvent();
			}
		}

		public void Unregister(PlayerUnitEvent @event, int filterId)
		{
			var handler = Handlers.FirstOrDefault(x => x.Identifier == null && x.PlayerUnitEvent == @event);
			if (handler != null && handler.ActionsByType.Remove(filterId) && handler.ActionsByType.Count < 2)
			{
				RemoveHandler(handler);
			}
		}

		public void Unregister(string @event, int filterId)
		{
			var handler = Handlers.FirstOrDefault(x => x.Identifier == @event);
			if (handler != null && handler.ActionsByType.Remove(filterId) && handler.ActionsByType.Count < 2)
			{
				RemoveHandler(handler);
			}
		}

		private void AddHandler(InternalHandler handler)
		{
			Handlers.Add(handler);
			if (Handlers.Count <= 2)
			{
				RegisterEvent();
			}
		}

		private void RemoveHandler(InternalHandler handler)
		{
			Handlers.Remove(handler);
			if (Handlers.Count < 2)
			{
				RegisterEvent();
			}
		}

		private void RegisterEvent()
		{
			if (Trigger != null)
			{
				DisableTrigger(Trigger);
				DestroyTrigger(Trigger);
			}

#pragma warning disable IDE0007 // Use implicit type
			Action method = GetEventMethodId() switch
#pragma warning restore IDE0007 // Use implicit type
			{
				1 => Execute01(),
				2 => Execute02(),
				3 => Execute10(),
				4 => Execute11(),
				5 => Execute12(),
				6 => Execute20(),
				7 => Execute21(),
				8 => Execute22(),
				_ => default
			};

			if (method != null)
			{
				Trigger = CreateTrigger();
				TriggerAddAction(Trigger, method);
				var maxPlayers = GetBJMaxPlayers();
				for (var i = 0; i < maxPlayers; i++)
				{
					var player = Player(i);
					if (GetPlayerSlotState(player) == PLAYER_SLOT_STATE_PLAYING)
					{
						TriggerRegisterPlayerUnitEvent(Trigger, player, NativeEvent, null);
					}
				}
			}
		}

		private int GetEventMethodId()
		{
			var methodId = 0;

			if (BaseActions.Count == 1)
			{
				methodId += 1;
			}
			else if (BaseActions.Count > 1)
			{
				methodId += 2;
			}

			if (Handlers.Count == 1)
			{
				methodId += 1 * 3;
			}
			else if (Handlers.Count == 2)
			{
				methodId += 2 * 3;
			}

			return methodId;
		}

		private Action Execute01()
		{
			return BaseActions[0];
		}

		private Action Execute02()
		{
			return () =>
			{
				foreach (var baseAction in BaseActions)
				{
					baseAction();
				}
			};
		}

		private Action Execute10()
		{
			return Handlers[0].Handle;
		}

		private Action Execute11()
		{
			var func = Handlers[0].Func;
			var dict = Handlers[0].ActionsByType;
			var baseAction = BaseActions[0];
			return () =>
			{
				baseAction();
				if (dict.TryGetValue(func(), out var action))
				{
					action();
				}
			};
		}

		private Action Execute12()
		{
			var func = Handlers[0].Func;
			var dict = Handlers[0].ActionsByType;
			return () =>
			{
				foreach (var baseAction in BaseActions)
				{
					baseAction();
				}

				if (dict.TryGetValue(func(), out var action))
				{
					action();
				}
			};
		}

		private Action Execute20()
		{
			return () =>
			{
				foreach (var handler in Handlers)
				{
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}
			};
		}

		private Action Execute21()
		{
			var baseAction = BaseActions[0];
			return () =>
			{
				baseAction();
				foreach (var handler in Handlers)
				{
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}
			};
		}

		private Action Execute22()
		{
			return () =>
			{
				foreach (var baseAction in BaseActions)
				{
					baseAction();
				}

				foreach (var handler in Handlers)
				{
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}
			};
		}
	}
}
