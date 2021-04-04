namespace WCSharp.Json
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	internal static class Rxi
	{
		/// @CSharpLua.Template = {0}.encode({1})
		public static extern string Encode(object rxi, object input);
		/// @CSharpLua.Template = {0}.decode({1})
		public static extern object Decode(object rxi, string input);
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
