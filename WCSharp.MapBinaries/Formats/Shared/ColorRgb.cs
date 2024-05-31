using System.Drawing;

namespace WCSharp.MapBinaries.Formats.Shared
{
	public class ColorRgb
	{
		public byte R { get; set; }
		public byte G { get; set; }
		public byte B { get; set; }

		public ColorRgb(byte r, byte g, byte b)
		{
			R = r;
			G = g;
			B = b;
		}

		public Color ToArgb()
		{
			return Color.FromArgb(R, G, B);
		}
	}

	public static class ColorExtensions
	{
		public static ColorRgb ToRgb(this Color color)
		{
			return new ColorRgb(color.R, color.G, color.B);
		}
	}
}
