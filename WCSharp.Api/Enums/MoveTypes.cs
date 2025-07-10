using System;

namespace WCSharp.Api.Enums
{
	[Flags]
	public enum MoveTypes
	{
		None = 0,
		Foot = 1 << 0,
		Fly = 1 << 1,
		Horse = 1 << 2,
		Hover = 1 << 3,
		Float = 1 << 4,
		Amphibian = 1 << 5,
		Unbuildable = 1 << 6,
	}
}
