using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	/// <summary>
	/// Timer that contains a set of <see cref="ICollectiveAction"/> that will all be executed at once per timeout.
	/// </summary>
	public class TimerSetCollective<T> : TimerSet<T>
		where T : class, ICollectiveAction
	{
		/// <summary>
		/// Creates a new timer set with the given parameters.
		/// </summary>
		/// <param name="timeout">The time interval between each execution of the timer.</param>
		public TimerSetCollective(float timeout) : base(timeout, timeout)
		{
		}

		/// <inheritdoc/>
		public override void Action()
		{
			var size = this.actions.Count;
			for (var i = 1; i <= size; i++)
			{
				var action = this.actions.DirectGet(i);

				if (action.Active)
					action.Action();

				if (!action.Active)
				{
					this.actions.DirectMove(size, i);
					size--;
					this.actions.RemoveAt(size);
					i--;
				}
			}

			if (size == 0)
				Active = this.actions.Count > 0;
		}

		/// <summary>
		/// Changes the timeout to the given value.
		/// <para>Note that the timing of the first tick after changing the timeout is unreliable.</para>
		/// </summary>
		public override void SetTimeout(float timeout)
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
