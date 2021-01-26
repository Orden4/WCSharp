using static War3Api.Common;

namespace WCSharp.SaveLoad
{
	internal class SyncMessage
	{
		public player Player { get; set; }
		public int SaveSlot { get; set; }
		public int MessagesRemaining { get; set; }
		public string Data { get; set; }

		public SyncMessage(player player, int saveSlot, int messagesRemaining)
		{
			Player = player;
			SaveSlot = saveSlot;
			MessagesRemaining = messagesRemaining;
			Data = "";
		}

		public Save ToSave()
		{
			return new Save(Player, SaveSlot, Data);
		}
	}
}
