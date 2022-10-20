using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal class UnitCreatedHandler : AbstractPlayerUnitEventHandler
	{
		public UnitCreatedHandler()
		{
			TriggerRegisterEnterRegion(this.trigger, Rectangle.WorldBounds.Region, null);
		}
	}
}
