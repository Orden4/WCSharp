using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class WidgetEvent : EventId
	{
		internal WidgetEvent()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator widgetevent(WidgetEvent x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator WidgetEvent(widgetevent x);

		/// @CSharpLua.Get = "EVENT_WIDGET_DEATH"
		public static extern WidgetEvent EventWidgetDeath { get; }

		/// @CSharpLua.Template = "ConvertWidgetEvent({0})"
		public static extern WidgetEvent Convert(int widgetEventId);
	}
}
