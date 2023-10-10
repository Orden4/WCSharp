namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class gametype : handle
	{
		internal gametype()
		{
		}

		/// @CSharpLua.Get = "GAME_TYPE_MELEE"
		public static extern gametype Melee { get; }
		/// @CSharpLua.Get = "GAME_TYPE_FFA"
		public static extern gametype FreeForAll { get; }
		/// @CSharpLua.Get = "GAME_TYPE_USE_MAP_SETTINGS"
		public static extern gametype UseMapSettings { get; }
		/// @CSharpLua.Get = "GAME_TYPE_BLIZ"
		public static extern gametype Bliz { get; }
		/// @CSharpLua.Get = "GAME_TYPE_ONE_ON_ONE"
		public static extern gametype OneOnOne { get; }
		/// @CSharpLua.Get = "GAME_TYPE_TWO_TEAM_PLAY"
		public static extern gametype TwoTeamPlay { get; }
		/// @CSharpLua.Get = "GAME_TYPE_THREE_TEAM_PLAY"
		public static extern gametype ThreeTeamPlay { get; }
		/// @CSharpLua.Get = "GAME_TYPE_FOUR_TEAM_PLAY"
		public static extern gametype FourTeamPlay { get; }

		/// @CSharpLua.Get = "GetGameTypeSelected()"
		public static extern gametype Selected { get; }

		/// @CSharpLua.Template = "ConvertGameType({0})"
		public static extern gametype Convert(int gameTypeId);

		/// @CSharpLua.Get = "IsGameTypeSupported({0})"
		/// @CSharpLua.Set = "SetGameTypeSupported({0}, {1})"
		public extern bool Supported { get; set; }
	}
}
