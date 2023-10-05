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

		/// @CSharpLua.Get = "IsTimerDialogDisplayed({0})"
		/// @CSharpLua.Set = "TimerDialogDisplay({0}, {1})"
		public extern bool IsDisplayed { get; set; }

		/// @CSharpLua.Template = "TimerDialogSetTitle({0}, {1})"
		public extern void SetTitle(string title);
		/// @CSharpLua.Template = "TimerDialogSetTitleColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetTitleColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "TimerDialogSetTimeColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetTimeColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "TimerDialogSetSpeed({0}, {1})"
		public extern void SetSpeed(float speedFactor);
		/// @CSharpLua.Template = "TimerDialogSetRealTimeRemaining({0}, {1})"
		public extern void SetTimeRemaining(float time);

		/// @CSharpLua.Template = "DestroyTimerDialog({0})"
		public extern void Dispose();
	}
}
