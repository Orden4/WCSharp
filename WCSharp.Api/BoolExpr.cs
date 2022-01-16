using System;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class BoolExpr : Agent, IDisposable
	{
		internal BoolExpr()
		{
		}

		/// @CSharpLua.Template = "DestroyBoolExpr({0})"
		public extern virtual void Dispose();
	}
}
