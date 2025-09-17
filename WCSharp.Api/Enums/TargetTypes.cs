using System;

namespace WCSharp.Api.Enums
{
	[Flags]
	public enum TargetTypes
	{
		/// <summary>
		/// This flag prohibits attacking, regardless of any other flags being set.
		/// <para>A unit will have the attack ability and display attack info, but cannot target anything.</para>
		/// <para>If only <see cref="None"/> is set, the UI will not display attack info, but will still show the attack ability.</para>
		/// </summary>
		None = 1 << 0,

		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Ground = 1 << 1,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Air = 1 << 2,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Structure = 1 << 3,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Ward = 1 << 4,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Item = 1 << 5,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Tree = 1 << 6,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Wall = 1 << 7,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Debris = 1 << 8,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Decoration = 1 << 9,
		/// <summary>
		/// Part of the <see cref="PrimaryMask"/>.
		/// </summary>
		Bridge = 1 << 10,
		/// <summary>
		/// Everything within the primary target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		PrimaryMask = Ground | Air | Structure | Ward | Item | Tree | Wall | Debris | Decoration | Bridge,

		/// <summary>
		/// Part of the <see cref="AlliancesMask"/>.
		/// </summary>
		Self = 1 << 12,
		/// <summary>
		/// Part of the <see cref="AlliancesMask"/>.
		/// </summary>
		PlayerUnits = 1 << 13,
		/// <summary>
		/// Part of the <see cref="AlliancesMask"/>.
		/// </summary>
		Allied = 1 << 14,
		/// <summary>
		/// Part of the <see cref="AlliancesMask"/>.
		/// </summary>
		Neutral = 1 << 15,
		/// <summary>
		/// Part of the <see cref="AlliancesMask"/>.
		/// </summary>
		Enemy = 1 << 16,
		/// <summary>
		/// Shorthand for being able to target any sort of friendly unit, as it appears in the World Editor.
		/// </summary>
		Friend = PlayerUnits | Allied,
		/// <summary>
		/// Shorthand for being able to target anything except self, as it appears in the World Editor.
		/// </summary>
		NotSelf = PlayerUnits | Allied | Neutral | Enemy,
		/// <summary>
		/// Everything within the alliances target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		AlliancesMask = Self | PlayerUnits | Allied | Neutral | Enemy,

		/// <summary>
		/// Part of the <see cref="VulnerabilityMask"/>.
		/// </summary>
		Vulnerable = 1 << 20,
		/// <summary>
		/// Part of the <see cref="VulnerabilityMask"/>.
		/// </summary>
		Invulnerable = 1 << 21,
		/// <summary>
		/// Everything within the vulnerability target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		VulnerabilityMask = Vulnerable | Invulnerable,

		/// <summary>
		/// Part of the <see cref="HeroMask"/>.
		/// </summary>
		Hero = 1 << 22,
		/// <summary>
		/// Part of the <see cref="HeroMask"/>.
		/// </summary>
		NonHero = 1 << 23,
		/// <summary>
		/// Everything within the hero target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		HeroMask = Hero | NonHero,

		/// <summary>
		/// Part of the <see cref="LifeMask"/>.
		/// </summary>
		Alive = 1 << 24,
		/// <summary>
		/// Part of the <see cref="LifeMask"/>.
		/// </summary>
		Dead = 1 << 25,
		/// <summary>
		/// Everything within the life target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		LifeMask = Alive | Dead,

		/// <summary>
		/// Part of the <see cref="CompositionMask"/>.
		/// </summary>
		Organic = 1 << 26,
		/// <summary>
		/// Part of the <see cref="CompositionMask"/>.
		/// </summary>
		Mechanical = 1 << 27,
		/// <summary>
		/// Everything within the composition target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		CompositionMask = Organic | Mechanical,

		/// <summary>
		/// Part of the <see cref="SuicidalMask"/>.
		/// <para>Also known as "Non-Sapper".</para>
		/// </summary>
		NonSuicidal = 1 << 28,
		/// <summary>
		/// Part of the <see cref="SuicidalMask"/>.
		/// <para>Also known as "Sapper".</para>
		/// </summary>
		Suicidal = 1 << 29,
		/// <summary>
		/// Everything within the suicidal target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		SuicidalMask = NonSuicidal | Suicidal,

		/// <summary>
		/// Part of the <see cref="AncientMask"/>.
		/// </summary>
		NonAncient = 1 << 30,
		/// <summary>
		/// Part of the <see cref="AncientMask"/>.
		/// </summary>
		Ancient = 1 << 31,
		/// <summary>
		/// Everything within the ancient target types mask.
		/// <para>For the purposes of targeting, the values covered by a mask (think of it as a category) are considered as "or",
		/// while the masks as a whole are considered as "and".</para>
		/// <para>If no values within a mask are set, it essentially considers it as if all values are set (as long as at least one of the masks is used).</para>
		/// </summary>
		AncientMask = NonAncient | Ancient,
	}
}
