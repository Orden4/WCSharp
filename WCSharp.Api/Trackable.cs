using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Trackable : Agent
	{
		internal Trackable()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator trackable(Trackable x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Trackable(trackable x);

		/// @CSharpLua.Template = "CreateTrackable({0}, {1}, {2}, {3})"
		public static extern Trackable Create(string modelPath, float x, float y, float facing);
	}
}
