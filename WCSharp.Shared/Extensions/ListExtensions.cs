using System;
using System.Collections.Generic;

namespace WCSharp.Utils.Extensions
{
	/// <summary>
	/// Extension class that defines a number of methods to simplify working with lists, in particular within context of Warcraft III.
	/// </summary>
	public static class ListExtensions
	{
		/// <summary>
		/// Due to C# to Lua conversion difficulties, standard ways of enumerating a list while removing items from it may not work.
		/// This extension method will safely iterate the list, and remove any which return false.
		/// </summary>
		public static void IterateWithRemoval<T>(this IList<T> list, Func<T, bool> func)
		{
			var size = list.Count;
			var i = 0;
			while (i < size)
			{
				if (func.Invoke(list[i]))
				{
					i++;
				}
				else
				{
					size--;
					list[i] = list[size];
					list.RemoveAt(size);
				}
			}
		}
	}
}
