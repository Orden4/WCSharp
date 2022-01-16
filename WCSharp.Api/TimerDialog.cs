namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TimerDialog : Agent
	{
		internal TimerDialog()
		{
		}

		/// @CSharpLua.Template = "DestroyTimerDialog({0})"
		public extern void Dispose();
	}
}
