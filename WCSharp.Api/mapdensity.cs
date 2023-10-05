namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class mapdensity
	{
		internal mapdensity()
		{
		}

		/// @CSharpLua.Get = "MAP_DENSITY_NONE"
		public static extern mapdensity None { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_LIGHT"
		public static extern mapdensity Light { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_MEDIUM"
		public static extern mapdensity Medium { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_HEAVY"
		public static extern mapdensity Heavy { get; }

		/// @CSharpLua.Get = "GetResourceDensity()"
		/// @CSharpLua.Set = "SetResourceDensity({0})"
		public static extern gamespeed ResourceDensity { get; set; }

		/// @CSharpLua.Get = "GetCreatureDensity()"
		/// @CSharpLua.Set = "SetCreatureDensity({0})"
		public static extern gamespeed CreatureDensity { get; set; }

		/// @CSharpLua.Template = "ConvertMapDensity({0})"
		public static extern mapdensity Convert(int mapDensityId);
	}
}
