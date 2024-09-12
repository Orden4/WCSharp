using System;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class filterfunc : boolexpr
	{
		internal filterfunc()
		{
		}

		/// @CSharpLua.Template = "Filter({0})"
		public static extern filterfunc Create(Func<bool> action);

		/// @CSharpLua.Template = "DestroyFilter({this})"
		public extern override void Dispose();
	}
}
