namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class location : agent
	{
		internal location()
		{
		}

		/// @CSharpLua.Template = "RemoveLocation({0})"
		public extern void Dispose();
	}
}
