using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class trigger : agent, IDisposable
	{
		internal trigger()
		{
		}

		/// @CSharpLua.Template = "CreateTrigger({0})"
		public static extern trigger Create();

		/// @CSharpLua.Get = "IsTriggerEnabled({0})"
		/// @CSharpLua.Set = "(if {1} then EnableTrigger({0}) else DisableTrigger({1}) end)"
		public extern bool Enabled { get; set; }
		/// @CSharpLua.Get = "IsTriggerWaitOnSleeps({0})"
		/// @CSharpLua.Set = "TriggerWaitOnSleeps({0}, {1})"
		public extern bool WaitOnSleeps { get; }
		/// @CSharpLua.Get = "GetTriggerEvalCount({0})"
		public extern int EvalCount { get; }
		/// @CSharpLua.Get = "GetTriggerExecCount({0})"
		public extern int ExecCount { get; }

		/// @CSharpLua.Template = "EnableTrigger({0})"
		public extern void Enable();

		/// @CSharpLua.Template = "DisableTrigger({0})"
		public extern void Disable();

		/// @CSharpLua.Template = "ResetTrigger({0})"
		public extern void Reset();

		/// @CSharpLua.Template = "DestroyTrigger({0})"
		public extern void Dispose();
	}
}
