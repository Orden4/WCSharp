namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playerslotstate : handle
	{
		internal playerslotstate()
		{
		}

		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_EMPTY"
		public static extern playerslotstate Empty { get; }
		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_PLAYING"
		public static extern playerslotstate Playing { get; }
		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_LEFT"
		public static extern playerslotstate Left { get; }

		/// @CSharpLua.Template = "ConvertPlayerSlotState({0})"
		public static extern playerslotstate Convert(int playerSlotStateId);
	}
}
