using System;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class WeatherEffect : IDisposable
	{
		internal WeatherEffect()
		{
		}

		/// @CSharpLua.Template = "RemoveWeatherEffect({0})"
		public extern void Dispose();
	}
}
