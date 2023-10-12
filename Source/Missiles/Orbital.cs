using System.Collections.Generic;
using WCSharp.Events;
using WCSharp.Missiles;
using WCSharp.Shared;
using WCSharp.Shared.Extensions;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source.Missiles
{
	internal class Orbital : OrbitalMissile
	{
		private class UnitHit
		{
			public float Age { get; set; }
			public unit Unit { get; }

			public UnitHit(unit unit)
			{
				Unit = unit;
			}
		}

		private readonly List<UnitHit> targetsHitCooldown = new();

		public static void Initialise()
		{
			PlayerUnitEvents.Register(SpellEvent.Effect, LaunchMissile, Constants.ABILITY_ORBITAL_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Orbital(GetTriggerUnit(), GetSpellTargetUnit())
			{
				Range = 600,
				OrbitalPeriod = 4.0f,
				SpinPeriod = 4.0f
			};
			Util.Debug(missile.SpinPeriod);
			Util.Debug(missile.OrbitalPeriod);
			MissileSystem.Add(missile);
		}

		public Orbital(unit caster, unit target) : base(caster, target)
		{
			TargetImpactZ = 50;
			EffectScale = 1.0f;
			EffectString = @"Abilities\Weapons\GlaiveMissile\GlaiveMissile.mdl";
			CollisionRadius = 150;
			Interval = PeriodicEvents.SYSTEM_INTERVAL;
		}

		public override void OnCollision(unit unit)
		{
			if (IsUnitEnemy(unit, CastingPlayer))
			{
				UnitDamageTarget(Caster, Target, 100, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
				this.targetsHitCooldown.Add(new UnitHit(unit));
			}
		}

		public override void OnPeriodic()
		{
			this.targetsHitCooldown.IterateWithRemoval(unitHit =>
			{

				unitHit.Age += PeriodicEvents.SYSTEM_INTERVAL;
				if (unitHit.Age >= 1)
				{
					TargetsHit.Remove(unitHit.Unit);
					return false;
				}

				return true;
			});
		}
	}
}
