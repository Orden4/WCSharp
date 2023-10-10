namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class armortype : handle
	{
		internal armortype()
		{
		}

		/// @CSharpLua.Get = "ARMOR_TYPE_WHOKNOWS"
		public static extern armortype WhoKnows { get; }
		/// @CSharpLua.Get = "ARMOR_TYPE_FLESH"
		public static extern armortype Flesh { get; }
		/// @CSharpLua.Get = "ARMOR_TYPE_METAL"
		public static extern armortype Metal { get; }
		/// @CSharpLua.Get = "ARMOR_TYPE_WOOD"
		public static extern armortype Wood { get; }
		/// @CSharpLua.Get = "ARMOR_TYPE_ETHREAL"
		public static extern armortype Ethereal { get; }
		/// @CSharpLua.Get = "ARMOR_TYPE_STONE"
		public static extern armortype Stone { get; }

		/// @CSharpLua.Template = "ConvertArmorType({0})"
		public static extern armortype Convert(int armorTypeId);
	}
}
