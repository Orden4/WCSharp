using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Sync
{
	internal class SyncTrigger
	{
		public trigger Trigger { get; init; }
		public conditionfunc Condition { get; init; }
	}
}
