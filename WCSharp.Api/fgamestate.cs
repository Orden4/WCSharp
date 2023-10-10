namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class fgamestate : gamestate
	{
		internal fgamestate()
		{
		}

		/// @CSharpLua.Get = "GAME_STATE_TIME_OF_DAY"
		public static extern fgamestate TimeOfDay { get; }

		/// @CSharpLua.Get = "GetFloatGameState({this})"
		/// @CSharpLua.Set = "SetFloatGameState({this}, {0})"
		public extern float Value { get; set; }

		/// @CSharpLua.Template = "ConvertFGameState({0})"
		public static extern fgamestate Convert(int fGameStateId);
	}
}
