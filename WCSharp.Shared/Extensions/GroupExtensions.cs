using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Shared.Extensions
{
	/// <summary>
	/// Extension class that defines a number of methods to simplify working with Warcraft III groups.
	/// </summary>
	public static class GroupExtensions
	{
		/// <summary>
		/// Enumerates all units within the <paramref name="group"/>. This will empty the group in the process.
		/// </summary>
		[Obsolete("Use one of the new extension methods instead: FirstOrDefault, ToList, ToHashSet. Due to list enumeration being notably faster, these are always faster.")]
		public static IEnumerable<unit> Enumerate(this group group)
		{
			while (true)
			{
				var unit = FirstOfGroup(group);
				if (unit == null)
				{
					yield break;
				}
				else
				{
					GroupRemoveUnit(group, unit);
					yield return unit;
				}
			}
		}

		/// <summary>
		/// Enumerates all units within the group that match the given filter. This will empty the group in the process.
		/// </summary>
		[Obsolete("Use one of the new extension methods instead: FirstOrDefault, ToList, ToHashSet. Due to list enumeration being notably faster, these are always faster.")]
		public static IEnumerable<unit> Enumerate(this group group, Func<unit, bool> filter)
		{
			while (true)
			{
				var unit = FirstOfGroup(group);
				if (unit == null)
				{
					yield break;
				}
				else
				{
					GroupRemoveUnit(group, unit);
					if (filter.Invoke(unit))
					{
						yield return unit;
					}
				}
			}
		}

		/// <summary>
		/// Finds the first unit in the <paramref name="group"/> that matches the given <paramref name="predicate"/>.
		/// <para>If you need to call this more than once, use ToList and Linq methods instead.</para>
		/// </summary>
		public static unit FirstOrDefault(this group group, Func<unit, bool> predicate)
		{
			var i = 0;
			while (true)
			{
				var unit = BlzGroupUnitAt(group, i);
				if (unit == null)
				{
					return null;
				}
				else if (predicate.Invoke(unit))
				{
					return unit;
				}
				i++;
			}
		}

		/// <summary>
		/// Returns a <see cref="List{unit}"/> containing all units within the given <paramref name="group"/>.
		/// </summary>
		public static List<unit> ToList(this group group)
		{
			var size = BlzGroupGetSize(group);
			var list = new List<unit>();
			for (var i = 0; i < size; i++)
			{
				list.Add(BlzGroupUnitAt(group, i));
			}
			return list;
		}

		/// <summary>
		/// Returns a <see cref="List{unit}"/> containing all units within the given <paramref name="group"/> that match the <paramref name="predicate"/>.
		/// </summary>
		public static List<unit> ToList(this group group, Func<unit, bool> predicate)
		{
			var size = BlzGroupGetSize(group);
			var list = new List<unit>();
			for (var i = 0; i < size; i++)
			{
				var unit = BlzGroupUnitAt(group, i);
				if (predicate.Invoke(unit))
				{
					list.Add(unit);
				}
			}
			return list;
		}

		/// <summary>
		/// Returns a <see cref="HashSet{unit}"/> containing all units within the given <paramref name="group"/>.
		/// </summary>
		public static HashSet<unit> ToHashSet(this group group)
		{
			var size = BlzGroupGetSize(group);
			var hashSet = new HashSet<unit>();
			for (var i = 0; i < size; i++)
			{
				hashSet.Add(BlzGroupUnitAt(group, i));
			}
			return hashSet;
		}

		/// <summary>
		/// Returns a <see cref="HashSet{unit}"/> containing all units within the given <paramref name="group"/> that match the <paramref name="predicate"/>.
		/// </summary>
		public static HashSet<unit> ToHashSet(this group group, Func<unit, bool> predicate)
		{
			var size = BlzGroupGetSize(group);
			var hashSet = new HashSet<unit>();
			for (var i = 0; i < size; i++)
			{
				var unit = BlzGroupUnitAt(group, i);
				if (predicate.Invoke(unit))
				{
					hashSet.Add(unit);
				}
			}
			return hashSet;
		}
	}
}
