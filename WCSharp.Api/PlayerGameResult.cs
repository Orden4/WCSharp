using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerGameResult
	{
		internal PlayerGameResult()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playergameresult(PlayerGameResult x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerGameResult(playergameresult x);

		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_VICTORY"
		public static extern PlayerGameResult Victory { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_DEFEAT"
		public static extern PlayerGameResult Defeat { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_TIE"
		public static extern PlayerGameResult Tie { get; }
		/// @CSharpLua.Get = "PLAYER_GAME_RESULT_NEUTRAL"
		public static extern PlayerGameResult Neutral { get; }

		/// @CSharpLua.Template = "ConvertPlayerGameResult({0})"
		public static extern PlayerGameResult Convert(int playerGameResultId);
	}
}
