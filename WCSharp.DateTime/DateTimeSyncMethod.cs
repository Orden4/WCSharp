namespace WCSharp.DateTime
{
	public enum DateTimeSyncMethod
	{
		/// <summary>
		/// Picks the earliest time among all players.
		/// </summary>
		Earliest,
		/// <summary>
		/// Picks the latest time among all players.
		/// </summary>
		Latest,
		/// <summary>
		/// Picks the average time of all players.
		/// </summary>
		Average,
		/// <summary>
		/// Picks a time that minimizes the time difference of the chosen time compared to that of all players.
		/// <para>In practice, this means it will pick the middle player on uneven player counts, or the average of the middle two players on even player counts.</para>
		/// </summary>
		BestFit
	}
}
