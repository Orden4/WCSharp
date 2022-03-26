using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Group : Agent, IDisposable
	{
		internal Group()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator group(Group x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Group(group x);

		/// @CSharpLua.Template = "DestroyGroup({0})"
		public extern void Dispose();
	}
}
