using System;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Force : Agent, IDisposable
	{
		internal Force()
		{
		}

		/// @CSharpLua.Template = "DestroyForce({0})"
		public extern void Dispose();
	}
}
