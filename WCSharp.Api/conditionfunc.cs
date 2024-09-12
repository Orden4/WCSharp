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
		public static extern conditionfunc Create(Func<bool> action);

		/// @CSharpLua.Template = "DestroyCondition({this})"
		public extern override void Dispose();
	}
}
