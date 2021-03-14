using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Sync;
using WCSharp.Utils;
using static War3Api.Common;

namespace WCSharp.DateTime
{
	internal class DateTimeSystem
	{
		private readonly Action<WcDateTime> action;
		private readonly DateTimeSyncMethod method;

		private readonly Dictionary<int, WcDateTime> timestamps;

		public DateTimeSystem(DateTimeSyncMethod method, Action<WcDateTime> action = null)
		{
			this.method = method;
			this.action = action;

			this.timestamps = new Dictionary<int, WcDateTime>();
		}

		public void Run()
		{
			var seconds = 0;
#if __CSharpLua__
	/*[[
	seconds = os.time()
	]]*/
#endif
			var message = new DateTimeSyncMessage
			{
				PlayerId = GetPlayerId(GetLocalPlayer()),
				Seconds = seconds
			};

			SyncSystem.Subscribe<DateTimeSyncMessage>(HandleDateTimeSyncMessage);
			SyncSystem.Send(message);
		}

		private void HandleDateTimeSyncMessage(DateTimeSyncMessage message)
		{
			this.timestamps[message.PlayerId] = new WcDateTime(message.Seconds);

			if (Util.EnumeratePlayers().All(x => this.timestamps.ContainsKey(GetPlayerId(x))))
			{
				var sync = this.method switch
				{
					DateTimeSyncMethod.Earliest => ResolveEarliest(),
					DateTimeSyncMethod.Latest => ResolveLatest(),
					DateTimeSyncMethod.Average => ResolveAverage(),
					_ => ResolveBestFit(),
				};

				SyncSystem.Unsubscribe<DateTimeSyncMessage>(HandleDateTimeSyncMessage);
				WcDateTime.StoreSynchronisedTime(sync.seconds, this.method);

				this.action?.Invoke(sync);
			}
		}

		private WcDateTime ResolveEarliest()
		{
			return this.timestamps.Values.Min();
		}

		private WcDateTime ResolveLatest()
		{
			return this.timestamps.Values.Max();
		}

		private WcDateTime ResolveAverage()
		{
			var count = this.timestamps.Count;
			var averageSeconds = this.timestamps.Values.Sum(x => x.seconds / count);
			return new WcDateTime(averageSeconds);
		}

		private WcDateTime ResolveBestFit()
		{
			if (this.timestamps.Count % 2 == 0)
			{
				var ordered = this.timestamps.Values
					.OrderBy(x => x.seconds)
					.ToList();
				var middle = this.timestamps.Count / 2;
				var averageSeconds = (ordered[middle].seconds / 2) + (ordered[middle + 1].seconds / 2);
				return new WcDateTime(averageSeconds);
			}
			else
			{
				var ordered = this.timestamps.Values
					.OrderBy(x => x.seconds)
					.ToList();
				return ordered[this.timestamps.Count / 2];
			}
		}
	}
}
