using WCSharp.Events;
using WCSharp.Missiles;
using static War3Api.Common;

namespace Source.Missiles
{
	public class Arcing : BasicMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, LaunchMissile, Constants.ABILITY_ARCING_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Arcing(GetTriggerUnit(), GetSpellTargetX(), GetSpellTargetY());
			MissileSystem.Add(missile);
		}

		public Arcing(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
			CasterZ = 0;
			TargetImpactZ = 50;
			Speed = 100;
			Arc = 0.3f;
			EffectScale = 3.0f;
			EffectString = @"Abilities\Spells\Undead\DeathCoil\DeathCoilMissile.mdl";
		}
	}
}
