using System;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class conditionfunc : boolexpr
	{
		internal conditionfunc()
		{
		}

		/// @CSharpLua.Template = "Condition({0})"
		public extern conditionfunc Create(Action action);

		/// @CSharpLua.Template = "DestroyCondition({0})"
		public extern override void Dispose();
	}
}
