namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class race
	{
		internal race()
		{
		}

		/// @CSharpLua.Get = "RACE_HUMAN"
		public static extern race Human { get; }
		/// @CSharpLua.Get = "RACE_ORC"
		public static extern race Orc { get; }
		/// @CSharpLua.Get = "RACE_UNDEAD"
		public static extern race Undead { get; }
		/// @CSharpLua.Get = "RACE_NIGHTELF"
		public static extern race NightElf { get; }
		/// @CSharpLua.Get = "RACE_DEMON"
		public static extern race Demon { get; }
		/// @CSharpLua.Get = "RACE_OTHER"
		public static extern race Other { get; }

		/// @CSharpLua.Template = "ConvertRace({0})"
		public static extern race Convert(int raceId);
	}
}
