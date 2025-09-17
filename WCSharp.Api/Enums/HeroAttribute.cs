namespace WCSharp.Api.Enums
{
	/// <summary>
	/// The possible attributes a hero can have.
	/// </summary>
	public enum HeroAttribute
	{
		/// <summary>
		/// Not a hero/invalid.
		/// </summary>
		None = 0,
		/// <summary>
		/// Corresponds to <see cref="Common.HERO_ATTRIBUTE_STR"/>.
		/// </summary>
		Strength = 1,
		/// <summary>
		/// Corresponds to <see cref="Common.HERO_ATTRIBUTE_INT"/>.
		/// </summary>
		Intelligence = 2,
		/// <summary>
		/// Corresponds to <see cref="Common.HERO_ATTRIBUTE_AGI"/>.
		/// </summary>
		Agility = 3,
	}
}
