using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Timer : Agent, IDisposable
	{
		internal Timer()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator timer(Timer x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Timer(timer x);

		/// @CSharpLua.Template = "CreateTimer()"
		public static extern Timer Create();

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

		/// @CSharpLua.Template = "DestroyTimer({0})"
		public extern void Dispose();
	}
}
