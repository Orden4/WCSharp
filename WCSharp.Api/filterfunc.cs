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
		public extern filterfunc Create(Action action);

		/// @CSharpLua.Template = "DestroyCondition({0})"
		public extern override void Dispose();
	}
}
