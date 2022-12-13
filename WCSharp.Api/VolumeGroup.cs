using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class VolumeGroup
	{
		internal VolumeGroup()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator volumegroup(VolumeGroup x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator VolumeGroup(volumegroup x);

		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_GENERAL"
		public static extern VolumeGroup CinematicGeneral { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_AMBIENT"
		public static extern VolumeGroup CinematicAmbient { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_MUSIC"
		public static extern VolumeGroup CinematicMusic { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_DIALOGUE"
		public static extern VolumeGroup CinematicDialogue { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_1"
		public static extern VolumeGroup CinematicSoundEffects1 { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_2"
		public static extern VolumeGroup CinematicSoundEffects2 { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_3"
		public static extern VolumeGroup CinematicSoundEffects3 { get; }

		/// @CSharpLua.Template = "ConvertVolumeGroup({0})"
		public static extern VolumeGroup Convert(int volumeGroupId);

		/// @CSharpLua.Template = "VolumeGroupSetVolume({0}, {1})"
		public extern void SetVolume(float scale);

		/// @CSharpLua.Template = "VolumeGroupReset({0})"
		public extern void Reset();
	}
}
