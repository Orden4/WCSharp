namespace WCSharp.SaveLoad
{
	public class SaveLoadedMessage
	{
		public int PlayerId { get; set; }
		public int SaveSlot { get; set; }
		public string TypeName { get; set; }
		public string SaveData { get; set; }
	}
}
