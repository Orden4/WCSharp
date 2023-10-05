namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class itemtype
	{
		internal itemtype()
		{
		}

		/// @CSharpLua.Get = "ITEM_TYPE_PERMANENT"
		public static extern itemtype Permanent { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_CHARGED"
		public static extern itemtype Charged { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_POWERUP"
		public static extern itemtype Powerup { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_ARTIFACT"
		public static extern itemtype Artifact { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_PURCHASABLE"
		public static extern itemtype Purchasable { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_CAMPAIGN"
		public static extern itemtype Campaign { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_MISCELLANEOUS"
		public static extern itemtype Miscellaneous { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_UNKNOWN"
		public static extern itemtype Unknown { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_ANY"
		public static extern itemtype Any { get; }

		/// @CSharpLua.Template = "ConvertItemType({0})"
		public static extern itemtype Convert(int itemTypeId);
	}
}
