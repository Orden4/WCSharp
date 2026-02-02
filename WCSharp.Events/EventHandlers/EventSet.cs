using System;
using System.Collections.Generic;
using WCSharp.Shared.Extensions;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSet : IEventSet
	{
		public int FilterId => int.MinValue;
		public int Count => this.actions.Count;

		private readonly List<Action> actions;

		public EventSet()
		{
			this.actions = new List<Action>();
		}

		public void Add(Action action, object filterObj)
		{
			this.actions.DirectAdd(action);
		}

		public bool Remove(Action action, object filterObj)
		{
			var index = this.actions.IndexOf(action);
			if (index == -1)
				return false;

			var lastIndex = this.actions.Count - 1;
			if (lastIndex > 0)
			{
				this.actions[index] = this.actions[lastIndex];
			}
			this.actions.RemoveAt(lastIndex);
			return lastIndex == 0;
		}

		public void Run()
		{
			for (var i = 1; i <= this.actions.Count; i++)
			{
				this.actions.DirectGet(i).Invoke();
			}
		}
	}
}
