using System;
using WCSharp.Events;
using WCSharp.Utils;
using WCSharp.Utils.Data;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Homing missile with a fixed speed that will attempt to aim itself at the target, restricted by turn speed.
	/// <para>Note: Does not have any behaviour to avoid endlessly circling the enemy.
	/// I recommend using it with a collision radius or such so that exact collisions aren't required.</para>
	/// </summary>
	public abstract class HomingMissile : Missile
	{
		/// <summary>
		/// The internal rate at which the missile can turn in radians per second.
		/// </summary>
		private float turnRate;

		/// <summary>
		/// The rate at which the missile can turn in degrees per second.
		/// </summary>
		public float TurnRate
		{
			get => this.turnRate * Util.RAD2DEG / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.turnRate = value * Util.DEG2RAD * PeriodicEvents.SYSTEM_INTERVAL;
		}
		/// <summary>
		/// The initial angle in degrees. If left at null, will default to the angle towards the target.
		/// </summary>
		public float? InitialAngle { get; set; } = null;

		public HomingMissile(unit caster, unit target) : base(caster, target)
		{
		}

		public HomingMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		public HomingMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		public HomingMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		public override void Launch()
		{
			this.casterZ += CasterLaunchZ;
			this.targetZ += TargetImpactZ;

			MissileX = CasterX;
			MissileY = CasterY;
			this.missileZ = this.casterZ;
			if (InitialAngle.HasValue)
			{
				this.yaw = InitialAngle.Value * Util.DEG2RAD;
				if (this.yaw < 0)
				{
					this.yaw += Util.PI * 2;
				}
				else if (this.yaw > Util.PI * 2)
				{
					this.yaw -= Util.PI * 2;
				}
			}
			else
			{
				this.yaw = Util.AngleBetweenPointsRad(CasterX, CasterY, TargetX, TargetY);
			}

			IntervalLeft = Interval;

			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffect(this.effectString, MissileX, MissileY);
				BlzSetSpecialEffectZ(Effect, MissileZ);
				BlzSetSpecialEffectScale(Effect, this.effectScale);
			}
		}

		public override void Action()
		{
			if (Target != null)
			{
				if (UnitAlive(Target))
				{
					TargetX = GetUnitX(Target);
					TargetY = GetUnitY(Target);
					this.targetZ = GetUnitFlyHeight(Target) + TargetImpactZ;
				}
				else
				{
					Target = null;
				}
			}

			if (Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Active = false;
				Impact();
				if (!Active)
				{
					Dispose();
				}
				return;
			}

			var oldZ = MissileZ;

			var desiredYaw = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);
			if (Math.Abs(desiredYaw - this.yaw) < this.turnRate)
			{
				this.yaw = desiredYaw;
			}
			else if ((this.yaw < desiredYaw && desiredYaw < this.yaw + Util.PI) || desiredYaw < this.yaw - Util.PI)
			{
				this.yaw += this.turnRate;
			}
			else
			{
				this.yaw -= this.turnRate;
			}

			if (this.yaw < 0)
			{
				this.yaw += Util.PI * 2;
			}
			else if (this.yaw > Util.PI * 2)
			{
				this.yaw -= Util.PI * 2;
			}

			var deltaX = this.speed * Cos(this.yaw);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(this.yaw);
			MissileY += deltaY;

			this.missileZ += (this.targetZ - this.missileZ) * (this.speed / Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY));

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				Active = false;
				ExitWorldBounds();
				if (!Active)
				{
					Dispose();
				}
				return;
			}

			if (Effect != null)
			{
				this.roll += this.spinPeriod;
				var newZ = MissileZ;
				this.pitch = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, this.yaw, this.pitch, this.roll);
			}

			if (Interval > 0)
			{
				RunInterval();
			}
			if (this.collisionRadius > 0)
			{
				RunCollisions();
			}
		}
	}
}
