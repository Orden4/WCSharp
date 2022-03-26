using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class CommandButtonEffect : IDisposable
	{
		internal CommandButtonEffect()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator commandbuttoneffect(CommandButtonEffect x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator CommandButtonEffect(commandbuttoneffect x);

		/// @CSharpLua.Template = "DestroyCommandButtonEffect({0})"
		public extern void Dispose();
	}
}
