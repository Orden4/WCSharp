using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class weathereffect : handle, IDisposable
	{
		internal weathereffect()
		{
		}

		/// @CSharpLua.Template = "AddWeatherEffect({0}, {1})"
		public static extern weathereffect Create(rect rect, int weatherEffectId);

		/// @CSharpLua.Template = "EnableWeatherEffect({this}, true)"
		public extern void Enable();

		/// @CSharpLua.Template = "EnableWeatherEffect({this}, false)"
		public extern void Disable();

		/// @CSharpLua.Template = "RemoveWeatherEffect({this})"
		public extern void Dispose();
	}
}
