using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Race
	{
		internal Race()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator race(Race x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Race(race x);

		/// @CSharpLua.Get = "RACE_HUMAN"
		public static extern Race Human { get; }
		/// @CSharpLua.Get = "RACE_ORC"
		public static extern Race Orc { get; }
		/// @CSharpLua.Get = "RACE_UNDEAD"
		public static extern Race Undead { get; }
		/// @CSharpLua.Get = "RACE_NIGHTELF"
		public static extern Race NightElf { get; }
		/// @CSharpLua.Get = "RACE_DEMON"
		public static extern Race Demon { get; }
		/// @CSharpLua.Get = "RACE_OTHER"
		public static extern Race Other { get; }

		/// @CSharpLua.Template = "ConvertRace({0})"
		public static extern Race Convert(int raceId);
	}
}
