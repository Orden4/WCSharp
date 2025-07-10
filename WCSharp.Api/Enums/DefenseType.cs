namespace WCSharp.Api.Enums
{
	/// <summary>
	/// <para>Defense types used to alter incoming damage.</para>
	/// <para><b>Note:</b> <see cref="Light"/>, <see cref="Fort"/> and <see cref="None"/> have inconsistent names between the editor and the code.</para>
	/// </summary>
	public enum DefenseType
	{
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_LIGHT"/></para>
		/// <para>Known in the editor as <c>Small</c>.</para>
		/// </summary>
		Light = 0,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_MEDIUM"/></para>
		/// <para>Known in the editor as <c>Medium</c>.</para>
		/// </summary>
		Medium = 1,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_LARGE"/></para>
		/// <para>Known in the editor as <c>Large</c>.</para>
		/// </summary>
		Large = 2,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_FORT"/></para>
		/// <para>Known in the editor as <c>Fortified</c>.</para>
		/// </summary>
		Fort = 3,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_NORMAL"/></para>
		/// <para>Known in the editor as <c>Normal</c>.</para>
		/// </summary>
		Normal = 4,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_HERO"/></para>
		/// <para>Known in the editor as <c>Hero</c>.</para>
		/// </summary>
		Hero = 5,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_DIVINE"/></para>
		/// <para>Known in the editor as <c>Divine</c>.</para>
		/// </summary>
		Divine = 6,
		/// <summary>
		/// <para>Corresponds to <see cref="Common.DEFENSE_TYPE_NONE"/></para>
		/// <para>Known in the editor as <c>Unarmored</c>.</para>
		/// </summary>
		None = 7,
	}
}
