namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playergameresult
	{
		internal playergameresult()
		{
		}

		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_VICTORY"
		public static extern playergameresult Victory { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_DEFEAT"
		public static extern playergameresult Defeat { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_TIE"
		public static extern playergameresult Tie { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_NEUTRAL"
		public static extern playergameresult Neutral { get; }

		/// @CSharpLua.Template = "ConvertPlayerGameResult({0})"
		public static extern playergameresult Convert(int playerGameResultId);
	}
}
