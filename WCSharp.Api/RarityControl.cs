using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class RarityControl
	{
		internal RarityControl()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator raritycontrol(RarityControl x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator RarityControl(raritycontrol x);

		/// @CSharpLua.Get = "RARITY_FREQUENT"
		public static extern RarityControl Frequent { get; }
		/// @CSharpLua.Get = "RARITY_RARE"
		public static extern RarityControl Rare { get; }

		/// @CSharpLua.Template = "ConvertRarityControl({0})"
		public static extern RarityControl Convert(int rarityControlId);
	}
}
