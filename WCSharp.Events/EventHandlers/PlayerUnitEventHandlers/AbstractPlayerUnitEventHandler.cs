using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Shared;
using static WCSharp.Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal abstract class AbstractPlayerUnitEventHandler : IPlayerUnitEventHandler
	{
		protected readonly List<IEventSet> eventSets;
		protected readonly trigger trigger;
		protected int index;
		protected int size;

		public AbstractPlayerUnitEventHandler()
		{
			this.eventSets = new List<IEventSet>();
			this.trigger = CreateTrigger();

			Func<bool> run = Run;
			if (PlayerUnitEvents.Debug)
			{
				run = () =>
				{
					try
					{
						Run();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine(ex.StackTrace);
					}
					return false;
				};
			}
			var condition = Condition(run);
			TriggerAddCondition(this.trigger, condition);
			DisableTrigger(this.trigger);
		}

		protected bool Run()
		{
			this.size = this.eventSets.Count;

			while (this.index < this.size)
			{
				// Purposely written stupidly to avoid decompilation into a for loop
				var eventSet = this.eventSets[this.index];
				this.index++;
				eventSet.Run();
			}

			this.index = 0;
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
			this.eventSets.Add(eventSet);
			if (this.eventSets.Count == 1)
			{
				EnableTrigger(this.trigger);
			}
			return eventSet;
		}

		private void RemoveEvent(IEventSet eventSet)
		{
			var searchIndex = -1;
			for (var i = 0; i < this.eventSets.Count; i++)
			{
				if (this.eventSets[i] == eventSet)
				{
					searchIndex = i;
					break;
				}
			}

			if (searchIndex == -1)
				throw new Exception("Attempting to remove an event that does not exist.");

			if (searchIndex < this.size)
			{
				if (searchIndex < this.index)
				{
					this.eventSets.RemoveAt(searchIndex);
					this.index--;
					this.size--;
				}
				else
				{
					this.size--;
					var removeIndex = this.eventSets.Count - 1;
					this.eventSets[searchIndex] = this.eventSets[this.size];
					this.eventSets[this.size] = this.eventSets[removeIndex];
					this.eventSets.RemoveAt(removeIndex);
				}
			}
			else
			{
				var removeIndex = this.eventSets.Count - 1;
				this.eventSets[searchIndex] = this.eventSets[removeIndex];
				this.eventSets.RemoveAt(removeIndex);
			}

			if (this.eventSets.Count == 0)
			{
				DisableTrigger(this.trigger);
			}
		}
	}
}
