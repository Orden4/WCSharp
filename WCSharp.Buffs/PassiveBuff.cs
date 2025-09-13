using WCSharp.Api;
using static WCSharp.Api.Common;

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
			if (this.effectString != null)
			{
				Effect = AddSpecialEffectTarget(this.effectString, Target, this.effectAttachmentPoint);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}

			Disposed = false;
			OnApply();
		}

		/// <inheritdoc/>
		public sealed override void Action()
		{
			Duration -= BuffSystem.TickInterval;
			if (Duration <= 0)
			{
				Active = false;
				OnExpire();
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
