namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class textaligntype : handle
	{
		internal textaligntype()
		{
		}

		/// @CSharpLua.Get = "TEXT_JUSTIFY_TOP"
		public static extern textaligntype Top { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_MIDDLE"
		public static extern textaligntype Middle { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_BOTTOM"
		public static extern textaligntype Bottom { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_LEFT"
		public static extern textaligntype Left { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_CENTER"
		public static extern textaligntype Center { get; }
		/// @CSharpLua.Get = "TEXT_JUSTIFY_RIGHT"
		public static extern textaligntype Right { get; }

		/// @CSharpLua.Template = "ConvertTextAlignType({0})"
		public static extern textaligntype Convert(int textAlignTypeId);
	}
}
