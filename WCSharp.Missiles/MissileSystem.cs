﻿using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Missiles
{
	public static class MissileSystem
	{
		private static readonly PeriodicTrigger<Missile> periodicTrigger = new PeriodicTrigger<Missile>(PeriodicEvents.SYSTEM_INTERVAL);
		/// <summary>
		/// All active missiles.
		/// </summary>
		public static IEnumerable<Missile> Missiles => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given missile to the system. This will also initialise or alter some values according to the missiles' properties.
		/// </summary>
		public static void Add(Missile missile)
		{
			missile.Launch();
			periodicTrigger.Add(missile);
			missile.Action();
		}

		/// <summary>
		/// By default, <see cref="Missile.CastingPlayer"/> and <see cref="Missile.TargetPlayer"/> are not updated when a unit changes owner.
		/// <para>This adds an event to pass over all missiles and update <see cref="Missile.CastingPlayer"/> and <see cref="Missile.TargetPlayer"/> on ownership changes.</para>
		/// <para>This will ignore ownership changes of unit type 'xxxx' (WCSharp's dummy unit type).</para>
		/// </summary>
		public static void RegisterForOwnershipChanges()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeChangesOwner, OnUnitTypeChangesOwner);
		}

		private static void OnUnitTypeChangesOwner()
		{
			var unit = GetTriggerUnit();
			if (GetUnitTypeId(unit) == 2021161080)
				return;

			foreach (var missile in periodicTrigger.Actions)
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
	}
}