using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AbilityBooleanField
	{
		internal AbilityBooleanField()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator abilitybooleanfield(AbilityBooleanField x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AbilityBooleanField(abilitybooleanfield x);
	}
}
