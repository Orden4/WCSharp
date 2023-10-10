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

		/// @CSharpLua.Template = "EnableWeatherEffect({0}, true)"
		public extern void Enable();

		/// @CSharpLua.Template = "EnableWeatherEffect({0}, false)"
		public extern void Disable();

		/// @CSharpLua.Template = "RemoveWeatherEffect({0})"
		public extern void Dispose();
	}
}
