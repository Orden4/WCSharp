namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class gamespeed
	{
		internal gamespeed()
		{
		}

		/// @CSharpLua.Get = "MAP_SPEED_SLOWEST"
		public static extern gamespeed Slowest { get; }
		/// @CSharpLua.Get = "MAP_SPEED_SLOW"
		public static extern gamespeed Slow { get; }
		/// @CSharpLua.Get = "MAP_SPEED_NORMAL"
		public static extern gamespeed Normal { get; }
		/// @CSharpLua.Get = "MAP_SPEED_FAST"
		public static extern gamespeed Fast { get; }
		/// @CSharpLua.Get = "MAP_SPEED_FASTEST"
		public static extern gamespeed Fastest { get; }

		/// @CSharpLua.Get = "GetGameSpeed()"
		/// @CSharpLua.Set = "SetGameSpeed({0})"
		public static extern gamespeed Current { get; set; }

		/// @CSharpLua.Template = "ConvertGameSpeed({0})"
		public static extern mousebuttontype Convert(int gameSpeedId);
	}
}
