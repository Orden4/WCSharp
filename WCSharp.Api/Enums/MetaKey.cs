using System;

namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Specifies the modifier keys that must be active.
	/// </summary>
	[Flags]
	public enum MetaKey
	{
		None = 0,
		Shift = 1 << 0,
		Control = 1 << 1,
		Alt = 1 << 2,
		/// <summary>
		/// Windows/Super key.
		/// </summary>
		META = 1 << 3,
	}
}
