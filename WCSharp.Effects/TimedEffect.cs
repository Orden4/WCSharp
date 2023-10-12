using WCSharp.Events;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Effects
{
	internal class TimedEffect : IPeriodicAction
	{
		public bool Active { get; set; }
		public float Duration { get; set; }
		public effect Effect { get; set; }

		public TimedEffect(effect effect, float duration)
		{
			Effect = effect;
			Duration = duration;
		}

		public void Action()
		{
			Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			if (Duration <= 0)
			{
				DestroyEffect(Effect);
				Active = false;
			}
		}
	}
}
