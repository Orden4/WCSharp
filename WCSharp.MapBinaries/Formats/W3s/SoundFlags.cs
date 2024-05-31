namespace WCSharp.MapBinaries.Formats.W3s
{
	[Flags]
	public enum SoundFlags
	{
		Looping = 1 << 0,
		Is3D = 1 << 1,
		StopOutOfRange = 1 << 2,
		Music = 1 << 3,
	}
}
