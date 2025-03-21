using System;
using System.Collections.Generic;

namespace WCSharp.Shared.Extensions
{
	/// <summary>
	/// Extension class that defines a number of methods to simplify working with lists, in particular within context of Warcraft III.
	/// </summary>
	public static class IListExtensions
	{
		/// <summary>
		/// Due to C# to Lua conversion difficulties, standard ways of enumerating a list while removing items from it may not work.
		/// This extension method will safely iterate the list, and remove any which return false.
		/// <para>Alternatively, you can use a standard reverse order iteration, as this will still work correctly.</para>
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

#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final element.
		/// <para>If you already know the size of the list, use <see cref="Nil{T}(List{T}, int)"/> instead.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// @CSharpLua.Template = "{0}[#{0}] = nil"
		public static extern void Nil<T>(this List<T> list);
		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final element.
		/// <para>WARNING! If <paramref name="count"/> is NOT equal to <see cref="List{T}.Count"/>, you WILL cause major bugs!</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="count">This MUST be equal to <see cref="List{T}.Count"/>, else you WILL cause major bugs!</param>
		/// @CSharpLua.Template = "{0}[{1}] = nil"
		public static extern void Nil<T>(this List<T> list, int count);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it

		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final elements.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list to modify.</param>
		/// <param name="amount">The number of elements to remove.</param>
		public static void ClearLast<T>(this List<T> list, int amount)
		{
			var count = list.Count;
			var end = count - amount;
			while (end < count)
			{
				list.Nil(count);
				count--;
			}
		}

		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final elements.
		/// <para>WARNING! If <paramref name="count"/> is NOT equal to <see cref="List{T}.Count"/>, you WILL cause major bugs!</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list to modify.</param>
		/// <param name="amount">The number of elements to remove.</param>
		/// <param name="count">This MUST be equal to <see cref="List{T}.Count"/>, else you WILL cause major bugs!</param>
		public static void ClearLast<T>(this List<T> list, int amount, int count)
		{
			var end = count - amount;
			while (end < count)
			{
				list.Nil(count);
				count--;
			}
		}
	}
}
