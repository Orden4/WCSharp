using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TimerDialog : Agent
	{
		internal TimerDialog()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator timerdialog(TimerDialog x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TimerDialog(timerdialog x);

		/// @CSharpLua.Template = "DestroyTimerDialog({0})"
		public extern void Dispose();
	}
}
