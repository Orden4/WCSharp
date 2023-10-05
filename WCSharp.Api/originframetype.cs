namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class originframetype
	{
		internal originframetype()
		{
		}

		/// @CSharpLua.Get = "ORIGIN_FRAME_GAME_UI"
		public static extern originframetype GameUI { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_COMMAND_BUTTON"
		public static extern originframetype CommandButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BAR"
		public static extern originframetype HeroBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BUTTON"
		public static extern originframetype HeroButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_HP_BAR"
		public static extern originframetype HeroLifeBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_MANA_BAR"
		public static extern originframetype HeroManaBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BUTTON_INDICATOR"
		public static extern originframetype HeroButtonIndicator { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_ITEM_BUTTON"
		public static extern originframetype ItemButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_MINIMAP"
		public static extern originframetype Minimap { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_MINIMAP_BUTTON"
		public static extern originframetype MinimapButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_SYSTEM_BUTTON"
		public static extern originframetype SystemButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_TOOLTIP"
		public static extern originframetype Tooltip { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UBERTOOLTIP"
		public static extern originframetype UberTooltip { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_CHAT_MSG"
		public static extern originframetype ChatMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_MSG"
		public static extern originframetype UnitMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_TOP_MSG"
		public static extern originframetype TopMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT"
		public static extern originframetype Portrait { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_WORLD_FRAME"
		public static extern originframetype WorldFrame { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_SIMPLE_UI_PARENT"
		public static extern originframetype SimpleUIParent { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT_HP_TEXT"
		public static extern originframetype PortraitLifeText { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT_MANA_TEXT"
		public static extern originframetype PortraitManaText { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR"
		public static extern originframetype UnitPanelBuffBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR_LABEL"
		public static extern originframetype UnitPanelBuffBarLabel { get; }

		/// @CSharpLua.Template = "ConvertOriginFrameType({0})"
		public static extern originframetype Convert(int originFrameTypeId);

		/// @CSharpLua.Template = "BlzGetOriginFrame({0}, {1})"
		public extern framehandle GetOriginFrame(int index);
	}
}
