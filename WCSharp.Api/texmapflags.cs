namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class texmapflags : handle
	{
		internal texmapflags()
		{
		}

		/// @CSharpLua.Get = "TEXMAP_FLAG_NONE"
		public static extern texmapflags None { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_U"
		public static extern texmapflags WrapU { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_V"
		public static extern texmapflags WrapV { get; }
		/// @CSharpLua.Get = "TEXMAP_FLAG_WRAP_UV"
		public static extern texmapflags WrapUV { get; }

		/// @CSharpLua.Template = "ConvertTexMapFlags({0})"
		public static extern texmapflags Convert(int textMapFlagsId);
	}
}
