using System;
using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public class DamageTriggerOrEvent
	{
		public unit Source { get; set; }
		public unit Target { get; set; }

		public float BaseDamage { get; set; }
		public float BaseDamageFactor { get; set; }
		public float BonusDamage { get; set; }
		public float GlobalFactor { get; set; }
		private float? rawDamage;
		public float RawDamage
		{
			get => this.rawDamage ?? (BaseDamage * BaseDamageFactor) + BonusDamage;
			set => this.rawDamage = value;
		}
		public float RealDamage { get; set; }
		public float DamageCap { get; set; }

		private attacktype attackType;
		public attacktype AttackType
		{
			get => this.attackType ??= BlzGetEventAttackType();
			set
			{
				if (IsEvent && this.attackType != value)
				{
					BlzSetEventAttackType(value);
				}
				this.attackType = value;
			}
		}
		private damagetype damageType;
		public damagetype DamageType
		{
			get => this.damageType ??= BlzGetEventDamageType();
			set
			{
				if (IsEvent && this.damageType != value)
				{
					BlzSetEventDamageType(value);
				}
				this.damageType = value;
			}
		}
		private weapontype weaponType;
		public weapontype WeaponType
		{
			get => this.weaponType ??= BlzGetEventWeaponType();
			set
			{
				if (IsEvent && this.weaponType != value)
				{
					BlzSetEventWeaponType(value);
				}
				this.weaponType = value;
			}
		}
		private armortype armorType;
		public armortype ArmorType => this.armorType ??= ConvertArmorType(BlzGetUnitIntegerField(Target, UNIT_IF_ARMOR_TYPE));
		private defensetype defenseType;
		public defensetype DefenseType => this.defenseType ??= ConvertDefenseType(BlzGetUnitIntegerField(Target, UNIT_IF_DEFENSE_TYPE));
		private float? armor;
		public float Armor => this.armor ??= BlzGetUnitArmor(Target);
		public int ArmorPierce { get; set; }

		public bool IsEvent { get; }

		public DamageTrigger()
		{
			IsEvent = true;
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
			if (IsEvent)
			{
				BlzSetEventDamage(RealDamage);
			}
			else
			{
				UnitDamageTarget(Source, Target, Math.Min(DamageCap, RawDamage), false, false, AttackType, DamageType, WeaponType);
			}
		}
	}
}
