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

		/// @CSharpLua.Get = "LESS_THAN"
		public static extern LimitOp LessThan { get; }
		/// @CSharpLua.Get = "LESS_THAN_OR_EQUAL"
		public static extern LimitOp LessThanOrEqual { get; }
		/// @CSharpLua.Get = "EQUAL"
		public static extern LimitOp Equal { get; }
		/// @CSharpLua.Get = "GREATER_THAN_OR_EQUAL"
		public static extern LimitOp GreaterThanOrEqual { get; }
		/// @CSharpLua.Get = "GREATER_THAN"
		public static extern LimitOp GreaterThan { get; }
		/// @CSharpLua.Get = "NOT_EQUAL"
		public static extern LimitOp NotEqual { get; }

		/// @CSharpLua.Template = "ConvertLimitOp({0})"
		public static extern LimitOp Convert(int limitOpId);
	}
}
