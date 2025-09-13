namespace WCSharp.Timers
{
	/// <summary>
	/// Collective actions are executed all at the same time whenever their timer expires.
	/// <para>Use this variant if you need to clean up when the action is ended.</para>
	/// </summary>
	public interface ICollectiveDisposableAction : ICollectiveAction
	{
		/// <summary>
		/// Automatically called after <see cref="ITimerAction.Active"/> is set to <see langword="false"/>.
		/// </summary>
		void Dispose();
	}
}
