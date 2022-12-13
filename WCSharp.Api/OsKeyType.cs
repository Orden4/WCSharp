using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class OsKeyType
	{
		internal OsKeyType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator oskeytype(OsKeyType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator OsKeyType(oskeytype x);

		/// @CSharpLua.Get = "OSKEY_BACKSPACE"
		public static extern OsKeyType Backspace { get; }
		/// @CSharpLua.Get = "OSKEY_TAB"
		public static extern OsKeyType Tab { get; }
		/// @CSharpLua.Get = "OSKEY_CLEAR"
		public static extern OsKeyType Clear { get; }
		/// @CSharpLua.Get = "OSKEY_RETURN"
		public static extern OsKeyType Return { get; }
		/// @CSharpLua.Get = "OSKEY_SHIFT"
		public static extern OsKeyType Shift { get; }
		/// @CSharpLua.Get = "OSKEY_CONTROL"
		public static extern OsKeyType Control { get; }
		/// @CSharpLua.Get = "OSKEY_ALT"
		public static extern OsKeyType Alt { get; }
		/// @CSharpLua.Get = "OSKEY_PAUSE"
		public static extern OsKeyType Pause { get; }
		/// @CSharpLua.Get = "OSKEY_CAPSLOCK"
		public static extern OsKeyType CapsLock { get; }
		/// @CSharpLua.Get = "OSKEY_KANA"
		public static extern OsKeyType Kana { get; }
		/// @CSharpLua.Get = "OSKEY_HANGUL"
		public static extern OsKeyType Hangul { get; }
		/// @CSharpLua.Get = "OSKEY_JUNJA"
		public static extern OsKeyType Junja { get; }
		/// @CSharpLua.Get = "OSKEY_FINAL"
		public static extern OsKeyType Final { get; }
		/// @CSharpLua.Get = "OSKEY_HANJA"
		public static extern OsKeyType Hanja { get; }
		/// @CSharpLua.Get = "OSKEY_KANJI"
		public static extern OsKeyType Kanji { get; }
		/// @CSharpLua.Get = "OSKEY_ESCAPE"
		public static extern OsKeyType Escape { get; }
		/// @CSharpLua.Get = "OSKEY_CONVERT"
		public static extern OsKeyType ConvertKey { get; }
		/// @CSharpLua.Get = "OSKEY_NONCONVERT"
		public static extern OsKeyType NonConvert { get; }
		/// @CSharpLua.Get = "OSKEY_ACCEPT"
		public static extern OsKeyType Accept { get; }
		/// @CSharpLua.Get = "OSKEY_MODECHANGE"
		public static extern OsKeyType ModeChange { get; }
		/// @CSharpLua.Get = "OSKEY_SPACE"
		public static extern OsKeyType Space { get; }
		/// @CSharpLua.Get = "OSKEY_PAGEUP"
		public static extern OsKeyType PageUp { get; }
		/// @CSharpLua.Get = "OSKEY_PAGEDOWN"
		public static extern OsKeyType PageDown { get; }
		/// @CSharpLua.Get = "OSKEY_END"
		public static extern OsKeyType End { get; }
		/// @CSharpLua.Get = "OSKEY_HOME"
		public static extern OsKeyType Home { get; }
		/// @CSharpLua.Get = "OSKEY_LEFT"
		public static extern OsKeyType Left { get; }
		/// @CSharpLua.Get = "OSKEY_UP"
		public static extern OsKeyType Up { get; }
		/// @CSharpLua.Get = "OSKEY_RIGHT"
		public static extern OsKeyType Right { get; }
		/// @CSharpLua.Get = "OSKEY_DOWN"
		public static extern OsKeyType Down { get; }
		/// @CSharpLua.Get = "OSKEY_SELECT"
		public static extern OsKeyType Select { get; }
		/// @CSharpLua.Get = "OSKEY_PRINT"
		public static extern OsKeyType Print { get; }
		/// @CSharpLua.Get = "OSKEY_EXECUTE"
		public static extern OsKeyType Execute { get; }
		/// @CSharpLua.Get = "OSKEY_PRINTSCREEN"
		public static extern OsKeyType PrintScreen { get; }
		/// @CSharpLua.Get = "OSKEY_INSERT"
		public static extern OsKeyType Insert { get; }
		/// @CSharpLua.Get = "OSKEY_DELETE"
		public static extern OsKeyType Delete { get; }
		/// @CSharpLua.Get = "OSKEY_HELP"
		public static extern OsKeyType Help { get; }
		/// @CSharpLua.Get = "OSKEY_0"
		public static extern OsKeyType D0 { get; }
		/// @CSharpLua.Get = "OSKEY_1"
		public static extern OsKeyType D1 { get; }
		/// @CSharpLua.Get = "OSKEY_2"
		public static extern OsKeyType D2 { get; }
		/// @CSharpLua.Get = "OSKEY_3"
		public static extern OsKeyType D3 { get; }
		/// @CSharpLua.Get = "OSKEY_4"
		public static extern OsKeyType D4 { get; }
		/// @CSharpLua.Get = "OSKEY_5"
		public static extern OsKeyType D5 { get; }
		/// @CSharpLua.Get = "OSKEY_6"
		public static extern OsKeyType D6 { get; }
		/// @CSharpLua.Get = "OSKEY_7"
		public static extern OsKeyType D7 { get; }
		/// @CSharpLua.Get = "OSKEY_8"
		public static extern OsKeyType D8 { get; }
		/// @CSharpLua.Get = "OSKEY_9"
		public static extern OsKeyType D9 { get; }
		/// @CSharpLua.Get = "OSKEY_A"
		public static extern OsKeyType A { get; }
		/// @CSharpLua.Get = "OSKEY_B"
		public static extern OsKeyType B { get; }
		/// @CSharpLua.Get = "OSKEY_C"
		public static extern OsKeyType C { get; }
		/// @CSharpLua.Get = "OSKEY_D"
		public static extern OsKeyType D { get; }
		/// @CSharpLua.Get = "OSKEY_E"
		public static extern OsKeyType E { get; }
		/// @CSharpLua.Get = "OSKEY_F"
		public static extern OsKeyType F { get; }
		/// @CSharpLua.Get = "OSKEY_G"
		public static extern OsKeyType G { get; }
		/// @CSharpLua.Get = "OSKEY_H"
		public static extern OsKeyType H { get; }
		/// @CSharpLua.Get = "OSKEY_I"
		public static extern OsKeyType I { get; }
		/// @CSharpLua.Get = "OSKEY_J"
		public static extern OsKeyType J { get; }
		/// @CSharpLua.Get = "OSKEY_K"
		public static extern OsKeyType K { get; }
		/// @CSharpLua.Get = "OSKEY_L"
		public static extern OsKeyType L { get; }
		/// @CSharpLua.Get = "OSKEY_M"
		public static extern OsKeyType M { get; }
		/// @CSharpLua.Get = "OSKEY_N"
		public static extern OsKeyType N { get; }
		/// @CSharpLua.Get = "OSKEY_O"
		public static extern OsKeyType O { get; }
		/// @CSharpLua.Get = "OSKEY_P"
		public static extern OsKeyType P { get; }
		/// @CSharpLua.Get = "OSKEY_Q"
		public static extern OsKeyType Q { get; }
		/// @CSharpLua.Get = "OSKEY_R"
		public static extern OsKeyType R { get; }
		/// @CSharpLua.Get = "OSKEY_S"
		public static extern OsKeyType S { get; }
		/// @CSharpLua.Get = "OSKEY_T"
		public static extern OsKeyType T { get; }
		/// @CSharpLua.Get = "OSKEY_U"
		public static extern OsKeyType U { get; }
		/// @CSharpLua.Get = "OSKEY_V"
		public static extern OsKeyType V { get; }
		/// @CSharpLua.Get = "OSKEY_W"
		public static extern OsKeyType W { get; }
		/// @CSharpLua.Get = "OSKEY_X"
		public static extern OsKeyType X { get; }
		/// @CSharpLua.Get = "OSKEY_Y"
		public static extern OsKeyType Y { get; }
		/// @CSharpLua.Get = "OSKEY_Z"
		public static extern OsKeyType Z { get; }
		/// @CSharpLua.Get = "OSKEY_LMETA"
		public static extern OsKeyType LMeta { get; }
		/// @CSharpLua.Get = "OSKEY_RMETA"
		public static extern OsKeyType RMeta { get; }
		/// @CSharpLua.Get = "OSKEY_APPS"
		public static extern OsKeyType Apps { get; }
		/// @CSharpLua.Get = "OSKEY_SLEEP"
		public static extern OsKeyType Sleep { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD0"
		public static extern OsKeyType NumPad0 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD1"
		public static extern OsKeyType NumPad1 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD2"
		public static extern OsKeyType NumPad2 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD3"
		public static extern OsKeyType NumPad3 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD4"
		public static extern OsKeyType NumPad4 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD5"
		public static extern OsKeyType NumPad5 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD6"
		public static extern OsKeyType NumPad6 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD7"
		public static extern OsKeyType NumPad7 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD8"
		public static extern OsKeyType NumPad8 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMPAD9"
		public static extern OsKeyType NumPad9 { get; }
		/// @CSharpLua.Get = "OSKEY_MULTIPLY"
		public static extern OsKeyType Multiply { get; }
		/// @CSharpLua.Get = "OSKEY_ADD"
		public static extern OsKeyType Add { get; }
		/// @CSharpLua.Get = "OSKEY_SEPARATOR"
		public static extern OsKeyType Separator { get; }
		/// @CSharpLua.Get = "OSKEY_SUBTRACT"
		public static extern OsKeyType Subtract { get; }
		/// @CSharpLua.Get = "OSKEY_DECIMAL"
		public static extern OsKeyType Decimal { get; }
		/// @CSharpLua.Get = "OSKEY_DIVIDE"
		public static extern OsKeyType Divide { get; }
		/// @CSharpLua.Get = "OSKEY_F1"
		public static extern OsKeyType F1 { get; }
		/// @CSharpLua.Get = "OSKEY_F2"
		public static extern OsKeyType F2 { get; }
		/// @CSharpLua.Get = "OSKEY_F3"
		public static extern OsKeyType F3 { get; }
		/// @CSharpLua.Get = "OSKEY_F4"
		public static extern OsKeyType F4 { get; }
		/// @CSharpLua.Get = "OSKEY_F5"
		public static extern OsKeyType F5 { get; }
		/// @CSharpLua.Get = "OSKEY_F6"
		public static extern OsKeyType F6 { get; }
		/// @CSharpLua.Get = "OSKEY_F7"
		public static extern OsKeyType F7 { get; }
		/// @CSharpLua.Get = "OSKEY_F8"
		public static extern OsKeyType F8 { get; }
		/// @CSharpLua.Get = "OSKEY_F9"
		public static extern OsKeyType F9 { get; }
		/// @CSharpLua.Get = "OSKEY_F10"
		public static extern OsKeyType F10 { get; }
		/// @CSharpLua.Get = "OSKEY_F11"
		public static extern OsKeyType F11 { get; }
		/// @CSharpLua.Get = "OSKEY_F12"
		public static extern OsKeyType F12 { get; }
		/// @CSharpLua.Get = "OSKEY_F13"
		public static extern OsKeyType F13 { get; }
		/// @CSharpLua.Get = "OSKEY_F14"
		public static extern OsKeyType F14 { get; }
		/// @CSharpLua.Get = "OSKEY_F15"
		public static extern OsKeyType F15 { get; }
		/// @CSharpLua.Get = "OSKEY_F16"
		public static extern OsKeyType F16 { get; }
		/// @CSharpLua.Get = "OSKEY_F17"
		public static extern OsKeyType F17 { get; }
		/// @CSharpLua.Get = "OSKEY_F18"
		public static extern OsKeyType F18 { get; }
		/// @CSharpLua.Get = "OSKEY_F19"
		public static extern OsKeyType F19 { get; }
		/// @CSharpLua.Get = "OSKEY_F20"
		public static extern OsKeyType F20 { get; }
		/// @CSharpLua.Get = "OSKEY_F21"
		public static extern OsKeyType F21 { get; }
		/// @CSharpLua.Get = "OSKEY_F22"
		public static extern OsKeyType F22 { get; }
		/// @CSharpLua.Get = "OSKEY_F23"
		public static extern OsKeyType F23 { get; }
		/// @CSharpLua.Get = "OSKEY_F24"
		public static extern OsKeyType F24 { get; }
		/// @CSharpLua.Get = "OSKEY_NUMLOCK"
		public static extern OsKeyType NumLock { get; }
		/// @CSharpLua.Get = "OSKEY_SCROLLLOCK"
		public static extern OsKeyType ScrollLock { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_NEC_EQUAL"
		public static extern OsKeyType OemNecEqual { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FJ_JISHO"
		public static extern OsKeyType OemFjJisho { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FJ_MASSHOU"
		public static extern OsKeyType OemFjMasshou { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FJ_TOUROKU"
		public static extern OsKeyType OemFjTouroku { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FJ_LOYA"
		public static extern OsKeyType OemFjLoya { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FJ_ROYA"
		public static extern OsKeyType OemFjRoya { get; }
		/// @CSharpLua.Get = "OSKEY_LSHIFT"
		public static extern OsKeyType LeftShift { get; }
		/// @CSharpLua.Get = "OSKEY_RSHIFT"
		public static extern OsKeyType RightShift { get; }
		/// @CSharpLua.Get = "OSKEY_LCONTROL"
		public static extern OsKeyType LeftCtrl { get; }
		/// @CSharpLua.Get = "OSKEY_RCONTROL"
		public static extern OsKeyType RightCtrl { get; }
		/// @CSharpLua.Get = "OSKEY_LALT"
		public static extern OsKeyType LeftAlt { get; }
		/// @CSharpLua.Get = "OSKEY_RALT"
		public static extern OsKeyType RightAlt { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_BACK"
		public static extern OsKeyType BrowserBack { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_FORWARD"
		public static extern OsKeyType BrowserForward { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_REFRESH"
		public static extern OsKeyType BrowserRefresh { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_STOP"
		public static extern OsKeyType BrowserStop { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_SEARCH"
		public static extern OsKeyType BrowserSearch { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_FAVORITES"
		public static extern OsKeyType BrowserFavorites { get; }
		/// @CSharpLua.Get = "OSKEY_BROWSER_HOME"
		public static extern OsKeyType BrowserHome { get; }
		/// @CSharpLua.Get = "OSKEY_VOLUME_MUTE"
		public static extern OsKeyType VolumeMute { get; }
		/// @CSharpLua.Get = "OSKEY_VOLUME_DOWN"
		public static extern OsKeyType VolumeDown { get; }
		/// @CSharpLua.Get = "OSKEY_VOLUME_UP"
		public static extern OsKeyType VolumeUp { get; }
		/// @CSharpLua.Get = "OSKEY_MEDIA_NEXT_TRACK"
		public static extern OsKeyType MediaNextTrack { get; }
		/// @CSharpLua.Get = "OSKEY_MEDIA_PREV_TRACK"
		public static extern OsKeyType MediaPreviousTrack { get; }
		/// @CSharpLua.Get = "OSKEY_MEDIA_STOP"
		public static extern OsKeyType MediaStop { get; }
		/// @CSharpLua.Get = "OSKEY_MEDIA_PLAY_PAUSE"
		public static extern OsKeyType MediaPlayPause { get; }
		/// @CSharpLua.Get = "OSKEY_LAUNCH_MAIL"
		public static extern OsKeyType LaunchMail { get; }
		/// @CSharpLua.Get = "OSKEY_LAUNCH_MEDIA_SELECT"
		public static extern OsKeyType LaunchMediaSelect { get; }
		/// @CSharpLua.Get = "OSKEY_LAUNCH_APP1"
		public static extern OsKeyType LaunchApp1 { get; }
		/// @CSharpLua.Get = "OSKEY_LAUNCH_APP2"
		public static extern OsKeyType LaunchApp2 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_1"
		public static extern OsKeyType Oem1 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_PLUS"
		public static extern OsKeyType OemPlus { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_COMMA"
		public static extern OsKeyType OemComma { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_MINUS"
		public static extern OsKeyType OemMinus { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_PERIOD"
		public static extern OsKeyType OemPeriod { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_2"
		public static extern OsKeyType Oem2 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_3"
		public static extern OsKeyType Oem3 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_4"
		public static extern OsKeyType Oem4 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_5"
		public static extern OsKeyType Oem5 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_6"
		public static extern OsKeyType Oem6 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_7"
		public static extern OsKeyType Oem7 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_8"
		public static extern OsKeyType Oem8 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_AX"
		public static extern OsKeyType OemAx { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_102"
		public static extern OsKeyType Oem102 { get; }
		/// @CSharpLua.Get = "OSKEY_ICO_HELP"
		public static extern OsKeyType IcoHelp { get; }
		/// @CSharpLua.Get = "OSKEY_ICO_00"
		public static extern OsKeyType Ic00 { get; }
		/// @CSharpLua.Get = "OSKEY_PROCESSKEY"
		public static extern OsKeyType ProcessKey { get; }
		/// @CSharpLua.Get = "OSKEY_ICO_CLEAR"
		public static extern OsKeyType IcoClear { get; }
		/// @CSharpLua.Get = "OSKEY_PACKET"
		public static extern OsKeyType Packet { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_RESET"
		public static extern OsKeyType OemReset { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_JUMP"
		public static extern OsKeyType OemJump { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_PA1"
		public static extern OsKeyType OemPa1 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_PA2"
		public static extern OsKeyType OemPa2 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_PA3"
		public static extern OsKeyType OemPa3 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_WSCTRL"
		public static extern OsKeyType OemWsctrl { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_CUSEL"
		public static extern OsKeyType OemCusel { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_ATTN"
		public static extern OsKeyType OemAttn { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_FINISH"
		public static extern OsKeyType OemFinish { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_COPY"
		public static extern OsKeyType OemCopy { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_AUTO"
		public static extern OsKeyType OemAuto { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_ENLW"
		public static extern OsKeyType OemEnlw { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_BACKTAB"
		public static extern OsKeyType OemBackTab { get; }
		/// @CSharpLua.Get = "OSKEY_ATTN"
		public static extern OsKeyType Attn { get; }
		/// @CSharpLua.Get = "OSKEY_CRSEL"
		public static extern OsKeyType CrSel { get; }
		/// @CSharpLua.Get = "OSKEY_EXSEL"
		public static extern OsKeyType ExSel { get; }
		/// @CSharpLua.Get = "OSKEY_EREOF"
		public static extern OsKeyType ErEof { get; }
		/// @CSharpLua.Get = "OSKEY_PLAY"
		public static extern OsKeyType Play { get; }
		/// @CSharpLua.Get = "OSKEY_ZOOM"
		public static extern OsKeyType Zoom { get; }
		/// @CSharpLua.Get = "OSKEY_NONAME"
		public static extern OsKeyType NoName { get; }
		/// @CSharpLua.Get = "OSKEY_PA1"
		public static extern OsKeyType Pa1 { get; }
		/// @CSharpLua.Get = "OSKEY_OEM_CLEAR"
		public static extern OsKeyType OemClear { get; }

		/// @CSharpLua.Template = "ConvertOsKeyType({0})"
		public static extern OsKeyType Convert(int osKeyTypeId);
	}
}
