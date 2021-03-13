using WCSharp.Events;
using WCSharp.Missiles;
using static War3Api.Common;

namespace Source.Missiles
{
	internal class Straight : BasicMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, LaunchMissile, Constants.ABILITY_STRAIGHT_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Straight(GetTriggerUnit(), GetSpellTargetX(), GetSpellTargetY());
			MissileSystem.Add(missile);
		}

		public Straight(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
			CasterZ = 50;
			TargetImpactZ = 50;
			Speed = 100;
			EffectScale = 1.0f;
			EffectString = @"Abilities\Weapons\Dryadmissile\Dryadmissile.mdl";
		}
	}
}
