namespace WCSharp.Events
{
	/// <summary>
	/// Interface for defining periodic actions. If your periodic action has actions that it should perform when ended, use <see cref="IPeriodicDisposableAction"/> instead.
	/// </summary>
	public interface IPeriodicAction
	{
		/// <summary>
		/// Indicates the active state of this IPeriodicAction. Set this to false to disable and remove this instance.
		/// </summary>
		bool Active { get; set; }
		/// <summary>
		/// The action that will be invoked every period by <see cref="PeriodicTrigger{T}"/>.
		/// </summary>
		void Action();
	}
}
