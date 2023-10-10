namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class framepointtype : handle
	{
		internal framepointtype()
		{
		}

		/// @CSharpLua.Get = "FRAMEPOINT_TOPLEFT"
		public static extern framepointtype TopLeft { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_TOP"
		public static extern framepointtype Top { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_TOPRIGHT"
		public static extern framepointtype TopRight { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_LEFT"
		public static extern framepointtype Left { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_CENTER"
		public static extern framepointtype Center { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_RIGHT"
		public static extern framepointtype Right { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_BOTTOMLEFT"
		public static extern framepointtype BottomLeft { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_BOTTOM"
		public static extern framepointtype Bottom { get; }
		/// @CSharpLua.Get = "FRAMEPOINT_BOTTOMRIGHT"
		public static extern framepointtype BottomRight { get; }

		/// @CSharpLua.Template = "ConvertFramePointType({0})"
		public static extern framepointtype Convert(int framePointTypeId);
	}
}
