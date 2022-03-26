using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class StartLocPrio
	{
		internal StartLocPrio()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator startlocprio(StartLocPrio x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator StartLocPrio(startlocprio x);
	}
}
