using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TextAlignType
	{
		internal TextAlignType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator textaligntype(TextAlignType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TextAlignType(textaligntype x);

		/// @CSharpLua.Get = "TEXT_JUSTIFY_TOP"
		public static extern TextAlignType Top { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_MIDDLE"
		public static extern TextAlignType Middle { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_BOTTOM"
		public static extern TextAlignType Bottom { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_LEFT"
		public static extern TextAlignType Left { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_CENTER"
		public static extern TextAlignType Center { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_RIGHT"
		public static extern TextAlignType Right { get; }

		/// @CSharpLua.Template = "ConvertTextAlignType({0})"
		public static extern TextAlignType Convert(int textAlignTypeId);
	}
}
