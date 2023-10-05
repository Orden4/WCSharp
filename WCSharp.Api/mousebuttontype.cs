namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class mousebuttontype
	{
		internal mousebuttontype()
		{
		}

		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_LEFT"
		public static extern mousebuttontype Left { get; }
		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_MIDDLE"
		public static extern mousebuttontype Middle { get; }
		/// @CSharpLua.Get = "MOUSE_BUTTON_TYPE_RIGHT"
		public static extern mousebuttontype Right { get; }

		/// @CSharpLua.Template = "ConvertMouseButtonType({0})"
		public static extern mousebuttontype Convert(int mouseButtonTypeId);
	}
}
