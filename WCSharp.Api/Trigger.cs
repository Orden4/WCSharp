using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Trigger : Agent, IDisposable
	{
		internal Trigger()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator trigger(Trigger x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Trigger(trigger x);

		/// @CSharpLua.Template = "DestroyTrigger({0})"
		public extern void Dispose();
	}
}
