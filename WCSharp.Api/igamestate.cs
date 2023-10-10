namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class igamestate : gamestate
	{
		internal igamestate()
		{
		}

		/// @CSharpLua.Get = "GAME_STATE_DIVINE_INTERVENTION"
		public static extern igamestate DivineIntervention { get; }

		/// @CSharpLua.Get = "GAME_STATE_DISCONNECTED"
		public static extern igamestate Disconnected { get; }

		/// @CSharpLua.Get = "GetIntegerGameState({0})"
		/// @CSharpLua.Set = "SetIntegerGameState({0}, {1})"
		public extern int Value { get; set; }


		/// @CSharpLua.Template = "ConvertIGameState({0})"
		public static extern igamestate Convert(int iGameStateId);
	}
}
