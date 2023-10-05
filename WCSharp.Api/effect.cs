using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class effect : agent, IDisposable
	{
		internal effect()
		{
		}

		/// @CSharpLua.Template = "DestroyEffect({0})"
		public extern void Dispose();
	}
}
