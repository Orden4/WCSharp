using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class ubersplat : handle, IDisposable
	{
		internal ubersplat()
		{
		}

		/// @CSharpLua.Template = "CreateUbersplat({1}, {2}, {0}, {3}, {4}, {5}, {6}, {7}, {8})"
		public static extern ubersplat Create(string name, float x, float y, int red = 255, int green = 255, int blue = 255, int alpha = 255, bool forcePaused = false, bool noBirthTime = false);

		/// @CSharpLua.Template = "ResetUbersplat({this})"
		public extern void Reset();

		/// @CSharpLua.Template = "FinishUbersplat({this})"
		public extern void Finish();

		/// @CSharpLua.Template = "ShowUbersplat({this}, {0})"
		public extern void SetVisibility(bool visibility);

		/// @CSharpLua.Template = "SetUbersplatRender({this}, {0})"
		public extern void SetRender(bool render);

		/// @CSharpLua.Template = "SetUbersplatRenderAlways({this}, {0})"
		public extern void SetRenderAlways(bool renderAlways);

		/// @CSharpLua.Template = "DestroyUbersplat({this})"
		public extern void Dispose();
	}
}
