namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class ConditionFunc : BoolExpr
	{
		internal ConditionFunc()
		{
		}

		/// @CSharpLua.Template = "DestroyCondition({0})"
		public extern override void Dispose();
	}
}
