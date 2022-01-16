namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class FilterFunc : BoolExpr
	{
		internal FilterFunc()
		{
		}

		/// @CSharpLua.Template = "DestroyCondition({0})"
		public extern override void Dispose();
	}
}
