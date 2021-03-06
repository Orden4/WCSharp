using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers
{
	internal abstract class InternalPlayerUnitEventHandler : IPlayerUnitEventHandler
	{
		public abstract PlayerUnitEvent Event { get; }
		public trigger Trigger { get; set; }
		public List<Action> Actions { get; set; }
		public Dictionary<int, Action> ActionsByFilter { get; set; }

		public InternalPlayerUnitEventHandler()
		{
			Actions = new List<Action>();
			ActionsByFilter = new Dictionary<int, Action>();
		}

		public void Register(Action action)
		{
			Actions.Add(action);
			if (Actions.Count == 1)
			{
				RegisterEvent();
			}
		}

		public void Unregister(Action action)
		{
			if (Actions.Remove(action) && Actions.Count == 0)
			{
				RegisterEvent();
			}
		}

		public void Register(PlayerUnitEvent @event, Action action, int filter)
		{
			ActionsByFilter[filter] = action;
			if (ActionsByFilter.Count == 1)
			{
				RegisterEvent();
			}
		}

		public void Unregister(PlayerUnitEvent @event, int filter)
		{
			if (ActionsByFilter.Remove(filter) && Actions.Count == 0)
			{
				RegisterEvent();
			}
		}

		protected void RegisterEvent()
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
				1 => Execute1,
				2 => Execute2,
				3 => Execute12,
				_ => default
			};

			if (method != null)
			{
				Trigger = CreateTrigger();
				TriggerAddAction(Trigger, method);
				RegisterTriggerEvents(Trigger);
			}
		}

		protected abstract void RegisterTriggerEvents(trigger trigger);

		protected int GetEventMethodId()
		{
			var methodId = 0;

			if (Actions.Count > 0)
			{
				methodId += 1;
			}
			if (ActionsByFilter.Count > 0)
			{
				methodId += 2;
			}

			return methodId;
		}

		protected void Execute1()
		{
			foreach (var action in Actions)
			{
				action();
			}
		}

		protected void Execute12()
		{
			foreach (var action in Actions)
			{
				action();
			}

			if (ActionsByFilter.TryGetValue(GetUnitTypeId(GetTriggerUnit()), out var actionByType))
			{
				actionByType();
			}
		}

		protected void Execute2()
		{
			if (ActionsByFilter.TryGetValue(GetUnitTypeId(GetTriggerUnit()), out var actionByType))
			{
				actionByType();
			}
		}

		void IPlayerUnitEventHandler.Register(string @event, Action action, int filter)
		{
			throw new NotImplementedException();
		}

		void IPlayerUnitEventHandler.Unregister(string @event, int filter)
		{
			throw new NotImplementedException();
		}
	}
}
