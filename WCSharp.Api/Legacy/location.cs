using System;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class location : agent, IDisposable
	{
		internal location()
		{
		}

		/// @CSharpLua.Get = "GetLocationX({this})"
		public extern float X { get; }
		/// @CSharpLua.Get = "GetLocationY({this})"
		public extern float Y { get; }
		/// @CSharpLua.Get = "GetLocationZ({this})"
		public extern float LocalZ { get; }

		/// @CSharpLua.Template = "RemoveLocation({this})"
		public extern void Dispose();
	}
}
