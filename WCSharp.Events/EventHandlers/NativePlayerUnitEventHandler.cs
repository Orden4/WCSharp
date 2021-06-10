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

			public bool Handle()
			{
				if (ActionsByType.TryGetValue(Func(), out var action))
				{
					action();
				}

				return false;
			}
		}

		public playerunitevent NativeEvent { get; set; }
		public trigger Trigger { get; set; }
		public conditionfunc Condition { get; set; }
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
				if (handler.ActionsByType.Count == 0)
				{
					RemoveHandler(handler);
				}
				else
				{
					RegisterEvent();
				}
			}
		}

		public void Unregister(string @event, int filterId)
		{
			var handler = Handlers.FirstOrDefault(x => x.Identifier == @event);
			if (handler != null && handler.ActionsByType.Remove(filterId) && handler.ActionsByType.Count < 2)
			{
				if (handler.ActionsByType.Count == 0)
				{
					RemoveHandler(handler);
				}
				else
				{
					RegisterEvent();
				}
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
				DestroyCondition(Condition);
			}

#pragma warning disable IDE0007 // Use implicit type
			Func<bool> method = GetEventMethodId() switch
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
				Condition = Condition(method);
				TriggerAddCondition(Trigger, Condition);
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

		private Func<bool> Execute01()
		{
			var action = BaseActions[0];
			return () =>
			{
				action();
				return false;
			};
		}

		private Func<bool> Execute02()
		{
			return () =>
			{
				for (var i = 0; i < BaseActions.Count; i++)
				{
					BaseActions[i]();
				}
				return false;
			};
		}

		private Func<bool> Execute10()
		{
			return Handlers[0].Handle;
		}

		private Func<bool> Execute11()
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
				return false;
			};
		}

		private Func<bool> Execute12()
		{
			var func = Handlers[0].Func;
			var dict = Handlers[0].ActionsByType;
			return () =>
			{
				for (var i = 0; i < BaseActions.Count; i++)
				{
					BaseActions[i]();
				}

				if (dict.TryGetValue(func(), out var action))
				{
					action();
				}

				return false;
			};
		}

		private Func<bool> Execute20()
		{
			return () =>
			{
				for (var i = 0; i < Handlers.Count; i++)
				{
					var handler = Handlers[i];
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}

				return false;
			};
		}

		private Func<bool> Execute21()
		{
			var baseAction = BaseActions[0];
			return () =>
			{
				baseAction();
				for (var i = 0; i < Handlers.Count; i++)
				{
					var handler = Handlers[i];
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}
				return false;
			};
		}

		private Func<bool> Execute22()
		{
			return () =>
			{
				for (var i = 0; i < BaseActions.Count; i++)
				{
					BaseActions[i]();
				}

				for (var i = 0; i < Handlers.Count; i++)
				{
					var handler = Handlers[i];
					if (handler.ActionsByType.TryGetValue(handler.Func(), out var action))
					{
						action();
					}
				}

				return false;
			};
		}
	}
}
