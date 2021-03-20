using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Dummies;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	public static class BuffSystem
	{
		private static readonly PeriodicTrigger<Buff> periodicTrigger = new PeriodicTrigger<Buff>(PeriodicEvents.SYSTEM_INTERVAL);
		private static readonly Dictionary<int, List<Buff>> buffsByHandleId = new Dictionary<int, List<Buff>>();

		/// <summary>
		/// All active buffs.
		/// </summary>
		public static IEnumerable<Buff> Buffs => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given buffs to the system. This will also initialise or alter some values according to the buffs' properties.
		/// </summary>
		/// <returns>The buff that was applied, or the buff whose stacks were added to.</returns>
		public static Buff Add(Buff buff, StackBehaviour stackBehaviour = StackBehaviour.None)
		{
			if (buffsByHandleId.TryGetValue(buff.targetHandleId, out var buffs))
			{
				if (stackBehaviour != StackBehaviour.None)
				{
					var type = buff.GetType();
					foreach (var currentBuff in buffs)
					{
						if (currentBuff.GetType() == type)
						{
							if (stackBehaviour == StackBehaviour.Stack ||
								(stackBehaviour == StackBehaviour.StackCaster && buff.Caster == currentBuff.Caster) ||
								(buff.CastingPlayer == currentBuff.CastingPlayer))
							{
								switch (currentBuff.OnStack(buff))
								{
									case StackResult.Stack:
										return currentBuff;
									case StackResult.Consume:
										currentBuff.Dispose();
										break;
								}
							}
						}
					}
				}

				buffs.Add(buff);
			}
			else
			{
				buffsByHandleId.Add(buff.targetHandleId, new List<Buff>
				{
					buff
				});
			}

			periodicTrigger.Add(buff);
			buff.Apply();
			return buff;
		}

		internal static void Remove(Buff buff)
		{
			if (buffsByHandleId.TryGetValue(buff.targetHandleId, out var buffs))
			{
				if (buffs.Count == 1)
				{
					buffsByHandleId.Remove(buff.targetHandleId);
				}
				else
				{
					buffs.Remove(buff);
				}
			}
		}

		/// <summary>
		/// By default, <see cref="Buff.CastingPlayer"/> and <see cref="Buff.TargetPlayer"/> are not updated when a unit changes owner.
		/// <para>This adds an event to pass over all auras and update <see cref="Buff.CastingPlayer"/> and <see cref="Buff.TargetPlayer"/> on ownership changes.</para>
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

			foreach (var buff in periodicTrigger.Actions)
			{
				if (buff.Caster == unit)
				{
					buff.CastingPlayer = GetOwningPlayer(unit);
				}
			}

			if (buffsByHandleId.TryGetValue(GetHandleId(unit), out var buffs))
			{
				var owner = GetOwningPlayer(unit);
				foreach (var buff in buffs)
				{
					buff.TargetPlayer = owner;
				}
			}
		}

		/// <summary>
		/// Uses a dictionary to quickly find all buffs attached to the given unit.
		/// </summary>
		public static IEnumerable<Buff> GetBuffsOnUnit(unit unit)
		{
			return GetBuffsOnUnit(GetHandleId(unit));
		}

		/// <summary>
		/// Uses a dictionary to quickly find all buffs attached to the given unit.
		/// </summary>
		public static IEnumerable<Buff> GetBuffsOnUnit(int unitHandleId)
		{
			if (buffsByHandleId.TryGetValue(unitHandleId, out var buffs))
			{
				return buffs;
			}

			return Enumerable.Empty<Buff>();
		}

		/// <summary>
		/// Attempts to dispel buffs from the target with the given dispel type.
		/// </summary>
		/// <param name="target">The target to dispel from.</param>
		/// <param name="dispeller">The caster of the dispel effect.</param>
		/// <param name="isBeneficial">Whether to dispel beneficial or detrimental buffs.</param>
		/// <param name="dispelAmount">The maximum number of buffs to dispel.</param>
		/// <param name="dispelType">The type of buffs that can be dispelled.</param>
		/// <returns>All dispelled buffs.</returns>
		public static IEnumerable<Buff> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, string dispelType)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Contains(dispelType))
				{
					if (buff.OnDispel(dispeller))
					{
						buff.Active = false;
						buff.Dispose();
						yield return buff;
					}

					if (--dispelAmount == 0)
					{
						yield break;
					}
				}
			}
		}

		/// <summary>
		/// Attempts to dispel buffs with any of the given dispel types.
		/// </summary>
		/// <param name="target">The target to dispel from.</param>
		/// <param name="dispeller">The caster of the dispel effect.</param>
		/// <param name="isBeneficial">Whether to dispel beneficial or detrimental buffs.</param>
		/// <param name="dispelAmount">The maximum number of buffs to dispel.</param>
		/// <param name="dispelTypes">The buff types that can be dispelled.</param>
		/// <returns>All dispelled buffs.</returns>
		public static IEnumerable<Buff> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, params string[] dispelTypes)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)))
				{
					if (buff.OnDispel(dispeller))
					{
						buff.Active = false;
						buff.Dispose();
						yield return buff;
					}

					if (--dispelAmount == 0)
					{
						yield break;
					}
				}
			}
		}

		/// <summary>
		/// For more complex buff hierarchies. Attempts to dispel buffs with any of the given dispel types, unless it has an excluded type.
		/// </summary>
		/// <param name="target">The target to dispel from.</param>
		/// <param name="dispeller">The caster of the dispel effect.</param>
		/// <param name="isBeneficial">Whether to dispel beneficial or detrimental buffs.</param>
		/// <param name="dispelAmount">The maximum number of buffs to dispel.</param>
		/// <param name="dispelTypes">The buff types that can be dispelled.</param>
		/// <param name="exclusions">Will not dispel buffs with any of the given exclusion types.</param>
		/// <returns>All dispelled buffs.</returns>
		public static IEnumerable<Buff> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, List<string> dispelTypes, List<string> exclusions)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)) && !buff.BuffTypes.Any(x => exclusions.Contains(x)))
				{
					if (buff.OnDispel(dispeller))
					{
						buff.Active = false;
						buff.Dispose();
						yield return buff;
					}

					if (--dispelAmount == 0)
					{
						yield break;
					}
				}
			}
		}
	}
}
