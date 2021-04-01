using System.Collections.Generic;
using WCSharp.Dummies;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Tracks and runs all active <see cref="IAura"/> instances.
	/// </summary>
	public static class AuraSystem
	{
		private static readonly PeriodicDisposableTrigger<IAura> periodicTrigger = new PeriodicDisposableTrigger<IAura>(PeriodicEvents.SYSTEM_INTERVAL);

		/// <summary>
		/// All active buffs.
		/// </summary>
		public static IEnumerable<IAura> Auras => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given <paramref name="aura"/> to the system.
		/// </summary>
		public static void Add(IAura aura)
		{
			aura.Apply();
			periodicTrigger.Add(aura);
		}

		/// <summary>
		/// By default, <see cref="IAura.CastingPlayer"/> is not updated when a unit changes owner.
		/// <para>This adds an event to pass over all auras and update <see cref="IAura.CastingPlayer"/> on ownership changes.</para>
		/// <para>This will ignore ownership changes of unit type 'xxxx' (<see cref="DummySystem.UNIT_TYPE_DUMMY"/>).</para>
		/// </summary>
		public static void RegisterForOwnershipChanges()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeChangesOwner, OnUnitTypeChangesOwner);
		}

		private static void OnUnitTypeChangesOwner()
		{
			var unit = GetTriggerUnit();
			if (GetUnitTypeId(unit) == DummySystem.UNIT_TYPE_DUMMY)
				return;

			foreach (var aura in periodicTrigger.Actions)
			{
				if (aura.Caster == unit)
				{
					aura.CastingPlayer = GetOwningPlayer(unit);
				}
			}
		}
	}
}
