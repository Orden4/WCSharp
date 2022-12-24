namespace WCSharp.SaveLoad
{
	/// <summary>
	/// Indicates the state of the loaded save file.
	/// </summary>
	public enum LoadResult
	{
		/// <summary>
		/// Indicates that no existing save was found and a new one was created.
		/// </summary>
		NewSave = 0,
		/// <summary>
		/// Indicates that the Base64 decoding of the save failed.
		/// <para>This could be the result of a faulty version upgrade, or because the save was tampered with.</para>
		/// </summary>
		FailedDecode = 1,
		/// <summary>
		/// Indicates that the deserialization of the save failed.
		/// <para>This is likely the result of a faulty version upgrade, but could also indicate save tampering.</para>
		/// </summary>
		FailedDeserialize = 2,
		/// <summary>
		/// Indicates that the hash of the save did not match.
		/// <para>This likely means that the save was tampered with.</para>
		/// </summary>
		FailedHash = 3,
		/// <summary>
		/// Indicates that an existing save was loaded successfully.
		/// </summary>
		Success = 4
	}

	/// <summary>
	/// Extension class for <see cref="LoadResult"/>s.
	/// </summary>
	public static class LoadResultExtensions
	{
		/// <summary>
		/// Extension method for determining whether the load result is any of the failed states.
		/// </summary>
		public static bool Failed(this LoadResult r)
		{
			return r != LoadResult.NewSave && r != LoadResult.Success;
		}
	}
}
