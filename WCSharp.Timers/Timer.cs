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
		public float Timeout { get; set; }
		/// <summary>
		/// The time remaining until the next execution.
		/// </summary>
		public float TimerRemaining { get; set; }
		/// <summary>
		/// The time elapsed since the last execution.
		/// </summary>
		public float TimerElapsed => Timeout - TimerRemaining;
		/// <summary>
		/// The action to be executed when the timer expires.
		/// </summary>
		public Action<Timer> TimerAction { get; set; }

		/// <summary>
		/// Creates a new timer.
		/// <para>Use <see cref="TimerSystem.Add(Timer)"/> to activate.</para>
		/// </summary>
		public Timer(Action<Timer> timerAction, float timeout)
		{
			TimerAction = timerAction;
			Timeout = timeout;
		}

		/// <inheritdoc/>
		public void Action()
		{
			TimerRemaining -= TimerSystem.TickInterval;
			while (TimerRemaining <= 0 && Active)
			{
				TimerRemaining += Timeout;
				TimerAction(this);
			}
		}
	}
}
