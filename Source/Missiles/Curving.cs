using WCSharp.Events;
using WCSharp.Missiles;
using WCSharp.Shared;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace Source.Missiles
{
	internal class Curving : CurveMissile
	{
		public static void Initialise()
		{
			PlayerUnitEvents.Register(SpellEvent.Effect, LaunchMissile, Constants.ABILITY_CURVING_MISSILE);
		}

		private static void LaunchMissile()
		{
			for (var i = 0; i < 5; i++)
			{
				var missile = new Curving(GetTriggerUnit(), GetSpellTargetX(), GetSpellTargetY())
				{
					Curve = -90 + (45 * i)
				};
				MissileSystem.Add(missile);
			}
		}

		public Curving(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
			CasterZ = 50;
			TargetImpactZ = 50;
			Speed = -400;
			Arc = 1.0f;
			EffectScale = 1.0f;
			Interval = 0.3f;
			EffectString = @"Abilities\Weapons\Dryadmissile\Dryadmissile.mdl";
		}

		public override void OnPeriodic()
		{
			IsArcingOrCurving = false;
			Speed = FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY) * 2;
			Interval = 0;
		}
	}
}
