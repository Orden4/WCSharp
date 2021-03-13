namespace WCSharp.Sync
{
	/// <summary>
	/// Represents a single packet of 255 characters being sent via sync. To send as much as possible per packet, the property names are shortened.
	/// </summary>
	internal class SyncPacket
	{
		/// <summary>
		/// PlayerId.
		/// </summary>
		public int P { get; set; }
		/// <summary>
		/// Message. Maximum <see cref="SyncSystem.PACKET_SIZE"/> characters long.
		/// </summary>
		public string M { get; set; }
	}
}
