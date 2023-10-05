namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class widgetevent : eventid
	{
		internal widgetevent()
		{
		}

		/// @CSharpLua.Get = "EVENT_WIDGET_DEATH"
		public static extern widgetevent EventWidgetDeath { get; }

		/// @CSharpLua.Template = "ConvertWidgetEvent({0})"
		public static extern widgetevent Convert(int widgetEventId);
	}
}
