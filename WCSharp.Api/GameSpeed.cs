using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class GameSpeed
	{
		internal GameSpeed()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator gamespeed(GameSpeed x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator GameSpeed(gamespeed x);

		/// @CSharpLua.Get = "MAP_SPEED_SLOWEST"
		public static extern GameSpeed Slowest { get; }
		/// @CSharpLua.Get = "MAP_SPEED_SLOW"
		public static extern GameSpeed Slow { get; }
		/// @CSharpLua.Get = "MAP_SPEED_NORMAL"
		public static extern GameSpeed Normal { get; }
		/// @CSharpLua.Get = "MAP_SPEED_FAST"
		public static extern GameSpeed Fast { get; }
		/// @CSharpLua.Get = "MAP_SPEED_FASTEST"
		public static extern GameSpeed Fastest { get; }

		/// @CSharpLua.Get = "GetGameSpeed()"
		/// @CSharpLua.Set = "SetGameSpeed({0})"
		public static extern GameSpeed Current { get; set; }

		/// @CSharpLua.Template = "ConvertGameSpeed({0})"
		public static extern MouseButtonType Convert(int gameSpeed);
	}
}
