using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MultiboardItem : Agent, IDisposable
	{
		internal MultiboardItem()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator multiboarditem(MultiboardItem x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MultiboardItem(multiboarditem x);

		/// @CSharpLua.Template = "MultiboardSetItemStyle({0}, {1}, {2})"
		public extern void SetVisibility(bool showValue, bool showIcon);

		/// @CSharpLua.Template = "MultiboardSetItemValue({0}, {1})"
		public extern void SetText(string value);

		/// @CSharpLua.Template = "MultiboardSetItemValueColor({0}, {1}, {2}, {3})"
		public extern void SetColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "MultiboardSetItemWidth({0}, {1})"
		public extern void SetWidth(float width);

		/// @CSharpLua.Template = "MultiboardSetItemIcon({0}, {1})"
		public extern void SetIcon(string iconPath);

		/// @CSharpLua.Template = "MultiboardReleaseItem({0})"
		public extern void Dispose();
	}
}
