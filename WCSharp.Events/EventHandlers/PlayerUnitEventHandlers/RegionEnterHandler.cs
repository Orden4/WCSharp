using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal class RegionEnterHandler : AbstractPlayerUnitEventHandler
	{
		public RegionEnterHandler(region region)
		{
			TriggerRegisterEnterRegion(this.trigger, region, null);
		}
	}
}
