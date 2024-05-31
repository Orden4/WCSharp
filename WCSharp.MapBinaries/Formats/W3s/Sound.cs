namespace WCSharp.MapBinaries.Formats.W3s
{
	public class Sound
	{
		public required string Name { get; set; }
		public required string VariableName { get; set; }
		public required string Path { get; set; }
		public required string Eax { get; set; }
		public SoundFlags Flags { get; set; }
		public required FadeRate FadeRate { get; set; }
		public int Volume { get; set; }
		public float Pitch { get; set; }
		public float Channel { get; set; }
		public required Distance Distance { get; set; }
	}
}
