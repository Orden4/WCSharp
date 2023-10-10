using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class boolexpr : agent, IDisposable
	{
		internal boolexpr()
		{
		}

		/// @CSharpLua.Template = "DestroyBoolExpr({this})"
		public extern virtual void Dispose();
	}
}
