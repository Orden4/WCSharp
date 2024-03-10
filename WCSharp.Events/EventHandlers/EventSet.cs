using System;
using System.Collections.Generic;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSet : IEventSet
	{
		public int FilterId => int.MinValue;
		public int Count => this.actions.Count;

		protected readonly List<Action> actions;
		protected int index;
		protected int size;

		public EventSet()
		{
			this.actions = new List<Action>();
		}

		public void Add(Action action, object filterObj)
		{
			this.actions.Add(action);
		}

		public bool Remove(Action action, object filterObj)
		{
			var indexToRemove = this.actions.IndexOf(action);
			if (indexToRemove == -1)
				return false;

			if (indexToRemove < this.size)
			{
				if (indexToRemove <= this.index)
				{
					this.actions.RemoveAt(indexToRemove);
					this.index--;
					this.size--;
				}
				else
				{
					var actualSize = this.actions.Count;
					this.actions[indexToRemove] = this.actions[this.size - 1];
					this.actions[this.size - 1] = this.actions[actualSize - 1];
					this.actions.RemoveAt(indexToRemove);
					this.size--;
				}
			}
			else
			{
				var actualSize = this.actions.Count;
				this.actions[indexToRemove] = this.actions[actualSize - 1];
				this.actions.RemoveAt(actualSize - 1);
			}

			return true;
		}

		public void Run()
		{
			this.index = 0;
			this.size = this.actions.Count;

			while (this.index < this.size)
			{
				this.actions[this.index].Invoke();
				this.index++;
			}
		}
	}
}
