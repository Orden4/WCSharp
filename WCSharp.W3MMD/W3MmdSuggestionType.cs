namespace WCSharp.W3MMD
{
	/// <summary>
	/// A suggestion for what the parser should do for tracking the variable.
	/// </summary>
	public enum W3MmdSuggestionType
	{
		/// <summary>
		/// Nothing.
		/// </summary>
		None,
		/// <summary>
		/// Variable should be tracked.
		/// </summary>
		Track,
		/// <summary>
		/// Variable should appear on a leaderboard.
		/// </summary>
		Leaderboard
	}
}
