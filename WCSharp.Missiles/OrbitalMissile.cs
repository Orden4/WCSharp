using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Missile that will orbit the specified target.
	/// <para>Note: this missile calls <see cref="Missile.OnImpact"/> when the target dies.</para>
	/// </summary>
	public abstract class OrbitalMissile : Missile
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
		/// <summary>
		/// The speed of the missile. Defined in units per second.
		/// <para>Use negative values to go clockwise.</para>
		/// <para>This can be used instead of <see cref="OrbitalPeriod"/>, and will ensure a consistent units per second speed through <see cref="Speed"/> adjustments.</para>
		/// </summary>
		/// this.speed is only used to store the desired speed for if the range is adjusted later on.
		/// Actual speed is always in radians per tick, determined by this.orbitalVelocity.
		public sealed override float Speed
		{
			get => 2 / PeriodicEvents.SYSTEM_INTERVAL * this.orbitalVelocity * this.range;
			set
			{
				this.speed = value;
				this.orbitalVelocity = PeriodicEvents.SYSTEM_INTERVAL * 2 * value / this.range;
			}
		}
		private float range;
		/// <summary>
		/// The distance at which the <see cref="OrbitalMissile"/> orbits from the origin.
		/// <para>The speed of the missile after a range adjustment is determined by whether it was set via <see cref="Speed"/> or <see cref="OrbitalPeriod"/>.</para>
		/// </summary>
		public float Range
		{
			get => this.range;
			set
			{
				if (this.speed != 0 && value != 0)
				{
					this.orbitalVelocity = PeriodicEvents.SYSTEM_INTERVAL * 2 * this.speed / value;
				}

				this.range = value;
			}
		}
		/// <summary>
		/// The amount of time it takes to make one rotation in seconds.
		/// <para>Use negative values to go clockwise.</para>
		/// <para>This can be used instead of <see cref="Speed"/>, and will ensure a consistent orbital period through <see cref="Range"/> adjustments.</para>
		/// </summary>
		public float OrbitalPeriod
		{
			get => this.orbitalVelocity == 0 ? 0 : ROTATION_SECONDS_TO_RADIANS / this.orbitalVelocity;
			set
			{
				this.speed = 0;
				this.orbitalVelocity = value == 0 ? 0 : ROTATION_SECONDS_TO_RADIANS / value;
			}
		}
		/// <summary>
		/// The initial angle in degrees at which this missile is created. If left at null, will use a random angle.
		/// </summary>
		public float? InitialAngle { get; set; }

		private float currentAngle;
		private float orbitalVelocity;

		/// <inheritdoc/>
		protected OrbitalMissile(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		protected OrbitalMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		protected OrbitalMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		/// <inheritdoc/>
		protected OrbitalMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public sealed override void Launch()
		{
			this.casterZ += CasterLaunchZ;
			this.targetZ += TargetImpactZ;
			if (InitialAngle.HasValue)
			{
				this.currentAngle = InitialAngle.Value * Util.DEG2RAD;
			}
			else
			{
				this.currentAngle = GetRandomReal(0, Util.PI * 2);
			}

			MissileX = Util.PositionWithPolarOffsetRadX(TargetX, this.range, this.currentAngle);
			MissileY = Util.PositionWithPolarOffsetRadY(TargetY, this.range, this.currentAngle);
			this.missileZ = this.targetZ;

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
				}
				else
				{
					Active = false;
					OnImpact();
					if (!Active)
					{
						if (!UnitAlive(Target))
						{
							Target = null;
						}
						return;
					}
				}
			}

			this.currentAngle += this.orbitalVelocity;
			if (this.currentAngle > Util.PI * 2)
			{
				this.currentAngle -= Util.PI * 2;
			}
			else if (this.currentAngle < 0)
			{
				this.currentAngle += Util.PI * 2;
			}
			var oldX = MissileX;
			var oldY = MissileY;
			var oldZ = GetZ(MissileX, MissileY);
			MissileX = Util.PositionWithPolarOffsetRadX(TargetX, this.range, this.currentAngle);
			MissileY = Util.PositionWithPolarOffsetRadY(TargetY, this.range, this.currentAngle);

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return;
			}

			if (Effect != null)
			{
				this.yaw = this.orbitalVelocity > 0 ? this.currentAngle + (Util.PI / 2) : this.currentAngle - (Util.PI / 2);
				this.roll += this.spinPeriod;
				var deltaX = oldX - MissileX;
				var deltaY = oldY - MissileY;
				var newZ = GetZ(MissileX, MissileY);
				this.pitch = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, this.missileZ + newZ);
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
