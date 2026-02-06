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

			var count = this.actions.Count;
			if (count == 1)
			{
				this.actions.DirectNil(count);
				return true;
			}
			else
			{
				this.actions.DirectNilShift(index + 1, count);
				return false;
			}
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
