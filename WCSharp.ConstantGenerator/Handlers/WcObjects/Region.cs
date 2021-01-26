using System.Drawing;
using System.IO;
using WCSharp.ConstantGenerator.Extensions;

namespace WCSharp.ConstantGenerator.Handlers.WcObjects
{
	internal class Region
	{
		public float Left { get; set; }
		public float Bottom { get; set; }
		public float Right { get; set; }
		public float Top { get; set; }
		public string Name { get; set; }
		public int CreationNumber { get; set; }
		public string WeatherId { get; set; }
		public string AmbientId { get; set; }
		public Color Color { get; set; }

		public Region(BinaryReader reader)
		{
			Left = reader.ReadSingle();
			Bottom = reader.ReadSingle();
			Right = reader.ReadSingle();
			Top = reader.ReadSingle();
			Name = reader.ReadWcString();
			CreationNumber = reader.ReadInt32();
			WeatherId = reader.ReadString(4);
			AmbientId = reader.ReadWcString();
			Color = reader.ReadColor();
		}
	}
}
