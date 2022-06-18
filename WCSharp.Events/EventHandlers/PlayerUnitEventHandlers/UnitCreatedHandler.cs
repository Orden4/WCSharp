using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal class UnitCreatedHandler : AbstractPlayerUnitEventHandler
	{
		public UnitCreatedHandler()
		{
			var condition = Condition(Run);
			TriggerAddCondition(this.trigger, condition);
			DisableTrigger(this.trigger);

			TriggerRegisterEnterRegion(this.trigger, Rectangle.WorldBounds.Region, null);
		}
	}
}
