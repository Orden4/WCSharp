using System;

namespace WCSharp.Api.Enums
{
	[Flags]
	public enum PathingTypes
	{
		None = 0,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_WALKABILITY"/>.
		/// </summary>
		Walkable = 1 << 1,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_FLYABILITY"/>.
		/// </summary>
		Flyable = 1 << 2,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_BUILDABILITY"/>.
		/// </summary>
		Buildable = 1 << 3,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_PEONHARVESTPATHING"/>.
		/// </summary>
		Harvest = 1 << 4,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_BLIGHTPATHING"/>.
		/// </summary>
		Blighted = 1 << 5,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_FLOATABILITY"/>.
		/// </summary>
		Sea = 1 << 6,
		/// <summary>
		/// Based on <see cref="Common.PATHING_TYPE_PEONHARVESTPATHING"/>.
		/// </summary>
		Amphibious = 1 << 7,
		/// <summary>
		/// Based on (the inverse of) <see cref="Common.PATHING_FLAG_UNITEMPLACABLE"/>.
		/// </summary>
		Item = 1 << 8,
	}
}
