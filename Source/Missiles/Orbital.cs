using WCSharp.Events;
using WCSharp.Missiles;
using WCSharp.Utils;
using static War3Api.Common;

namespace Source.Missiles
{
	internal class Orbital : OrbitalMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, LaunchMissile, Constants.ABILITY_ORBITAL_MISSILE);
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
		}
	}
}
