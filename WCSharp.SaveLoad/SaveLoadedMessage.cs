namespace WCSharp.SaveLoad
{
	internal class SaveLoadedMessage<T>
		where T : Saveable
	{
		public int PlayerId { get; set; }
		public int SaveSlot { get; set; }
		public LoadResult LoadResult { get; set; }
		public T SaveData { get; set; }
	}
}
