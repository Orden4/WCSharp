using System.Collections.Generic;
using WCSharp.Shared;
using WCSharp.Timers;

namespace WCSharp.Knockbacks
{
	/// <summary>
	/// Keeps track of all active knockbacks.
	/// </summary>
	public static class KnockbackSystem
	{
		private static readonly TimerSetCollective<Knockback> timerSet = new(TimerSystem.DEFAULT_TICK_INTERVAL);
		/// <summary>
		/// All active knockbacks.
		/// </summary>
		public static IEnumerable<Knockback> Knockbacks => timerSet.Actions;

		/// <summary>
		/// Adds the given knockback to the system. This will also initialise or alter some values according to the knockbacks' properties.
		/// </summary>
		public static void Add(Knockback knockback)
		{
			timerSet.Add(knockback);
		}

		/// <summary>
		/// The interval between each update of the system.
		/// <para>Use <see cref="SetTickInterval(float)"/> to adjust.</para>
		/// </summary>
		public static float TickInterval { get; private set; } = TimerSystem.DEFAULT_TICK_INTERVAL;
		/// <summary>
		/// Changes the tick interval to the desired value.
		/// <para>Note that the actual change occurs after a 0 second delay.</para>
		/// <para>Calls <see cref="Knockback.BeforeTickIntervalChanged(float, float)"/> to adjust existing knockbacks.</para>
		/// </summary>
		public static void SetTickInterval(float tickInterval)
		{
			Delay.Add(() =>
			{
				var old = TickInterval;
				if (old != tickInterval)
				{
					foreach (var action in timerSet.Actions)
					{
						action.BeforeTickIntervalChanged(old, tickInterval);
					}
					timerSet.SetTimeout(tickInterval);
					TickInterval = tickInterval;
				}
			});
		}
	}
}
