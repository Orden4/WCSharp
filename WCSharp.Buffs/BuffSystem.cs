using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Dummies;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Tracks and runs all active <see cref="Buff"/> instances.
	/// </summary>
	public static class BuffSystem
	{
		private static readonly PeriodicDisposableTrigger<Buff> periodicTrigger = new PeriodicDisposableTrigger<Buff>(PeriodicEvents.SYSTEM_INTERVAL);
		private static readonly Dictionary<unit, List<Buff>> buffsByUnit = new Dictionary<unit, List<Buff>>();

		/// <summary>
		/// All active buffs.
		/// </summary>
		public static IEnumerable<Buff> Buffs => periodicTrigger.Actions;

		/// <summary>
		/// Adds the given <paramref name="buff"/> to the system. If addition is successful, will invoke <see cref="Buff.OnApply"/>.
		/// </summary>
		/// <returns>The buff that was applied, or the buff whose stacks were added to.</returns>
		public static Buff Add(Buff buff, StackBehaviour stackBehaviour = StackBehaviour.None)
		{
			if (buffsByUnit.TryGetValue(buff.Target, out var buffs))
			{
				if (stackBehaviour != StackBehaviour.None)
				{
					var type = buff.GetType();
					foreach (var currentBuff in buffs)
					{
						if (currentBuff.Active && currentBuff.GetType() == type)
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
										currentBuff.Active = false;
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
				buffsByUnit.Add(buff.Target, new List<Buff>
				{
					buff
				});
			}

			buff.Apply();
			periodicTrigger.Add(buff);
			return buff;
		}

		internal static void Remove(Buff buff)
		{
			if (buffsByUnit.TryGetValue(buff.Target, out var buffs))
			{
				if (buffs.Count == 1)
				{
					buffsByUnit.Remove(buff.Target);
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

			var owner = GetOwningPlayer(unit);
			foreach (var buff in GetBuffsOnUnit(unit))
			{
				buff.TargetPlayer = owner;
			}
		}

		/// <summary>
		/// Uses a dictionary to quickly find all buffs attached to the given unit.
		/// </summary>
		public static IEnumerable<Buff> GetBuffsOnUnit(unit unit)
		{
			if (buffsByUnit.TryGetValue(unit, out var buffs))
			{
				foreach (var buff in buffs)
				{
					if (buff.Active)
					{
						yield return buff;
					}
				}
			}
		}

		/// <summary>
		/// Attempts to dispel buffs from the target with the given dispel type.
		/// </summary>
		/// <param name="target">The target to dispel from.</param>
		/// <param name="dispeller">The caster of the dispel effect.</param>
		/// <param name="isBeneficial">Whether to dispel beneficial or detrimental buffs.</param>
		/// <param name="dispelAmount">The maximum number of buffs to dispel.</param>
		/// <param name="dispelType">The type of buffs that can be dispelled.</param>
		/// <returns>All dispels.</returns>
		public static IEnumerable<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, string dispelType)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Contains(dispelType))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.Active = false;
					}

					yield return new Dispel(buff, chargesConsumed, stacks - buff.Stacks);

					if (dispelAmount <= 0)
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
		/// <returns>All dispels.</returns>
		public static IEnumerable<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, params string[] dispelTypes)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.Active = false;
					}

					yield return new Dispel(buff, chargesConsumed, stacks - buff.Stacks);

					if (dispelAmount <= 0)
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
		/// <returns>All dispels.</returns>
		public static IEnumerable<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, List<string> dispelTypes, List<string> exclusions)
		{
			foreach (var buff in GetBuffsOnUnit(target))
			{
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)) && !buff.BuffTypes.Any(x => exclusions.Contains(x)))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.Active = false;
					}

					yield return new Dispel(buff, chargesConsumed, stacks - buff.Stacks);

					if (dispelAmount <= 0)
					{
						yield break;
					}
				}
			}
		}
	}
}
