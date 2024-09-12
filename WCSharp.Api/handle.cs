using System;
using System.ComponentModel;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class handle
	{
		internal handle()
		{
		}

		/// @CSharpLua.Get = "GetHandleId({this})"
		[Obsolete("HandleId does not serve a purpose in lua/C#. It is prone to desyncs. Use the object itself as a key instead.")]
		public extern int HandleId { get; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public extern override bool Equals(object obj);
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public extern override int GetHashCode();
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public extern override string ToString();
	}
}
