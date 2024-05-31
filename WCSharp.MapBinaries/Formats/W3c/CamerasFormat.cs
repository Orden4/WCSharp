namespace WCSharp.MapBinaries.Formats.W3c
{
	public class CamerasFormat
	{
		public int Version { get; set; }
		public List<Camera> Cameras { get; } = new();
	}
}
