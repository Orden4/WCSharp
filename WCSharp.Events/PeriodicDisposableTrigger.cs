using System.Collections.Generic;
using System.Linq;
using WCSharp.Shared.Extensions;

namespace WCSharp.Events
{
	/// <summary>
	/// Helpful class that can be used to batch together multiple periodic events of the same type. Will automatically remove inactive triggers, and
	/// subscribe/unsubscribe from <see cref="PeriodicEvents"/> based on whether any triggers are active.
	/// <para>Has additional functionality for disposing of actions when they end.</para>
	/// </summary>
	public class PeriodicDisposableTrigger<T>
		where T : class, IPeriodicDisposableAction
	{
		private readonly List<T> actions;
		private readonly PeriodicEvent timerEvent;
		private bool active;

		/// <summary>
		/// All currently active periodic actions within this periodic trigger.
		/// </summary>
		public IEnumerable<T> Actions => this.actions.Where(x => x.Active);

		/// <summary>
		/// Creates a new periodic trigger which will trigger all supplied actions every given <paramref name="period"/>.
		/// </summary>
		/// <param name="period">How frequently this trigger should fire.</param>
		public PeriodicDisposableTrigger(float period)
		{
			this.actions = new List<T>();
			this.timerEvent = new PeriodicEvent(Periodic, period);
		}

		/// <summary>
		/// Adds the given <paramref name="periodicDisposableTrigger"/> to automatic management.
		/// </summary>
		public void Add(T periodicDisposableTrigger)
		{
			if (!this.active)
			{
				PeriodicEvents.AddPeriodicEvent(this.timerEvent);
				this.active = true;
			}

			periodicDisposableTrigger.Active = true;
			this.actions.Add(periodicDisposableTrigger);
		}

		private bool Periodic()
		{
			var size = this.actions.Count;

			for (var i = 1; i <= size; i++)
			{
				var action = this.actions.DirectGet(i);
				if (action.Active)
				{
					action.Action();
				}

				if (!action.Active)
				{
					action.Dispose();
					this.actions.DirectMove(size, i);
					size--;
					this.actions.RemoveAt(size);
					i--;
				}
			}

			if (size == 0)
			{
				this.active = this.actions.Count > 0;
			}

			return this.active;
		}
	}
}
