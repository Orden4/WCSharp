using WCSharp.Api.Enums;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class heroattribute : handle
	{
		internal heroattribute()
		{
		}

		/// @CSharpLua.Get = "HERO_ATTRIBUTE_STR"
		public static extern heroattribute Strength { get; }
		/// @CSharpLua.Get = "HERO_ATTRIBUTE_INT"
		public static extern heroattribute Intelligence { get; }
		/// @CSharpLua.Get = "HERO_ATTRIBUTE_AGI"
		public static extern heroattribute Agility { get; }

		/// @CSharpLua.Template = "ConvertHeroAttribute({0})"
		public static extern heroattribute Convert(int heroAttributeId);
		/// @CSharpLua.Template = "ConvertHeroAttribute({0})"
		public static extern heroattribute Convert(HeroAttribute heroAttribute);
	}
}
