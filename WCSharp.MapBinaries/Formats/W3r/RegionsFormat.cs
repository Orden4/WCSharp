namespace WCSharp.MapBinaries.Formats.W3r
{
	public class RegionsFormat
	{
		public int Version { get; set; }
		public List<Region> Regions { get; } = new();
	}
}
