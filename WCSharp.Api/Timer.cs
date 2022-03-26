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

		/// @CSharpLua.Template = "DestroyTimer({0})"
		public extern void Dispose();
	}
}
