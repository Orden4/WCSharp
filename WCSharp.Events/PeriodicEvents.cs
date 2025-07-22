using System;
using System.Collections.Generic;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Events
{
	/// <summary>
	/// Keeps track of all periodic events. The system runs at an interval defined by <see cref="SYSTEM_INTERVAL"/> (0.03125).
	/// </summary>
	public static class PeriodicEvents
	{
		/// <summary>
		/// The speed at which the system operates.
		/// </summary>
		public const float SYSTEM_INTERVAL = 0.03125f;

		private static readonly List<PeriodicEvent> timerEvents = new();
		private static timer timer = Start(Tick);

		private static timer Start(Action action)
		{
			var timer = CreateTimer();
			TimerStart(timer, SYSTEM_INTERVAL, true, action);
			return timer;
		}

		/// <summary>
		/// Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to <see cref="PeriodicEvents"/> will automatically output
		/// information.
		/// <para>It is recommended to use compilation time conditions to not call this on release mode.</para>
		/// </summary>
		public static void EnableDebug()
		{
			DestroyTimer(timer);
			timer = Start(() =>
			{
				try
				{
					Tick();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			});
		}

		/// <summary>
		/// Adds the given method to the periodic system. In most cases, you can ignore the return value.
		/// </summary>
		/// <param name="method">The method to execute. Must return a boolean to indicate whether to continue looping or abort the periodic event.</param>
		/// <param name="period">
		/// The speed at which this event should fire.
		/// <para>Periods below <see cref="SYSTEM_INTERVAL"/> (0.03125) will run multiple times on certain ticks.</para>
		/// </param>
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
				// Purposely written stupidly to avoid decompilation into a for loop
				var timerEvent = timerEvents[i];
				i++;
				timerEvent.IntervalLeft -= SYSTEM_INTERVAL;
				while (timerEvent.IntervalLeft <= 0)
				{
					timerEvent.IntervalLeft += timerEvent.Interval;
					if (!timerEvent.Method.Invoke())
					{
						i--;
						size--;
						timerEvents[i] = timerEvents[size];
						timerEvents.RemoveAt(size);
						break;
					}
				}
			}
		}
	}
}
