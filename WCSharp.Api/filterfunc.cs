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
		public static extern filterfunc Create(Action action);

		/// @CSharpLua.Template = "DestroyCondition({this})"
		public extern override void Dispose();
	}
}
