using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class OriginFrameType
	{
		internal OriginFrameType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator originframetype(OriginFrameType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator OriginFrameType(originframetype x);

		/// @CSharpLua.Get = "ORIGIN_FRAME_GAME_UI"
		public static extern OriginFrameType GameUI { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_COMMAND_BUTTON"
		public static extern OriginFrameType CommandButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BAR"
		public static extern OriginFrameType HeroBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BUTTON"
		public static extern OriginFrameType HeroButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_HP_BAR"
		public static extern OriginFrameType HeroLifeBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_MANA_BAR"
		public static extern OriginFrameType HeroManaBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_HERO_BUTTON_INDICATOR"
		public static extern OriginFrameType HeroButtonIndicator { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_ITEM_BUTTON"
		public static extern OriginFrameType ItemButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_MINIMAP"
		public static extern OriginFrameType Minimap { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_MINIMAP_BUTTON"
		public static extern OriginFrameType MinimapButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_SYSTEM_BUTTON"
		public static extern OriginFrameType SystemButton { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_TOOLTIP"
		public static extern OriginFrameType Tooltip { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UBERTOOLTIP"
		public static extern OriginFrameType UberTooltip { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_CHAT_MSG"
		public static extern OriginFrameType ChatMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_MSG"
		public static extern OriginFrameType UnitMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_TOP_MSG"
		public static extern OriginFrameType TopMessage { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT"
		public static extern OriginFrameType Portrait { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_WORLD_FRAME"
		public static extern OriginFrameType WorldFrame { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_SIMPLE_UI_PARENT"
		public static extern OriginFrameType SimpleUIParent { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT_HP_TEXT"
		public static extern OriginFrameType PortraitLifeText { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_PORTRAIT_MANA_TEXT"
		public static extern OriginFrameType PortraitManaText { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR"
		public static extern OriginFrameType UnitPanelBuffBar { get; }
		/// @CSharpLua.Get = "ORIGIN_FRAME_UNIT_PANEL_BUFF_BAR_LABEL"
		public static extern OriginFrameType UnitPanelBuffBarLabel { get; }

		/// @CSharpLua.Template = "ConvertOriginFrameType({0})"
		public static extern OriginFrameType Convert(int originFrameTypeId);

		/// @CSharpLua.Template = "BlzGetOriginFrame({0})"
		public static extern FrameHandle GetOriginFrame(int index);
	}
}
