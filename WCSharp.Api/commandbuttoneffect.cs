using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class commandbuttoneffect : IDisposable
	{
		internal commandbuttoneffect()
		{
		}

		/// @CSharpLua.Template = "DestroyCommandButtonEffect({0})"
		public extern void Dispose();
	}
}
