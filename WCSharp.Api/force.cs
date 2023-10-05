using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class force : agent, IDisposable
	{
		internal force()
		{
		}

		/// @CSharpLua.Template = "DestroyForce({0})"
		public extern void Dispose();
	}
}
