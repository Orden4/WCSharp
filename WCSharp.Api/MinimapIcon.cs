using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class MinimapIcon : IDisposable
	{
		internal MinimapIcon()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator minimapicon(MinimapIcon x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator MinimapIcon(minimapicon x);

		/// @CSharpLua.Template = "DestroyMinimapIcon({0})"
		public extern void Dispose();
	}
}
