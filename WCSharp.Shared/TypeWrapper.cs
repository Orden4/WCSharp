namespace WCSharp.Shared
{
	/// <summary>
	/// Wrapper for WC3 handles to pass type inspection.
	/// <para>Sometimes some type casts or pattern matching is required for handles, however this doesn't work as they are not proper objects.</para>
	/// <para>By wrapping them in a C# object like this, we can properly cast and match handles.</para>
	/// </summary>
	public class TypeWrapper<T>
	{
		/// <summary>
		/// The value being wrapped.
		/// </summary>
		public T Value { get; }

		/// <summary>
		/// Wraps the given value in a C# type.
		/// </summary>
		public TypeWrapper(T value)
		{
			Value = value;
		}
	}
}
