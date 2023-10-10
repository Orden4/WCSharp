namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playerevent : eventid
	{
		internal playerevent()
		{
		}

		/// @CSharpLua.Get = "EVENT_PLAYER_STATE_LIMIT"
		public static extern playerevent StateLimit { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ALLIANCE_CHANGED"
		public static extern playerevent AllianceChanged { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_DEFEAT"
		public static extern playerevent Defeat { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_VICTORY"
		public static extern playerevent Victory { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_LEAVE"
		public static extern playerevent Leave { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_CHAT"
		public static extern playerevent Chat { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_END_CINEMATIC"
		public static extern playerevent EndCinematic { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_LEFT_DOWN"
		public static extern playerevent ArrowLeftDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_LEFT_UP"
		public static extern playerevent ArrowLeftUp { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_RIGHT_DOWN"
		public static extern playerevent ArrowRightDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_RIGHT_UP"
		public static extern playerevent ArrowRightUp { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_DOWN_DOWN"
		public static extern playerevent ArrowDownDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_DOWN_UP"
		public static extern playerevent ArrowDownUp { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_UP_DOWN"
		public static extern playerevent ArrowUpDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_ARROW_UP_UP"
		public static extern playerevent ArrowUpUp { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_MOUSE_DOWN"
		public static extern playerevent MouseDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_MOUSE_UP"
		public static extern playerevent MouseUp { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_MOUSE_MOVE"
		public static extern playerevent MouseMove { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_SYNC_DATA"
		public static extern playerevent SyncData { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_KEY"
		public static extern playerevent Key { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_KEY_DOWN"
		public static extern playerevent KeyDown { get; }
		/// @CSharpLua.Get = "EVENT_PLAYER_KEY_UP"
		public static extern playerevent KeyUp { get; }

		/// @CSharpLua.Template = "ConvertPlayerEvent({0})"
		public static extern playerevent Convert(int playerEventId);
	}
}
