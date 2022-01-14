using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public class DamageEvent
	{
		public unit Source { get; set; }
		public unit Target { get; set; }

		public float BaseDamage { get; set; }
		public float BonusDamage { get; set; }
		public float BonusDamageFactor { get; set; }
		public float RawDamage { get; set; }
		public float RealDamage { get; set; }
		public float DamageCap { get; set; }

		public attacktype AttackType { get; set; }
		public armortype ArmorType { get; set; }
		public damagetype DamageType { get; set; }
		public defensetype DefenseType { get; set; }
		public weapontype WeaponType { get; set; }
		public int Armor { get; set; }
		public int ArmorPierce { get; set; }

		public bool IsEvent { get; }
	}
}
