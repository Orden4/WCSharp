using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class dialog : agent, IDisposable
	{
		internal dialog()
		{
		}

		/// @CSharpLua.Template = "DialogDestroy({0})"
		public extern void Dispose();
	}
}
