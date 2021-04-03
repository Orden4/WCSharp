using WCSharp.Events;
using WCSharp.Missiles;
using static War3Api.Common;

namespace Source.Missiles
{
	internal class Homing : HomingMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, LaunchMissile, Constants.ABILITY_HOMING_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Homing(GetTriggerUnit(), GetSpellTargetUnit());
			MissileSystem.Add(missile);
		}

		public Homing(unit caster, unit target) : base(caster, target)
		{
			CasterZ = 50;
			TargetImpactZ = 50;
			Speed = 800;
			TurnRate = 90;
			Roll = 90;
			EffectScale = 1.0f;
			EffectString = @"Abilities\Weapons\GlaiveMissile\GlaiveMissile.mdl";
			CollisionRadius = 300;
		}

		public override void OnCollision(unit unit)
		{
			if (IsUnitEnemy(unit, CastingPlayer))
			{
				UnitDamageTarget(Caster, Target, 100, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
				Active = false;
			}
		}
	}
}
