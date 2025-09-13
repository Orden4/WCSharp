namespace WCSharp.Timers
{
	/// <summary>
	/// Interface for any kind of timer-based action.
	/// </summary>
	public interface ITimerAction
	{
		/// <summary>
		/// Used to indicate whether the timer should remain active or not.
		/// <para>Set to <see langword="true"/> automatically.</para>
		/// <para>Set to <see langword="false"/> to disable the loop.</para>
		/// </summary>
		bool Active { get; set; }

		/// <summary>
		/// Automatically called by the timer system whenever the actions timer expires.
		/// </summary>
		void Action();
	}
}
