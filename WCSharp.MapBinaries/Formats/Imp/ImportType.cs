namespace WCSharp.MapBinaries.Formats.Imp
{
	public enum ImportType
	{
		/// <summary>
		/// Ideally use <see cref="Standard8"/> instead.
		/// </summary>
		Standard0 = 0,
		/// <summary>
		/// Ideally use <see cref="Standard8"/> instead.
		/// </summary>
		Standard5 = 5,
		/// <summary>
		/// Preferred standard variant.
		/// </summary>
		Standard8 = 8,
		/// <summary>
		/// Ideally use <see cref="Custom13"/> instead.
		/// </summary>
		Custom10 = 10,
		/// <summary>
		/// Preferred custom variant.
		/// </summary>
		Custom13 = 13
	}

	public static class ImportTypeExtensions
	{
		public static bool IsStandard(this ImportType type)
		{
			return type == ImportType.Standard0 || type == ImportType.Standard5 || type == ImportType.Standard8;
		}

		public static bool IsCustom(this ImportType type)
		{
			return type == ImportType.Custom10 || type == ImportType.Custom13;
		}
	}
}
