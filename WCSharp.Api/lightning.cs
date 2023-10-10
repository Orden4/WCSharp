using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class lightning : handle, IDisposable
	{
		internal lightning()
		{
		}

		/// @CSharpLua.Template = "AddLightning({0}, {5}, {1}, {2}, {3}, {4})"
		public static extern lightning Create(string name, float x1, float y1, float x2, float y2, bool visible = true);
		/// @CSharpLua.Template = "AddLightningEx({0}, {7}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern lightning Create(string name, float x1, float y1, float z1, float x2, float y2, float z2, bool visible = true);

		/// @CSharpLua.Get = "GetLightningColorR({this})"
		/// @CSharpLua.Set = "SetLightningColor({this}, {0}, GetLightningColorG({this}), GetLightningColorB({this}), GetLightningColorA({this}))"
		public extern float Red { get; set; }

		/// @CSharpLua.Get = "GetLightningColorG({this})"
		/// @CSharpLua.Set = "SetLightningColor({this}, GetLightningColorR({this}), {0}, GetLightningColorB({this}), GetLightningColorA({this}))"
		public extern float Green { get; set; }

		/// @CSharpLua.Get = "GetLightningColorB({this})"
		/// @CSharpLua.Set = "SetLightningColor({this}, GetLightningColorR({this}), GetLightningColorG({this}), {0}, GetLightningColorA({this}))"
		public extern float Blue { get; set; }

		/// @CSharpLua.Get = "GetLightningColorA({this})"
		/// @CSharpLua.Set = "SetLightningColor({this}, GetLightningColorR({this}), GetLightningColorG({this}), GetLightningColorB({this}), {0})"
		public extern float Alpha { get; set; }

		/// @CSharpLua.Template = "MoveLightning({this}, {4}, {0}, {1}, {2}, {3})"
		public extern void Move(float x1, float y1, float x2, float y2, bool visible = true);
		/// @CSharpLua.Template = "MoveLightningEx({this}, {6}, {0}, {1}, {2}, {3}, {4}, {5})"
		public extern void Move(float x1, float y1, float z1, float x2, float y2, float z2, bool visible = true);

		/// @CSharpLua.Template = "SetLightningColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetColor(float red, float green, float blue, float alpha = 1.0f);

		/// @CSharpLua.Template = "DestroyLightning({this})"
		public extern void Dispose();
	}
}
