using WCSharp.Api;
using WCSharp.Timers;
using static WCSharp.Api.Common;

namespace WCSharp.Effects
{
	internal class TimedEffect : ICollectiveAction
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
			Duration -= TimerSystem.DEFAULT_TICK_INTERVAL;
			if (Duration <= 0)
			{
				DestroyEffect(Effect);
				Active = false;
			}
		}
	}
}
