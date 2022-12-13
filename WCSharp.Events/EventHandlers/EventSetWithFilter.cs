using System;
using System.Collections.Generic;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSetWithFilter : IEventSet
	{
		public Func<int> FilterFunc { get; init; }
		public int Count => this.actionsByFilterId.Count;

		private readonly Dictionary<int, Action> actionsByFilterId;
		private readonly Dictionary<int, EventSet> eventSetsByFilterId;

		public EventSetWithFilter(Func<int> filterFunc)
		{
			FilterFunc = filterFunc ?? throw new ArgumentNullException(nameof(filterFunc));
			this.actionsByFilterId = new Dictionary<int, Action>();
			this.eventSetsByFilterId = new Dictionary<int, EventSet>();
		}

		public void Add(Action action, int filterId)
		{
			if (this.eventSetsByFilterId.TryGetValue(filterId, out var eventSet))
			{
				eventSet.Add(action, filterId);
			}
			else if (this.actionsByFilterId.TryGetValue(filterId, out var existingAction))
			{
				this.actionsByFilterId.Remove(filterId);
				eventSet = new EventSet();
				eventSet.Add(existingAction, filterId);
				eventSet.Add(action, filterId);
				this.actionsByFilterId.Add(filterId, eventSet.Run);
				this.eventSetsByFilterId.Add(filterId, eventSet);
			}
			else
			{
				this.actionsByFilterId.Add(filterId, action);
			}
		}

		public bool Remove(Action action, int filterId)
		{
			if (this.eventSetsByFilterId.TryGetValue(filterId, out var eventSet))
			{
				if (eventSet.Remove(action, filterId))
				{
					if (eventSet.Count == 0)
					{
						this.actionsByFilterId.Remove(filterId);
						this.eventSetsByFilterId.Remove(filterId);
					}

					return true;
				}

				return false;
			}
			else
			{
				return this.actionsByFilterId.Remove(filterId);
			}
		}

		public void Run()
		{
			if (this.actionsByFilterId.TryGetValue(FilterFunc(), out var action))
			{
				action.Invoke();
			}
		}
	}
}
