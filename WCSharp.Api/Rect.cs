using System;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Rect : Agent, IDisposable
	{
		internal Rect()
		{
		}

		/// @CSharpLua.Template = "RemoveRect({0})"
		public extern void Dispose();
	}
}
