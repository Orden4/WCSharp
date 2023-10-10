namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class raritycontrol : handle
	{
		internal raritycontrol()
		{
		}

		/// @CSharpLua.Get = "RARITY_FREQUENT"
		public static extern raritycontrol Frequent { get; }
		/// @CSharpLua.Get = "RARITY_RARE"
		public static extern raritycontrol Rare { get; }

		/// @CSharpLua.Template = "ConvertRarityControl({0})"
		public static extern raritycontrol Convert(int rarityControlId);
	}
}
