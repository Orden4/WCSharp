using WCSharp.Events;
using WCSharp.Missiles;
using static War3Api.Common;

namespace Source.Missiles
{
	internal class Momentum : MomentumMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, LaunchMissile, Constants.ABILITY_MOMENTUM_MISSILE);
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
		}
	}
}
