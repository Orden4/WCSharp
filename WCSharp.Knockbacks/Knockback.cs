using WCSharp.Events;
using WCSharp.Utils;
using static War3Api.Common;

namespace WCSharp.Knockbacks
{
	/// <summary>
	/// Represents a single knockback instance. Add to <see cref="KnockbackSystem"/> to activate.
	/// </summary>
	public class Knockback : IPeriodicAction
	{
		/// <summary>
		/// The interval between <see cref="Effect1"/> spawns.
		/// </summary>
		public const float EFFECT1_PERIOD = 1.0f;
		/// <summary>
		/// The interval between <see cref="Effect2"/> spawns.
		/// </summary>
		public const float EFFECT2_PERIOD = 0.125f;

		/// <summary>
		/// Setting this to false will immediately end the knockback.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// The target of the knockback.
		/// </summary>
		public unit Target { get; }
		/// <summary>
		/// The angle of the knockback in radians.
		/// </summary>
		public float Angle { get; set; }
		/// <summary>
		/// The distance traversed per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// </summary>
		public float Speed { get; set; }
		/// <summary>
		/// The amount of speed lost per <see cref="PeriodicEvents.SYSTEM_INTERVAL"/> (0.03125).
		/// </summary>
		public float SpeedDropoff { get; set; }
		/// <summary>
		/// This effect will be spawned every 1.0 seconds on the target using <see cref="Effect1AttachmentPoint"/>.
		/// </summary>
		public string Effect1 { get; set; }
		/// <summary>
		/// This effect will be spawned every 0.125 on the target using <see cref="Effect2AttachmentPoint"/>.
		/// </summary>
		public string Effect2 { get; set; }
		/// <summary>
		/// The attachment point to use for <see cref="Effect1"/>.
		/// </summary>
		public string Effect1AttachmentPoint { get; set; }
		/// <summary>
		/// The attachment point to use for <see cref="Effect2"/>.
		/// </summary>
		public string Effect2AttachmentPoint { get; set; }

		private float effect1Interval;
		private float effect2Interval;

		private Knockback(unit target, float distance, float duration)
		{
			Target = target;
			Speed = distance / duration * PeriodicEvents.SYSTEM_INTERVAL;
			SpeedDropoff = Speed / duration * PeriodicEvents.SYSTEM_INTERVAL;
		}

		/// <summary>
		/// Knocks the target the given distance towards the given angle (in degrees) over the given duration.
		/// </summary>
		/// <param name="target">The target to perform the knockback on</param>
		/// <param name="distance">The distance in units to knock the target back</param>
		/// <param name="duration">The duration in seconds over which the target should be knocked back</param>
		/// <param name="angle">In degrees.</param>
		public Knockback(unit target, float distance, float duration, float angle) : this(target, distance, duration)
		{
			Angle = angle * Util.DEG2RAD;
		}

		/// <summary>
		/// Knocks the target the given distance towards the given location over the given duration.
		/// </summary>
		public Knockback(unit target, float distance, float duration, float targetX, float targetY) : this(target, distance, duration)
		{
			var unitX = GetUnitX(Target);
			var unitY = GetUnitY(Target);
			Angle = Util.AngleBetweenPoints(unitX, unitY, targetX, targetY);
		}

		/// <summary>
		/// Called by the system. Do not call yourself.
		/// </summary>
		public void Action()
		{
			var unitX = GetUnitX(Target) + (Speed * Cos(Angle));
			var unitY = GetUnitY(Target) + (Speed * Sin(Angle));
			SetUnitPosition(Target, unitX, unitY);
			Speed -= SpeedDropoff;

			if (Speed <= 0)
			{
				Active = false;
				return;
			}

			if (Effect1 != null)
			{
				this.effect1Interval -= PeriodicEvents.SYSTEM_INTERVAL;
				if (this.effect1Interval <= 0)
				{
					this.effect1Interval = EFFECT1_PERIOD;
					var effect = AddSpecialEffectTarget(Effect1, Target, Effect1AttachmentPoint);
					DestroyEffect(effect);
				}
			}

			if (Effect2 != null)
			{
				this.effect2Interval -= PeriodicEvents.SYSTEM_INTERVAL;
				if (this.effect2Interval <= 0)
				{
					this.effect2Interval = EFFECT2_PERIOD;
					var effect = AddSpecialEffectTarget(Effect1, Target, Effect1AttachmentPoint);
					DestroyEffect(effect);
				}
			}
		}

		/// <summary>
		/// Merges the force of the given knockback into this knockback. Typically though, you can also just have both knockbacks active simultaneously and achieve the same effect.
		/// </summary>
		public void Merge(Knockback knockback)
		{
			var newX = (Speed * Cos(Angle)) + (knockback.Speed * Cos(knockback.Angle));
			var newY = (Speed * Sin(Angle)) + (knockback.Speed * Sin(knockback.Angle));
			Angle = Atan2(newY, newX);
			Speed = SquareRoot((newX * newX) + (newY * newY));
		}
	}
}
