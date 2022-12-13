using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PathingType
	{
		internal PathingType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator pathingtype(PathingType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PathingType(pathingtype x);

		/// @CSharpLua.Get = "PATHING_TYPE_ANY"
		public static extern PathingType Any { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_WALKABILITY"
		public static extern PathingType Walkability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_FLYABILITY"
		public static extern PathingType Flyability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_BUILDABILITY"
		public static extern PathingType Buildability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_PEONHARVESTPATHING"
		public static extern PathingType PeonHarvest { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_BLIGHTPATHING"
		public static extern PathingType Blight { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_FLOATABILITY"
		public static extern PathingType Floatability { get; }
		/// @CSharpLua.Get = "PATHING_TYPE_AMPHIBIOUSPATHING"
		public static extern PathingType Amphibious { get; }

		/// @CSharpLua.Template = "ConvertPathingType({0})"
		public static extern PathingType Convert(int pathingTypeId);
	}
}
