using System;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Homing-type missile that is based on momentum. Every tick, it will accelerate itself towards the target, up to a maximum speed.
	/// <para>Note that the actual acceleration when adjusting its angle towards the target can be significantly less than specified.</para>
	/// <para>It is recommended to use at least a little bit of <see cref="Missile.ImpactLeeway"/> when using this missile.</para>
	/// </summary>
	public abstract class MomentumMissile : Missile
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
		/// The initial angle in degrees. If left at null, will default to the angle towards the target.
		/// </summary>
		public float? InitialAngle { get; set; }
		/// <summary>
		/// The acceleration in units per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// <para>This is used to make adjustments to the trajectory.</para>
		/// <para>Alternatively, use <see cref="Acceleration"/>.</para>
		/// </summary>
		public float AccelerationPerTick { get; set; }
		/// <summary>
		/// The acceleration in units per second.
		/// <para>This is used to make adjustments to the trajectory.</para>
		/// <para>Alternatively, use <see cref="AccelerationPerTick"/>.</para>
		/// </summary>
		public float Acceleration
		{
			get => AccelerationPerTick / PeriodicEvents.SYSTEM_INTERVAL;
			set => AccelerationPerTick = value * PeriodicEvents.SYSTEM_INTERVAL;
		}
		/// <summary>
		/// The maximum speed in units per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// <para>Alternatively, use <see cref="MaximumSpeed"/>.</para>
		/// </summary>
		public float MaximumSpeedPerTick { get; set; }
		/// <summary>
		/// The maximum speed in units per second.
		/// <para>Alternatively, use <see cref="MaximumSpeedPerTick"/>.</para>
		/// </summary>
		public float MaximumSpeed
		{
			get => MaximumSpeedPerTick / PeriodicEvents.SYSTEM_INTERVAL;
			set => MaximumSpeedPerTick = value * PeriodicEvents.SYSTEM_INTERVAL;
		}

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
		public MomentumMissile(unit caster, unit target) : base(caster, target)
		{
		}

		/// <inheritdoc/>
		public MomentumMissile(unit caster, float targetX, float targetY) : base(caster, targetX, targetY)
		{
		}

		/// <inheritdoc/>
		public MomentumMissile(player castingPlayer, float casterX, float casterY, unit target) : base(castingPlayer, casterX, casterY, target)
		{
		}

		/// <inheritdoc/>
		public MomentumMissile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : base(castingPlayer, casterX, casterY, targetX, targetY)
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
			var homingYaw = (YawRad < desiredYaw && desiredYaw < YawRad + Util.PI) || desiredYaw < YawRad - Util.PI
				? Math.Min(YawRad + Util.PI, desiredYaw + (Util.PI / 4))
				: Math.Max(YawRad - Util.PI, desiredYaw - (Util.PI / 4));

			var deltaX = (this.speed * Cos(YawRad)) + (AccelerationPerTick * Cos(homingYaw));
			MissileX += deltaX;

			var deltaY = (this.speed * Sin(YawRad)) + (AccelerationPerTick * Sin(homingYaw));
			MissileY += deltaY;

			var actualYaw = Util.PI + Atan2(-deltaY, -deltaX);
			if ((actualYaw < desiredYaw && desiredYaw < YawRad) || (YawRad < desiredYaw && desiredYaw < actualYaw))
			{
				YawRad = desiredYaw;
				this.speed = Math.Min(MaximumSpeedPerTick, this.speed + AccelerationPerTick);
			}
			else
			{
				YawRad = actualYaw;
				this.speed = Math.Min(MaximumSpeedPerTick, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
			}

			InternalMissileZ += (InternalTargetZ - InternalMissileZ) * (this.speed / FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY));

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return;
			}

			if (Effect != null)
			{
				RollRad += SpinVelocityRad;
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
