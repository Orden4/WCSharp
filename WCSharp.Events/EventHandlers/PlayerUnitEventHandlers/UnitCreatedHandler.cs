using WCSharp.Shared.Data;
using WCSharp.Api;
using static WCSharp.Api.Common;

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
