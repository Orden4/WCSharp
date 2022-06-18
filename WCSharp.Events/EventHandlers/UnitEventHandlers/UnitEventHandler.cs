using System;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers.UnitEventHandlers
{
	internal class UnitEventHandler : IEventSet
	{
		public Func<int> FilterFunc { get; init; }
		public int Count => 1;

		private readonly trigger trigger;
		private readonly triggeraction triggerAction;
		private readonly Action action;

		public UnitEventHandler(unitevent @event, unit unit, Action action)
		{
			this.trigger = CreateTrigger();
			this.triggerAction = TriggerAddAction(this.trigger, action);
			this.action = action;
			TriggerRegisterUnitEvent(this.trigger, unit, @event);
		}


		public void Add(Action action, int filterId)
		{
			throw new NotImplementedException();
		}

		public bool Remove(Action action, int filterId)
		{
			throw new NotImplementedException();
		}

		public void Run()
		{
			throw new NotImplementedException();
		}

		public UnitEventHandlerSet Upgrade()
		{
			TriggerRemoveAction(this.trigger, this.triggerAction);
			var eventSet = new UnitEventHandlerSet(this.trigger);
			eventSet.Add(this.action, 0);
			return eventSet;
		}

		public void Dispose()
		{
			DisableTrigger(this.trigger);
			DestroyTrigger(this.trigger);
		}
	}
}
