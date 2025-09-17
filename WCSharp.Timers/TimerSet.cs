using System.Collections.Generic;
using System.Linq;

namespace WCSharp.Timers
{
	/// <summary>
	/// The base type for all timer sets.
	/// </summary>
	public abstract class TimerSet<T> : ITimerAction
		where T : ITimerAction
	{
		/// <inheritdoc/>
		public bool Active { get; set; }
		/// <summary>
		/// The time in seconds after which the timer will execute.
		/// </summary>
		public float Timeout { get; protected set; }
		/// <summary>
		/// The currently active actions within this timer set.
		/// </summary>
		public IEnumerable<T> Actions => this.actions.Where(x => x.Active);

		/// <summary>
		/// The actions managed by this timer set.
		/// </summary>
		protected List<T> actions = new();
		internal TimerRoot root;

		/// <summary>
		/// Creates a new timer set.
		/// </summary>
		/// <param name="timeout">The time between each execution of actions.</param>
		/// <param name="rootTimeout">The time between each execution of this timer set.</param>
		protected TimerSet(float timeout, float? rootTimeout = null)
		{
			Timeout = timeout;
			this.root = TimerSystem.GetOrCreate(rootTimeout);
		}

		/// <summary>
		/// Will add the given action to this timer set, tracking it for execution whenever the timeout expires.
		/// </summary>
		public virtual void Add(T action)
		{
			if (this.actions.Count == 0)
				this.root.Add(this);

			this.actions.Add(action);
			action.Active = true;
		}

		/// <inheritdoc/>
		public abstract void Action();
		/// <summary>
		/// Changes the timeout of the timer set.
		/// <para>See the individual implementations on more details, as each type of timer set has its own quirks to doing this.</para>
		/// </summary>
		public abstract void SetTimeout(float timeout);
	}
}
