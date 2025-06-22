using WCSharp.Api;
using WCSharp.Events;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// A simple buff that only adds a ticking behaviour, allowing an action to be performed every interval.
	/// If you simply want to damage/heal every tick, you can use <see cref="AutoBuff"/> instead to simplify the process.
	/// </summary>
	public abstract class TickingBuff : Buff
	{
		/// <summary>
		/// The time, in seconds, remaining until the next tick.
		/// </summary>
		public float IntervalLeft { get; set; }
		/// <summary>
		/// The time, in seconds, between each tick.
		/// </summary>
		public float Interval { get; set; }

		/// <inheritdoc/>
		public TickingBuff(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public sealed override void Apply()
		{
			if (this.effectString != null)
			{
				Effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}

			Disposed = false;
			IntervalLeft = Interval;
			OnApply();
		}

		/// <inheritdoc/>
		public sealed override void Action()
		{
			if (Interval > 0)
			{
				IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
				while (IntervalLeft <= 0)
				{
					IntervalLeft += Interval;
					OnTick();
				}
			}

			Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			if (Duration <= 0)
			{
				Active = false;
				OnExpire();
			}
		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public abstract void OnTick();

		/// <inheritdoc/>
		public sealed override void Dispose()
		{
			OnDispose();

			if (Effect != null)
			{
				DestroyEffect(Effect);
			}

			BuffSystem.Remove(this);
		}
	}
}
