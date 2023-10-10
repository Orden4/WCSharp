using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unitpool : handle, IDisposable
	{
		internal unitpool()
		{
		}

		/// @CSharpLua.Template = "DestroyUnitPool({0})"
		public extern void Dispose();
	}
}
