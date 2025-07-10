using WCSharp.Api.Enums;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class weapontype : handle
	{
		internal weapontype()
		{
		}

		/// @CSharpLua.Get = "WEAPON_TYPE_WHOKNOWS"
		public static extern weapontype WhoKnows { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_LIGHT_CHOP"
		public static extern weapontype MetalLightChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_CHOP"
		public static extern weapontype MetalMediumChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_CHOP"
		public static extern weapontype MetalHeavyChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_LIGHT_SLICE"
		public static extern weapontype MetalLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_SLICE"
		public static extern weapontype MetalMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_SLICE"
		public static extern weapontype MetalHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_BASH"
		public static extern weapontype MetalMediumBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_BASH"
		public static extern weapontype MetalHeavyBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_MEDIUM_STAB"
		public static extern weapontype MetalMediumStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_METAL_HEAVY_STAB"
		public static extern weapontype MetalHeavyStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_SLICE"
		public static extern weapontype WoodLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_SLICE"
		public static extern weapontype WoodMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_HEAVY_SLICE"
		public static extern weapontype WoodHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_BASH"
		public static extern weapontype WoodLightBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_BASH"
		public static extern weapontype WoodMediumBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_HEAVY_BASH"
		public static extern weapontype WoodHeavyBash { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_LIGHT_STAB"
		public static extern weapontype WoodLightStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_WOOD_MEDIUM_STAB"
		public static extern weapontype WoodMediumStab { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_LIGHT_SLICE"
		public static extern weapontype ClawLightSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_MEDIUM_SLICE"
		public static extern weapontype ClawMediumSlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_CLAW_HEAVY_SLICE"
		public static extern weapontype ClawHeavySlice { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_AXE_MEDIUM_CHOP"
		public static extern weapontype AxeMediumChop { get; }
		/// @CSharpLua.Get = "WEAPON_TYPE_ROCK_HEAVY_BASH"
		public static extern weapontype RockHeavyBash { get; }

		/// @CSharpLua.Template = "ConvertWeaponType({0})"
		public static extern weapontype Convert(int weaponTypeId);
		/// @CSharpLua.Template = "ConvertWeaponType({0})"
		public static extern weapontype Convert(WeaponType weaponType);
	}
}
