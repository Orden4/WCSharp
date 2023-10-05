using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class boolexpr : agent, IDisposable
	{
		internal boolexpr()
		{
		}

		/// @CSharpLua.Template = "DestroyBoolExpr({0})"
		public extern virtual void Dispose();
	}
}
