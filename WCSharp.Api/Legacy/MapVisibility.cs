using static War3Api.Common;

namespace WCSharp.Api.Legacy
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MapVisibility
	{
		internal MapVisibility()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator mapvisibility(MapVisibility x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MapVisibility(mapvisibility x);
	}
}
