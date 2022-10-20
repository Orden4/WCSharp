using System;
using System.Collections.Generic;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSetWithFilter : IEventSet
	{
		public Func<int> FilterFunc { get; init; }
		public int Count => this.actionsByFilterId.Count;

		private readonly Dictionary<int, Action> actionsByFilterId;
		private readonly Dictionary<Action, EventSet> eventSetsByAction;

		public EventSetWithFilter(Func<int> filterFunc)
		{
			FilterFunc = filterFunc ?? throw new ArgumentNullException(nameof(filterFunc));
			this.actionsByFilterId = new Dictionary<int, Action>();
			this.eventSetsByAction = new Dictionary<Action, EventSet>();
		}

		public void Add(Action action, int filterId)
		{
			if (this.actionsByFilterId.TryGetValue(filterId, out var existingAction))
			{
				if (!this.eventSetsByAction.TryGetValue(existingAction, out var eventSet))
				{
					eventSet = new EventSet();
					eventSet.Add(existingAction, filterId);
					this.eventSetsByAction.Add(existingAction, eventSet);
					this.eventSetsByAction.Add(eventSet.Run, eventSet);
					this.actionsByFilterId[filterId] = eventSet.Run;
				}

				eventSet.Add(action, filterId);
				this.eventSetsByAction.Add(action, eventSet);
			}
			else
			{
				this.actionsByFilterId.Add(filterId, action);
			}
		}

		public bool Remove(Action action, int filterId)
		{
			if (this.eventSetsByAction.TryGetValue(action, out var eventSet))
			{
				if (eventSet.Remove(action, filterId))
				{
					if (eventSet.Count == 0)
					{
						this.eventSetsByAction.Remove(eventSet.Run);
						this.actionsByFilterId.Remove(filterId);
					}

					this.eventSetsByAction.Remove(action);
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
