using System.Collections.Generic;
using System.Linq;
using static WCSharp.Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Helpful class that can be used to batch together multiple smooth events of the same type. Will automatically remove inactive triggers, and
	/// subscribe/unsubscribe from <see cref="PeriodicEvents"/> based on whether any triggers are active.
	/// <para>Unlike <see cref="PeriodicTrigger{T}"/>, all actions will not trigger simultaneously, since each action is counted down separately.</para>
	/// </summary>
	public class SmoothTrigger<T>
		where T : ISmoothAction
	{
		private readonly List<T> actions;
		private readonly PeriodicEvent timerEvent;
		private readonly int ticksPerAction;
		private bool active;

		/// <summary>
		/// All currently active smooth actions within this smooth trigger.
		/// </summary>
		public IEnumerable<T> Actions => this.actions.Where(x => x.Active);

		/// <summary>
		/// Creates a new smooth trigger which will individually trigger supplied actions every given interval.
		/// <para><paramref name="tickInterval"/> will be rounded to the nearest multiple of <paramref name="tickRate"/></para>
		/// </summary>
		/// <param name="tickInterval">The amount of time between each <see cref="ISmoothAction.Action"/> call.</param>
		/// <param name="tickRate">Expresses the smoothness of the trigger. Ideally use multiples of <see cref="PeriodicEvents.SYSTEM_INTERVAL"/>.</param>
		public SmoothTrigger(float tickInterval, float tickRate = PeriodicEvents.SYSTEM_INTERVAL)
		{
			this.ticksPerAction = MathRound(tickInterval / tickRate);
			this.actions = new List<T>();
			this.timerEvent = new PeriodicEvent(Periodic, tickRate);
		}

		/// <summary>
		/// Creates a new smooth trigger which will individually trigger supplied actions every given interval.
		/// <para>Interval is equal to <paramref name="ticksPerAction"/>*<paramref name="tickRate"/>.</para>
		/// </summary>
		/// <param name="ticksPerAction">The number of times that <paramref name="tickRate"/> should pass between each <see cref="ISmoothAction.Action"/> call.</param>
		/// <param name="tickRate">Expresses the smoothness of the trigger. Ideally use multiples of <see cref="PeriodicEvents.SYSTEM_INTERVAL"/>.</param>
		public SmoothTrigger(int ticksPerAction, float tickRate = PeriodicEvents.SYSTEM_INTERVAL)
		{
			this.ticksPerAction = ticksPerAction;
			this.actions = new List<T>();
			this.timerEvent = new PeriodicEvent(Periodic, tickRate);
		}

		/// <summary>
		/// Adds the given <paramref name="smoothTrigger"/> to automatic management.
		/// <para>The first action call will occur after the tick interval. If this isn't desired, adjust <see cref="ISmoothAction.TicksLeft"/> after calling this.</para>
		/// </summary>
		public void Add(T smoothTrigger)
		{
			if (!this.active)
			{
				PeriodicEvents.AddPeriodicEvent(this.timerEvent);
				this.active = true;
			}

			smoothTrigger.Active = true;
			smoothTrigger.TicksLeft = this.ticksPerAction;
			this.actions.Add(smoothTrigger);
		}

		private bool Periodic()
		{
			var size = this.actions.Count;
			var i = 0;

			while (i < size)
			{
				var action = this.actions[i];
				// Purposely written stupidly to avoid decompilation into a for loop
				i++;
				action.TicksLeft--;
				if (action.TicksLeft <= 0)
				{
					action.TicksLeft = this.ticksPerAction;
					if (action.Active)
					{
						action.Action();
					}

					if (!action.Active)
					{
						i--;

						size--;
						this.actions[i] = this.actions[size];
						this.actions.RemoveAt(size);
					}
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
