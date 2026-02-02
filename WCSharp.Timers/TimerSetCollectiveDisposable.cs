using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	/// <summary>
	/// Timer that contains a set of <see cref="ICollectiveDisposableAction"/> that will all be executed at once per timeout.
	/// </summary>
	public class TimerSetCollectiveDisposable<T> : TimerSetCollective<T>
		where T : class, ICollectiveDisposableAction
	{
		/// <inheritdoc/>
		public TimerSetCollectiveDisposable(float timeout) : base(timeout)
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
