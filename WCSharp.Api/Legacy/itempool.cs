using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class itempool : handle, IDisposable
	{
		internal itempool()
		{
		}

		/// @CSharpLua.Template = "DestroyItemPool({this})"
		public extern void Dispose();
	}
}
