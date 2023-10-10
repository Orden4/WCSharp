namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class location : agent
	{
		internal location()
		{
		}

		/// @CSharpLua.Template = "RemoveLocation({this})"
		public extern void Dispose();
	}
}
