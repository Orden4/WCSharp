using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Effect : Agent, IDisposable
	{
		internal Effect()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator effect(Effect x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Effect(effect x);

		/// @CSharpLua.Template = "DestroyEffect({0})"
		public extern void Dispose();
	}
}
