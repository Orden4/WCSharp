using System;
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
		/// <summary>
		/// The flight modes of this missile type.
		/// </summary>
		public enum FlightMode
		{
			/// <summary>
			/// Default value prior to the missile being launched.
			/// <para>Will automatically change to <see cref="BestFit"/>.</para>
			/// </summary>
			Default,
			/// <summary>
			/// The missile will use the terrain height at the position of the missile itself.
			/// </summary>
			MissileBased,
			/// <summary>
			/// The missile will use the terrain height at the position of the target that it is orbiting.
			/// <para>This can result in the missile clipping through terrain, you can use <see cref="BestFit"/> to avoid this.</para>
			/// </summary>
			TargetBased,
			/// <summary>
			/// Essentially <see cref="TargetBased"/> but with extra logic to avoid clipping into terrain.
			/// </summary>
			BestFit,
			/// <summary>
			/// The height of the missile will never be adjusted.
			/// </summary>
			None
		}

		/// <inheritdoc/>
		public sealed override float CasterZ
		{
			get => InternalCasterZ + Util.GetZ(CasterX, CasterY);
			set => InternalCasterZ = value - Util.GetZ(CasterX, CasterY);
		}
		/// <inheritdoc/>
		public sealed override float TargetZ
		{
			get => InternalTargetZ + Util.GetZ(TargetX, TargetY);
			set => InternalTargetZ = value - Util.GetZ(TargetX, TargetY);
		}
		/// <inheritdoc/>
		public sealed override float MissileZ
		{
			get => InternalMissileZ;
			set => InternalMissileZ = value;
		}
		/// <summary>
		/// The speed of the missile, expressed in units per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> tick (0.03125).
		/// <para>Use negative values to go clockwise.</para>
		/// <para>This can be used instead of <see cref="OrbitalPeriod"/>, and will ensure a consistent speed for the missile itself through <see cref="Range"/> adjustments.</para>
		/// </summary>
		public sealed override float SpeedPerTick
		{
			get => 2 / this.orbitalVelocity * this.range;
			set
			{
				this.speed = value;
				this.orbitalVelocity = 2 * value / this.range;
			}
		}
		/// <summary>
		/// The speed of the missile, expressed in units per second.
		/// <para>Use negative values to go clockwise.</para>
		/// <para>This can be used instead of <see cref="OrbitalPeriod"/>, and will ensure a consistent speed for the missile itself through <see cref="Range"/> adjustments.</para>
		/// </summary>
		public sealed override float Speed
		{
			get => 2 / PeriodicEvents.SYSTEM_INTERVAL * this.orbitalVelocity * this.range;
			set
			{
				this.speed = value * PeriodicEvents.SYSTEM_INTERVAL;
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
		/// The speed at which the missile is orbiting, expressed in radians per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> tick (0.03125).
		/// </summary>
		public float OrbitalVelocityRad
		{
			get => this.orbitalVelocity;
			set
			{
				SpeedPerTick = 0;
				this.orbitalVelocity = value;
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
				SpeedPerTick = 0;
				this.orbitalVelocity = value == 0 ? 0 : ROTATION_SECONDS_TO_RADIANS / value;
			}
		}

		/// <summary>
		/// The current angle from the target of the orbit to the missile, expressed in radians.
		/// <para>Ranges between 0 (inclusive) and 2pi (exclusive).</para>
		/// <para>Automatically set to a random angle.</para>
		/// </summary>
		public float OrbitalAngleRad { get; set; } = GetRandomReal(0, Util.PI * 2);
		/// <summary>
		/// The current angle from the target of the orbit to the missile, expressed in degrees.
		/// <para>Automatically set to a random angle.</para>
		/// </summary>
		public float OrbitalAngle
		{
			get => OrbitalAngleRad * Util.RAD2DEG;
			set => OrbitalAngleRad = value * Util.DEG2RAD;
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

		/// <summary>
		/// Only used to store the desired speed for if <see cref="Range"/> is adjusted later on.
		/// </summary>
		private float speed;
		/// <summary>
		/// The true orbital velocity.
		/// </summary>
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

		private void SetFlightMode(FlightMode value = FlightMode.Default)
		{
			if (value == FlightMode.Default)
				value = FlightMode.BestFit;

			if (Active)
				AdjustMissileZ();

			this.mode = value;
		}

		/// <inheritdoc/>
		public sealed override void Launch()
		{
			InternalCasterZ += CasterLaunchZ;
			InternalTargetZ += TargetImpactZ;
			IntervalLeft = Interval;
			MissileX = Util.PositionWithPolarOffsetRadX(TargetX, this.range, OrbitalAngleRad);
			MissileY = Util.PositionWithPolarOffsetRadY(TargetY, this.range, OrbitalAngleRad);

			SetFlightMode(this.mode);
			AdjustMissileZ();

			if (!string.IsNullOrEmpty(this.effectString))
			{
				Effect = AddSpecialEffect(this.effectString, MissileX, MissileY);
				BlzSetSpecialEffectZ(Effect, InternalMissileZ);
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

			OrbitalAngleRad += this.orbitalVelocity;
			if (OrbitalAngleRad >= Util.PI * 2)
			{
				OrbitalAngleRad -= Util.PI * 2;
			}
			else if (OrbitalAngleRad < 0)
			{
				OrbitalAngleRad += Util.PI * 2;
			}

			var oldX = MissileX;
			var oldY = MissileY;
			MissileX = Util.PositionWithPolarOffsetRadX(TargetX, this.range, OrbitalAngleRad);
			MissileY = Util.PositionWithPolarOffsetRadY(TargetY, this.range, OrbitalAngleRad);

			if (!Rectangle.WorldBounds.Contains(MissileX, MissileY))
			{
				ExitWorldBounds();
				return;
			}

			if (Effect != null)
			{
				var oldZ = InternalMissileZ;
				AdjustMissileZ();
				YawRad = this.orbitalVelocity > 0 ? OrbitalAngleRad + (Util.PI / 2) : OrbitalAngleRad - (Util.PI / 2);
				RollRad += SpinVelocityRad;
				var deltaX = oldX - MissileX;
				var deltaY = oldY - MissileY;
				var newZ = InternalMissileZ;
				PitchRad = Atan2(oldZ - newZ, SquareRoot((deltaX * deltaX) + (deltaY * deltaY)));
				BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, InternalMissileZ);
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

		private void AdjustMissileZ()
		{
			if (this.mode == FlightMode.MissileBased)
			{
				InternalMissileZ = InternalTargetZ + Util.GetZ(MissileX, MissileY);
			}
			else if (this.mode == FlightMode.TargetBased)
			{
				InternalMissileZ = InternalTargetZ + Util.GetZ(TargetX, TargetY);
			}
			else if (this.mode == FlightMode.BestFit)
			{
				InternalMissileZ = InternalTargetZ + Math.Max(Util.GetZ(MissileX, MissileY), Util.GetZ(TargetX, TargetY));
			}
		}
	}
}
