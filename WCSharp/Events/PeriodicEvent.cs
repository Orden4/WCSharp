using System;

namespace WCSharp.Events
{
	public class PeriodicEvent
	{
		public Func<bool> Method { get; set; }
		public double Interval { get; set; }
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
