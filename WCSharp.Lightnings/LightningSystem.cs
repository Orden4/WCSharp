using System.Collections.Generic;
using WCSharp.Events;

namespace WCSharp.Lightnings
{
	/// <summary>
	/// Tracks and runs all active <see cref="Lightning"/> instances.
	/// </summary>
	public static class LightningSystem
	{
		private static readonly PeriodicDisposableTrigger<Lightning> periodicTrigger = new(PeriodicEvents.SYSTEM_INTERVAL);
		/// <summary>
		/// All active lightnings.
		/// </summary>
		public static IEnumerable<Lightning> Missiles => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given <paramref name="lightning"/> to the system. This will also initialise or alter some values according to the lightnings' properties.
		/// </summary>
		public static void Add(Lightning lightning)
		{
			lightning.Start();
			periodicTrigger.Add(lightning);
		}
	}
}
