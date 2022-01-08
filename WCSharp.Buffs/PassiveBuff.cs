using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// A very basic buff implementation that simply applies and removes itself according to its duration.
	/// </summary>
	public abstract class PassiveBuff : Buff
	{
		/// <inheritdoc/>
		public PassiveBuff(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}
			OnApply();
		}

		/// <inheritdoc/>
		public sealed override void Action()
		{
			if (Duration <= PeriodicEvents.SYSTEM_INTERVAL)
			{
				OnExpire();
				Active = false;
			}
			else
			{
				Duration -= PeriodicEvents.SYSTEM_INTERVAL;
			}
		}

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
