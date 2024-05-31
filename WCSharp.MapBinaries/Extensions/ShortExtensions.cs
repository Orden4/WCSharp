namespace WCSharp.MapBinaries.Extensions
{
	public static class ShortExtensions
	{
		public static short Clamp(this short value, short min, short max)
		{
			return Math.Min(max, Math.Max(min, value));
		}
	}
}
