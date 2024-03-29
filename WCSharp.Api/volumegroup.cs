﻿namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class volumegroup : handle
	{
		internal volumegroup()
		{
		}

		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_GENERAL"
		public static extern volumegroup CinematicGeneral { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_AMBIENT"
		public static extern volumegroup CinematicAmbient { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_MUSIC"
		public static extern volumegroup CinematicMusic { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_DIALOGUE"
		public static extern volumegroup CinematicDialogue { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_1"
		public static extern volumegroup CinematicSoundEffects1 { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_2"
		public static extern volumegroup CinematicSoundEffects2 { get; }
		/// @CSharpLua.Get = "SOUND_VOLUMEGROUP_CINEMATIC_SOUND_EFFECTS_3"
		public static extern volumegroup CinematicSoundEffects3 { get; }

		/// @CSharpLua.Template = "ConvertVolumeGroup({0})"
		public static extern volumegroup Convert(int volumeGroupId);
		/// @CSharpLua.Template = "VolumeGroupReset()"
		public static extern void Reset();

		/// @CSharpLua.Template = "VolumeGroupSetVolume({this}, {0})"
		public extern void SetVolume(float scale);
	}
}
