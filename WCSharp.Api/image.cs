using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class image : handle, IDisposable
	{
		internal image()
		{
		}

		/// @CSharpLua.Template = "CreateImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})"
		public static extern image Create(string file, float sizeX, float sizeY, float sizeZ, float posX, float posY, float posZ, float originX, float originY, float originZ, int imageType);

		/// @CSharpLua.Template = "ShowImage({this}, {0})"
		public extern void SetVisibility(bool visibility);
		/// @CSharpLua.Template = "SetImageConstantHeight({this}, {0}, {1})"
		public extern void SetConstantHeight(bool isConstant, float height);
		/// @CSharpLua.Template = "SetImagePosition({this}, {0}, {1}, {2})"
		public extern void SetPosition(float x, float y, float z);
		/// @CSharpLua.Template = "SetImageColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "SetImageRender({this}, {0})"
		public extern void SetRender(bool render);
		/// @CSharpLua.Template = "SetImageRenderAlways({this}, {0})"
		public extern void SetRenderAlways(bool renderAlways);
		/// @CSharpLua.Template = "SetImageAboveWater({this}, {0}, {1})"
		public extern void SetAboveWater(bool aboveWater, bool useWaterAlpha);
		/// @CSharpLua.Template = "SetImageType({this}, {0})"
		public extern void SetType(int imageType);

		/// @CSharpLua.Template = "DestroyImage({this})"
		public extern void Dispose();
	}
}
