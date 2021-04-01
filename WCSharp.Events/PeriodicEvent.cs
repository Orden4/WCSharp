using System;

namespace WCSharp.Events
{
	/// <summary>
	/// Represents a single periodic event that will invoke <see cref="Method"/> every <see cref="Interval"/>.
	/// </summary>
	public class PeriodicEvent
	{
		/// <summary>
		/// The function that will be invoked every <see cref="Interval"/>. Return true for the event to be repeated.
		/// </summary>
		public Func<bool> Method { get; set; }
		/// <summary>
		/// Specifies the time in seconds of a single loop of this periodic event..
		/// </summary>
		public double Interval { get; set; }
		/// <summary>
		/// Indicates the time remaining until it will invoke <see cref="Method"/>.
		/// </summary>
		public double IntervalLeft { get; set; }

		/// <summary>
		/// Creates a new periodic event that will call the given method every interval.
		/// Must be added to <see cref="PeriodicEvents"/> in order to be active.
		/// </summary>
		public PeriodicEvent(Func<bool> method, double interval)
		{
			Method = method;
			Interval = interval;
			IntervalLeft = interval;
		}
	}
}
