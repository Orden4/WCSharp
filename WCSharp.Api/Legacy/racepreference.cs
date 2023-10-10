namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class racepreference : handle
	{
		internal racepreference()
		{
		}

		/// @CSharpLua.Get = "RACE_PREF_HUMAN"
		public static extern racepreference Human { get; }
		/// @CSharpLua.Get = "RACE_PREF_ORC"
		public static extern racepreference Orc { get; }
		/// @CSharpLua.Get = "RACE_PREF_NIGHTELF"
		public static extern racepreference NightElf { get; }
		/// @CSharpLua.Get = "RACE_PREF_UNDEAD"
		public static extern racepreference Undead { get; }
		/// @CSharpLua.Get = "RACE_PREF_DEMON"
		public static extern racepreference Demon { get; }
		/// @CSharpLua.Get = "RACE_PREF_RANDOM"
		public static extern racepreference Random { get; }
		/// @CSharpLua.Get = "RACE_PREF_USER_SELECTABLE"
		public static extern racepreference UserSelectable { get; }

		/// @CSharpLua.Template = "ConvertRacePref({0})"
		public static extern racepreference Convert(int racePreferenceId);
	}
}
