using System;
using WCSharp.Events;
using WCSharp.Missiles;
using static War3Api.Common;

namespace Source.Missiles
{
	public class Arcing : BasicMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(SpellEvent.Effect, LaunchMissile, Constants.ABILITY_ARCING_MISSILE);
		}

		private static void LaunchMissile()
		{
			var missile = new Arcing(GetTriggerUnit(), GetSpellTargetX(), GetSpellTargetY());
			MissileSystem.Add(missile);
			missile.DisableArc();
		}

		public Arcing(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
			CasterZ = 0;
			TargetImpactZ = 0;
			CasterLaunchZ = 600;
			Speed = 100;
			Arc = 0.0f;
			EffectScale = 1.0f;
			EffectString = @"Abilities\Spells\Undead\DeathCoil\DeathCoilMissile.mdl";
			Interval = 1.0f;
		}

		public override void OnPeriodic()
		{
			Console.WriteLine($"Before: {MissileZ}");
			if (MissileZ >= 100)
			{
				MissileZ -= 100f;
				Console.WriteLine($"After: {MissileZ}");
			}
			else
			{
				Interval = 0;
				CollisionRadius = 100;
				Speed *= 2;
			}
		}
	}
}
