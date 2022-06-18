using static War3Api.Common;

namespace WCSharp.Events.EventHandlers.UnitEventHandlers
{
	internal class UnitEventHandlerSet : EventSet
	{
		private readonly trigger trigger;

		public UnitEventHandlerSet(unitevent @event, unit unit)
		{
			this.trigger = CreateTrigger();
			TriggerAddAction(this.trigger, Run);
			TriggerRegisterUnitEvent(this.trigger, unit, @event);
		}

		public UnitEventHandlerSet(trigger trigger)
		{
			this.trigger = trigger;
		}

		public void Dispose()
		{
			DisableTrigger(this.trigger);
			DestroyTrigger(this.trigger);
		}
	}
}
