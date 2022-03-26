using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Destructable : Widget, IDisposable
	{
		internal Destructable()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator destructable(Destructable x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Destructable(destructable x);

		/// @CSharpLua.Get = "IsDestructableInvulnerable({0})"
		/// @CSharpLua.Set = "SetDestructableInvulnerable({0}, {1})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "GetDestructableTypeId({0})"
		public extern int Type { get; }

		/// @CSharpLua.Get = "GetDestructableName({0})"
		public extern string Name { get; }

		/// @CSharpLua.Get = "GetDestructableOccluderHeight({0})"
		/// @CSharpLua.Set = "SetDestructableOccluderHeight({0}, {1})"
		public extern float OccluderHeight { get; }

		/// @CSharpLua.Template = "RemoveDestructable({0})"
		public extern void Dispose();
	}
}
