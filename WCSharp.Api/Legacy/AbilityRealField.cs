using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AbilityRealField
	{
		internal AbilityRealField()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator abilityrealfield(AbilityRealField x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AbilityRealField(abilityrealfield x);
	}
}
