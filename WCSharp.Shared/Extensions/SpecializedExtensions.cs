using System.Collections.Generic;
using System.ComponentModel;
namespace WCSharp.Shared.Extensions
{
	/// <summary>
	/// Contains a number of methods that are specialised for lua to improve performance.
	/// <para>It is strongly recommended that you do not use these.</para>
	/// </summary>
	public static class SpecializedExtensions
	{
		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final element.
		/// <para>If you already know the size of the list, use <see cref="DirectNil{T}(List{T}, int)"/> instead.</para>
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// @CSharpLua.Template = "{0}[#{0}] = nil"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectNil<T>(this List<T> list);

		/// <summary>
		/// Abuses how lists work in lua in order to cheaply remove the final element.
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> <paramref name="count"/> must be equal to <see cref="List{T}.Count"/>.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="count">This should always be equal to <see cref="List{T}.Count"/>.</param>
		/// @CSharpLua.Template = "{0}[{1}] = nil"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectNil<T>(this List<T> list, int count);

		/// <summary>
		/// Moves the final element to the given index, then removes the final element.
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> <paramref name="count"/> must be equal to <see cref="List{T}.Count"/>.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="index">The index to move the final item to.</param>
		/// <param name="count">This should always be equal to <see cref="List{T}.Count"/>.</param>
		/// @CSharpLua.Template = "{0}[{1}], {0}[{2}] = {0}[{2}], nil"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectNilShift<T>(this List<T> list, int index, int count);

		/// <summary>
		/// Slightly more efficient way to add an item to an array or list.
		/// <para>If you already know the size of the list, use <see cref="DirectSet{T}(IList{T}, T, int)"/> instead.</para>
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Do not use if <paramref name="item"/> may be <see langword="null"/>.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="item">The item to add.</param>
		/// @CSharpLua.Template = "{0}[#{0}] = {1}"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectAdd<T>(this List<T> list, T item);

		/// <summary>
		/// Slightly more efficient way to set or add an item to a list.
		/// <para>Can be used to add as long as <paramref name="index"/> is equal to <paramref name="list"/>.Count.</para>
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Do not use if <paramref name="item"/> may be <see langword="null"/>.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="item">The item to set/add.</param>
		/// <param name="index">The index to place it at.</param>
		/// @CSharpLua.Template = "{0}[{2}] = {1}"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectSet<T>(this IList<T> list, T item, int index);

		/// <summary>
		/// Slightly more efficient way to get an item from a list.
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Do not use if the value may be <see langword="null"/>.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// </summary>
		/// <param name="list">The list to retrieve from.</param>
		/// <param name="index">The index to get.</param>
		/// @CSharpLua.Template = "{0}[{1}]"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern T DirectGet<T>(this IList<T> list, int index);

		/// <summary>
		/// Slightly more efficient way to move an item to another index.
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="sourceIndex">The index of the item to be moved.</param>
		/// <param name="destinationIndex">The index to move to.</param>
		/// @CSharpLua.Template = "{0}[{2}] = {0}[{1}]"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectMove<T>(this IList<T> list, int sourceIndex, int destinationIndex);

		/// <summary>
		/// Slightly more efficient way to swap two items in a list.
		/// <para><b>Warning:</b> When using direct methods, indexing is 1-based.</para>
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <param name="list">The list to modify.</param>
		/// <param name="first">The first index.</param>
		/// <param name="second">The second index.</param>
		/// @CSharpLua.Template = "{0}[{1}], {0}[{2}] = {0}[{2}], {0}[{1}]"
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static extern void DirectSwap<T>(this IList<T> list, int first, int second);

		/// <summary>
		/// Slightly more efficient way to remove the final elements in a list.
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list to modify.</param>
		/// <param name="amount">The number of elements to remove.</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static void DirectNilLast<T>(this List<T> list, int amount)
		{
			var count = list.Count;
			var end = count - amount;
			while (end < count)
			{
				list.DirectNil(count);
				count--;
			}
		}

		/// <summary>
		/// Slightly more efficient way to remove the final elements in a list.
		/// <para><b>Warning:</b> Does not check for bounds.</para>
		/// <para><b>Warning:</b> The logic that checks for collections being changed during enumeration cannot detect this.</para>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list">The list to modify.</param>
		/// <param name="amount">The number of elements to remove.</param>
		/// <param name="count">This must be equal to <see cref="List{T}.Count"/>.</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static void DirectNilLast<T>(this List<T> list, int amount, int count)
		{
			var end = count - amount;
			while (end < count)
			{
				list.DirectNil(count);
				count--;
			}
		}
	}
}
