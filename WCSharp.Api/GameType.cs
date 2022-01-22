using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class GameType
	{
		internal GameType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator gametype(GameType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator GameType(gametype x);

		/// @CSharpLua.Get = "GAME_TYPE_MELEE"
		public static extern GameType Melee { get; }
		/// @CSharpLua.Get = "GAME_TYPE_FFA"
		public static extern GameType FreeForAll { get; }
		/// @CSharpLua.Get = "GAME_TYPE_USE_MAP_SETTINGS"
		public static extern GameType UseMapSettings { get; }
		/// @CSharpLua.Get = "GAME_TYPE_BLIZ"
		public static extern GameType Bliz { get; }
		/// @CSharpLua.Get = "GAME_TYPE_ONE_ON_ONE"
		public static extern GameType OneOnOne { get; }
		/// @CSharpLua.Get = "GAME_TYPE_TWO_TEAM_PLAY"
		public static extern GameType TwoTeamPlay { get; }
		/// @CSharpLua.Get = "GAME_TYPE_THREE_TEAM_PLAY"
		public static extern GameType ThreeTeamPlay { get; }
		/// @CSharpLua.Get = "GAME_TYPE_FOUR_TEAM_PLAY"
		public static extern GameType FourTeamPlay { get; }

		/// @CSharpLua.Get = "GetGameTypeSelected()"
		public static extern GameType Selected { get; }

		/// @CSharpLua.Template = "ConvertGameType({0})"
		public static extern AiDifficulty Convert(int gameType);

		/// @CSharpLua.Get = "IsGameTypeSupported({0})"
		/// @CSharpLua.Set = "SetGameTypeSupported({0}, {1})"
		public extern bool Supported { get; set; }
	}
}
