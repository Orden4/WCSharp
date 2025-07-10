using System;

namespace WCSharp.Api.Enums
{
	/// <summary>
	/// All unit classifications, also known as unit categories.
	/// </summary>
	[Flags]
	public enum UnitClassifications
	{
		None = 0,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_GIANT"/>.
		/// </summary>
		Giant = 1 << 0,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_UNDEAD"/>.
		/// </summary>
		Undead = 1 << 1,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_SUMMONED"/>.
		/// </summary>
		Summoned = 1 << 2,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_MECHANICAL"/>.
		/// </summary>
		Mechanical = 1 << 3,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_PEON"/>.
		/// </summary>
		Worker = 1 << 4,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_SAPPER"/>.
		/// </summary>
		Suicidal = 1 << 5,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_TOWNHALL"/>.
		/// </summary>
		TownHall = 1 << 6,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_ANCIENT"/>.
		/// </summary>
		Ancient = 1 << 7,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_NEUTRAL"/>.
		/// </summary>
		Neutral = 1 << 8,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_WARD"/>.
		/// </summary>
		Ward = 1 << 9,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_STANDON"/>.
		/// </summary>
		Walkable = 1 << 10,
		/// <summary>
		/// Corresponds to <see cref="Common.UNIT_CATEGORY_TAUREN"/>.
		/// </summary>
		Tauren = 1 << 11,
	}
}
