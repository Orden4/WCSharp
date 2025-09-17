using System;

namespace WCSharp.Timers
{
	/// <summary>
	/// A timer dedicated to a single action.
	/// </summary>
	public class Timer : ITimerAction
	{
		/// <inheritdoc/>
		public bool Active { get; set; }
		/// <summary>
		/// The time interval per execution.
		/// </summary>
		public float Timeout { get; private set; }
		/// <summary>
		/// The action to be executed when the timer expires.
		/// </summary>
		public Action<Timer> TimerAction { get; set; }

		private TimerRoot root;

		/// <summary>
		/// Creates a new timer.
		/// <para>Use <see cref="TimerSystem.Add(Timer)"/> to activate.</para>
		/// </summary>
		public Timer(Action<Timer> timerAction, float timeout)
		{
			TimerAction = timerAction;
			Timeout = timeout;
			this.root = TimerSystem.GetOrCreate(timeout);
		}

		/// <inheritdoc/>
		public void Action()
		{
			if (Active)
				TimerAction(this);
		}

		/// <summary>
		/// Changes the timeout to the given value.
		/// <para>Note that the timing of the first tick after changing the timeout is unreliable.</para>
		/// </summary>
		public void SetTimeout(float timeout)
		{
			Timeout = timeout;
			if (Active)
			{
				this.root.Remove(this);
			}
			this.root = TimerSystem.GetOrCreate(timeout);
			this.root.Add(this);
		}
	}
}
