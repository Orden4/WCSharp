namespace WCSharp.W3MMD
{
	/// <summary>
	/// Represents the state of the player.
	/// <para>For any particular player, only the last value set over the course of a game matters.</para>
	/// </summary>
	public enum W3MmdFlag
	{
		/// <summary>
		/// The player ended in a draw.
		/// </summary>
		Drawer,
		/// <summary>
		/// The player lost.
		/// </summary>
		Loser,
		/// <summary>
		/// The player won.
		/// </summary>
		Winner,
		/// <summary>
		/// The player left.
		/// </summary>
		Leaver,
		/// <summary>
		/// The player is practicing.
		/// </summary>
		Practicing
	}
}
