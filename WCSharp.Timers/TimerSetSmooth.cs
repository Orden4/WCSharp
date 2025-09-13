using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	/// <summary>
	/// Timer that contains a set of <see cref="ISmoothAction"/>.
	/// <para>Each action has its own individual timeout.</para>
	/// </summary>
	public class TimerSetSmooth<T> : TimerSet<T>
		where T : ISmoothAction
	{
		/// <summary>
		/// The time interval of the smoothing timer.
		/// <para>All actions internally tick down in increments specified by this property.</para>
		/// <para>For example, setting timeout to 1 and root timeout to 0.125 will make the timers expire every second,
		/// with each check being 0.125 seconds apart.</para>
		/// </summary>
		public float RootTimeout => this.root.Timeout;

		/// <summary>
		/// Creates a new timer set with the given parameters.
		/// </summary>
		/// <param name="timeout">The time interval between each execution of the timer.</param>
		/// <param name="rootTimeout">
		/// The time interval of the smoothing timer. See <see cref="RootTimeout"/> for more info.
		/// <para>Leaving this at default (<see langword="null"/>) will make it use the highest precision (<see cref="TimerSystem.TickInterval"/>) at all times.</para>
		/// </param>
		public TimerSetSmooth(float timeout, float? rootTimeout = null) : base(timeout, rootTimeout)
		{
		}

		/// <inheritdoc/>
		public override void Action()
		{
			var size = this.actions.Count;
			var tickInterval = this.root.Timeout;
			for (var i = 1; i <= size; i++)
			{
				var action = this.actions.DirectGet(i);
				action.TimerRemaining -= tickInterval;

				while (action.TimerRemaining <= 0 && action.Active)
				{
					action.TimerRemaining += Timeout;
					action.Action();
				}

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
		/// Changes the timeout of each individual action within this smooth set.
		/// <para>The <see cref="ISmoothAction.TimerRemaining"/> is adjusted accordingly to ensure a smooth transition.</para>
		/// </summary>
		public override void SetTimeout(float timeout)
		{
			var offset = Timeout - timeout;
			Timeout = timeout;

			foreach (var action in this.actions)
			{
				action.TimerRemaining += offset;
			}
		}

		/// <summary>
		/// Changes the root timeout of the smoothing timer.
		/// <para>See <see cref="RootTimeout"/> for more info.</para>
		/// <para>Leaving this at default (<see langword="null"/>) will make it use the highest precision (<see cref="TimerSystem.TickInterval"/>) at all times.</para>
		/// </summary>
		public void SetRootTimeout(float? rootTimeout = null)
		{
			if (Active)
			{
				this.root.Remove(this);
			}
			this.root = TimerSystem.GetOrCreate(rootTimeout);
			this.root.Add(this);
		}
	}
}
