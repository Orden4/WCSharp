using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TargetFlag
	{
		internal TargetFlag()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator targetflag(TargetFlag x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TargetFlag(targetflag x);
	}
}
