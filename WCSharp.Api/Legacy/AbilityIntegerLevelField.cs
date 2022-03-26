using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AbilityIntegerLevelField
	{
		internal AbilityIntegerLevelField()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator abilityintegerlevelfield(AbilityIntegerLevelField x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AbilityIntegerLevelField(abilityintegerlevelfield x);
	}
}
