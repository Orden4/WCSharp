using static War3Api.Common;

namespace WCSharp.Utils.Extensions
{
	/// <summary>
	/// Extension class that defines a number of methods to simplify working with Warcraft III units.
	/// </summary>
	public static class UnitExtensions
	{
		/// <summary>
		/// Shorthand for damaging a unit, as the default has many arguments that arent't generally used.
		/// </summary>
		public static void Damage(this unit target, unit damageDealer, float damage, attacktype attackType, damagetype damagetype = null)
		{
			UnitDamageTarget(damageDealer, target, damage, true, false, attackType, damagetype ?? DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
		}

		/// <summary>
		/// Shorthand for healing a unit.
		/// </summary>
		public static void Heal(this unit target, float amount)
		{
			SetUnitState(target, UNIT_STATE_LIFE, GetUnitState(target, UNIT_STATE_LIFE) + amount);
		}
	}
}
