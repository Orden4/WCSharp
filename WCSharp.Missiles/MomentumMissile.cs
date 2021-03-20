using System;
using WCSharp.Events;
using WCSharp.Utils;
using WCSharp.Utils.Data;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Homing-type missile that is based on momentum. Every tick, it will accelerate itself towards the target, up to a maximum speed.
	/// <para>Note that the actual acceleration when adjusting its angle towards the target can be significantly less than specified.</para>
	/// <para>It is recommended to use at least a little bit of <see cref="Missile.ImpactLeeway"/> when using this missile.</para>
	/// </summary>
	public abstract class MomentumMissile : Missile
	{
		public sealed override float CasterZ
		{
			get => this.casterZ + GetZ(CasterX, CasterY);
			set => this.casterZ = value - GetZ(CasterX, CasterY);
		}
		public sealed override float TargetZ
		{
			get => this.targetZ + GetZ(TargetX, TargetY);
			set => this.targetZ = value - GetZ(TargetX, TargetY);
		}
		public sealed override float MissileZ
		{
			get => this.missileZ + GetZ(MissileX, MissileY);
			set => this.missileZ = value - GetZ(MissileX, MissileY);
		}
		public sealed override float Speed
		{
			get => this.speed / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.speed = value * PeriodicEvents.SYSTEM_INTERVAL;
		}

		/// <summary>
		/// The initial angle in degrees. If left at null, will default to the angle towards the target.
		/// </summary>
		public float? InitialAngle { get; set; }
		/// <summary>
		/// The internal acceleration in units per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// </summary>
		private float acceleration;
		/// <summary>
		/// The acceleration in units per second.
		/// <para>This is used to make adjustments to the trajectory.</para>
		/// </summary>
		public float Acceleration
		{
			get => this.acceleration / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.acceleration = value * PeriodicEvents.SYSTEM_INTERVAL;
		}
		/// <summary>
		/// The internal maximum speed in units per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// </summary>
		private float maximumSpeed;
		/// <summary>
		/// The maximum speed in units per second.
		/// </summary>
		public float MaximumSpeed
		{
			get => this.maximumSpeed / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.maximumSpeed = value * PeriodicEvents.SYSTEM_INTERVAL;
		}

		public MomentumMissile(unit caster, unit target) : base(caster, target)
		{
		}

		public MomentumMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		public MomentumMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		public MomentumMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		public sealed override void Launch()
		{
			this.casterZ += CasterLaunchZ;
			this.targetZ += TargetImpactZ;

			MissileX = CasterX;
			MissileY = CasterY;
			this.missileZ = this.casterZ;

			IntervalLeft = Interval;
			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffect(this.effectString, MissileX, MissileY);
				BlzSetSpecialEffectZ(Effect, MissileZ);
				BlzSetSpecialEffectScale(Effect, this.effectScale);
			}

			this.yaw = InitialAngle.HasValue
				? InitialAngle.Value * Util.DEG2RAD
				: Util.AngleBetweenPointsRad(CasterX, CasterY, TargetX, TargetY);
		}

		public sealed override void Action()
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
			var homingYaw = (this.yaw < desiredYaw && desiredYaw < this.yaw + Util.PI) || desiredYaw < this.yaw - Util.PI
				? Math.Min(this.yaw + Util.PI, desiredYaw + (Util.PI / 4))
				: Math.Max(this.yaw - Util.PI, desiredYaw - (Util.PI / 4));

			var deltaX = (this.speed * Cos(this.yaw)) + (this.acceleration * Cos(homingYaw));
			MissileX += deltaX;

			var deltaY = (this.speed * Sin(this.yaw)) + (this.acceleration * Sin(homingYaw));
			MissileY += deltaY;

			var actualYaw = Util.PI + Atan2(-deltaY, -deltaX);
			if ((actualYaw < desiredYaw && desiredYaw < this.yaw) || (this.yaw < desiredYaw && desiredYaw < actualYaw))
			{
				this.yaw = desiredYaw;
				this.speed = Math.Min(this.maximumSpeed, this.speed + this.acceleration);
			}
			else
			{
				this.yaw = actualYaw;
				this.speed = Math.Min(this.maximumSpeed, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
			}

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
