using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class LimitOp : EventId
	{
		internal LimitOp()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator limitop(LimitOp x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator LimitOp(limitop x);
	}
}
