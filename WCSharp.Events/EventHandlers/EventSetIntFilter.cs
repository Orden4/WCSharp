using System;
using System.Collections.Generic;
using WCSharp.Shared;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSetIntFilter : IEventSet
	{
		public int FilterId { get; }
		public int Count => this.actionsByFilterId.Count;

		private readonly Func<int> filterFunc;
		private readonly Dictionary<int, Action> actionsByFilterId;
		private readonly Dictionary<int, EventSet> eventSetsByFilterId;

		public EventSetIntFilter(int filterId, Func<int> filterFunc)
		{
			FilterId = filterId;
			this.filterFunc = filterFunc ?? throw new ArgumentNullException(nameof(filterFunc));
			this.actionsByFilterId = new();
			this.eventSetsByFilterId = new();
		}

		public void Add(Action action, object filterObj)
		{
			if (filterObj is not int filterValue)
				throw new ArgumentException($"Unable to cast event filter to required type {typeof(int)}", nameof(filterObj));

			if (this.eventSetsByFilterId.TryGetValue(filterValue, out var eventSet))
			{
				eventSet.Add(action, filterValue);
			}
			else if (this.actionsByFilterId.TryGetValue(filterValue, out var existingAction))
			{
				this.actionsByFilterId.Remove(filterValue);
				eventSet = new EventSet();
				eventSet.Add(existingAction, filterValue);
				eventSet.Add(action, filterValue);
				this.actionsByFilterId.Add(filterValue, eventSet.Run);
				this.eventSetsByFilterId.Add(filterValue, eventSet);
			}
			else
			{
				this.actionsByFilterId.Add(filterValue, action);
			}
		}

		public bool Remove(Action action, object filterObj)
		{
			if (filterObj is not TypeWrapper<int> filterWrapper)
				throw new ArgumentException($"Unable to cast event filter to required type {typeof(int)}", nameof(filterObj));
			var filterValue = filterWrapper.Value;

			if (this.eventSetsByFilterId.TryGetValue(filterValue, out var eventSet))
			{
				if (eventSet.Remove(action, filterValue))
				{
					if (eventSet.Count == 0)
					{
						this.actionsByFilterId.Remove(filterValue);
						this.eventSetsByFilterId.Remove(filterValue);
					}

					return true;
				}

				return false;
			}
			else
			{
				return this.actionsByFilterId.Remove(filterValue);
			}
		}

		public void Run()
		{
			if (this.actionsByFilterId.TryGetValue(this.filterFunc(), out var action))
			{
				action.Invoke();
			}
		}
	}
}
