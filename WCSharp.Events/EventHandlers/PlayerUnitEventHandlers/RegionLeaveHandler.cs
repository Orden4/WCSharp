using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal class RegionLeaveHandler : AbstractPlayerUnitEventHandler
	{
		public RegionLeaveHandler(region region)
		{
			TriggerRegisterLeaveRegion(this.trigger, region, null);
		}
	}
}
