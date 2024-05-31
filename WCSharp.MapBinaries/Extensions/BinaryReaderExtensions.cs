using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace WCSharp.ConstantGenerator.Extensions
{
	internal static class BinaryReaderExtensions
	{
		public static string ReadWcString(this BinaryReader reader)
		{
			return Encoding.UTF8.GetString(reader.ReadUntilNul().ToArray());
		}

		public static IEnumerable<byte> ReadUntilNul(this BinaryReader reader)
		{
			while (true)
			{
				var b = reader.ReadByte();
				if (b != 0)
				{
					yield return b;
				}
				else
				{
					yield break;
				}
			}
		}

		public static string ReadString(this BinaryReader reader, int number)
		{
			return Encoding.UTF8.GetString(reader.ReadBytes(number));
		}

		public static Color ReadColor(this BinaryReader reader)
		{
			var alpha = reader.ReadByte();
			var red = reader.ReadByte();
			var green = reader.ReadByte();
			var blue = reader.ReadByte();
			return Color.FromArgb(alpha, red, green, blue);
		}
	}
}
