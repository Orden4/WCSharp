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

		/// @CSharpLua.Template = "RegionAddRect({this}, {0})"
		public extern void AddRect(rect rect);
		/// @CSharpLua.Template = "RegionAddCell({this}, {0}, {1})"
		public extern void AddCell(float x, float y);
		/// @CSharpLua.Template = "RegionClearRect({this}, {0})"
		public extern void RemoveRect(rect rect);
		/// @CSharpLua.Template = "RegionClearCell({this}, {0}, {1})"
		public extern void RemoveCell(float x, float y);

		/// @CSharpLua.Template = "IsUnitInRegion({this}, {0})"
		public extern bool Contains(unit unit);
		/// @CSharpLua.Template = "IsPointInRegion({this}, {0}, {1})"
		public extern bool Contains(float x, float y);

		/// @CSharpLua.Template = "RemoveRegion({this})"
		public extern void Dispose();
	}
}
