using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class WeaponType
	{
		internal WeaponType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator weapontype(WeaponType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator WeaponType(weapontype x);

		/// @CSharpLua.Get = "WEAPON_TYPE_WHOKNOWS"
		public static extern WeaponType WhoKnows { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_LIGHT_CHOP"
		public static extern WeaponType MetalLightChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_CHOP"
		public static extern WeaponType MetalMediumChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_CHOP"
		public static extern WeaponType MetalHeavyChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_LIGHT_SLICE"
		public static extern WeaponType MetalLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_SLICE"
		public static extern WeaponType MetalMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_SLICE"
		public static extern WeaponType MetalHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_BASH"
		public static extern WeaponType MetalMediumBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_BASH"
		public static extern WeaponType MetalHeavyBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_STAB"
		public static extern WeaponType MetalMediumStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_STAB"
		public static extern WeaponType MetalHeavyStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_SLICE"
		public static extern WeaponType WoodLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_SLICE"
		public static extern WeaponType WoodMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_HEAVY_SLICE"
		public static extern WeaponType WoodHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_BASH"
		public static extern WeaponType WoodLightBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_BASH"
		public static extern WeaponType WoodMediumBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_HEAVY_BASH"
		public static extern WeaponType WoodHeavyBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_STAB"
		public static extern WeaponType WoodLightStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_STAB"
		public static extern WeaponType WoodMediumStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_LIGHT_SLICE"
		public static extern WeaponType ClawLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_MEDIUM_SLICE"
		public static extern WeaponType ClawMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_HEAVY_SLICE"
		public static extern WeaponType ClawHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_AXE_MEDIUM_CHOP"
		public static extern WeaponType AxeMediumChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_ROCK_HEAVY_BASH"
		public static extern WeaponType RockHeavyBash { get; }

		/// @CSharpLua.Template = "ConvertWeaponType({0})"
		public static extern WeaponType Convert(int weaponTypeId);
	}
}
