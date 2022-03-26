using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class BoolExpr : Agent, IDisposable
	{
		internal BoolExpr()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator boolexpr(BoolExpr x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator BoolExpr(boolexpr x);

		/// @CSharpLua.Template = "DestroyBoolExpr({0})"
		public extern virtual void Dispose();
	}
}
