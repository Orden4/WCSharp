using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class TexMapFlags
	{
		internal TexMapFlags()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator texmapflags(TexMapFlags x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator TexMapFlags(texmapflags x);

		/// @CSharpLua.Get = "TEXMAP_FLAG_NONE"
		public static extern SubAnimType None { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_U"
		public static extern SubAnimType WrapU { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_V"
		public static extern SubAnimType WrapV { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_UV"
		public static extern SubAnimType WrapUV { get; }

		/// @CSharpLua.Template = "ConvertTexMapFlags({0})"
		public static extern TexMapFlags Convert(int textMapFlags);
	}
}
