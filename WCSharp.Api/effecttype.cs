namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class effecttype : handle
	{
		internal effecttype()
		{
		}

		/// @CSharpLua.Get = "EFFECT_TYPE_EFFECT"
		public static extern effecttype Effect { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_TARGET"
		public static extern effecttype Target { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_CASTER"
		public static extern effecttype Caster { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_SPECIAL"
		public static extern effecttype Special { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_AREA_EFFECT"
		public static extern effecttype AreaEffect { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_MISSILE"
		public static extern effecttype Missile { get; }
		/// @CSharpLua.Get = "EFFECT_TYPE_LIGHTNING"
		public static extern effecttype Lightning { get; }

		/// @CSharpLua.Template = "ConvertEffectType({0})"
		public static extern effecttype Convert(int effectTypeId);
	}
}
