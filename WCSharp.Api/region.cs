namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class region : agent
	{
		internal region()
		{
		}

		/// @CSharpLua.Template = "CreateRegion()"
		public static extern region Create();

		/// @CSharpLua.Template = "RegionAddRect({0}, {1})"
		public extern void AddCell(rect rect);
		/// @CSharpLua.Template = "RegionAddCell({0}, {1}, {2})"
		public extern void AddCell(float x, float y);
		/// @CSharpLua.Template = "RegionClearRect({0}, {1})"
		public extern void RemoveCell(rect rect);
		/// @CSharpLua.Template = "RegionClearCell({0}, {1}, {2})"
		public extern void RemoveCell(float x, float y);

		/// @CSharpLua.Template = "IsUnitInRegion({0}, {1})"
		public extern bool Contains(unit unit);
		/// @CSharpLua.Template = "IsPointInRegion({0}, {1}, {2})"
		public extern bool Contains(float x, float y);

		/// @CSharpLua.Template = "RemoveRegion({0})"
		public extern void Dispose();
	}
}
