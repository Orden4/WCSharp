using System;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class location : agent, IDisposable
	{
		internal location()
		{
		}

		/// @CSharpLua.Template = "GetLocationX({this})"
		public extern float X { get; }
		/// @CSharpLua.Template = "GetLocationY({this})"
		public extern float Y { get; }
		/// @CSharpLua.Template = "GetLocationZ({this})"
		public extern float LocalZ { get; }

		/// @CSharpLua.Template = "RemoveLocation({this})"
		public extern void Dispose();
	}
}
