namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class animtype : handle
	{
		internal animtype()
		{
		}

		/// @CSharpLua.Get = "ANIM_TYPE_BIRTH"
		public static extern animtype Birth { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DEATH"
		public static extern animtype Death { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DECAY"
		public static extern animtype Decay { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_DISSIPATE"
		public static extern animtype Dissipate { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_STAND"
		public static extern animtype Stand { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_WALK"
		public static extern animtype Walk { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_ATTACK"
		public static extern animtype Attack { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_MORPH"
		public static extern animtype Morph { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_SLEEP"
		public static extern animtype Sleep { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_SPELL"
		public static extern animtype Spell { get; }
		/// @CSharpLua.Get = "ANIM_TYPE_PORTRAIT"
		public static extern animtype Portrait { get; }

		/// @CSharpLua.Template = "ConvertAnimType({0})"
		public static extern animtype Convert(int animTypeId);

		/// @CSharpLua.Get = "BlzGetAnimName({this})"
		public extern string Name { get; }
	}
}
