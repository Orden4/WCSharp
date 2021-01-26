using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Effects
{
	public partial class EffectSystem
	{
		private static readonly PeriodicTrigger<TimedEffect> periodicTrigger = new PeriodicTrigger<TimedEffect>(PeriodicEvents.SYSTEM_INTERVAL);

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
