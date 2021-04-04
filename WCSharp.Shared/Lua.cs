namespace WCSharp.Shared
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// <summary>
	/// Helper class for directly executing Lua without needing the __CSharpLua__ directive.
	/// <para>This is only really useful if you cannot use __CSharpLua__, e.g. when making packages.</para>
	/// </summary>
	/// @CSharpLua.Ignore
	public static class Lua
	{
		/// <summary>
		/// Converts into raw lua in the form of "for keyName,valueName in pairs(table) do"
		/// </summary>
		/// @CSharpLua.Template = "for {1},{2} in pairs({0}) do"
		public static extern void ForPairs(object table, object keyName, object valueName);

		/// <summary>
		/// Converts into raw lua in the form of "end"
		/// </summary>
		/// @CSharpLua.Template = "end"
		public static extern void End();

		/// <summary>
		/// Converts into raw lua in the form of "load(code)".
		/// </summary>
		/// @CSharpLua.Template = "load({0})"
		public static extern object Load(string code);

		/// <summary>
		/// Converts into raw lua in the form of "obj(args)".
		/// <para>This works for functions with any number of arguments, including 0.</para>
		/// </summary>
		/// @CSharpLua.Template = "{0}({*1})"
		public static extern object Call(object obj, params object[] args);
	}
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
}
