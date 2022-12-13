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

		/// @CSharpLua.Template = "CreateRegion()"
		public static extern Region Create();

		/// @CSharpLua.Template = "RegionAddRect({0}, {1})"
		public extern void AddRect(Rect rect);

		/// @CSharpLua.Template = "RegionClearRect({0}, {1})"
		public extern void ClearRect(Rect rect);

		/// @CSharpLua.Template = "RegionAddCell({0}, {1}, {2})"
		public extern void AddCell(float x, float y);

		/// @CSharpLua.Template = "RegionClearCell({0}, {1}, {2})"
		public extern void ClearCell(float x, float y);

		/// @CSharpLua.Template = "IsUnitInRegion({0}, {1})"
		public extern bool Contains(Unit unit);

		/// @CSharpLua.Template = "IsPointInRegion({0}, {1}, {2})"
		public extern bool Contains(float x, float y);

		/// @CSharpLua.Template = "RemoveRegion({0})"
		public extern void Dispose();
	}
}
