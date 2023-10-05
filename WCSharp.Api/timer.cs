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

		/// @CSharpLua.Get = "TimerGetElapsed({0})"
		public extern float Elapsed { get; }
		/// @CSharpLua.Get = "TimerGetRemaining({0})"
		public extern float Remaining { get; }
		/// @CSharpLua.Get = "TimerGetTimeout({0})"
		public extern float Timeout { get; }

		/// @CSharpLua.Template = "TimerStart({0}, {1}, {2}, {3})"
		public extern void Start(float timeout, bool periodic, Action callback);
		/// @CSharpLua.Template = "ResumeTimer({0})"
		public extern void Resume();
		/// @CSharpLua.Template = "PauseTimer({0})"
		public extern void Pause();

		/// @CSharpLua.Template = "CreateTimerDialog({0})"
		public extern void CreateDialog();

		/// @CSharpLua.Template = "DestroyTimer({0})"
		public extern void Dispose();
	}
}
