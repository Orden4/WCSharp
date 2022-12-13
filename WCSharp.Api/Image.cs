using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Image : IDisposable
	{
		internal Image()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator image(Image x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Image(image x);

		/// @CSharpLua.Template = "DestroyImage({0})"
		public extern void Dispose();
	}
}
