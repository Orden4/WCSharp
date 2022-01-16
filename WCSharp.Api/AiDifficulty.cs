using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class AiDifficulty
	{
		internal AiDifficulty()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator aidifficulty(AiDifficulty x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator AiDifficulty(aidifficulty x);

		/// @CSharpLua.Get = "AI_DIFFICULTY_NEWBIE"
		public static extern AiDifficulty Newbie { get; }
		/// @CSharpLua.Get = "AI_DIFFICULTY_NORMAL"
		public static extern AiDifficulty Normal { get; }
		/// @CSharpLua.Get = "AI_DIFFICULTY_INSANE"
		public static extern AiDifficulty Insane { get; }

		/// @CSharpLua.Template = "ConvertAIDifficulty({0})"
		public static extern AiDifficulty Convert(int difficulty);

		/// @CSharpLua.Template = "GetAIDifficulty({0})"
		public static extern AiDifficulty Get(Player player);
	}
}
