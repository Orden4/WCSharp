using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MouseButtonType
	{
		internal MouseButtonType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator mousebuttontype(MouseButtonType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MouseButtonType(mousebuttontype x);

		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_LEFT"
		public static extern MouseButtonType Left { get; }
		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_MIDDLE"
		public static extern MouseButtonType Middle { get; }
		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_RIGHT"
		public static extern MouseButtonType Right { get; }

		/// @CSharpLua.Template = "ConvertMouseButtonType({0})"
		public static extern MouseButtonType Convert(int mouseButtonType);
	}
}
