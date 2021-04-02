using System;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Basic missile that will go from unit/location A to unit/location B.
	/// <para>The main feature for this missile is that missiles can arc.</para>
	/// </summary>
	public abstract class BasicMissile : Missile
	{
		/// <inheritdoc/>
		public sealed override float CasterZ
		{
			get => this.followsTerrain ? this.casterZ + GetZ(CasterX, CasterY) : this.casterZ;
			set => this.casterZ = this.followsTerrain ? value - GetZ(CasterX, CasterY) : value;
		}
		/// <inheritdoc/>
		public sealed override float TargetZ
		{
			get => this.followsTerrain ? this.targetZ + GetZ(TargetX, TargetY) : this.targetZ;
			set => this.targetZ = this.followsTerrain ? value - GetZ(TargetX, TargetY) : value;
		}
		/// <inheritdoc/>
		public sealed override float MissileZ
		{
			get => this.followsTerrain ? this.missileZ + GetZ(MissileX, MissileY) : this.missileZ;
			set => this.missileZ = this.followsTerrain ? value - GetZ(MissileX, MissileY) : value;
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

		private bool followsTerrain;
		private float totalDistanceToTarget;

		/// <inheritdoc/>
		public BasicMissile(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public BasicMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public BasicMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		/// <inheritdoc/>
		public BasicMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public sealed override void Launch()
		{
			this.casterZ += CasterLaunchZ;
			this.targetZ += TargetImpactZ;
			this.followsTerrain = this.casterZ < 300 && Arc == 0;
			this.totalDistanceToTarget = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

			if (!this.followsTerrain)
			{
				this.casterZ += GetZ(CasterX, CasterY);
				this.targetZ += GetZ(TargetX, TargetY);
			}

			MissileX = CasterX;
			MissileY = CasterY;
			this.missileZ = this.casterZ;

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
					if (this.followsTerrain)
					{
						this.targetZ += GetZ(TargetX, TargetY);
					}
				}
				else
				{
					Target = null;
				}
			}

			if (Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Impact();
				return;
			}

			var oldZ = MissileZ;

			if (this.followsTerrain)
			{
				this.missileZ += (this.targetZ - this.missileZ) * (this.speed / Util.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY));
			}
			else
			{
				var totalDistance = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

				// If the target has moved by more than 50 units since the last tick (which is a bit over 3 times the maximum speed)
				// We stop the arc as we presume the target has teleported
				if (Math.Abs(this.totalDistanceToTarget - totalDistance) > 50)
				{
					DisableArc();
				}
				else
				{
					this.totalDistanceToTarget = totalDistance;
					var percentageTravelled = Util.DistanceBetweenPoints(CasterX, CasterY, MissileX, MissileY) / totalDistance;
					this.missileZ = this.casterZ
						+ (percentageTravelled * (this.targetZ - this.casterZ))
						+ (totalDistance * Arc * Sin(percentageTravelled * Util.PI));
				}
			}

			this.yaw = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);

			var deltaX = this.speed * Cos(this.yaw);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(this.yaw);
			MissileY += deltaY;

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
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

		/// <summary>
		/// If the arc behaviour has or would disable itself (because of a large change in target position), you can forcefully re-activate it using this method.
		/// <para>Note: Will set the caster position to the missiles current position.</para>
		/// </summary>
		public void ReactivateArc()
		{
			if (this.followsTerrain && Arc != 0)
			{
				this.followsTerrain = false;
				this.targetZ += GetZ(TargetX, TargetY);
				this.missileZ += GetZ(MissileX, MissileY);
				CasterX = MissileX;
				CasterY = MissileY;
				this.casterZ = this.missileZ;
				CasterLaunchZ = 0;
				this.totalDistanceToTarget = Util.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);
			}
		}

		/// <summary>
		/// Disables the arc and causes the missile to fly in a straight line towards the target.
		/// </summary>
		public void DisableArc()
		{
			if (!this.followsTerrain)
			{
				this.followsTerrain = true;
				this.casterZ -= GetZ(CasterX, CasterY);
				this.targetZ -= GetZ(TargetX, TargetY);
				this.missileZ -= GetZ(MissileX, MissileY);
			}
		}
	}
}
