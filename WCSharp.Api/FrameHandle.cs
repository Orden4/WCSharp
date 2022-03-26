using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class FrameHandle : IDisposable
	{
		internal FrameHandle()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator framehandle(FrameHandle x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator FrameHandle(framehandle x);

		/// @CSharpLua.Template = "BlzDestroyFrame({0})"
		public extern void Dispose();
	}
}
