using WCSharp.Events;
using static War3Api.Common;

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

		public TickingBuff(unit caster, unit target) : base(caster, target)
		{
		}

		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				this.effect = AddSpecialEffectTarget(this.effectString, Target, EffectAttachmentPoint);
			}

			IntervalLeft = Interval;
			OnApply();
		}

		public sealed override void Action()
		{
			if (!UnitAlive(Target))
			{
				OnDeath(false);
				Dispose();
				return;
			}
			else if (IntervalLeft <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				IntervalLeft += Interval;
				OnTick();
				if (!UnitAlive(Target))
				{
					OnDeath(true);
					Dispose();
					return;
				}
			}

			IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;

			if (Duration <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				OnExpire();
				Dispose();
				return;
			}
			else
			{
				Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			}
		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public abstract void OnTick();

		public sealed override void Dispose()
		{
			OnDispose();
			Active = false;

			if (this.effect != null)
			{
				DestroyEffect(this.effect);
			}

			BuffSystem.Remove(this);
		}
	}
}
