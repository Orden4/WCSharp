using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class ubersplat : handle, IDisposable
	{
		internal ubersplat()
		{
		}

		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, 255, 255, 255, 255, true, true)"
		public static extern ubersplat Create(string name, float x, float y);
		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, {3}, {4}, {5}, {6}, true, true)"
		public static extern ubersplat Create(string name, float x, float y, int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "CreateUbersplat({2}, {0}, {1}, {3}, {4}, {5}, {6}, {7}, {8})"
		public static extern ubersplat Create(string name, float x, float y, int red, int green, int blue, int alpha, bool forcePaused, bool noBirthTime);

		/// @CSharpLua.Template = "ResetUbersplat({this})"
		public extern void Reset();

		/// @CSharpLua.Template = "FinishUbersplat({this})"
		public extern void Finish();

		/// @CSharpLua.Template = "ShowUbersplat({this}, {1])"
		public extern void SetVisibility(bool visibility);

		/// @CSharpLua.Template = "SetUbersplatRender({this}, {1])"
		public extern void SetRender(bool render);

		/// @CSharpLua.Template = "SetUbersplatRenderAlways({this}, {1])"
		public extern void SetRenderAlways(bool renderAlways);

		/// @CSharpLua.Template = "DestroyUbersplat({this})"
		public extern void Dispose();
	}
}
