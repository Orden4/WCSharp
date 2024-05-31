namespace WCSharp.MapBinaries.Formats.W3s
{
	public class SoundsFormat
	{
		public int Version { get; set; }
		public List<Sound> Sounds { get; } = new();
	}
}
