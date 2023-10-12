using WCSharp.Api;
using static WCSharp.Api.Common;

namespace WCSharp.Shared.Extensions
{
	/// <summary>
	/// Extension class that defines a number of methods to simplify working with Warcraft III units.
	/// </summary>
	/// @CSharpLua.Ignore
	public static class UnitExtensions
	{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
		/// <summary>
		/// Shorthand for damaging a unit, as the default has many arguments that arent't generally used.
		/// </summary>
		/// @CSharpLua.Template = "UnitDamageTarget({1}, {0}, {2}, false, false, {3}, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS)"
		public static extern void Damage(this unit target, unit damageDealer, float damage, attacktype attackType);

		/// <summary>
		/// Shorthand for damaging a unit, as the default has many arguments that arent't generally used.
		/// </summary>
		/// @CSharpLua.Template = "UnitDamageTarget({1}, {0}, {2}, false, false, {3}, {4}, WEAPON_TYPE_WHOKNOWS)"
		public static extern void Damage(this unit target, unit damageDealer, float damage, attacktype attackType, damagetype damagetype);

		/// <summary>
		/// Shorthand for healing a unit.
		/// </summary>
		/// @CSharpLua.Template = "SetWidgetLife({0}, GetWidgetLife({0}) + {1})"
		public static extern void Heal(this widget target, float amount);

		/// <summary>
		/// Shorthand for replenishing a units mana.
		/// </summary>
		/// @CSharpLua.Template = "SetUnitState({0}, UNIT_STATE_MANA, GetUnitState({0}, UNIT_STATE_MANA) + {1})"
		public static extern void Replenish(this unit target, float amount);
#pragma warning restore CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	}
}
