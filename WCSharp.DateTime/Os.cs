namespace WCSharp.DateTime
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	internal static class Os
	{
		/// @CSharpLua.Template = "os.date({0})"
		public static extern object Date(string format);

		/// @CSharpLua.Template = "os.date({0}, {1})"
		public static extern string Date(string format, int seconds);

		/// @CSharpLua.Template = "os.clock()"
		public static extern float Clock();
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
