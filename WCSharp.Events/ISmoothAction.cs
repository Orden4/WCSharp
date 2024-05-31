namespace WCSharp.Events
{
	/// <summary>
	/// Interface for defining smooth actions. If your smooth action has actions that it should perform when ended, use <see cref="ISmoothDisposableAction"/> instead.
	/// </summary>
	public interface ISmoothAction
	{
		/// <summary>
		/// Indicates the active state of this <see cref="ISmoothAction"/>. Set this to false to disable and remove this instance.
		/// </summary>
		bool Active { get; set; }
		/// <summary>
		/// The number of ticks remaining before the next tick.
		/// <para>This is always set to the actions per tick before <see cref="Action"/> is called.</para>
		/// </summary>
		int TicksLeft { get; set; }
		/// <summary>
		/// The action that will be invoked every period by <see cref="SmoothTrigger{T}"/>.
		/// </summary>
		void Action();
	}
}
