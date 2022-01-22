using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AnimType
	{
		internal AnimType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator animtype(AnimType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AnimType(animtype x);

		/// @CSharpLua.Get = "ANIM_TYPE_BIRTH"
		public static extern AnimType Birth { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DEATH"
		public static extern AnimType Death { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DECAY"
		public static extern AnimType Decay { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DISSIPATE"
		public static extern AnimType Dissipate { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_STAND"
		public static extern AnimType Stand { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_WALK"
		public static extern AnimType Walk { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_ATTACK"
		public static extern AnimType Attack { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_MORPH"
		public static extern AnimType Morph { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_SLEEP"
		public static extern AnimType Sleep { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_SPELL"
		public static extern AnimType Spell { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_PORTRAIT"
		public static extern AnimType Portrait { get; }

		/// @CSharpLua.Template = "ConvertAnimType({0})"
		public static extern AnimType Convert(int animType);

		/// @CSharpLua.Get = "BlzGetAnimName({0})"
		public extern string Name { get; }
	}
}
