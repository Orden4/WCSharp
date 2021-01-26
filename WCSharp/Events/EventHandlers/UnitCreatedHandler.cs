using WCSharp.Utils.Data;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers
{
	internal class UnitCreatedHandler : InternalPlayerUnitEventHandler
	{
		public override PlayerUnitEvent Event => PlayerUnitEvent.UnitTypeIsCreated;

		protected override void RegisterTriggerEvents(trigger trigger)
		{
			TriggerRegisterEnterRegion(trigger, Rectangle.WorldBounds.Region, null);
		}
	}
}
