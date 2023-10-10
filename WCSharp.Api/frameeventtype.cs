namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class frameeventtype : handle
	{
		internal frameeventtype()
		{
		}

		/// @CSharpLua.Get = "FRAMEEVENT_CONTROL_CLICK"
		public static extern frameeventtype Click { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_ENTER"
		public static extern frameeventtype MouseEnter { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_LEAVE"
		public static extern frameeventtype MouseLeave { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_UP"
		public static extern frameeventtype MouseUp { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_DOWN"
		public static extern frameeventtype MouseDown { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_WHEEL"
		public static extern frameeventtype MouseWheel { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_CHECKBOX_CHECKED"
		public static extern frameeventtype CheckBoxChecked { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_CHECKBOX_UNCHECKED"
		public static extern frameeventtype CheckBoxUnchecked { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_EDITBOX_TEXT_CHANGED"
		public static extern frameeventtype EditBoxTextChanged { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_POPUPMENU_ITEM_CHANGED"
		public static extern frameeventtype PopupMenuItemChanged { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_MOUSE_DOUBLECLICK"
		public static extern frameeventtype MouseDoubleClick { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_SPRITE_ANIM_UPDATE"
		public static extern frameeventtype SpriteAnimationUpdate { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_SLIDER_VALUE_CHANGED"
		public static extern frameeventtype SliderValueChanged { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_DIALOG_CANCEL"
		public static extern frameeventtype DialogCancel { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_DIALOG_ACCEPT"
		public static extern frameeventtype DialogAccept { get; }
		/// @CSharpLua.Get = "FRAMEEVENT_EDITBOX_ENTER"
		public static extern frameeventtype EditBoxEnter { get; }

		/// @CSharpLua.Template = "ConvertFrameEventType({0})"
		public static extern frameeventtype Convert(int frameEventTypeId);
	}
}
