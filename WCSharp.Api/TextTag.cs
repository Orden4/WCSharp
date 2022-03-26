using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TextTag : IDisposable
	{
		internal TextTag()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator texttag(TextTag x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TextTag(texttag x);

		/// @CSharpLua.Template = "DestroyTextTag({0})"
		public extern void Dispose();
	}
}
