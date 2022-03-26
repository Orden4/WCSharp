using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UnitWeaponRealField
	{
		internal UnitWeaponRealField()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unitweaponrealfield(UnitWeaponRealField x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UnitWeaponRealField(unitweaponrealfield x);
	}
}
