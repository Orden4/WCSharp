using System;

namespace WCSharp.Sync
{
	internal class SyncHandler
	{
		public Action<object> Action { get; set; }
		public object InternalAction { get; set; }
		public Type Type { get; set; }

		public static SyncHandler Create<T>(Action<T> action)
		{
			return new SyncHandler
			{
				Action = x => action.Invoke((T)x),
				InternalAction = action,
				Type = typeof(T)
			};
		}
	}
}
