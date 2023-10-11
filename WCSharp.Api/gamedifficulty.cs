namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class gamedifficulty : handle
	{
		internal gamedifficulty()
		{
		}

		/// @CSharpLua.Get = "MAP_DIFFICULTY_EASY"
		public static extern gamedifficulty Easy { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_NORMAL"
		public static extern gamedifficulty Normal { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_HARD"
		public static extern gamedifficulty Hard { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_INSANE"
		public static extern gamedifficulty Insane { get; }

		/// @CSharpLua.Get = "GetGameDifficulty()"
		/// @CSharpLua.Set = "SetGameDifficulty({0})"
		public static extern gamedifficulty Current { get; set; }

		/// @CSharpLua.Get = "GetDefaultDifficulty()"
		/// @CSharpLua.Set = "SetDefaultDifficulty({0})"
		public static extern gamedifficulty Default { get; set; }

		/// @CSharpLua.Template = "ConvertGameDifficulty({0})"
		public static extern gamedifficulty Convert(int gameDifficultyId);
	}
}
