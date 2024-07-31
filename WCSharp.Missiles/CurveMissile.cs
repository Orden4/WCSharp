using System;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Advanced missile that allows for arcing/curving motions, i.e. a boomerang motion.
	/// <para>If you do not use the <see cref="Curve"/> property, you should use <see cref="BasicMissile"/> instead for greater performance and
	/// identical features.</para>
	/// </summary>
	public abstract class CurveMissile : Missile
	{
		/// <summary>
		/// The flight modes of this missile type.
		/// </summary>
		public enum FlightMode
		{
			/// <summary>
			/// Default value prior to the missile being launched.
			/// <para>Will change to <see cref="Direct"/> if launched from a high altitude or with a non-zero <see cref="Arc"/>.</para>
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
		/// The arc of the missile. Closely matches the object editor arc values.
		/// <para>If you want a fixed height arc, set the Arc equal to (arc height/distance to target).</para>
		/// </summary>
		public float Arc { get; set; }

		/// <summary>
		/// The curve of the projectile, expressed in radians.
		/// <para>This alters the arc, a pi/2 or -pi/2 degree curve is a boomerang.</para>
		/// <para>Alternatively, use <see cref="Curve"/>.</para>
		/// </summary>
		public float CurveRad { get; set; }
		/// <summary>
		/// The curve of the projectile, expressed in degrees.
		/// <para>This alters the arc, a 90 or -90 degree curve is a boomerang.</para>
		/// <para>Alternatively, use <see cref="CurveRad"/>.</para>
		/// </summary>
		public float Curve
		{
			get => CurveRad * Util.RAD2DEG;
			set => CurveRad = value * Util.DEG2RAD;
		}

		/// <summary>
		/// The internal X of the missile without the arc/curve.
		/// </summary>
		public float OriginX { get; set; }
		/// <summary>
		/// The internal Y of the missile without the arc/curve.
		/// </summary>
		public float OriginY { get; set; }
		/// <summary>
		/// The internal Z of the missile without the arc/curve and terrain height.
		/// </summary>
		public float OriginZ { get; set; }

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

		private bool isArcingOrCurving;
		/// <summary>
		/// Whether the projectile is currently performing an arc or curve motion.
		/// <para>Automatically set at launch according to the <see cref="Arc"/> and <see cref="Curve"/>/<see cref="CurveRad"/> value.</para>
		/// <para>This is automatically disabled if the target moves more than 50 units in a single <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> tick (0.03125).</para>
		/// <para>Warning: Setting this to <see langword="true"/> mid-flight will cause the stored caster position to be changed to the missiles current position.</para>
		/// </summary>
		public bool IsArcingOrCurving
		{
			get => this.isArcingOrCurving;
			set
			{
				if (!this.isArcingOrCurving && value)
				{
					OriginX = MissileX;
					OriginY = MissileY;
					OriginZ = MissileZ;
					CasterX = OriginX;
					CasterY = OriginY;
					CasterLaunchZ = 0;
					InternalCasterZ = OriginZ;
					this.totalDistanceToTarget = FastUtil.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);
				}
				this.isArcingOrCurving = value;
			}
		}

		private float totalDistanceToTarget;

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

		private void SetFlightMode(FlightMode value = FlightMode.Default)
		{
			if (value == FlightMode.Default)
			{
				value = Arc != 0 || GetUnitFlyHeight(Caster) + CasterLaunchZ >= 300
					? FlightMode.Direct
					: FlightMode.FollowTerrain;
			}

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
			OriginX = CasterX;
			OriginY = CasterY;
			OriginZ = InternalCasterZ;
			RollRad = CurveRad;

			this.isArcingOrCurving = Arc != 0 || Curve != 0;
			this.totalDistanceToTarget = FastUtil.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

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

			if (this.isArcingOrCurving ? ArcAction() : DirectAction())
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
			var distance = FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY);
			if (distance < this.speed + ImpactLeeway)
			{
				Impact();
				return false;
			}

			var oldZ = MissileZ;
			InternalMissileZ += (InternalTargetZ - InternalMissileZ) * (this.speed / distance);

			YawRad = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);

			var deltaX = this.speed * Cos(YawRad);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(YawRad);
			MissileY += deltaY;

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return false;
			}

			if (Effect != null)
			{
				RollRad += SpinVelocityRad;
				var newZ = MissileZ;
				PitchRad = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, YawRad, PitchRad, RollRad);
			}

			return true;
		}

		private bool ArcAction()
		{
			if (FastUtil.DistanceBetweenPoints(OriginX, OriginY, TargetX, TargetY) < this.speed + ImpactLeeway)
			{
				Impact();
				return false;
			}

			var totalDistance = FastUtil.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

			// If the target has moved by more than 50 units since the last tick (which is a bit over 3 times the maximum speed)
			// We stop the arc as we presume the target has teleported
			if (Math.Abs(this.totalDistanceToTarget - totalDistance) > 50)
			{
				this.isArcingOrCurving = false;
				DirectAction();
				return true;
			}

			this.totalDistanceToTarget = totalDistance;
			var distanceTravelled = FastUtil.DistanceBetweenPoints(CasterX, CasterY, OriginX, OriginY);

			var originYaw = Util.AngleBetweenPointsRad(OriginX, OriginY, TargetX, TargetY);

			var deltaX = this.speed * Cos(originYaw);
			OriginX += deltaX;

			var deltaY = this.speed * Sin(originYaw);
			OriginY += deltaY;

			var oldOriginZ = OriginZ;
			OriginZ = InternalCasterZ
					+ (distanceTravelled / totalDistance * (InternalTargetZ - InternalCasterZ));
			var pitch = Atan2(oldOriginZ - OriginZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));

			var oldX = MissileX;
			var oldY = MissileY;
			var oldZ = MissileZ;
			var arcHeight = totalDistance * Arc * Sin(distanceTravelled / totalDistance * Util.PI);

			var cosYaw = Cos(originYaw);
			var sinYaw = Sin(originYaw);
			var cosRoll = Cos(CurveRad);
			var sinRoll = Sin(CurveRad);
			var sinPitchCosRoll = Sin(pitch) * cosRoll;

			MissileX = OriginX + (arcHeight * ((cosYaw * sinPitchCosRoll) + (sinYaw * sinRoll)));
			MissileY = OriginY + (arcHeight * ((sinYaw * sinPitchCosRoll) - (cosYaw * sinRoll)));
			InternalMissileZ = OriginZ + (arcHeight * Cos(pitch) * cosRoll);

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

				YawRad = Util.AngleBetweenPointsRad(oldX, oldY, MissileX, MissileY);
				PitchRad = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				RollRad += SpinVelocityRad;
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, newZ);
				BlzSetSpecialEffectOrientation(Effect, YawRad, PitchRad, RollRad);
			}

			return true;
		}
	}
}
