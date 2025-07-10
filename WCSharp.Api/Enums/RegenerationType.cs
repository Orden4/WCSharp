using System;

namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Decides when regeneration is active.
	/// </summary>
	[Flags]
	public enum RegenerationType
	{
		/// <summary>
		/// Corresponds to <see cref="Common.REGENERATION_TYPE_NONE"/>.
		/// </summary>
		Never = 0,
		/// <summary>
		/// Corresponds to <see cref="Common.REGENERATION_TYPE_ALWAYS"/>.
		/// </summary>
		Always = 1,
		/// <summary>
		/// Corresponds to <see cref="Common.REGENERATION_TYPE_BLIGHT"/>.
		/// </summary>
		Blight = 2,
		/// <summary>
		/// Corresponds to <see cref="Common.REGENERATION_TYPE_DAY"/>.
		/// </summary>
		Day = 3,
		/// <summary>
		/// Corresponds to <see cref="Common.REGENERATION_TYPE_NIGHT"/>.
		/// </summary>
		Night = 4,
	}
}
