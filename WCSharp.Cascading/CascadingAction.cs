using System;

namespace WCSharp.Cascading
{
	internal class CascadingAction<T>
	{
		public Action<T> Action { get; }
		public int Priority { get; }

		public CascadingAction(Action<T> action, int priority)
		{
			Action = action;
			Priority = priority;
		}
	}
}
