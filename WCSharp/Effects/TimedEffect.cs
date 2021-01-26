using WCSharp.Events;
using static War3Api.Common;

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
				Dispose();
				Active = false;
			}
		}

		public void Dispose()
		{
			DestroyEffect(Effect);
		}
	}
}
