using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Lua;
using WCSharp.Shared;
using WCSharp.Sync;
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
			var message = new DateTimeSyncMessage
			{
				PlayerId = GetPlayerId(GetLocalPlayer()),
				Seconds = Os.Time()
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
				WcDateTime.StoreSynchronisedTime(sync.TotalSeconds, this.method);

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
			var averageSeconds = this.timestamps.Values.Sum(x => x.TotalSeconds / count);
			return new WcDateTime(averageSeconds);
		}

		private WcDateTime ResolveBestFit()
		{
			if (this.timestamps.Count % 2 == 0)
			{
				var ordered = this.timestamps.Values
					.OrderBy(x => x.TotalSeconds)
					.ToList();
				var middle = this.timestamps.Count / 2;
				var averageSeconds = (ordered[middle].TotalSeconds / 2) + (ordered[middle + 1].TotalSeconds / 2);
				return new WcDateTime(averageSeconds);
			}
			else
			{
				var ordered = this.timestamps.Values
					.OrderBy(x => x.TotalSeconds)
					.ToList();
				return ordered[this.timestamps.Count / 2];
			}
		}
	}
}
