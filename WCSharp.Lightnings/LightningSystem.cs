using System.Collections.Generic;
using WCSharp.Shared;
using WCSharp.Timers;

namespace WCSharp.Lightnings
{
	/// <summary>
	/// Tracks and runs all active <see cref="Lightning"/> instances.
	/// </summary>
	public static class LightningSystem
	{
		private static readonly TimerSetCollectiveDisposable<Lightning> timerSet = new(TimerSystem.DEFAULT_TICK_INTERVAL);
		/// <summary>
		/// All active lightnings.
		/// </summary>
		public static IEnumerable<Lightning> Lightnings => timerSet.Actions;

		/// <summary>
		/// Adds the given <paramref name="lightning"/> to the system. This will also initialise or alter some values according to the lightnings' properties.
		/// </summary>
		public static void Add(Lightning lightning)
		{
			lightning.Start();
			timerSet.Add(lightning);
		}

		/// <summary>
		/// The interval between each update of the system.
		/// <para>Use <see cref="SetTickInterval(float)"/> to adjust.</para>
		/// </summary>
		public static float TickInterval { get; private set; } = TimerSystem.DEFAULT_TICK_INTERVAL;
		/// <summary>
		/// Changes the tick interval to the desired value.
		/// <para>Note that the actual change occurs after a 0 second delay.</para>
		/// <para>Calls <see cref="Lightning.BeforeTickIntervalChanged(float, float)"/> to adjust existing lightnings.</para>
		/// </summary>
		public static void SetTickInterval(float tickInterval)
		{
			Delay.Add(() =>
			{
				var old = TickInterval;
				if (old != tickInterval)
				{
					foreach (var actions in timerSet.Actions)
					{
						actions.BeforeTickIntervalChanged(old, tickInterval);
					}
					timerSet.SetTimeout(tickInterval);
					TickInterval = tickInterval;
				}
			});
		}
	}
}
