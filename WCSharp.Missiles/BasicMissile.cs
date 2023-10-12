using System;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Data;
using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Basic missile that will go from unit/location A to unit/location B.
	/// <para>The main feature for this missile is that missiles can arc.</para>
	/// </summary>
	public abstract class BasicMissile : Missile
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

		private bool isArcing;
		/// <summary>
		/// Whether the projectile is currently performing an arc motion.
		/// <para>Automatically set at launch according to the <see cref="Arc"/> value.</para>
		/// <para>This is automatically disabled if the target moves more than 50 units in a single <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> tick (0.03125).</para>
		/// <para>Warning: Setting this to <see langword="true"/> mid-flight will cause the stored caster position to be changed to the missiles current position.</para>
		/// </summary>
		public bool IsArcing
		{
			get => this.isArcing;
			set
			{
				if (!this.isArcing && value)
				{
					CasterLaunchZ = 0;
					CasterX = MissileX;
					CasterY = MissileY;
					InternalCasterZ = InternalMissileZ;
					this.totalDistanceToTarget = FastUtil.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);
				}
				this.isArcing = value;
			}
		}

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

			this.isArcing = Arc != 0;
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
					InternalTargetZ = GetUnitFlyHeight(Target) + TargetImpactZ;
					if (this.mode != FlightMode.FollowTerrain)
					{
						InternalTargetZ += Util.GetZ(TargetX, TargetY);
					}
				}
				else
				{
					Target = null;
				}
			}

			var distance = FastUtil.DistanceBetweenPoints(MissileX, MissileY, TargetX, TargetY);
			if (distance < this.speed + ImpactLeeway)
			{
				Impact();
				return;
			}

			var oldZ = MissileZ;

			if (this.isArcing)
			{
				var totalDistance = FastUtil.DistanceBetweenPoints(CasterX, CasterY, TargetX, TargetY);

				// If the target has moved by more than 50 units since the last tick (which is a bit over 3 times the maximum speed)
				// We stop the arc as we presume the target has teleported
				if (Math.Abs(this.totalDistanceToTarget - totalDistance) > 50)
				{
					this.isArcing = false;
				}
				else
				{
					this.totalDistanceToTarget = totalDistance;
					var factorTravelled = FastUtil.DistanceBetweenPoints(CasterX, CasterY, MissileX, MissileY) / totalDistance;
					InternalMissileZ = InternalCasterZ
						+ (factorTravelled * (InternalTargetZ - InternalCasterZ))
						+ (totalDistance * Arc * Sin(factorTravelled * Util.PI));
				}
			}
			else
			{
				InternalMissileZ += (InternalTargetZ - InternalMissileZ) * (this.speed / distance);
			}

			YawRad = Util.AngleBetweenPointsRad(MissileX, MissileY, TargetX, TargetY);

			var deltaX = this.speed * Cos(YawRad);
			MissileX += deltaX;

			var deltaY = this.speed * Sin(YawRad);
			MissileY += deltaY;

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
