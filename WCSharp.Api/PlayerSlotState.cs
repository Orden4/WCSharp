using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerSlotState
	{
		internal PlayerSlotState()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playerslotstate(PlayerSlotState x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerSlotState(playerslotstate x);

		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_EMPTY"
		public static extern PlayerSlotState Empty { get; }
		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_PLAYING"
		public static extern PlayerSlotState Playing { get; }
		/// @CSharpLua.Get = "PLAYER_SLOT_STATE_LEFT"
		public static extern PlayerSlotState Left { get; }

		/// @CSharpLua.Template = "ConvertPlayerSlotState({0})"
		public static extern PlayerSlotState Convert(int playerSlotState);
	}
}
