using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MapControl
	{
		internal MapControl()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator mapcontrol(MapControl x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MapControl(mapcontrol x);

		/// @CSharpLua.Get = "MAP_CONTROL_USER"
		public static extern MapControl User { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_COMPUTER"
		public static extern MapControl Computer { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_RESCUABLE"
		public static extern MapControl Rescuable { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_NEUTRAL"
		public static extern MapControl Neutral { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_CREEP"
		public static extern MapControl Creep { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_NONE"
		public static extern MapControl None { get; }

		/// @CSharpLua.Template = "ConvertMapControl({0})"
		public static extern MapControl Convert(int mapControl);
	}
}
