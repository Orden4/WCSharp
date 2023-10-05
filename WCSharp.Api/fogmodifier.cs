using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class fogmodifier : agent, IDisposable
	{
		internal fogmodifier()
		{
		}

		/// @CSharpLua.Template = "DestroyFogModifier({0})"
		public extern void Dispose();
	}
}
