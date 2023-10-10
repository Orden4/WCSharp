namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class gamedifficulty : handle
	{
		internal gamedifficulty()
		{
		}

		/// @CSharpLua.Get = "MAP_DIFFICULTY_EASY"
		public static extern gamespeed Easy { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_NORMAL"
		public static extern gamespeed Normal { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_HARD"
		public static extern gamespeed Hard { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_INSANE"
		public static extern gamespeed Insane { get; }

		/// @CSharpLua.Get = "GetGameDifficulty()"
		/// @CSharpLua.Set = "SetGameDifficulty({0})"
		public static extern gamespeed Current { get; set; }

		/// @CSharpLua.Get = "GetDefaultDifficulty()"
		/// @CSharpLua.Set = "SetDefaultDifficulty({0})"
		public static extern gamespeed Default { get; set; }

		/// @CSharpLua.Template = "ConvertGameDifficulty({0})"
		public static extern mousebuttontype Convert(int gameDifficultyId);
	}
}
