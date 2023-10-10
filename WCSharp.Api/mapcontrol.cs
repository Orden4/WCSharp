namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class mapcontrol : handle
	{
		internal mapcontrol()
		{
		}

		/// @CSharpLua.Get = "MAP_CONTROL_USER"
		public static extern mapcontrol User { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_COMPUTER"
		public static extern mapcontrol Computer { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_RESCUABLE"
		public static extern mapcontrol Rescuable { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_NEUTRAL"
		public static extern mapcontrol Neutral { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_CREEP"
		public static extern mapcontrol Creep { get; }
		/// @CSharpLua.Get = "MAP_CONTROL_NONE"
		public static extern mapcontrol None { get; }

		/// @CSharpLua.Get = "GetResourceDensity()"
		/// @CSharpLua.Set = "SetResourceDensity({0})"
		public static extern mapcontrol ResourceDensity { get; set; }

		/// @CSharpLua.Get = "GetCreatureDensity()"
		/// @CSharpLua.Set = "SetCreatureDensity({0})"
		public static extern mapcontrol CreatureDensity { get; set; }

		/// @CSharpLua.Template = "ConvertMapControl({0})"
		public static extern mapcontrol Convert(int mapControlId);
	}
}
