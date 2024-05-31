using WCSharp.MapBinaries.Formats.Shared;

namespace WCSharp.MapBinaries.Formats.W3r
{
	public class Region
	{
		public required Rect Position { get; set; }
		public required string Name { get; set; }
		public int Id { get; set; }
		public required string WeatherEffect { get; set; }
		public required string AmbientSound { get; set; }
		public required ColorRgb Color { get; set; }
	}
}
