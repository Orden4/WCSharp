using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class framehandle : IDisposable
	{
		internal framehandle()
		{
		}

		/// @CSharpLua.Template = "BlzDestroyFrame({0})"
		public extern void Dispose();
	}
}
