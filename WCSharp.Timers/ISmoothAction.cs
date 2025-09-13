namespace WCSharp.Timers
{
	/// <summary>
	/// Smooth actions are executed separately, allowing for more fine-grained timings.
	/// </summary>
	public interface ISmoothAction : ITimerAction
	{
		/// <summary>
		/// The time left until the next tick.
		/// </summary>
		float TimerRemaining { get; set; }
	}
}
