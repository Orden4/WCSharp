namespace WCSharp.Timers
{
	/// <summary>
	/// Delegate for responding to the tick interval of a timer being changed.
	/// </summary>
	public delegate void TickIntervalChangedEventHandler(float oldTickInterval, float newTickInterval);
}
