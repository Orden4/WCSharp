using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Utils.Extensions
{
	public static class GroupExtensions
	{
		/// <summary>
		/// Enumerates all units within the group. This will empty the group in the process.
		/// </summary>
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
	}
}
