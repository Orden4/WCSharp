﻿using WCSharp.Events;
using WCSharp.Utils.Extensions;
using static War3Api.Common;

namespace WCSharp.Buffs
{
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

		public AutoBuff(unit caster, unit target) : base(caster, target)
		{
		}

		public sealed override void Apply()
		{
			if (!string.IsNullOrEmpty(this.effectString))
			{
				this.effect = AddSpecialEffectTarget(this.effectString, Target, EffectAttachmentPoint);
			}

			Active = true;
			IntervalLeft = Interval;
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

				if (DamagePerInterval < 0)
				{
					Target.Heal(-DamagePerInterval);
				}
				else if (DamagePerInterval > 0)
				{
					var damageDealer = UnitAlive(Caster) ? Caster : Target;
					Target.Damage(damageDealer, DamagePerInterval, AttackType, DamageType);
				}

				if (UnitAlive(Target))
				{
					OnTick();
				}

				if (!UnitAlive(Target))
				{
					OnDeath(true);
					Dispose();
					return;
				}
			}
			else
			{
				IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
			}


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
		public virtual void OnTick()
		{

		}
	}
}