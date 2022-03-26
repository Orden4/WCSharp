using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class ItemPool : IDisposable
	{
		internal ItemPool()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator itempool(ItemPool x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator ItemPool(itempool x);

		/// @CSharpLua.Template = "DestroyItemPool({0})"
		public extern void Dispose();
	}
}
