using System;
using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using static WCSharp.Api.Common;

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
		/// The flight modes of this missile type.
		/// </summary>
		public enum FlightMode
		{
			/// <summary>
			/// Default value prior to the missile being launched.
			/// <para>Will automatically change to <see cref="FollowTerrain"/>.</para>
			/// </summary>
			Default,
			/// <summary>
			/// The missile will follow the height of the terrain.
			/// </summary>
			FollowTerrain,
			/// <summary>
			/// The missile will ignore the height of the terrain.
			/// </summary>
			Direct
		}

		/// <inheritdoc/>
		public sealed override float CasterZ
		{
			get => this.mode == FlightMode.FollowTerrain ? InternalCasterZ + Util.GetZ(CasterX, CasterY) : InternalCasterZ;
			set => InternalCasterZ = this.mode == FlightMode.FollowTerrain ? value - Util.GetZ(CasterX, CasterY) : value;
		}
		/// <inheritdoc/>
		public sealed override float TargetZ
		{
			get => this.mode == FlightMode.FollowTerrain ? InternalTargetZ + Util.GetZ(TargetX, TargetY) : InternalTargetZ;
			set => InternalTargetZ = this.mode == FlightMode.FollowTerrain ? value - Util.GetZ(TargetX, TargetY) : value;
		}
		/// <inheritdoc/>
		public sealed override float MissileZ
		{
			get => this.mode == FlightMode.FollowTerrain ? InternalMissileZ + Util.GetZ(MissileX, MissileY) : InternalMissileZ;
			set => InternalMissileZ = this.mode == FlightMode.FollowTerrain ? value - Util.GetZ(MissileX, MissileY) : value;
		}
		private float speed;
		/// <inheritdoc/>
		public sealed override float SpeedPerTick
		{
			get => this.speed;
			set => this.speed = value;
		}
		/// <inheritdoc/>
		public sealed override float Speed
		{
			get => this.speed / PeriodicEvents.SYSTEM_INTERVAL;
			set => this.speed = value * PeriodicEvents.SYSTEM_INTERVAL;
		}

		/// <summary>
		/// The speed at which the missile can turn, expressed in radians per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> tick (0.03125).
		/// <para>Alternatively, use <see cref="TurnRate"/> or <see cref="TurnPeriod"/>.</para>
		/// </summary>
		public float TurnVelocityRad { get; set; }
		/// <summary>
		/// The rate at which the missile can turn, expressed in degrees per second.
		/// <para>Alternatively, use <see cref="TurnVelocityRad"/> or <see cref="TurnPeriod"/>.</para>
		/// </summary>
		public float TurnRate
		{
			get => TurnVelocityRad * Util.RAD2DEG / PeriodicEvents.SYSTEM_INTERVAL;
			set => TurnVelocityRad = value * Util.DEG2RAD * PeriodicEvents.SYSTEM_INTERVAL;
		}
		/// <summary>
		/// The rate at which the missile can turn, expressed in degrees per second.
		/// <para>Alternatively, use <see cref="TurnVelocityRad"/> or <see cref="TurnRate"/>.</para>
		/// </summary>
		public float TurnPeriod
		{
			get => TurnVelocityRad == 0 ? 0 : ROTATION_SECONDS_TO_RADIANS / TurnVelocityRad;
			set => TurnVelocityRad = value == 0 ? 0 : ROTATION_SECONDS_TO_RADIANS / value;
		}

		/// <summary>
		/// The initial angle in degrees. If left at null, will default to the angle towards the target.
		/// </summary>
		public float? InitialAngle { get; set; }

		private FlightMode mode;
		/// <summary>
		/// The current flight mode of the projectile.
		/// <para>Automatically set at launch unless changed to a value other than <see cref="FlightMode.Default"/>.</para>
		/// </summary>
		public FlightMode Mode
		{
			get => this.mode;
			set
			{
				if (Active)
					SetFlightMode(value);
				else
					this.mode = value;
			}
		}

		/// <inheritdoc/>
		public HomingMissile(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public HomingMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public HomingMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		/// <inheritdoc/>
		public HomingMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
		{
		}

		private void SetFlightMode(FlightMode value = FlightMode.Default)
		{
			if (value == FlightMode.Default)
				value = FlightMode.FollowTerrain;

			if (this.mode == FlightMode.Direct)
			{
				if (value == FlightMode.FollowTerrain)
				{
					InternalCasterZ -= Util.GetZ(CasterX, CasterY);
					InternalMissileZ -= Util.GetZ(MissileX, MissileY);
					InternalTargetZ -= Util.GetZ(TargetX, TargetY);
				}
			}
			else if (value == FlightMode.Direct)
			{
				InternalCasterZ += Util.GetZ(CasterX, CasterY);
				InternalMissileZ += Util.GetZ(MissileX, MissileY);
				InternalTargetZ += Util.GetZ(TargetX, TargetY);
			}

			this.mode = value;
		}

		/// <inheritdoc/>
		public sealed override void Launch()
		{
			InternalCasterZ += CasterLaunchZ;
			InternalTargetZ += TargetImpactZ;
			InternalMissileZ = InternalCasterZ;
			IntervalLeft = Interval;
			MissileX = CasterX;
			MissileY = CasterY;

			if (this.mode == FlightMode.Default)
			{
				SetFlightMode();
			}
			else
			{
				var actualMode = this.mode;
				this.mode = FlightMode.Default;
				SetFlightMode();
				SetFlightMode(actualMode);
			}

			if (InitialAngle.HasValue)
			{
				YawRad = InitialAngle.Value * Util.DEG2RAD;
				if (YawRad < 0)
				{
					YawRad += Util.PI * 2;
				}
				else if (YawRad > Util.PI * 2)
				{
					YawRad -= Util.PI * 2;
				}
			}
			else
			{
				YawRad = Util.AngleBetweenPointsRad(CasterX, CasterY, TargetX, TargetY);
			}

			if (this.effectString != null)
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
					InternalTargetZ = GetUnitFlyHeight(Target) + TargetImpactZ;
				}
				else
				{
					Target = null;
				}
			}

			if (FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Impact();
				return;
			}

			var oldZ = MissileZ;

			var desiredYaw = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);
			if (Math.Abs(desiredYaw - YawRad) < TurnVelocityRad)
			{
				YawRad = desiredYaw;
			}
			else if ((YawRad < desiredYaw && desiredYaw < YawRad + Util.PI) || desiredYaw < YawRad - Util.PI)
			{
				YawRad += TurnVelocityRad;
			}
			else
			{
				YawRad -= TurnVelocityRad;
			}

			if (YawRad < 0)
			{
				YawRad += Util.PI * 2;
			}
			else if (YawRad > Util.PI * 2)
			{
				YawRad -= Util.PI * 2;
			}

			var deltaX = this.speed * Cos(YawRad);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(YawRad);
			MissileY += deltaY;

			InternalMissileZ += (InternalTargetZ - InternalMissileZ) * (this.speed / FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY));

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return;
			}

			if (Effect != null)
			{
				var newZ = MissileZ;
				PitchRad = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, YawRad, PitchRad, RollRad);
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
