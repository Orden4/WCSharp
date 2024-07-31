using System;

namespace WCSharp.Api.Enums
{
	[Flags]
	public enum TargetsAllowed
	{
		/// <summary>
		/// This flag prohibits attacking, regardless of any other flags being set.
		/// <para>A unit will have the attack ability and display attack info, but cannot target anything.</para>
		/// <para>If only <see cref="None"/> is set, the UI will not display attack info, but will still show the attack ability.</para>
		/// </summary>
		None = 1 << 0,
		Ground = 1 << 1,
		Air = 1 << 2,
		Structure = 1 << 3,
		Ward = 1 << 4,
		Item = 1 << 5,
		Tree = 1 << 6,
		Wall = 1 << 7,
		Debris = 1 << 8,
		Decoration = 1 << 9,
		Bridge = 1 << 10,

		Self = 1 << 12,
		PlayerUnits = 1 << 13,
		Allied = 1 << 14,
		Neutral = 1 << 15,
		Enemy = 1 << 16,

		Vulnerable = 1 << 20,
		Invulnerable = 1 << 21,
		Hero = 1 << 22,
		NonHero = 1 << 23,
		Alive = 1 << 24,
		Dead = 1 << 25,
		Organic = 1 << 26,
		Mechanical = 1 << 27,
		/// <summary>
		/// Also known as "Non-Sapper".
		/// </summary>
		NonSuicidal = 1 << 28,
		/// <summary>
		/// Also known as "Sapper".
		/// </summary>
		Suicidal = 1 << 29,
		NonAncient = 1 << 30,
		Ancient = 1 << 31,

		NotSelf = PlayerUnits | Allied | Neutral | Enemy,
		Friend = PlayerUnits | Allied,
	}
}
