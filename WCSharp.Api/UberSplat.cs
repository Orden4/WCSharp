using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UberSplat : IDisposable
	{
		internal UberSplat()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator ubersplat(UberSplat x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UberSplat(ubersplat x);

		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, 255, 255, 255, 255, true, true)"
		public static extern UberSplat Create(string name, float x, float y);
		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, {3}, {4}, {5}, {6}, true, true)"
		public static extern UberSplat Create(string name, float x, float y, int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, {3}, {4}, {5}, {6}, {7}, {8})"
		public static extern UberSplat Create(string name, float x, float y, int red, int green, int blue, int alpha, bool forcePaused, bool noBirthTime);

		/// @CSharpLua.Template = "ResetUbersplat({0})"
		public extern void Reset();

		/// @CSharpLua.Template = "FinishUbersplat({0})"
		public extern void Finish();

		/// @CSharpLua.Template = "ShowUbersplat({0}, {1])"
		public extern void SetVisibility(bool visibility);

		/// @CSharpLua.Template = "SetUbersplatRender({0}, {1])"
		public extern void SetRender(bool render);

		/// @CSharpLua.Template = "SetUbersplatRenderAlways({0}, {1])"
		public extern void SetRenderAlways(bool renderAlways);

		/// @CSharpLua.Template = "DestroyUbersplat({0})"
		public extern void Dispose();
	}
}
