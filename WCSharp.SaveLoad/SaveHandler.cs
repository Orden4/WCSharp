using System;

namespace WCSharp.SaveLoad
{
	internal class SaveHandler
	{
		public Action<object> Action { get; set; }
		public Type Type { get; set; }

		public static SaveHandler Create<T>(Action<T> action)
		{
			return new SaveHandler
			{
				Action = x => action?.Invoke((T)x),
				Type = typeof(T)
			};
		}
	}
}
