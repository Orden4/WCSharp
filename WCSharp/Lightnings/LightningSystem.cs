using System.Collections.Generic;
using WCSharp.Events;

namespace WCSharp.Lightnings
{
	public static class LightningSystem
	{
		private static readonly PeriodicTrigger<Lightning> periodicTrigger = new PeriodicTrigger<Lightning>(PeriodicEvents.SYSTEM_INTERVAL);
		/// <summary>
		/// All active lightnings.
		/// </summary>
		public static IEnumerable<Lightning> Missiles => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given lightning to the system. This will also initialise or alter some values according to the lightnings' properties.
		/// </summary>
		public static void Add(Lightning lightning)
		{
			lightning.Start();
			periodicTrigger.Add(lightning);
		}
	}
}
