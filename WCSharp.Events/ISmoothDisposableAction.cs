namespace WCSharp.Events
{
	/// <summary>
	/// Interface for defining smooth actions. If your smooth action does not have actions that it should perform when ended, use <see cref="ISmoothAction"/> instead.
	/// </summary>
	public interface ISmoothDisposableAction
	{
		/// <summary>
		/// Indicates the active state of this <see cref="ISmoothDisposableAction"/>. Set this to false to disable and remove this instance.
		/// </summary>
		bool Active { get; set; }
		/// <summary>
		/// The number of ticks remaining before the next tick.
		/// <para>This is always set to the actions per tick before <see cref="Action"/> is called.</para>
		/// </summary>
		int TicksLeft { get; set; }
		/// <summary>
		/// The action that will be invoked every period by <see cref="SmoothDisposableTrigger{T}"/>.
		/// </summary>
		void Action();
		/// <summary>
		/// Automatically called after <see cref="Active"/> is set to false.
		/// <para>Note: If set to active from outside of the <see cref="Action"/> class, this will only be called on the next interval.</para>
		/// </summary>
		void Dispose();
	}
}
