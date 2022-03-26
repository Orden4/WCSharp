using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class UnitPool : IDisposable
	{
		internal UnitPool()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unitpool(UnitPool x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator UnitPool(unitpool x);

		/// @CSharpLua.Template = "DestroyUnitPool({0})"
		public extern void Dispose();
	}
}
