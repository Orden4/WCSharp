using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	/// <summary>
	/// Timer that contains a set of <see cref="ISmoothDisposableAction"/>.
	/// <para>Each action has its own individual timeout.</para>
	/// </summary>
	public class TimerSetSmoothDisposable<T> : TimerSetSmooth<T>
		where T : class, ISmoothDisposableAction
	{
		/// <inheritdoc/>
		public TimerSetSmoothDisposable(float timeout, float? rootTimeout = null) : base(timeout, rootTimeout)
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
					action.Dispose();
					this.actions.DirectMove(size, i);
					size--;
					this.actions.RemoveAt(size);
					i--;
				}
			}

			if (size == 0)
				Active = this.actions.Count > 0;
		}
	}
}
