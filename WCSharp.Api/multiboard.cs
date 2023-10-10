using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class multiboard : agent, IDisposable
	{
		internal multiboard()
		{
		}

		/// @CSharpLua.Template = "CreateMultiboard()"
		public static extern multiboard Create();

		/// @CSharpLua.Template = "MultiboardSuppressDisplay(~{0})"
		public static extern void SetVisibility(bool visible);

		/// @CSharpLua.Get = "IsMultiboardDisplayed({this})"
		/// @CSharpLua.Set = "MultiboardDisplay({this}, {0})"
		public extern bool IsDisplayed { get; set; }

		/// @CSharpLua.Get = "IsMultiboardMinimized({this})"
		/// @CSharpLua.Set = "MultiboardMinimize({this}, {0})"
		public extern bool IsMinimized { get; set; }

		/// @CSharpLua.Get = "MultiboardGetRowCount({this})"
		/// @CSharpLua.Set = "MultiboardSetRowCount({this}, {0})"
		public extern int Rows { get; set; }

		/// @CSharpLua.Get = "MultiboardGetColumnCount({this})"
		/// @CSharpLua.Set = "MultiboardSetColumnCount({this}, {0})"
		public extern int Columns { get; set; }

		/// @CSharpLua.Get = "MultiboardGetTitleText({this})"
		/// @CSharpLua.Set = "MultiboardSetTitleText({this}, {0})"
		public extern string Title { get; set; }

		/// @CSharpLua.Template = "MultiboardGetItem({this}, {0}, {1})"
		public extern multiboarditem GetItem(int row, int column);

		/// @CSharpLua.Template = "MultiboardSetItem({this}, {0}, {1})"
		public extern multiboarditem SetItem(int row, int column);

		/// @CSharpLua.Template = "MultiboardSetItemsStyle({this}, {0}, {1})"
		public extern void SetChildVisibility(bool showValue, bool showIcon);

		/// @CSharpLua.Template = "MultiboardSetItemsValue({this}, {0})"
		public extern void SetChildText(string value);

		/// @CSharpLua.Template = "MultiboardSetItemsValueColor({this}, {0}, {1}, {2})"
		public extern void SetChildColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "MultiboardSetItemsWidth({this}, {0})"
		public extern void SetChildWidth(float width);

		/// @CSharpLua.Template = "MultiboardSetItemsIcon({this}, {0})"
		public extern void SetChildIcon(string iconPath);

		/// @CSharpLua.Template = "MultiboardClear({this})"
		public extern void Clear();

		/// @CSharpLua.Template = "DestroyMultiboard({this})"
		public extern void Dispose();
	}
}
