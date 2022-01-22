using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class EffectType
	{
		internal EffectType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator effecttype(EffectType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator EffectType(effecttype x);

		/// @CSharpLua.Get = "EFFECT_TYPE_EFFECT"
		public static extern EffectType Effect { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_TARGET"
		public static extern EffectType Target { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_CASTER"
		public static extern EffectType Caster { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_SPECIAL"
		public static extern EffectType Special { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_AREA_EFFECT"
		public static extern EffectType AreaEffect { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_MISSILE"
		public static extern EffectType Missile { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_LIGHTNING"
		public static extern EffectType Lightning { get; }

		/// @CSharpLua.Template = "ConvertEffectType({0})"
		public static extern EffectType Convert(int effectType);
	}
}
