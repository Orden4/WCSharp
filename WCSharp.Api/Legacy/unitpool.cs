using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unitpool : IDisposable
	{
		internal unitpool()
		{
		}

		/// @CSharpLua.Template = "DestroyUnitPool({0})"
		public extern void Dispose();
	}
}
