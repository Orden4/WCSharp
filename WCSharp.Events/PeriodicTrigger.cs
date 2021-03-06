using System.Collections.Generic;
using System.Linq;

namespace WCSharp.Events
{
	/// <summary>
	/// Helpful class that can be used to batch together multiple periodic events of the same type. Will automatically remove inactive triggers, and
	/// subscribe/unsubscribe from <see cref="PeriodicEvents"/> based on whether any triggers are active.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class PeriodicTrigger<T>
		where T : IPeriodicAction
	{
		private readonly List<T> actions;
		protected PeriodicEvent timerEvent;
		public IEnumerable<T> Actions => this.actions.Where(x => x.Active);

		/// <param name="period">How frequently this trigger should fire.</param>
		public PeriodicTrigger(float period)
		{
			this.actions = new List<T>();
			this.timerEvent = new PeriodicEvent(Periodic, period);
		}

		/// <summary>
		/// Adds the given periodicTrigger to automatic management.
		/// </summary>
		public void Add(T periodicTrigger)
		{
			if (this.actions.Count == 0)
			{
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
				return false;
			}

			var i = 0;
			while (i < size)
			{
				var action = this.actions[i];
				if (action.Active)
				{
					action.Action();
					i++;
				}
				else
				{
					size--;
					this.actions[i] = this.actions[size];
					this.actions.RemoveAt(size);
				}
			}

			return true;
		}
	}
}
