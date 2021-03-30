using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// A very basic buff implementation that simply applies and removes itself according to its duration.
	/// </summary>
	public abstract class PassiveBuff : Buff
	{
		public PassiveBuff(unit caster, unit target) : base(caster, target)
		{
		}

		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				this.effect = AddSpecialEffectTarget(this.effectString, Target, EffectAttachmentPoint);
			}
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

			if (Duration <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				OnExpire();
				Dispose();
			}
			else
			{
				Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			}
		}

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
