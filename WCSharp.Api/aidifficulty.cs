namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class aidifficulty
	{
		internal aidifficulty()
		{
		}

		/// @CSharpLua.Get = "AI_DIFFICULTY_NEWBIE"
		public static extern aidifficulty Newbie { get; }
		/// @CSharpLua.Get = "AI_DIFFICULTY_NORMAL"
		public static extern aidifficulty Normal { get; }
		/// @CSharpLua.Get = "AI_DIFFICULTY_INSANE"
		public static extern aidifficulty Insane { get; }

		/// @CSharpLua.Template = "ConvertAIDifficulty({0})"
		public static extern aidifficulty Convert(int difficultyId);

		/// @CSharpLua.Template = "GetAIDifficulty({0})"
		public static extern aidifficulty Get(player player);
	}
}
