namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class limitop : eventid
	{
		internal limitop()
		{
		}

		/// @CSharpLua.Get = "LESS_THAN"
		public static extern limitop LessThan { get; }
		/// @CSharpLua.Get = "LESS_THAN_OR_EQUAL"
		public static extern limitop LessThanOrEqual { get; }
		/// @CSharpLua.Get = "EQUAL"
		public static extern limitop Equal { get; }
		/// @CSharpLua.Get = "GREATER_THAN_OR_EQUAL"
		public static extern limitop GreaterThanOrEqual { get; }
		/// @CSharpLua.Get = "GREATER_THAN"
		public static extern limitop GreaterThan { get; }
		/// @CSharpLua.Get = "NOT_EQUAL"
		public static extern limitop NotEqual { get; }

		/// @CSharpLua.Template = "ConvertLimitOp({0})"
		public static extern limitop Convert(int limitOpId);
	}
}
