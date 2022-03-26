using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Buff : Ability
	{
		internal Buff()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator buff(Buff x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Buff(buff x);
	}
}
