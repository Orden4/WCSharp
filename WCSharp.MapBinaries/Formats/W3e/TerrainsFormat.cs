namespace WCSharp.MapBinaries.Formats.W3e
{
	public class TerrainsFormat
	{
		public int Version { get; set; }
		public Tileset Tileset { get; set; }
		public bool UsesCustomTileset { get; set; }
		public List<string> GroundTilesets { get; } = new();
		public List<string> CliffTilesets { get; } = new();
		public int Width { get; set; }
		public int Height { get; set; }
		public float HorizontalOffset { get; set; }
		public float VerticalOffset { get; set; }
		public List<TerrainTile> Tiles { get; } = new();
	}
}
