using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class PlayerColor
	{
		internal PlayerColor()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator playercolor(PlayerColor x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator PlayerColor(playercolor x);

		/// @CSharpLua.Get = "PLAYER_COLOR_RED"
		public static extern PlayerColor Red { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_BLUE"
		public static extern PlayerColor Blue { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_CYAN"
		public static extern PlayerColor Cyan { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PURPLE"
		public static extern PlayerColor Purple { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_YELLOW"
		public static extern PlayerColor Yellow { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_ORANGE"
		public static extern PlayerColor Orange { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_GREEN"
		public static extern PlayerColor Green { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PINK"
		public static extern PlayerColor Pink { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LIGHT_GRAY"
		public static extern PlayerColor LightGray { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LIGHT_BLUE"
		public static extern PlayerColor LightBlue { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_AQUA"
		public static extern PlayerColor Aqua { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_BROWN"
		public static extern PlayerColor Brown { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_MAROON"
		public static extern PlayerColor Maroon { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_NAVY"
		public static extern PlayerColor Navy { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_TURQUOISE"
		public static extern PlayerColor Turquoise { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_VIOLET"
		public static extern PlayerColor Violet { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_WHEAT"
		public static extern PlayerColor Wheat { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PEACH"
		public static extern PlayerColor Peach { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_MINT"
		public static extern PlayerColor Mint { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LAVENDER"
		public static extern PlayerColor Lavender { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_COAL"
		public static extern PlayerColor Coal { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_SNOW"
		public static extern PlayerColor Snow { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_EMERALD"
		public static extern PlayerColor Emerald { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PEANUT"
		public static extern PlayerColor Peanut { get; }

		/// @CSharpLua.Template = "ConvertPlayerColor({0})"
		public static extern PlayerColor Convert(int playerColorId);
	}
}
