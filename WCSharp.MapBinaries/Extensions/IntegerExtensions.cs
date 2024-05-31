namespace WCSharp.MapBinaries.Extensions
{
	public static class IntegerExtensions
	{
		public static int Clamp(this int value, int min, int max)
		{
			return Math.Min(max, Math.Max(min, value));
		}
	}
}
