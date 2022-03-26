using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Lightning : IDisposable
	{
		internal Lightning()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator lightning(Lightning x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Lightning(lightning x);

		/// @CSharpLua.Template = "AddLightning({0}, {5}, {1}, {2}, {3}, {4})"
		public static extern Lightning Create(string name, float x1, float y1, float x2, float y2, bool visible = true);
		/// @CSharpLua.Template = "AddLightningEx({0}, {7}, {1}, {2}, {3}, {4}, {5}, {6})"
		public static extern Lightning Create(string name, float x1, float y1, float z1, float x2, float y2, float z2, bool visible = true);

		/// @CSharpLua.Get = "GetLightningColorR({0})"
		/// @CSharpLua.Set = "SetLightningColor({0}, {1}, GetLightningColorG({0}), GetLightningColorB({0}), GetLightningColorA({0}))"
		public extern float Red { get; set; }

		/// @CSharpLua.Get = "GetLightningColorG({0})"
		/// @CSharpLua.Set = "SetLightningColor({0}, GetLightningColorR({0}), {1}, GetLightningColorB({0}), GetLightningColorA({0}))"
		public extern float Green { get; set; }

		/// @CSharpLua.Get = "GetLightningColorB({0})"
		/// @CSharpLua.Set = "SetLightningColor({0}, GetLightningColorR({0}), GetLightningColorG({0}), {1}, GetLightningColorA({0}))"
		public extern float Blue { get; set; }

		/// @CSharpLua.Get = "GetLightningColorA({0})"
		/// @CSharpLua.Set = "SetLightningColor({0}, GetLightningColorR({0}), GetLightningColorG({0}), GetLightningColorB({0}), {1})"
		public extern float Alpha { get; set; }

		/// @CSharpLua.Template = "MoveLightning({0}, {5}, {1}, {2}, {3}, {4})"
		public extern void Move(float x1, float y1, float x2, float y2, bool visible = true);
		/// @CSharpLua.Template = "MoveLightningEx({0}, {7}, {1}, {2}, {3}, {4}, {5}, {6})"
		public extern void Move(float x1, float y1, float z1, float x2, float y2, float z2, bool visible = true);

		/// @CSharpLua.Template = "SetLightningColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetColor(float red, float green, float blue, float alpha = 1.0f);

		/// @CSharpLua.Template = "DestroyLightning({0})"
		public extern void Dispose();
	}
}
