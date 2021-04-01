using System.Collections.Generic;
using WCSharp.Events;

namespace WCSharp.Knockbacks
{
	/// <summary>
	/// Keeps track of all active knockbacks.
	/// </summary>
	public static class KnockbackSystem
	{
		private static readonly PeriodicTrigger<Knockback> periodicTrigger = new PeriodicTrigger<Knockback>(PeriodicEvents.SYSTEM_INTERVAL);
		/// <summary>
		/// All active knockbacks.
		/// </summary>
		public static IEnumerable<Knockback> Knockbacks => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given knockback to the system. This will also initialise or alter some values according to the knockbacks' properties.
		/// </summary>
		public static void Add(Knockback knockback)
		{
			periodicTrigger.Add(knockback);
		}
	}
}
