using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class GameDifficulty
	{
		internal GameDifficulty()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator gamedifficulty(GameDifficulty x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator GameDifficulty(gamedifficulty x);

		/// @CSharpLua.Get = "MAP_DIFFICULTY_EASY"
		public static extern GameSpeed Easy { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_NORMAL"
		public static extern GameSpeed Normal { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_HARD"
		public static extern GameSpeed Hard { get; }
		/// @CSharpLua.Get = "MAP_DIFFICULTY_INSANE"
		public static extern GameSpeed Insane { get; }

		/// @CSharpLua.Get = "GetGameDifficulty()"
		/// @CSharpLua.Set = "SetGameDifficulty({0})"
		public static extern GameSpeed Current { get; set; }

		/// @CSharpLua.Get = "GetDefaultDifficulty()"
		/// @CSharpLua.Set = "SetDefaultDifficulty({0})"
		public static extern GameSpeed Default { get; set; }

		/// @CSharpLua.Template = "ConvertGameDifficulty({0})"
		public static extern MouseButtonType Convert(int gameDifficulty);
	}
}
