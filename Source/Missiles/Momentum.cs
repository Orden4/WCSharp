using WCSharp.Events;
using WCSharp.Missiles;
using WCSharp.Shared.Extensions;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source.Missiles
{
	internal class Momentum : MomentumMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(SpellEvent.Effect, LaunchMissile, Constants.ABILITY_MOMENTUM_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Momentum(GetTriggerUnit(), GetSpellTargetUnit());
			MissileSystem.Add(missile);
		}

		public Momentum(unit caster, unit target) : base(caster, target)
		{
			CasterZ = 50;
			TargetImpactZ = 50;
			Speed = 100;
			MaximumSpeed = 1000;
			Acceleration = 25;
			InitialAngle = GetRandomReal(0, 360);
			EffectScale = 1.0f;
			Roll = 90;
			EffectString = @"Abilities\Weapons\GlaiveMissile\GlaiveMissile.mdl";
			Interval = 5.0f;
		}

		public override void OnImpact()
		{
			Explode();
		}

		public override void OnPeriodic()
		{
			Explode();
		}

		private void Explode()
		{
			var group = CreateGroup();
			GroupEnumUnitsInRange(group, MissileX, MissileY, 300, null);
			foreach (var unit in group.ToList())
			{
				UnitDamageTarget(Caster, unit, 100, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
			}
			DestroyGroup(group);
			Active = false;
		}
	}
}
