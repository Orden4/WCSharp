using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class ItemType
	{
		internal ItemType()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator itemtype(ItemType x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator ItemType(itemtype x);

		/// @CSharpLua.Get = "ITEM_TYPE_PERMANENT"
		public static extern ItemType Permanent { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_CHARGED"
		public static extern ItemType Charged { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_POWERUP"
		public static extern ItemType Powerup { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_ARTIFACT"
		public static extern ItemType Artifact { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_PURCHASABLE"
		public static extern ItemType Purchasable { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_CAMPAIGN"
		public static extern ItemType Campaign { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_MISCELLANEOUS"
		public static extern ItemType Miscellaneous { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_UNKNOWN"
		public static extern ItemType Unknown { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_ANY"
		public static extern ItemType Any { get; }
		/// @CSharpLua.Get = "ITEM_TYPE_TOME"
		public static extern ItemType Tome { get; }

		/// @CSharpLua.Template = "ConvertItemType({0})"
		public static extern ItemType Convert(int itemType);
	}
}
