namespace WCSharp.Api.Enums
{
	/// <summary>
	/// Dictates the way in which an image is rendered.
	/// </summary>
	public enum ImageType
	{
		/// <summary>
		/// Causes CreateImage to return image(-1).
		/// </summary>
		None = 0,
		/// <summary>
		/// Drawn above all other imageTypes.
		/// </summary>
		Selection = 1,
		/// <summary>
		/// Drawn above imageType 4, but below 1 and 3.
		/// </summary>
		Indicator = 2,
		/// <summary>
		/// Drawn above imageType 4 and 2 and below imageType 1.
		/// </summary>
		OcclusionMask = 3,
		/// <summary>
		/// Drawn below every other type. Images of this type are additionally affected by time of day and the fog of war (only for tinting).
		/// </summary>
		Ubersplat = 4,
	}
}
