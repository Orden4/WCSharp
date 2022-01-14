using System;
using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public class DamageTrigger
	{
		public unit Source { get; set; }
		public unit Target { get; set; }

		public float BaseDamage { get; set; }
		public float BaseDamageFactor { get; set; }
		public float BonusDamage { get; set; }
		public float RawDamage => (BaseDamage * BaseDamageFactor) + BonusDamage;
		public float RealDamage
		{
			get
			{
				var damage = ((BaseDamage * BaseDamageFactor) + BonusDamage) * DamageConfiguration.DamageFactors[AttackType][DefenseType];
				if (IsUnitType(Target, UNIT_TYPE_ETHEREAL))
					damage *= DamageConfiguration.EtherealFactors[AttackType];
				if (DamageType != DAMAGE_TYPE_UNIVERSAL)
				{
					var armor = Armor - ArmorPierce;
					damage *= 1 - (armor * 0.06f / (1 + (armor * 0.06f)));
				}

				return damage;
			}
		}
		public float DamageCap { get; set; }

		public attacktype AttackType { get; set; }
		public damagetype DamageType { get; set; }
		public weapontype WeaponType { get; set; }
		private armortype armorType;
		public armortype ArmorType => this.armorType ??= ConvertArmorType(BlzGetUnitIntegerField(Target, UNIT_IF_ARMOR_TYPE));
		private defensetype defenseType;
		public defensetype DefenseType => this.defenseType ??= ConvertDefenseType(BlzGetUnitIntegerField(Target, UNIT_IF_DEFENSE_TYPE));
		private float? armor;
		public float Armor => this.armor ??= BlzGetUnitArmor(Target);
		public int ArmorPierce { get; set; }

		public DamageTrigger()
		{
			Source = GetTriggerUnit();
			Target = BlzGetEventDamageTarget();
		}

		public DamageTrigger(float damage, attacktype attackType, damagetype damageType = null, weapontype weaponType = null)
		{
			BaseDamage = damage;
			AttackType = attackType;
			DamageType = damageType ?? DAMAGE_TYPE_NORMAL;
			WeaponType = weaponType ?? WEAPON_TYPE_WHOKNOWS;
		}

		public void DealDamage()
		{
			UnitDamageTarget(Source, Target, Math.Min(DamageCap, RawDamage), false, false, AttackType, DamageType, WeaponType);
		}
	}
}
