using System.Collections.Generic;
using System.Linq;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	public static class BuffSystem
	{
		private static readonly PeriodicTrigger<Buff> periodicTrigger = new PeriodicTrigger<Buff>(PeriodicEvents.SYSTEM_INTERVAL);
		public static IEnumerable<Buff> Buffs => periodicTrigger.Actions;

		internal static readonly Dictionary<int, List<Buff>> buffsByHandleId = new Dictionary<int, List<Buff>>();

		/// <summary>
		/// Adds the given buffs to the system. This will also initialise or alter some values according to the buffs' properties.
		/// </summary>
		public static void Add(Buff buff)
		{
			buff.Apply();
			periodicTrigger.Add(buff);
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
