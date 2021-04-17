using System.Collections.Generic;
using System.Text;

namespace WCSharp.Sync
{
	internal class SyncMessage
	{
		public SyncHeader SyncHeader { get; }
		public List<SyncPacket> Packets { get; }
		public bool IsComplete => SyncHeader.PacketCount == Packets.Count;

		public SyncMessage(SyncHeader header)
		{
			SyncHeader = header;
			Packets = new List<SyncPacket>();
		}

		public string GetContents()
		{
			var sb = new StringBuilder();
			for (var i = 0; i < Packets.Count; i++)
			{
				sb.Append(Packets[i].M);
			}
			return sb.ToString();
		}
	}
}
