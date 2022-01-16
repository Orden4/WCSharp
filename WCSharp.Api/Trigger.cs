using System;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Trigger : Agent, IDisposable
	{
		internal Trigger()
		{
		}

		/// @CSharpLua.Template = "DestroyTrigger({0})"
		public extern void Dispose();
	}
}
