using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public interface IDamage
	{
		/// <summary>
		/// The unit that will be dealing damage.
		/// </summary>
		unit Source { get; set; }
		/// <summary>
		/// The unit that will be taking damage.
		/// </summary>
		unit Target { get; set; }

		/// <summary>
		/// The attack type of the damage.
		/// </summary>
		attacktype AttackType { get; set; }
		/// <summary>
		/// The armor type of the <see cref="Target"/>
		/// </summary>
		armortype ArmorType { get; set; }
		/// <summary>
		///  The damage type of the damage.
		/// </summary>
		damagetype DamageType { get; set; }
		/// <summary>
		/// The defense type of the <see cref="Target"/>.
		/// </summary>
		defensetype DefenseType { get; set; }
		/// <summary>
		/// The weapon type of the damage.
		/// </summary>
		weapontype WeaponType { get; set; }
	}
}
