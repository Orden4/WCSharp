using System.IO;
using WCSharp.ConstantGenerator.Extensions;

namespace WCSharp.ConstantGenerator.Handlers.WcObjects
{
	internal class Camera
	{
		public float TargetX { get; set; }
		public float TargetY { get; set; }
		public float ZOffset { get; set; }
		public float Rotation { get; set; }
		public float AngleOfAttack { get; set; }
		public float Distance { get; set; }
		public float Roll { get; set; }
		public float FoV { get; set; }
		public float FarZ { get; set; }
		public float NearZ { get; set; }
		public float LocalPitch { get; set; }
		public float LocalYaw { get; set; }
		public float LocalRoll { get; set; }
		public string Name { get; set; }

		public Camera(BinaryReader reader)
		{
			TargetX = reader.ReadSingle();
			TargetY = reader.ReadSingle();
			ZOffset = reader.ReadSingle();
			Rotation = reader.ReadSingle();
			AngleOfAttack = reader.ReadSingle();
			Distance = reader.ReadSingle();
			Roll = reader.ReadSingle();
			FoV = reader.ReadSingle();
			FarZ = reader.ReadSingle();
			NearZ = reader.ReadSingle();
			LocalPitch = reader.ReadSingle();
			LocalYaw = reader.ReadSingle();
			LocalRoll = reader.ReadSingle();
			Name = reader.ReadWcString();
		}
	}
}
