namespace WCSharp.SaveLoad
{
	internal class Save<T>
		where T : Saveable
	{
		public int Version { get; set; }
		public int HashCode { get; set; }
		public T SaveData { get; set; }
		public string SaveString { get; set; }
	}
}
