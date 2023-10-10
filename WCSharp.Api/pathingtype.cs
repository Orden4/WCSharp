namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class pathingtype : handle
	{
		internal pathingtype()
		{
		}

		/// @CSharpLua.Get = "PATHING_TYPE_ANY"
		public static extern pathingtype Any { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_WALKABILITY"
		public static extern pathingtype Walkability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_FLYABILITY"
		public static extern pathingtype Flyability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_BUILDABILITY"
		public static extern pathingtype Buildability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_PEONHARVESTPATHING"
		public static extern pathingtype PeonHarvest { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_BLIGHTPATHING"
		public static extern pathingtype Blight { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_FLOATABILITY"
		public static extern pathingtype Floatability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_AMPHIBIOUSPATHING"
		public static extern pathingtype Amphibious { get; }

		/// @CSharpLua.Template = "ConvertPathingType({0})"
		public static extern pathingtype Convert(int pathingTypeId);

		/// @CSharpLua.Template = "IsTerrainPathable({0}, {1}, {this})"
		public extern bool GetPathable(float x, float y);

		/// @CSharpLua.Template = "SetTerrainPathable({0}, {1}, {this}, {2})"
		public extern void SetPathable(float x, float y, bool pathable);
	}
}
