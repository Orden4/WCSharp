using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Shared;

namespace WCSharp.Events.EventHandlers
{
	internal class EventSetHandleFilter : IEventSet
	{
		public int FilterId { get; }
		public int Count => this.actionsByFilterId.Count;

		private readonly Func<handle> filterFunc;
		private readonly Dictionary<handle, Action> actionsByFilterId;
		private readonly Dictionary<handle, EventSet> eventSetsByFilterId;

		public EventSetHandleFilter(int filterId, Func<handle> filterFunc)
		{
			FilterId = filterId;
			this.filterFunc = filterFunc ?? throw new ArgumentNullException(nameof(filterFunc));
			this.actionsByFilterId = new();
			this.eventSetsByFilterId = new();
		}

		public void Add(Action action, object filterObj)
		{
			if (filterObj is not TypeWrapper<handle> filterWrapper)
				throw new ArgumentException($"Unable to cast event filter to required type {typeof(handle)}", nameof(filterObj));
			var filterValue = filterWrapper.Value;

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
			if (filterObj is not TypeWrapper<handle> filterWrapper)
				throw new ArgumentException($"Unable to cast event filter to required type {typeof(handle)}", nameof(filterObj));
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
			var filterValue = this.filterFunc();
			if (filterValue == null)
				return;

			if (this.actionsByFilterId.TryGetValue(filterValue, out var action))
			{
				action.Invoke();
			}
		}
	}
}
