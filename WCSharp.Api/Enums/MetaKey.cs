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
		Shift = 1,
		Control = 2,
		Alt = 4,
		/// <summary>
		/// Windows key.
		/// </summary>
		META = 8,
	}
}
