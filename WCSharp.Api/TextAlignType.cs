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
	}
}
