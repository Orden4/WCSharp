using System;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Advanced missile that allows for arcing/curving motions, i.e. a boomerang motion.
	/// <para>If you do not use the <see cref="Curve"/> property, you should use <see cref="BasicMissile"/> instead for greater performance and
	/// identical features.</para>
	/// </summary>
	public abstract class CurveMissile : Missile
	{
		/// <inheritdoc/>
		public sealed override float CasterZ
		{
			get => this.casterZ + GetZ(CasterX, CasterY);
			set => this.casterZ = value - GetZ(CasterX, CasterY);
		}
		/// <inheritdoc/>
		public sealed override float TargetZ
		{
			get => this.targetZ + GetZ(TargetX, TargetY);
			set => this.targetZ = value - GetZ(TargetX, TargetY);
		}
		/// <inheritdoc/>
		public sealed override float MissileZ
		{
			get => this.missileZ + GetZ(MissileX, MissileY);
			set => this.missileZ = value - GetZ(MissileX, MissileY);
		}
		/// <inheritdoc/>
		public sealed override float Speed
		{
			get => this.speed / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.speed = value * PeriodicEvents.SYSTEM_INTERVAL;
		}

		/// <summary>
		/// The arc of the missile. Closely matches the object editor arc values.
		/// <para>If you want a fixed height arc, set the Arc equal to (arc height/distance to target).</para>
		/// </summary>
		public float Arc { get; set; }
		/// <summary>
		/// The internal curve of the projectile in radians.
		/// </summary>
		private float curve;
		/// <summary>
		/// The curve of the projectile in degrees. This alters the arc, a 90 or -90 degree curve is a boomerang.
		/// </summary>
		public float Curve
		{
			get => this.curve * Util.RAD2DEG;
			set => this.curve = value * Util.DEG2RAD;
		}

		private bool arcActive;
		private float totalDistanceToTarget;

		/// <summary>
		/// The internal X of the missile without the arc/curve.
		/// </summary>
		protected float originX;
		/// <summary>
		/// The internal Y of the missile without the arc/curve.
		/// </summary>
		protected float originY;
		/// <summary>
		/// The internal Z of the missile without the arc/curve.
		/// </summary>
		protected float originZ;

		/// <inheritdoc/>
		public CurveMissile(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public CurveMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public CurveMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		/// <inheritdoc/>
		public CurveMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public sealed override void Launch()
		{
			this.casterZ += CasterLaunchZ;
			this.targetZ += TargetImpactZ;
			this.totalDistanceToTarget = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);
			this.arcActive = Arc != 0;

			MissileX = CasterX;
			MissileY = CasterY;
			this.originX = CasterX;
			this.originY = CasterY;
			this.originZ = this.casterZ;

			IntervalLeft = Interval;

			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffect(this.effectString, MissileX, MissileY);
				BlzSetSpecialEffectZ(Effect, MissileZ);
				if (this.effectScale != 1)
				{
					BlzSetSpecialEffectScale(Effect, this.effectScale);
				}
			}

			this.roll = this.curve;
		}

		/// <inheritdoc/>
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

			if (this.arcActive ? ArcAction() : DirectAction())
			{
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

		private bool DirectAction()
		{
			if (Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Impact();
				return false;
			}

			var oldZ = MissileZ;
			this.missileZ += (this.targetZ - this.missileZ) * (this.speed / Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY));

			this.yaw = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);

			var deltaX = this.speed * Cos(this.yaw);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(this.yaw);
			MissileY += deltaY;

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return false;
			}

			if (Effect != null)
			{
				this.roll += this.spinPeriod;
				var newZ = MissileZ;
				this.pitch = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, this.yaw, this.pitch, this.roll);
			}

			return true;
		}

		private bool ArcAction()
		{
			if (Util.DistanceBetweenPoints(this.originX, this.originY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Impact();
				return false;
			}

			var totalDistance = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

			// If the target has moved by more than 50 units since the last tick (which is a bit over 3 times the maximum speed)
			// We stop the arc as we presume the target has teleported
			if (Math.Abs(this.totalDistanceToTarget - totalDistance) > 50)
			{
				DisableArc();
				DirectAction();
				return true;
			}

			this.totalDistanceToTarget = totalDistance;
			var distanceTravelled = Util.DistanceBetweenPoints(CasterX, CasterY, this.originX, this.originY);

			var originYaw = Util.AngleBetweenPointsRad(this.originX, this.originY, TargetX, TargetY);

			var deltaX = this.speed * Cos(originYaw);
			this.originX += deltaX;

			var deltaY = this.speed * Sin(originYaw);
			this.originY += deltaY;

			var oldOriginZ = this.originZ;
			this.originZ = this.casterZ
					+ (distanceTravelled / totalDistance * (this.targetZ - this.casterZ));
			var pitch = Atan2(oldOriginZ - this.originZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));

			var oldX = MissileX;
			var oldY = MissileY;
			var oldZ = MissileZ;
			var arcHeight = totalDistance * Arc * Sin(distanceTravelled / totalDistance * Util.PI);

			var cosYaw = Cos(originYaw);
			var sinYaw = Sin(originYaw);
			var cosRoll = Cos(this.curve);
			var sinRoll = Sin(this.curve);
			var sinPitchCosRoll = Sin(pitch) * cosRoll;

			MissileX = this.originX + (arcHeight * ((cosYaw * sinPitchCosRoll) + (sinYaw * sinRoll)));
			MissileY = this.originY + (arcHeight * ((sinYaw * sinPitchCosRoll) - (cosYaw * sinRoll)));
			this.missileZ = this.originZ + (arcHeight * Cos(pitch) * cosRoll);

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return false;
			}

			if (Effect != null)
			{
				deltaX = oldX - MissileX;
				deltaY = oldY - MissileY;
				var newZ = MissileZ;

				this.yaw = Util.AngleBetweenPointsRad(oldX, oldY, MissileX, MissileY);
				base.pitch = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				this.roll += this.spinPeriod;
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, this.yaw, base.pitch, this.roll);
			}

			return true;
		}

		/// <summary>
		/// If the arc behaviour has or would disable itself (because of a large change in target position), you can forcefully re-activate it using this method.
		/// <para>Note: Will set the caster position to the missiles current position.</para>
		/// </summary>
		public void ReactivateArc()
		{
			if (!this.arcActive && Arc != 0)
			{
				this.arcActive = true;
				this.originX = MissileX;
				this.originY = MissileY;
				this.originZ = MissileZ;
				CasterX = this.originX;
				CasterY = this.originY;
				this.casterZ = this.originZ;
				CasterLaunchZ = 0;
				this.totalDistanceToTarget = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);
			}
		}

		/// <summary>
		/// Disables the arc and causes the missile to fly in a straight line towards the target.
		/// </summary>
		public void DisableArc()
		{
			this.arcActive = false;
		}
	}
}
