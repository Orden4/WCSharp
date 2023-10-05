using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class multiboarditem : agent, IDisposable
	{
		internal multiboarditem()
		{
		}

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
