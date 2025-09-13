using WCSharp.Api;
using WCSharp.Timers;

namespace WCSharp.Effects
{
	/// <summary>
	/// Simple system for destroying effects after a given duration.
	/// <para>This circumvents issues with certain special effects not showing up if deleted immediately in Reforged.</para>
	/// </summary>
	public partial class EffectSystem
	{
		private static readonly TimerSetCollective<TimedEffect> timerSet = new(TimerSystem.DEFAULT_TICK_INTERVAL);

		/// <summary>
		/// Adds an effect for removal after the given duration.
		/// </summary>
		/// <param name="effect"></param>
		/// <param name="duration">In seconds.</param>
		public static void Add(effect effect, float duration = TimerSystem.DEFAULT_TICK_INTERVAL)
		{
			timerSet.Add(new TimedEffect(effect, duration));
		}
	}
}
