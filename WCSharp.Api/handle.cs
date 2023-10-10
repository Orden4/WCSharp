using System.ComponentModel;

namespace WCSharp.Api
{
	public class handle
	{
		internal handle()
		{
		}

		/// @CSharpLua.Get = "GetHandleId({this})"
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
