using System.Collections.Generic;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Timers;
using static WCSharp.Api.Common;

namespace WCSharp.Missiles
{
	/// <summary>
	/// Tracks and runs all active <see cref="Missile"/> instances.
	/// </summary>
	public static class MissileSystem
	{
		private static readonly TimerSetCollectiveDisposable<Missile> timerSet = new(TimerSystem.DEFAULT_TICK_INTERVAL);

		/// <summary>
		/// All active missiles.
		/// </summary>
		public static IEnumerable<Missile> Missiles => timerSet.Actions;

		/// <summary>
		/// Adds the given <paramref name="missile"/> to the system.
		/// </summary>
		public static void Add(Missile missile)
		{
			missile.Launch();
			timerSet.Add(missile);
			missile.Action();
		}

		/// <summary>
		/// By default, <see cref="Missile.CastingPlayer"/> and <see cref="Missile.TargetPlayer"/> are not updated when a unit changes owner.
		/// <para>This adds an event to pass over all missiles and update <see cref="Missile.CastingPlayer"/> and <see cref="Missile.TargetPlayer"/> on ownership changes.</para>
		/// <para>This will ignore ownership changes of unit type 'xxxx' (WCSharp's dummy unit type).</para>
		/// </summary>
		public static void RegisterForOwnershipChanges()
		{
			PlayerUnitEvents.Register(UnitTypeEvent.ChangesOwner, OnUnitTypeChangesOwner);
		}

		private static void OnUnitTypeChangesOwner()
		{
			var unit = GetTriggerUnit();
			if (GetUnitTypeId(unit) == 2021161080)
				return;

			foreach (var missile in timerSet.Actions)
			{
				if (missile.Caster == unit)
				{
					missile.CastingPlayer = GetOwningPlayer(unit);
				}
				if (missile.Target == unit)
				{
					missile.TargetPlayer = GetOwningPlayer(unit);
				}
			}
		}

		/// <summary>
		/// The interval between each update of the system.
		/// <para>Use <see cref="SetTickInterval(float)"/> to adjust.</para>
		/// </summary>
		public static float TickInterval { get; private set; } = TimerSystem.DEFAULT_TICK_INTERVAL;
		/// <summary>
		/// Changes the tick interval to the desired value.
		/// <para>Note that the actual change occurs after a 0 second delay.</para>
		/// <para>Calls <see cref="Missile.BeforeTickIntervalChanged(float, float)"/> to adjust existing missiles.</para>
		/// </summary>
		public static void SetTickInterval(float tickInterval)
		{
			Delay.Add(() =>
			{
				var old = TickInterval;
				if (old != tickInterval)
				{
					foreach (var action in timerSet.Actions)
					{
						action.BeforeTickIntervalChanged(old, tickInterval);
					}
					timerSet.SetTimeout(tickInterval);
					TickInterval = tickInterval;
				}
			});
		}
	}
}
