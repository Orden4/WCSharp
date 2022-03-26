using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MapDensity
	{
		internal MapDensity()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator mapdensity(MapDensity x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MapDensity(mapdensity x);

		/// @CSharpLua.Get = "MAP_DENSITY_NONE"
		public static extern MapControl None { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_LIGHT"
		public static extern MapControl Light { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_MEDIUM"
		public static extern MapControl Medium { get; }
		/// @CSharpLua.Get = "MAP_DENSITY_HEAVY"
		public static extern MapControl Heavy { get; }

		/// @CSharpLua.Get = "GetResourceDensity()"
		/// @CSharpLua.Set = "SetResourceDensity({0})"
		public static extern GameSpeed ResourceDensity { get; set; }

		/// @CSharpLua.Get = "GetCreatureDensity()"
		/// @CSharpLua.Set = "SetCreatureDensity({0})"
		public static extern GameSpeed CreatureDensity { get; set; }

		/// @CSharpLua.Template = "ConvertMapDensity({0})"
		public static extern MapControl Convert(int mapDensity);
	}
}
