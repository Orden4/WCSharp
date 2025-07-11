using System;

namespace WCSharp.Api.Enums
{
	[Flags]
	public enum MoveTypes
	{
		None = 0,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_FOOT"/>.
		/// </summary>
		Foot = 1 << 0,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_FLY"/>.
		/// </summary>
		Fly = 1 << 1,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_HORSE"/>.
		/// </summary>
		Horse = 1 << 2,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_HOVER"/>.
		/// </summary>
		Hover = 1 << 3,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_FLOAT"/>.
		/// </summary>
		Float = 1 << 4,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_AMPHIBIOUS"/>.
		/// </summary>
		Amphibious = 1 << 5,
		/// <summary>
		/// Corresponds to <see cref="Common.MOVE_TYPE_UNBUILDABLE"/>.
		/// </summary>
		Unbuildable = 1 << 6,
	}
}
