using WCSharp.Api.Enums;

namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class attacktype : handle
	{
		internal attacktype()
		{
		}

		/// @CSharpLua.Get = "ATTACK_TYPE_NORMAL"
		public static extern attacktype Normal { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_MELEE"
		public static extern attacktype Melee { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_PIERCE"
		public static extern attacktype Pierce { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_SIEGE"
		public static extern attacktype Siege { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_MAGIC"
		public static extern attacktype Magic { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_CHAOS"
		public static extern attacktype Chaos { get; }
		/// @CSharpLua.Get = "ATTACK_TYPE_HERO"
		public static extern attacktype Hero { get; }

		/// @CSharpLua.Template = "ConvertAttackType({0})"
		public static extern attacktype Convert(int attackTypeId);
		/// @CSharpLua.Template = "ConvertAttackType({0})"
		public static extern attacktype Convert(AttackType attackType);
	}
}
