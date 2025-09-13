namespace WCSharp.Timers
{
	/// <summary>
	/// Smooth actions are executed separately, allowing for more fine-grained timings.
	/// <para>Use this variant if you need to clean up when the action is ended.</para>
	/// </summary>
	public interface ISmoothDisposableAction : ISmoothAction
	{
		/// <summary>
		/// Automatically called after <see cref="ITimerAction.Active"/> is set to <see langword="false"/>.
		/// </summary>
		void Dispose();
	}
}
