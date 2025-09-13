namespace WCSharp.Timers
{
	/// <summary>
	/// Collective actions are executed all at the same time whenever their timer expires.
	/// </summary>
	public interface ICollectiveAction : ITimerAction
	{
	}
}
