using static War3Api.Common;

namespace WCSharp.Utils.Extensions
{
	public static class UnitExtensions
	{
		/// <summary>
		/// Shorthand for damaging a unit, as the default has many useless arguments.
		/// </summary>
		public static void Damage(this unit target, unit damageDealer, float damage, attacktype attackType)
		{
			UnitDamageTarget(damageDealer, target, damage, true, false, attackType, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
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
