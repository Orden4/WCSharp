using System.Collections.Generic;
using WCSharp.Events;
using WCSharp.Utils.Extensions;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	public abstract class Buff : IPeriodicAction
	{
		/// <summary>
		/// Setting this to false will immediately end the buff.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The unit that applied the buff.
		/// </summary>
		public unit Caster { get; set; }
		/// <summary>
		/// The owner of the caster. Automatically set on application only.
		/// </summary>
		public player CastingPlayer { get; set; }
		/// <summary>
		/// The target to which this buff is attached.
		/// </summary>
		public unit Target { get; set; }
		/// <summary>
		/// The owner of the target. Automatically set on application only.
		/// </summary>
		public player TargetPlayer { get; set; }
		/// <summary>
		/// The time, in seconds, remaining until the next tick.
		/// </summary>
		public float IntervalLeft { get; set; }

		/// <summary>
		/// The remaining duration before this buff expires.
		/// </summary>
		public abstract float Duration { get; set; }
		/// <summary>
		/// The time, in seconds, between each tick.
		/// </summary>
		public abstract float Interval { get; set; }
		/// <summary>
		/// The damage to apply on each tick. Set to negative to heal.
		/// </summary>
		public abstract float DamagePerInterval { get; set; }
		/// <summary>
		/// The attack type to apply when dealing damage via the built-in <see cref="DamagePerInterval"/> property.
		/// </summary>
		public abstract attacktype AttackType { get; set; }
		/// <summary>
		/// Whether this buff is beneficial or detrimental to the target.
		/// </summary>
		public abstract bool IsBeneficial { get; set; }

		/// <summary>
		/// The buff types, used primarily for dispelling. E.g. magic, physical, undispellable, etc.
		/// </summary>
		public virtual List<string> BuffTypes { get; set; } = new List<string>();

		/// <summary>
		/// The path of the effect to use. Leave empty for no effect.
		/// </summary>
		protected abstract string EffectString { get; set; }
		/// <summary>
		/// The attachment point for the effect.
		/// </summary>
		protected abstract string EffectAttachmentPoint { get; set; }

		/// <summary>
		/// The actual in-game effect applied on the target.
		/// </summary>
		protected effect effect;
		private readonly int targetHandleId;
		private bool targetAlive;

		/// <summary>
		/// Will set Caster, CastingPlayer, Target and TargetPlayer accordingly.
		/// </summary>
		public Buff(unit caster, unit target)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			Target = target;
			TargetPlayer = GetOwningPlayer(target);
			this.targetHandleId = GetHandleId(target);
		}

		/// <summary>
		/// Do not call this. Used by systems.
		/// </summary>
		public void Action()
		{
			var unitAlive = UnitAlive(Target);
			var unitKilled = false;
			Duration -= PeriodicEvents.SYSTEM_INTERVAL;

			if (Interval > 0)
			{
				IntervalLeft -= PeriodicEvents.SYSTEM_INTERVAL;
				if (IntervalLeft <= 0)
				{
					if (unitAlive)
					{
						if (DamagePerInterval < 0)
						{
							var damageDealer = UnitAlive(Caster) ? Caster : Target;
							Target.Heal(-DamagePerInterval);
						}
						else if (DamagePerInterval > 0)
						{
							var damageDealer = UnitAlive(Caster) ? Caster : Target;
							Target.Damage(damageDealer, DamagePerInterval, AttackType);
							var stillAlive = UnitAlive(Target);
							unitKilled = unitAlive && !stillAlive;
							unitAlive = stillAlive;
						}

						if (unitAlive)
						{
							OnTick();
							var stillAlive = UnitAlive(Target);
							unitKilled = unitKilled || (unitAlive && !stillAlive);
							unitAlive = stillAlive;
						}
					}

					IntervalLeft += Interval;
				}
			}

			if (this.targetAlive && !unitAlive && OnDeath(unitKilled))
			{
				Active = false;
				Dispose();
				return;
			}

			if (Duration <= 0)
			{
				OnExpire();
				Active = false;
				Dispose();
			}

			this.targetAlive = unitAlive;
		}

		internal void Apply()
		{
			if (!string.IsNullOrEmpty(EffectString))
			{
				this.effect = AddSpecialEffectTarget(EffectString, Target, EffectAttachmentPoint);
			}

			Active = true;
			IntervalLeft = Interval;
		}

		/// <summary>
		/// Executes immediately upon application of the buff.
		/// </summary>
		public virtual void OnApply()
		{

		}

		/// <summary>
		/// Executes immediately after <see cref="Target"/> dies. If you do not want the buff to automatically be removed upon death, return false.
		/// </summary>
		/// <param name="killingBlow"></param>
		/// <returns></returns>
		public virtual bool OnDeath(bool killingBlow)
		{
			return true;
		}

		/// <summary>
		/// Executes when an attempt is made to dispel the target. Return false to resist the dispel.
		/// </summary>
		public virtual bool OnDispel(unit dispeller)
		{
			return true;
		}

		/// <summary>
		/// Executes when the buff is removed for any reason whatsoever.
		/// </summary>
		public virtual void OnDispose()
		{

		}

		/// <summary>
		/// Executes when the buff expires by reaching the end of its duration. Does not trigger when the buff is removed via a dispel or target dies.
		/// </summary>
		public virtual void OnExpire()
		{

		}

		/// <summary>
		/// Executes every <see cref="Interval"/>.
		/// </summary>
		public virtual void OnTick()
		{

		}

		/// <summary>
		/// You MUST call this method whenever you manually set <see cref="Active"/> to false.
		/// </summary>
		public void Dispose()
		{
			OnDispose();

			if (this.effect != null)
			{
				DestroyEffect(this.effect);
			}

			if (BuffSystem.buffsByHandleId.TryGetValue(this.targetHandleId, out var buffs))
			{
				if (buffs.Count == 1)
				{
					BuffSystem.buffsByHandleId.Remove(this.targetHandleId);
				}
				else
				{
					buffs.Remove(this);
				}
			}
		}
	}
}
