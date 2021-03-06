using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Events
{
	public static class PeriodicEvents
	{
		/// <summary>
		/// The speed at which the system operates.
		/// </summary>
		public const float SYSTEM_INTERVAL = 0.03125f;

		private static readonly List<PeriodicEvent> timerEvents = new List<PeriodicEvent>();

#pragma warning disable IDE0052 // Remove unread private members
		private static readonly object initialiser = Initialise();
#pragma warning restore IDE0052 // Remove unread private members
		private static object Initialise()
		{
			var timer = CreateTimer();
			TimerStart(timer, SYSTEM_INTERVAL, true, Tick);
			return null;
		}

		/// <summary>
		/// Adds the given method to the periodic system. In most cases, you can ignore the return value.
		/// </summary>
		/// <param name="method">The method to execute. Must return a boolean to indicate whether to continue looping or abort the periodic event.</param>
		/// <param name="period">The speed at which this event should fire.</param>
		public static PeriodicEvent AddPeriodicEvent(Func<bool> method, double period = SYSTEM_INTERVAL)
		{
			var timerEvent = new PeriodicEvent(method, period);
			timerEvents.Add(timerEvent);
			return timerEvent;
		}

		/// <summary>
		/// Shorthand in case you already have an existing PeriodicEvent to resume.
		/// </summary>
		public static void AddPeriodicEvent(PeriodicEvent timerEvent)
		{
			timerEvents.Add(timerEvent);
		}

		private static void Tick()
		{
			var size = timerEvents.Count;
			var i = 0;
			while (i < size)
			{
				var timerEvent = timerEvents[i];
				timerEvent.IntervalLeft -= SYSTEM_INTERVAL;
				if (timerEvent.IntervalLeft <= 0)
				{
					timerEvent.IntervalLeft += timerEvent.Interval;
					if (!timerEvent.Method.Invoke())
					{
						size--;
						timerEvents[i] = timerEvents[size];
						timerEvents.RemoveAt(size);
						i--;
					}
				}
				i++;
			}
		}
	}
}
