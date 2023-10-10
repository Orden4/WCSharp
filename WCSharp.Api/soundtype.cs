namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class soundtype : handle
	{
		internal soundtype()
		{
		}

		/// @CSharpLua.Get = "SOUND_TYPE_EFFECT"
		public static extern soundtype Effect { get; }
		/// @CSharpLua.Get = "SOUND_TYPE_EFFECT_LOOPED"
		public static extern soundtype EffectLooped { get; }

		/// @CSharpLua.Template = "ConvertSoundType({0})"
		public static extern soundtype Convert(int soundTypeId);
	}
}
