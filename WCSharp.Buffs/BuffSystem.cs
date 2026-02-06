using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Api;
using WCSharp.Dummies;
using WCSharp.Events;
using WCSharp.Shared;
using WCSharp.Shared.Extensions;
using WCSharp.Timers;
using static WCSharp.Api.Common;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Tracks and runs all active <see cref="Buff"/> instances.
	/// </summary>
	public static class BuffSystem
	{
		static BuffSystem()
		{
			// Taking a shortcut from the standard approach and just assuming that there will pretty much always be buffs active and never unregistering these events.
			PlayerUnitEvents.Register(UnitTypeEvent.Dies, OnDeath);
		}

		private static readonly List<Buff> buffs = new();
		private static readonly Dictionary<unit, List<Buff>> buffsByUnit = new();
		private static readonly Timer timer = TimerSystem.Add(Action, TimerSystem.DEFAULT_TICK_INTERVAL);

		private static int index;
		private static int size;

		/// <summary>
		/// All active buffs.
		/// </summary>
		public static IEnumerable<Buff> Buffs => buffs.Where(x => x.Active);

		private static void Action(Timer timer)
		{
			size = buffs.Count;
			index = 0;

			while (index < size)
			{
				var buff = buffs[index];
				if (buff.Active)
				{
					buff.Action();
				}

				if (buff.Active)
				{
					index++;
				}
				else
				{
					size--;
					buffs[index] = buffs[size];
					buffs.RemoveAt(size);
					if (!buff.Disposed)
					{
						buff.Dispose();
					}
				}
			}
		}

		private static void OnDeath()
		{
			var unit = GetTriggerUnit();
			var buffsOnUnit = GetBuffsOnUnit(unit);

			if (index < size)
			{
				var buff = buffs[index];
				if (buff.Active && buff.Target == unit)
				{
					buff.Active = false;
					buff.OnDeath(true);
				}
			}

			for (var i = 1; i <= buffsOnUnit.Count; i++)
			{
				var buff = buffsOnUnit.DirectGet(i);
				if (buff.Active)
				{
					buff.Active = false;
					buff.OnDeath(false);
				}
			}
		}

		/// <summary>
		/// Adds the given <paramref name="buff"/> to the system. If addition is successful, will invoke <see cref="Buff.OnApply"/>.
		/// </summary>
		/// <returns>The buff that was applied, or the buff whose stacks were added to.</returns>
		public static Buff Add(Buff buff, StackBehaviour stackBehaviour = StackBehaviour.None)
		{
			if (buffsByUnit.TryGetValue(buff.Target, out var buffsOnUnit))
			{
				if (stackBehaviour != StackBehaviour.None)
				{
					var type = buff.GetType();
					for (var i = 1; i <= buffsOnUnit.Count; i++)
					{
						var currentBuff = buffsOnUnit.DirectGet(i);
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

				buffsOnUnit.Add(buff);
			}
			else
			{
				buffsByUnit.Add(buff.Target, new List<Buff>
				{
					buff
				});
			}

			buffs.Add(buff);
			buff.Active = true;
			buff.Apply();

			return buff;
		}

		internal static void Remove(Buff buff)
		{
			if (buffsByUnit.TryGetValue(buff.Target, out var buffsOnUnit))
			{
				if (buffsOnUnit.Count == 1)
				{
					buffsByUnit.Remove(buff.Target);
				}
				else
				{
					buffsOnUnit.Remove(buff);
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
			PlayerUnitEvents.Register(UnitTypeEvent.ChangesOwner, OnUnitTypeChangesOwner);
		}

		private static void OnUnitTypeChangesOwner()
		{
			var unit = GetTriggerUnit();
			if (GetUnitTypeId(unit) == DummySystem.UNIT_TYPE_DUMMY)
				return;

			for (var i = 1; i <= buffs.Count; i++)
			{
				if (buffs.DirectGet(i).Caster == unit)
				{
					buffs.DirectGet(i).CastingPlayer = GetOwningPlayer(unit);
				}
			}

			var owner = GetOwningPlayer(unit);
			var list = GetBuffsOnUnit(unit);
			for (var i = 1; i <= list.Count; i++)
			{
				list.DirectGet(i).TargetPlayer = owner;
			}
		}

		/// <summary>
		/// Uses a dictionary to quickly find all buffs attached to the given unit.
		/// </summary>
		public static IList<Buff> GetBuffsOnUnit(unit unit)
		{
			return buffsByUnit.TryGetValue(unit, out var buffsOnUnit)
				? buffsOnUnit.Where(x => x.Active).ToList()
				: Array.Empty<Buff>();
		}

		/// <summary>
		/// Attempts to dispel buffs from the target. Buff types are ignored.
		/// </summary>
		/// <param name="target">The target to dispel from.</param>
		/// <param name="dispeller">The caster of the dispel effect.</param>
		/// <param name="isBeneficial">Whether to dispel beneficial or detrimental buffs.</param>
		/// <param name="dispelAmount">The maximum number of buffs to dispel.</param>
		/// <returns>All dispels.</returns>
		public static List<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount)
		{
			var dispels = new List<Dispel>();
			var list = GetBuffsOnUnit(target);
			for (var i = 1; i <= list.Count; i++)
			{
				var buff = list.DirectGet(i);
				if (buff.IsBeneficial == isBeneficial)
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.RemoveInstantly();
					}

					dispels.Add(new Dispel(buff, chargesConsumed, stacks - buff.Stacks));

					if (dispelAmount <= 0)
						break;
				}
			}
			return dispels;
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
		public static List<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, string dispelType)
		{
			var dispels = new List<Dispel>();
			var list = GetBuffsOnUnit(target);
			for (var i = 1; i <= list.Count; i++)
			{
				var buff = list.DirectGet(i);
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Contains(dispelType))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.RemoveInstantly();
					}

					dispels.Add(new Dispel(buff, chargesConsumed, stacks - buff.Stacks));

					if (dispelAmount <= 0)
						break;
				}
			}
			return dispels;
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
		public static List<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, params string[] dispelTypes)
		{
			var dispels = new List<Dispel>();
			var list = GetBuffsOnUnit(target);
			for (var i = 1; i <= list.Count; i++)
			{
				var buff = list.DirectGet(i);
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.RemoveInstantly();
					}

					dispels.Add(new Dispel(buff, chargesConsumed, stacks - buff.Stacks));

					if (dispelAmount <= 0)
						break;
				}
			}
			return dispels;
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
		public static List<Dispel> Dispel(unit target, unit dispeller, bool isBeneficial, int dispelAmount, List<string> dispelTypes, List<string> exclusions)
		{
			var dispels = new List<Dispel>();
			var list = GetBuffsOnUnit(target);
			for (var i = 1; i <= list.Count; i++)
			{
				var buff = list.DirectGet(i);
				if (buff.IsBeneficial == isBeneficial && buff.BuffTypes.Any(x => dispelTypes.Contains(x)) && !buff.BuffTypes.Any(x => exclusions.Contains(x)))
				{
					var stacks = buff.Stacks;
					var chargesConsumed = buff.OnDispel(dispeller, dispelAmount);
					dispelAmount -= chargesConsumed;

					if (buff.Stacks == 0)
					{
						buff.RemoveInstantly();
					}

					dispels.Add(new Dispel(buff, chargesConsumed, stacks - buff.Stacks));

					if (dispelAmount <= 0)
						break;
				}
			}
			return dispels;
		}

		/// <summary>
		/// The interval between each update of the system.
		/// <para>Use <see cref="SetTickInterval(float)"/> to adjust.</para>
		/// </summary>
		public static float TickInterval { get; private set; } = TimerSystem.DEFAULT_TICK_INTERVAL;
		/// <summary>
		/// Changes the tick interval to the desired value.
		/// <para>Note that the actual change occurs after a 0 second delay.</para>
		/// <para>Calls <see cref="Buff.BeforeTickIntervalChanged(float, float)"/> to adjust existing missiles.</para>
		/// </summary>
		public static void SetTickInterval(float tickInterval)
		{
			Delay.Add(() =>
			{
				var old = TickInterval;
				if (old != tickInterval)
				{
					foreach (var buff in buffs)
					{
						buff.BeforeTickIntervalChanged(old, tickInterval);
					}
					TickInterval = tickInterval;
					timer.SetTimeout(tickInterval);
				}
			});
		}
	}
}
