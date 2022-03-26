using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Rect : Agent, IDisposable
	{
		internal Rect()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator rect(Rect x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Rect(rect x);

		/// @CSharpLua.Template = "RemoveRect({0})"
		public extern void Dispose();
	}
}
