namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class trackable : agent
	{
		internal trackable()
		{
		}

		/// @CSharpLua.Template = "CreateTrackable({0}, {1}, {2}, {3})"
		public static extern trackable Create(string modelPath, float x, float y, float facing);
	}
}
