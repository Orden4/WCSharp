using WCSharp.MapBinaries.Extensions;

namespace WCSharp.MapBinaries.Formats.W3e
{
	public class TerrainTile
	{
		private short waterHeight;
		private byte groundTexture;
		private byte groundVariation;
		private byte cliffVariation;
		private byte cliffTexture;
		private byte layerHeight;

		public short GroundHeight { get; set; }
		/// <summary>
		/// Clamped from -8192 to 8192.
		/// </summary>
		public short WaterHeight
		{
			get => this.waterHeight;
			set => this.waterHeight = value.Clamp(-8192, 8192);
		}
		public bool BoundaryFlag { get; set; }
		/// <summary>
		/// Clamped from 0 to 15.
		/// </summary>
		public byte GroundTexture
		{
			get => this.groundTexture;
			set => this.groundTexture = value.Clamp(0, 15);
		}
		/// <summary>
		/// Clamped from 0 to 31.
		/// </summary>
		public byte GroundVariation
		{
			get => this.groundVariation;
			set => this.groundVariation = value.Clamp(0, 31);
		}
		/// <summary>
		/// Clamped from 0 to 7.
		/// </summary>
		public byte CliffVariation
		{
			get => this.cliffVariation;
			set => this.cliffVariation = value.Clamp(0, 7);
		}
		/// <summary>
		/// Clamped from 0 to 15.
		/// </summary>
		public byte CliffTexture
		{
			get => this.cliffTexture;
			set => this.cliffTexture = value.Clamp(0, 15);
		}
		/// <summary>
		/// Clamped from 0 to 15.
		/// </summary>
		public byte LayerHeight
		{
			get => this.layerHeight;
			set => this.layerHeight = value.Clamp(0, 15);
		}
	}
}
