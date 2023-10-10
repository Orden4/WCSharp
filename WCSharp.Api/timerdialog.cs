namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class timerdialog : agent
	{
		internal timerdialog()
		{
		}

		/// @CSharpLua.Template = "CreateTimerDialog({0})"
		public static extern void Create(timer timer);

		/// @CSharpLua.Get = "IsTimerDialogDisplayed({this})"
		/// @CSharpLua.Set = "TimerDialogDisplay({this}, {0})"
		public extern bool IsDisplayed { get; set; }

		/// @CSharpLua.Template = "TimerDialogSetTitle({this}, {0})"
		public extern void SetTitle(string title);
		/// @CSharpLua.Template = "TimerDialogSetTitleColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetTitleColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "TimerDialogSetTimeColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetTimeColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "TimerDialogSetSpeed({this}, {0})"
		public extern void SetSpeed(float speedFactor);
		/// @CSharpLua.Template = "TimerDialogSetRealTimeRemaining({this}, {0})"
		public extern void SetTimeRemaining(float time);

		/// @CSharpLua.Template = "DestroyTimerDialog({this})"
		public extern void Dispose();
	}
}
