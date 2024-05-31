namespace WCSharp.Events
{
	/// <summary>
	/// Interface for defining periodic actions. If your periodic action does not have actions that it should perform when ended, use <see cref="IPeriodicAction"/> instead.
	/// </summary>
	public interface IPeriodicDisposableAction
	{
		/// <summary>
		/// Indicates the active state of this <see cref="IPeriodicDisposableAction"/>. Set this to false to disable and dispose this instance.
		/// </summary>
		bool Active { get; set; }
		/// <summary>
		/// The action that will be invoked every period by <see cref="PeriodicDisposableTrigger{T}"/>.
		/// </summary>
		void Action();
		/// <summary>
		/// Automatically called after <see cref="Active"/> is set to false.
		/// <para>Note: If set to active from outside of the <see cref="Action"/> class, this will only be called on the next interval.</para>
		/// </summary>
		void Dispose();
	}
}
