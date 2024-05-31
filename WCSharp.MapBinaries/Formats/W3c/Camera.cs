namespace WCSharp.MapBinaries.Formats.W3c
{
	public class Camera
	{
		public required string Name { get; set; }
		public float X { get; set; }
		public float Y { get; set; }
		public float OffsetZ { get; set; }
		public float Rotation { get; set; }
		public float AngleOfAttack { get; set; }
		public float Distance { get; set; }
		public float Roll { get; set; }
		public float FieldOfView { get; set; }
		public float FarClipping { get; set; }
	}
}
