using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class image : IDisposable
	{
		internal image()
		{
		}

		/// @CSharpLua.Template = "DestroyImage({0})"
		public extern void Dispose();
	}
}
