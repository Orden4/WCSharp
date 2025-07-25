﻿using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Shared.Extensions;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// AutoBuffs are buffs which automatically tick for a specified damage/healing amount.
	/// <para>If automatic damage/healing is not required, it is recommended to use <see cref="TickingBuff"/> instead.</para>
	/// </summary>
	public abstract class AutoBuff : Buff
	{
		/// <summary>
		/// The time, in seconds, remaining until the next tick.
		/// </summary>
		public float IntervalLeft { get; set; }
		/// <summary>
		/// The time, in seconds, between each tick.
		/// </summary>
		public float Interval { get; set; }
		/// <summary>
		/// The damage to apply on each tick. Set to negative to heal.
		/// <para>The damage dealer is the caster if the caster is alive, otherwise the target itself.</para>
		/// </summary>
		public float DamagePerInterval { get; set; }
		/// <summary>
		/// The attack type to use when dealing damage via the built-in <see cref="DamagePerInterval"/> property.
		/// </summary>
		public attacktype AttackType { get; set; }
		/// <summary>
		/// The damage type to use when dealing damage via the built-in <see cref="DamagePerInterval"/> property.
		/// </summary>
		public damagetype DamageType { get; set; }

		/// <inheritdoc/>
		public AutoBuff(unit caster, unit target) : base(caster, target)
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
			Duration -= PeriodicEvents.SYSTEM_INTERVAL;

			if (Interval > 0)
			{
				IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
				while (IntervalLeft <= 0)
				{
					IntervalLeft += Interval;
					OnTick();

					if (Active)
					{
						if (DamagePerInterval < 0)
						{
							Target.Heal(-DamagePerInterval);
						}
						else if (DamagePerInterval > 0)
						{
							var damageDealer = UnitAlive(Caster) ? Caster : Target;
							Target.Damage(damageDealer, DamagePerInterval, AttackType, DamageType);
						}
					}
				}
			}

			if (Duration <= 0)
			{
				Active = false;
				OnExpire();
			}
		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// <para>This is called BEFORE the automatic damage/healing occurs.</para>
		/// </summary>
		public virtual void OnTick()
		{

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
