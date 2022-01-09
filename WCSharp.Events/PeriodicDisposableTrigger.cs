using System.Collections.Generic;
using System.Linq;

namespace WCSharp.Events
{
	/// <summary>
	/// Helpful class that can be used to batch together multiple periodic events of the same type. Will automatically remove inactive triggers, and
	/// subscribe/unsubscribe from <see cref="PeriodicEvents"/> based on whether any triggers are active.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class PeriodicDisposableTrigger<T>
		where T : IPeriodicDisposableAction
	{
		private readonly List<T> actions;
		private readonly PeriodicEvent timerEvent;
		private bool active;

		/// <summary>
		/// All currently active periodic actions within this periodic trigger.
		/// </summary>
		public IEnumerable<T> Actions => this.actions.Where(x => x.Active);

		/// <param name="period">How frequently this trigger should fire.</param>
		public PeriodicDisposableTrigger(float period)
		{
			this.actions = new List<T>();
			this.timerEvent = new PeriodicEvent(Periodic, period);
		}

		/// <summary>
		/// Adds the given periodicTrigger to automatic management.
		/// </summary>
		public void Add(T periodicTrigger)
		{
			if (!this.active)
			{
				this.active = true;
				PeriodicEvents.AddPeriodicEvent(this.timerEvent);
			}

			periodicTrigger.Active = true;
			this.actions.Add(periodicTrigger);
		}

		private bool Periodic()
		{
			var size = this.actions.Count;
			if (size == 0)
			{
				this.active = false;
				return false;
			}

			var i = 0;
			while (i < size)
			{
				var action = this.actions[i];
				if (action.Active)
				{
					action.Action();
				}

				if (action.Active)
				{
					i++;
				}
				else
				{
					size--;
					this.actions[i] = this.actions[size];
					this.actions.RemoveAt(size);
					action.Dispose();
				}
			}

			return true;
		}
	}
}
