using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class WeatherEffect : IDisposable
	{
		internal WeatherEffect()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator weathereffect(WeatherEffect x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator WeatherEffect(weathereffect x);

		/// @CSharpLua.Template = "AddWeatherEffect({0}, {1})"
		public static extern WeatherEffect Create(Rect rect, int weatherEffectId);

		/// @CSharpLua.Template = "EnableWeatherEffect({0}, true)"
		public extern void Enable();

		/// @CSharpLua.Template = "EnableWeatherEffect({0}, false)"
		public extern void Disable();

		/// @CSharpLua.Template = "RemoveWeatherEffect({0})"
		public extern void Dispose();
	}
}
