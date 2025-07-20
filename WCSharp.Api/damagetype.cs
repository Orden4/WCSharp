namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class damagetype : handle
	{
		internal damagetype()
		{
		}

		/// @CSharpLua.Get = "DAMAGE_TYPE_UNKNOWN"
		public static extern damagetype Unknown { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_NORMAL"
		public static extern damagetype Normal { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_ENHANCED"
		public static extern damagetype Enhanced { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_FIRE"
		public static extern damagetype Fire { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_COLD"
		public static extern damagetype Cold { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_LIGHTNING"
		public static extern damagetype Lightning { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_POISON"
		public static extern damagetype Poison { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_DISEASE"
		public static extern damagetype Disease { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_DIVINE"
		public static extern damagetype Divine { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_MAGIC"
		public static extern damagetype Magic { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_SONIC"
		public static extern damagetype Sonic { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_ACID"
		public static extern damagetype Acid { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_FORCE"
		public static extern damagetype Force { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_DEATH"
		public static extern damagetype Death { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_MIND"
		public static extern damagetype Mind { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_PLANT"
		public static extern damagetype Plant { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_DEFENSIVE"
		public static extern damagetype Defensive { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_DEMOLITION"
		public static extern damagetype Demolition { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_SLOW_POISON"
		public static extern damagetype SlowPoison { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_SPIRIT_LINK"
		public static extern damagetype SpiritLink { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_SHADOW_STRIKE"
		public static extern damagetype ShadowStrike { get; }
		/// @CSharpLua.Get = "DAMAGE_TYPE_UNIVERSAL"
		public static extern damagetype Universal { get; }

		/// @CSharpLua.Template = "ConvertDamageType({0})"
		public static extern damagetype Convert(int damageTypeId);
	}
}
