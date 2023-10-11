using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class timer : agent, IDisposable
	{
		internal timer()
		{
		}

		/// @CSharpLua.Template = "CreateTimer()"
		public static extern timer Create();

		/// @CSharpLua.Get = "TimerGetElapsed({this})"
		public extern float Elapsed { get; }
		/// @CSharpLua.Get = "TimerGetRemaining({this})"
		public extern float Remaining { get; }
		/// @CSharpLua.Get = "TimerGetTimeout({this})"
		public extern float Timeout { get; }

		/// @CSharpLua.Template = "TimerStart({this}, {0}, {1}, {2})"
		public extern void Start(float timeout, bool periodic, Action callback);
		/// @CSharpLua.Template = "ResumeTimer({this})"
		public extern void Resume();
		/// @CSharpLua.Template = "PauseTimer({this})"
		public extern void Pause();

		/// @CSharpLua.Template = "CreateTimerDialog({this})"
		public extern timerdialog CreateDialog();

		/// @CSharpLua.Template = "DestroyTimer({this})"
		public extern void Dispose();
	}
}
