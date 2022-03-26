using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Region : Agent
	{
		internal Region()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator region(Region x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Region(region x);

		/// @CSharpLua.Template = "RemoveRegion({0})"
		public extern void Dispose();
	}
}
