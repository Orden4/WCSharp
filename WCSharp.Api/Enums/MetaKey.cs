using System;

namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Specifies the modifier keys that must be active.
	/// </summary>
	[Flags]
	public enum MetaKey
	{
		/// <summary>
		/// No meta key was held.
		/// </summary>
		None = 0,
		/// <summary>
		/// The shift key was held.
		/// </summary>
		Shift = 1 << 0,
		/// <summary>
		/// The control key was held.
		/// </summary>
		Control = 1 << 1,
		/// <summary>
		/// The alt key was held.
		/// </summary>
		Alt = 1 << 2,
		/// <summary>
		/// The Windows/Super key was held.
		/// </summary>
		META = 1 << 3,
	}
}
