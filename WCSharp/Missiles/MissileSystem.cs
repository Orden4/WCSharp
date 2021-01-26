using System.Collections.Generic;
using WCSharp.Events;

namespace WCSharp.Missiles
{
	public static class MissileSystem
	{
		private static readonly PeriodicTrigger<Missile> periodicTrigger = new PeriodicTrigger<Missile>(PeriodicEvents.SYSTEM_INTERVAL);
		/// <summary>
		/// All active missiles.
		/// </summary>
		public static IEnumerable<Missile> Missiles => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given missile to the system. This will also initialise or alter some values according to the missiles' properties.
		/// </summary>
		public static void Add(Missile missile)
		{
			missile.Launch();
			periodicTrigger.Add(missile);
			missile.Action();
		}
	}
}
