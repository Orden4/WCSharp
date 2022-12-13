using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class SoundType
	{
		internal SoundType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator soundtype(SoundType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator SoundType(soundtype x);

		/// @CSharpLua.Get = "SOUND_TYPE_EFFECT"
		public static extern SoundType Effect { get; }
		/// @CSharpLua.Get = "SOUND_TYPE_EFFECT_LOOPED"
		public static extern SoundType EffectLooped { get; }

		/// @CSharpLua.Template = "ConvertSoundType({0})"
		public static extern SoundType Convert(int soundTypeId);
	}
}
