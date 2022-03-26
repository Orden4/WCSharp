using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class OriginFrameType
	{
		internal OriginFrameType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator originframetype(OriginFrameType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator OriginFrameType(originframetype x);
	}
}
