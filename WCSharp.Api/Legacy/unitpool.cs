using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unitpool : handle, IDisposable
	{
		internal unitpool()
		{
		}

		/// @CSharpLua.Template = "DestroyUnitPool({this})"
		public extern void Dispose();
	}
}
