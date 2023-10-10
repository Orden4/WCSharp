using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class commandbuttoneffect : handle, IDisposable
	{
		internal commandbuttoneffect()
		{
		}

		/// @CSharpLua.Template = "DestroyCommandButtonEffect({this})"
		public extern void Dispose();
	}
}
