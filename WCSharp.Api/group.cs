using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class group : agent, IDisposable
	{
		internal group()
		{
		}

		/// @CSharpLua.Template = "DestroyGroup({0})"
		public extern void Dispose();
	}
}
