namespace WCSharp.MapBinaries.Extensions
{
	public static class ByteExtensions
	{
		public static byte Clamp(this byte value, byte min, byte max)
		{
			return Math.Min(max, Math.Max(min, value));
		}
	}
}
