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

		private static readonly EventAddRemoveResolver<IEventSet> resolver = new();
		public static int Depth { get; private set; }
		public static bool RequireUpdate { get; set; }

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
			try
			{
				Depth++;
				for (var i = 0; i < this.eventSets.Count; i++)
				{
					this.eventSets[i].Run();
				}
			}
			finally
			{
				Depth--;
				if (RequireUpdate && Depth == 0)
				{
					RequireUpdate = false;
					Console.WriteLine($"Running resolves");
					var s1 = resolver.Resolve();
					var s2 = EventSet.Resolver.Resolve();
					if (s1 || s2)
					{
						Console.WriteLine("Cleaning...");
						PlayerUnitEvents.Clean();
					}
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

			if (Depth == 0)
			{
				this.eventSets.Add(eventSet);
			}
			else
			{
				RequireUpdate = true;
				resolver.Add(this.eventSets, eventSet);
			}
			return eventSet;
		}

		private void RemoveEvent(IEventSet eventSet)
		{
			if (Depth == 0)
			{
				var index = this.eventSets.IndexOf(eventSet);
				if (index == -1)
					throw new Exception("Attempting to remove an event that does not exist.");

				var size = this.eventSets.Count;
				this.eventSets[index] = this.eventSets[size - 1];
				this.eventSets.Nil(size);

				if (size == 1)
				{
					this.active = false;
					DisableTrigger(this.trigger);
				}
			}
			else
			{
				RequireUpdate = true;
				resolver.Add(this.eventSets, eventSet);
			}
		}

		public void Clean()
		{
			var size = this.eventSets.Count;
			for (var i = 0; i < this.eventSets.Count; i++)
			{
				var eventSet = this.eventSets[i];
				if (eventSet.Count == 0)
				{
					this.eventSets[i] = this.eventSets[size - 1];
					this.eventSets.Nil(size);
					size--;
				}
			}

			if (size == 0 && this.active)
			{
				this.active = false;
				DisableTrigger(this.trigger);
			}
		}
	}
}
