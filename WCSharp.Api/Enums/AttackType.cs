namespace WCSharp.Api.Enums
{
	/// <summary>
	/// <para>Attack types used to deal damage.</para>
	/// <para><b>Note:</b> <see cref="Normal"/> and <see cref="Melee"/> have inconsistent names between the editor and the code.</para>
	/// </summary>
	public enum AttackType
	{
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_NORMAL"/></para>
		/// <para>Known in the editor as <c>Spells</c>.</para>
		/// </summary>
		Normal = 0,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_MELEE"/></para>
		/// <para>Known in the editor as <c>Normal</c>.</para>
		/// </summary>
		Melee = 1,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_PIERCE"/></para>
		/// <para>Known in the editor as <c>Pierce</c>.</para>
		/// </summary>
		Pierce = 2,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_SIEGE"/></para>
		/// <para>Known in the editor as <c>Siege</c>.</para>
		/// </summary>
		Siege = 3,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_MAGIC"/></para>
		/// <para>Known in the editor as <c>Magic</c>.</para>
		/// </summary>
		Magic = 4,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_CHAOS"/></para>
		/// <para>Known in the editor as <c>Chaos</c>.</para>
		/// </summary>
		Chaos = 5,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.ATTACK_TYPE_HERO"/></para>
		/// <para>Known in the editor as <c>Hero</c>.</para>
		/// </summary>
		Hero = 6,
	}
}
