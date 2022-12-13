using static War3Api.Common;

namespace WCSharp.Api.Legacy
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class RacePreference
	{
		internal RacePreference()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator racepreference(RacePreference x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator RacePreference(racepreference x);

		/// @CSharpLua.Get = "RACE_PREF_HUMAN"
		public static extern RacePreference Human { get; }
		/// @CSharpLua.Get = "RACE_PREF_ORC"
		public static extern RacePreference Orc { get; }
		/// @CSharpLua.Get = "RACE_PREF_NIGHTELF"
		public static extern RacePreference NightElf { get; }
		/// @CSharpLua.Get = "RACE_PREF_UNDEAD"
		public static extern RacePreference Undead { get; }
		/// @CSharpLua.Get = "RACE_PREF_DEMON"
		public static extern RacePreference Demon { get; }
		/// @CSharpLua.Get = "RACE_PREF_RANDOM"
		public static extern RacePreference Random { get; }
		/// @CSharpLua.Get = "RACE_PREF_USER_SELECTABLE"
		public static extern RacePreference UserSelectable { get; }

		/// @CSharpLua.Template = "ConvertRacePref({0})"
		public static extern RacePreference Convert(int racePreferenceId);
	}
}
