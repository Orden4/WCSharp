namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class blendmode : handle
	{
		internal blendmode()
		{
		}

		/// @CSharpLua.Get = "BLEND_MODE_NONE"
		public static extern blendmode None { get; }
		/// @CSharpLua.Get = "BLEND_MODE_DONT_CARE"
		public static extern blendmode DontCare { get; }
		/// @CSharpLua.Get = "BLEND_MODE_KEYALPHA"
		public static extern blendmode KeyAlpha { get; }
		/// @CSharpLua.Get = "BLEND_MODE_BLEND"
		public static extern blendmode Blend { get; }
		/// @CSharpLua.Get = "BLEND_MODE_ADDITIVE"
		public static extern blendmode Additive { get; }
		/// @CSharpLua.Get = "BLEND_MODE_MODULATE"
		public static extern blendmode Modulate { get; }
		/// @CSharpLua.Get = "BLEND_MODE_MODULATE_2X"
		public static extern blendmode Modulate2x { get; }

		/// @CSharpLua.Template = "SetCineFilterBlendMode({0})"
		public extern void Enable();

		/// @CSharpLua.Template = "ConvertBlendMode({0})"
		public static extern blendmode Convert(int blendModeId);
	}
}
