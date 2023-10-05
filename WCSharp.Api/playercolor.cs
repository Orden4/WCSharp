namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class playercolor
	{
		internal playercolor()
		{
		}

		/// @CSharpLua.Get = "PLAYER_COLOR_RED"
		public static extern playercolor Red { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_BLUE"
		public static extern playercolor Blue { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_CYAN"
		public static extern playercolor Cyan { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PURPLE"
		public static extern playercolor Purple { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_YELLOW"
		public static extern playercolor Yellow { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_ORANGE"
		public static extern playercolor Orange { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_GREEN"
		public static extern playercolor Green { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PINK"
		public static extern playercolor Pink { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LIGHT_GRAY"
		public static extern playercolor LightGray { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LIGHT_BLUE"
		public static extern playercolor LightBlue { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_AQUA"
		public static extern playercolor Aqua { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_BROWN"
		public static extern playercolor Brown { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_MAROON"
		public static extern playercolor Maroon { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_NAVY"
		public static extern playercolor Navy { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_TURQUOISE"
		public static extern playercolor Turquoise { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_VIOLET"
		public static extern playercolor Violet { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_WHEAT"
		public static extern playercolor Wheat { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PEACH"
		public static extern playercolor Peach { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_MINT"
		public static extern playercolor Mint { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_LAVENDER"
		public static extern playercolor Lavender { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_COAL"
		public static extern playercolor Coal { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_SNOW"
		public static extern playercolor Snow { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_EMERALD"
		public static extern playercolor Emerald { get; }
		/// @CSharpLua.Get = "PLAYER_COLOR_PEANUT"
		public static extern playercolor Peanut { get; }

		/// @CSharpLua.Template = "ConvertPlayerColor({0})"
		public static extern playercolor Convert(int playerColorId);
	}
}
