using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Dialog : Agent, IDisposable
	{
		internal Dialog()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator dialog(Dialog x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Dialog(dialog x);

		/// @CSharpLua.Template = "DialogDestroy({0})"
		public extern void Dispose();
	}
}
