using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Shared;
using WCSharp.Shared.Extensions;
using WCSharp.Timers;
using static WCSharp.Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Fundamental missile class that provides the properties and methods that are shared by (virtually) all missiles.
	/// <para>Unless you wish to define a new movement pattern for missiles, you should use one of the derived classes instead.</para>
	/// </summary>
	public abstract class Missile : ICollectiveDisposableAction
	{
		private static readonly group group = CreateGroup();

		/// <summary>
		/// Whether the missile is active. This is automatically set to false prior to calling <see cref="OnImpact"/>.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The caster, if it exists.
		/// </summary>
		public unit Caster { get; set; }
		/// <summary>
		/// The owner of the caster. Automatically set on launch.
		/// <para>Does NOT update automatically! If this is desired, you can use <see cref="MissileSystem.RegisterForOwnershipChanges"/>.</para>
		/// </summary>
		public player CastingPlayer { get; set; }
		/// <summary>
		/// The X coordinate from which the missile was fired.
		/// </summary>
		public float CasterX { get; set; }
		/// <summary>
		/// The Y coordinate from which the missile was fired.
		/// </summary>
		public float CasterY { get; set; }
		/// <summary>
		/// The Z coordinate from which the missile was fired.
		/// <para>By default, this is equal to UnitFlyHeight + <see cref="CasterLaunchZ"/> + GetLocationZ.</para>
		/// </summary>
		public virtual float CasterZ
		{
			get => InternalCasterZ + Util.GetZ(CasterX, CasterY);
			set => InternalCasterZ = value - Util.GetZ(CasterX, CasterY);
		}
		/// <summary>
		/// Use this to adjust the origin height of the missile when firing, as it will by default fire from the ground (plus unit flying height).
		/// </summary>
		public float CasterLaunchZ { get; set; }
		/// <summary>
		/// The target, if it exists. If the target dies during travel, this is set to null.
		/// </summary>
		public unit Target { get; set; }
		/// <summary>
		/// The owner of the target. Automatically set on launch.
		/// <para>Does NOT update automatically! If this is desired, you can use <see cref="MissileSystem.RegisterForOwnershipChanges"/>.</para>
		/// </summary>
		public player TargetPlayer { get; set; }
		/// <summary>
		/// The X coordinate that this missile is moving towards. While <see cref="Target"/> is alive, this will automatically be updated.
		/// </summary>
		public float TargetX { get; set; }
		/// <summary>
		/// The Y coordinate that this missile is moving towards. While <see cref="Target"/> is alive, this will automatically be updated.
		/// </summary>
		public float TargetY { get; set; }
		/// <summary>
		/// The Z coordinate that this missile is moving towards.
		/// <para>While <see cref="Target"/> is alive, this will automatically be updated.</para>
		/// <para>By default, this is equal to UnitFlyHeight + <see cref="TargetImpactZ"/> + GetLocationZ.</para>
		/// </summary>
		public virtual float TargetZ
		{
			get => InternalTargetZ + Util.GetZ(TargetX, TargetY);
			set => InternalTargetZ = value - Util.GetZ(TargetX, TargetY);
		}
		/// <summary>
		/// Use this to adjust the target height of the missile, as it will by default aim towards the ground (plus unit flying height).
		/// </summary>
		public float TargetImpactZ { get; set; }

		/// <summary>
		/// The current X position of the missile.
		/// <para>Depending on the type of missile, MissileX sets may be ignored.</para>
		/// </summary>
		public float MissileX { get; protected set; }
		/// <summary>
		/// The current Y position of the missile.
		/// <para>Depending on the type of missile, MissileY sets may be ignored.</para>
		/// </summary>
		public float MissileY { get; protected set; }
		/// <summary>
		/// The current Z position of the missile.
		/// <para>Depending on the type of missile, MissileZ sets may be ignored.</para>
		/// </summary>
		public virtual float MissileZ
		{
			get => InternalMissileZ + Util.GetZ(MissileX, MissileY);
			set => InternalMissileZ = value - Util.GetZ(MissileX, MissileY);
		}

		/// <summary>
		/// The speed of the missile, expressed in units per <see cref="MissileSystem.TickInterval"/>.
		/// <para>Alternatively, use <see cref="Speed"/>.</para>
		/// </summary>
		public abstract float SpeedPerTick { get; set; }
		/// <summary>
		/// The speed of the missile, expressed in units per second.
		/// <para>Alternatively, use <see cref="SpeedPerTick"/>.</para>
		/// </summary>
		public abstract float Speed { get; set; }

		/// <summary>
		/// By default impact triggers when the distance to the target is less than the missile's speed per tick.
		/// <para>Use this to increase that distance by a static number (default 0).</para>
		/// </summary>
		public float ImpactLeeway { get; set; }

		/// <summary>
		/// <para>Keeps track of all units collided with thus far.</para>
		/// <para>Null if <see cref="CollisionRadius"/> has never been set to a value greater than 0.</para>
		/// <para>Removing a unit from this means <see cref="OnCollision(unit)"/> will trigger for that unit once more.</para>
		/// </summary>
		public HashSet<unit> TargetsHit { get; set; }
		private protected float collisionRadius;
		/// <summary>
		/// The collision radius of the missile which is used to trigger <see cref="OnCollision(unit)"/>.
		/// <para>Leave at default (0) to disable. Will ignore values below 0.</para>
		/// </summary>
		public float CollisionRadius
		{
			get => this.collisionRadius;
			set
			{
				this.collisionRadius = Math.Max(0, value);
				if (this.collisionRadius > 0 && TargetsHit == null)
				{
					TargetsHit = new HashSet<unit>();
				}
			}
		}

		/// <summary>
		/// The interval at which the missile will call <see cref="OnPeriodic"/>.
		/// <para>Leave at default (0) to disable.</para>
		/// <para>Intervals lower than <see cref="MissileSystem.TickInterval"/> may run multiple times per tick.</para>
		/// </summary>
		public float Interval { get; set; }
		/// <summary>
		/// The time left until the next call to <see cref="OnPeriodic"/>.
		/// </summary>
		public float IntervalLeft { get; set; }

		/// <summary>
		/// The yaw of the projectile, expressed in radians.
		/// <para>Depending on the type of missile, yaw sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="Yaw"/>.</para>
		/// </summary>
		public float YawRad { get; set; }
		/// <summary>
		/// The yaw of the projectile, expressed in degrees.
		/// <para>Depending on the type of missile, yaw sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="YawRad"/>.</para>
		/// </summary>
		public float Yaw
		{
			get => YawRad * Util.RAD2DEG;
			set => YawRad = value * Util.DEG2RAD;
		}
		/// <summary>
		/// The pitch of the projectile, expressed in radians.
		/// <para>Depending on the type of missile, pitch sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="Pitch"/>.</para>
		/// </summary>
		public float PitchRad { get; set; }
		/// <summary>
		/// The pitch of the projectile. Defined in degrees.
		/// <para>Depending on the type of missile, pitch sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="PitchRad"/>.</para>
		/// </summary>
		public float Pitch
		{
			get => PitchRad * Util.RAD2DEG;
			set => PitchRad = value * Util.DEG2RAD;
		}
		/// <summary>
		/// The roll of the projectile, expressed in radians.
		/// <para>Depending on the type of missile, roll sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="Roll"/>.</para>
		/// </summary>
		public float RollRad { get; set; }
		/// <summary>
		/// The roll of the projectile, expressed in degrees.
		/// <para>Depending on the type of missile, roll sets may be ignored.</para>
		/// <para>Alternatively, use <see cref="RollRad"/>.</para>
		/// </summary>
		public float Roll
		{
			get => RollRad * Util.RAD2DEG;
			set => RollRad = value * Util.DEG2RAD;
		}

		/// <summary>
		/// Identical to <see cref="Yaw"/>.
		/// </summary>
		public float CurrentAngle
		{
			get => YawRad * Util.RAD2DEG;
			set => YawRad = value * Util.DEG2RAD;
		}

		/// <summary>
		/// Internal effect string.
		/// </summary>
		private protected string effectString;
		/// <summary>
		/// The effect string of the missile.
		/// <para>If null, no effect will be created.</para>
		/// <para>If changed mid-flight, automatically modifies the missile.</para>
		/// </summary>
		public string EffectString
		{
			get => this.effectString;
			set
			{
				if (this.effectString != value)
				{
					if (Active)
					{
						if (Effect != null)
						{
							DestroyEffect(Effect);
						}

						if (value != null)
						{
							Effect = AddSpecialEffect(value, MissileX, MissileY);
							BlzSetSpecialEffectZ(Effect, MissileZ);
							BlzSetSpecialEffectOrientation(Effect, YawRad, PitchRad, RollRad);
							if (this.effectScale != 1)
							{
								BlzSetSpecialEffectScale(Effect, this.effectScale);
							}
						}
					}

					this.effectString = value;
				}
			}
		}

		/// <summary>
		/// Internal effect scale. Used only when there is no effect present yet.
		/// </summary>
		private protected float effectScale = 1.0f;
		/// <summary>
		/// The effect scale of the missile.
		/// <para>If changed mid-flight, automatically modifies the missile.</para>
		/// </summary>
		public float EffectScale
		{
			get => Effect == null ? this.effectScale : BlzGetSpecialEffectScale(Effect);
			set
			{
				if (Effect != null)
				{
					BlzSetSpecialEffectScale(Effect, value);
				}
				this.effectScale = value;
			}
		}

		/// <summary>
		/// The effect being used by the missile. Creation of the effect should be done by setting <see cref="EffectString"/>, not by setting this property.
		/// </summary>
		public effect Effect { get; protected set; }

		/// <summary>
		/// The internal Z coordinate of the missile. This is what the system uses and may or may not be the actual position.
		/// <para>For standard purposes, you should use <see cref="MissileZ"/> instead.</para>
		/// </summary>
		public float InternalMissileZ { get; set; }
		/// <summary>
		/// The internal Z coordinate of the caster. This is what the system uses and may or may not be the actual position.
		/// <para>For standard purposes, you should use <see cref="CasterZ"/> instead.</para>
		/// </summary>
		public float InternalCasterZ { get; set; }
		/// <summary>
		/// The internal Z coordinate of the target. This is what the system uses and may or may not be the actual position.
		/// <para>For standard purposes, you should use <see cref="TargetZ"/> instead.</para>
		/// </summary>
		public float InternalTargetZ { get; set; }

		private Missile(unit caster)
		{
			Caster = caster;
			CastingPlayer = GetOwningPlayer(caster);
			CasterX = GetUnitX(caster);
			CasterY = GetUnitY(caster);
			InternalCasterZ = GetUnitFlyHeight(caster);
		}

		private Missile(player castingPlayer, float casterX, float casterY)
		{
			CastingPlayer = castingPlayer;
			CasterX = casterX;
			CasterY = casterY;
		}

		/// <summary>
		/// Creates a new missile instance with the given parameters.
		/// <para>Will automatically set <see cref="CastingPlayer"/>, <see cref="CasterX"/>, <see cref="CasterY"/>,
		/// <see cref="TargetPlayer"/>, <see cref="TargetX"/> and <see cref="TargetY"/>.</para>
		/// </summary>
		public Missile(unit caster, unit target) : this(caster)
		{
			Target = target;
			TargetPlayer = GetOwningPlayer(target);
			TargetX = GetUnitX(target);
			TargetY = GetUnitY(target);
			InternalTargetZ = GetUnitFlyHeight(target);
		}

		/// <summary>
		/// Creates a new missile instance with the given parameters.
		/// <para>Will automatically set <see cref="CastingPlayer"/>, <see cref="CasterX"/> and <see cref="CasterY"/>.</para>
		/// </summary>
		public Missile(unit caster, float targetX, float targetY) : this(caster)
		{
			TargetX = targetX;
			TargetY = targetY;
		}

		/// <summary>
		/// Creates a new missile instance with the given parameters.
		/// <para>Will automatically set <see cref="TargetPlayer"/>, <see cref="TargetX"/> and <see cref="TargetY"/>.</para>
		/// </summary>
		public Missile(player castingPlayer, float casterX, float casterY, unit target) : this(castingPlayer, casterX, casterY)
		{
			Target = target;
			TargetPlayer = GetOwningPlayer(target);
			TargetX = GetUnitX(target);
			TargetY = GetUnitY(target);
			InternalTargetZ = GetUnitFlyHeight(target);
		}

		/// <summary>
		/// Creates a new missile instance with the given parameters.
		/// </summary>
		public Missile(player castingPlayer, float casterX, float casterY, float targetX, float targetY) : this(castingPlayer, casterX, casterY)
		{
			TargetX = targetX;
			TargetY = targetY;
		}

		/// <summary>
		/// Called by the system. Do not call yourself.
		/// </summary>
		public abstract void Launch();

		/// <summary>
		/// Called by the system. Do not call yourself.
		/// </summary>
		public abstract void Action();

		/// <summary>
		/// Should be called when the missile would exit world bounds.
		/// </summary>
		protected void ExitWorldBounds()
		{
			if (Effect != null)
			{
				MissileX = BlzGetLocalSpecialEffectX(Effect);
				MissileY = BlzGetLocalSpecialEffectY(Effect);
				MissileZ = BlzGetLocalSpecialEffectZ(Effect);
			}

			if (Interval > 0)
			{
				RunInterval();
			}
			if (this.collisionRadius > 0)
			{
				RunCollisions();
			}

			Active = false;
			OnImpact();
		}

		/// <summary>
		/// Runs the Interval related code. Do not call if <see cref="Interval"/> is 0 (will cause an infinite loop!).
		/// </summary>
		protected void RunInterval()
		{
			IntervalLeft -= MissileSystem.TickInterval;
			while (IntervalLeft <= 0)
			{
				IntervalLeft += Interval;
				OnPeriodic();
			}
		}

		/// <summary>
		/// Runs the Collision related code. Do not call if <see cref="CollisionRadius"/> is 0.
		/// <para>Can be overridden in case you want to provide your own unit search code (e.g. using spatial hashing).</para>
		/// </summary>
		protected virtual void RunCollisions()
		{
			GroupEnumUnitsInRange(group, MissileX, MissileY, this.collisionRadius, null);
			var list = group.ToList();
			for (var i = 0; i < list.Count; i++)
			{
				var unit = list[i];
				if (TargetsHit.Add(unit))
				{
					OnCollision(unit);
				}
			}
		}

		/// <summary>
		/// Sets the missile position to that of the target and runs the interval, collision and impact code.
		/// </summary>
		protected void Impact()
		{
			MissileX = TargetX;
			MissileY = TargetY;
			InternalMissileZ = InternalTargetZ;
			BlzSetSpecialEffectPosition(Effect, MissileX, MissileY, MissileZ);
			BlzSetSpecialEffectPitch(Effect, 0);

			if (Interval > 0)
			{
				RunInterval();
			}
			if (this.collisionRadius > 0)
			{
				RunCollisions();
			}

			Active = false;
			OnImpact();
		}

		/// <summary>
		/// <para>Override this method if your missile has an effect that should trigger when colliding with another unit.</para>
		/// <para>For this to be active, <see cref="CollisionRadius"/> must be greater than 0.</para>
		/// <para>Note that there is no filter on this collision. This is called whenever it collides with anything not in <see cref="TargetsHit"/>.</para>
		/// <para>Before this method is called, the <paramref name="unit"/> is added to <see cref="TargetsHit"/>.</para>
		/// </summary>
		public virtual void OnCollision(unit unit)
		{

		}

		/// <summary>
		/// Override this method if your missile has an effect that should trigger when it is destroyed for any reason.
		/// </summary>
		public virtual void OnDispose()
		{

		}

		/// <summary>
		/// Override this method if your missile has an impact effect.
		/// <para><see cref="Active"/> is automatically set to false prior to calling this method. If you do not want the missile to end, you need to set <see cref="Active"/> back to true.</para>
		/// </summary>
		public virtual void OnImpact()
		{

		}

		/// <summary>
		/// <para>Override this method if your missile has a periodic effect.</para>
		/// <para>For this to be active, <see cref="Interval"/> must be greater than 0.</para>
		/// </summary>
		public virtual void OnPeriodic()
		{

		}

		/// <inheritdoc/>
		public void Dispose()
		{
			OnDispose();
			if (Effect != null)
			{
				DestroyEffect(Effect);
			}
		}

		/// <summary>
		/// Override if adjustments are needed when the tick interval is changed.
		/// <para>Ensure that the base is still called.</para>
		/// </summary>
		public virtual void BeforeTickIntervalChanged(float oldTickInterval, float newTickInterval)
		{
			SpeedPerTick = Speed * newTickInterval;
		}
	}
}
