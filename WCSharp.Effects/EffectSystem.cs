using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Effects
{
	/// <summary>
	/// Simple system for destroying effects after a given duration.
	/// <para>This circumvents issues with certain special effects not showing up if deleted immediately in Reforged.</para>
	/// </summary>
	public partial class EffectSystem
	{
		private static readonly PeriodicTrigger<TimedEffect> periodicTrigger = new(PeriodicEvents.SYSTEM_INTERVAL);

		/// <summary>
		/// Adds an effect for removal after the given duration.
		/// </summary>
		/// <param name="effect"></param>
		/// <param name="duration">In seconds.</param>
		public static void Add(effect effect, float duration = PeriodicEvents.SYSTEM_INTERVAL)
		{
			periodicTrigger.Add(new TimedEffect(effect, duration));
		}
	}
}
