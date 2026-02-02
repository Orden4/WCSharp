using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Shared;
using WCSharp.Shared.Extensions;
using static WCSharp.Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal abstract class AbstractPlayerUnitEventHandler : IPlayerUnitEventHandler
	{
		protected readonly List<IEventSet> eventSets;
		protected readonly trigger trigger;
		protected bool active;

		public static int Depth { get; private set; }
		public static bool RequiresUpdate { get; set; }

		public AbstractPlayerUnitEventHandler()
		{
			this.eventSets = new List<IEventSet>();
			this.trigger = CreateTrigger();

			var condition = Condition(Run);
			TriggerAddCondition(this.trigger, condition);
			DisableTrigger(this.trigger);
		}

		protected bool Run()
		{
			try
			{
				Depth++;
				for (var i = 1; i <= this.eventSets.Count; i++)
				{
					this.eventSets.DirectGet(i).Run();
				}
			}
			catch (Exception ex)
			{
				if (PlayerUnitEvents.Debug)
				{
					Console.WriteLine(ex);
				}
			}
			finally
			{
				Depth--;
				if (Depth == 0 && RequiresUpdate)
				{
					PlayerUnitEvents.ResolvePendingUpdates();
				}
			}

			return false;
		}

		public void Register(Action action)
		{
			if (!TryGetEventSet(int.MinValue, out var eventSet))
			{
				eventSet = AddEventSet(new EventSet());
			}

			eventSet.Add(action, null);
		}

		public void Register(Action action, int filterId, Func<int> filterFunc, int filterValue)
		{
			if (!TryGetEventSet(filterId, out var eventSet))
			{
				eventSet = AddEventSet(new EventSetIntFilter(filterId, filterFunc));
			}

			eventSet.Add(action, filterValue);
		}

		public void Register(Action action, int filterId, Func<handle> filterFunc, handle filterValue)
		{
			if (!TryGetEventSet(filterId, out var eventSet))
			{
				eventSet = AddEventSet(new EventSetHandleFilter(filterId, filterFunc));
			}

			eventSet.Add(action, new TypeWrapper<handle>(filterValue));
		}

		public void Unregister(Action action)
		{
			if (!TryGetEventSet(int.MinValue, out var eventSet))
				return;

			if (eventSet.Remove(action, null) && eventSet.Count == 0)
				RemoveEvent(eventSet);
		}

		public void Unregister(Action action, int filterId, Func<int> filterFunc, int filterValue)
		{
			if (!TryGetEventSet(filterId, out var eventSet))
				return;

			if (eventSet.Remove(action, filterValue) && eventSet.Count == 0)
				RemoveEvent(eventSet);
		}

		public void Unregister(Action action, int filterId, Func<handle> filterFunc, handle filterValue)
		{
			if (!TryGetEventSet(filterId, out var eventSet))
				return;

			if (eventSet.Remove(action, new TypeWrapper<handle>(filterValue)) && eventSet.Count == 0)
				RemoveEvent(eventSet);
		}

		private bool TryGetEventSet(int filterId, out IEventSet eventSet)
		{
			for (var i = 0; i < this.eventSets.Count; i++)
			{
				if (this.eventSets[i].FilterId == filterId)
				{
					eventSet = this.eventSets[i];
					return true;
				}
			}

			eventSet = null;
			return false;
		}

		private IEventSet AddEventSet(IEventSet eventSet)
		{
			if (!this.active)
			{
				this.active = true;
				EnableTrigger(this.trigger);
			}

			this.eventSets.DirectAdd(eventSet);
			return eventSet;
		}

		private void RemoveEvent(IEventSet eventSet)
		{
			var index = this.eventSets.IndexOf(eventSet);
			if (index == -1)
				throw new Exception("Attempting to remove an event that does not exist.");

			var lastIndex = this.eventSets.Count - 1;
			if (lastIndex == 0)
			{
				this.active = false;
				DisableTrigger(this.trigger);
			}
			else
			{
				this.eventSets[index] = this.eventSets[lastIndex];
			}

			this.eventSets.RemoveAt(lastIndex);
		}
	}
}
