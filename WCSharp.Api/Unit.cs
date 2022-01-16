using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Unit : Widget, IDisposable
	{
		internal Unit()
		{

		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator unit(Unit x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Unit(unit x);

		/// @CSharpLua.Get = "GetUnitX({0})"
		/// @CSharpLua.Set = "SetUnitX({0}, {1})"
		public extern override float X { get; set; }

		/// @CSharpLua.Get = "GetUnittY({0})"
		/// @CSharpLua.Set = "SetUnitY({0}, {1})"
		public extern override float Y { get; set; }

		/// @CSharpLua.Get = "GetUnitState({0}, UNIT_STATE_MANA)"
		/// @CSharpLua.Set = "SetUnitState({0}, {1}, UNIT_STATE_MANA)"
		public extern float Mana { get; set; }

		/// @CSharpLua.Get = "GetUnitState({0}, UNIT_STATE_MAX_LIFE)"
		/// @CSharpLua.Set = "BlzSetUnitMaxHP({0}, {1})"
		/// TODO: Test integer/float value for set max life
		public extern float MaxLife { get; set; }

		/// @CSharpLua.Get = "GetUnitState({0}, UNIT_STATE_MAX_MANA)"
		/// @CSharpLua.Set = "BlzSetUnitMaxMana({0}, {1})"
		/// TODO: Test integer/float value for set max mana
		public extern float MaxMana { get; set; }

		/// @CSharpLua.Get = "GetUnitFacing({0})"
		/// @CSharpLua.Set = "BlzSetUnitFacingEx({0}, {1})"
		public extern float Facing { get; set; }

		/// @CSharpLua.Get = "GetUnitMoveSpeed({0})"
		public extern float MovementSpeed { get; }

		/// @CSharpLua.Get = "GetUnitDefaultMoveSpeed({0})"
		/// @CSharpLua.Set = "SetUnitMoveSpeed({0}, {1})"
		public extern float BaseMovementSpeed { get; set; }

		/// @CSharpLua.Get = "GetUnitTurnSpeed({0})"
		/// @CSharpLua.Set = "SetUnitTurnSpeed({0}, {1})"
		public extern float TurnSpeed { get; set; }

		/// @CSharpLua.Get = "GetUnitPropWindow({0})"
		/// @CSharpLua.Set = "SetUnitPropWindow({0}, {1})"
		public extern float PropWindow { get; set; }

		/// @CSharpLua.Get = "GetUnitAcquireRange({0})"
		/// @CSharpLua.Set = "SetUnitAcquireRange({0}, {1})"
		public extern float AcquireRange { get; set; }

		/// @CSharpLua.Get = "GetUnitFlyHeight({0})"
		/// @CSharpLua.Set = "SetUnitFlyHeight({0}, {1}, 0)"
		public extern float FlyHeight { get; set; }

		/// @CSharpLua.Get = "GetUnitDefaultTurnSpeed({0})"
		public extern float DefaultTurnSpeed { get; }

		/// @CSharpLua.Get = "GetUnitDefaultPropWindow({0})"
		public extern float DefaultPropWindow { get; }

		/// @CSharpLua.Get = "GetUnitDefaultAcquireRange({0})"
		public extern float DefaultAcquireRange { get; }

		/// @CSharpLua.Get = "GetUnitDefaultFlyHeight({0})"
		public extern float DefaultFlyHeight { get; }

		/// @CSharpLua.Get = "GetUnitCreepGuard({0})"
		/// @CSharpLua.Set = "SetUnitCreepGuard({0}, {1})"
		public extern bool IsCreepGuard { get; set; }

		/// @CSharpLua.Get = "GetHeroStr({0}, false)"
		/// @CSharpLua.Set = "SetHeroStr({0}, {1}, false)"
		public extern int BaseStrength { get; set; }

		/// @CSharpLua.Get = "GetHeroAgi({0}, false)"
		/// @CSharpLua.Set = "SetHeroAgi({0}, {1}, false)"
		public extern int BaseAgility { get; set; }

		/// @CSharpLua.Get = "GetHeroInt({0}, false)"
		/// @CSharpLua.Set = "SetHeroInt({0}, {1}, false)"
		public extern int BaseIntelligence { get; set; }

		/// @CSharpLua.Get = "GetHeroStr({0}, true)"
		/// @CSharpLua.Set = "SetHeroStr({0}, {1}, true)"
		public extern int Strength { get; set; }

		/// @CSharpLua.Get = "GetHeroAgi({0}, true)"
		/// @CSharpLua.Set = "SetHeroAgi({0}, {1}, true)"
		public extern int Agility { get; set; }

		/// @CSharpLua.Get = "GetHeroInt({0}, true)"
		/// @CSharpLua.Set = "SetHeroInt({0}, {1}, true)"
		public extern int Intelligence { get; set; }

		/// @CSharpLua.Get = "GetHeroSkillPoints({0})"
		/// @CSharpLua.Set = "UnitModifySkillPoints({0}, {1} - GetHeroSkillPoints({0}))"
		public extern int SkillPoints { get; set; }

		/// @CSharpLua.Get = "IsSuspendedXP({0})"
		/// @CSharpLua.Set = "SuspendHeroXP({0}, {1})"
		public extern bool CanGainXp { get; set; }

		/// @CSharpLua.Get = "BlzIsUnitInvulnerable({0})"
		/// @CSharpLua.Set = "SetUnitInvulnerable({0}, {1})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "IsUnitPaused({0})"
		/// @CSharpLua.Set = "PauseUnit({0}, {1})"
		public extern bool IsPaused { get; set; }

		/// @CSharpLua.Get = "GetUnitPointValue({0})"
		public extern bool PointValue { get; }

		/// @CSharpLua.Get = "GetUnitName({0})"
		/// @CSharpLua.Set = "BlzSetUnitName({0}, {1})"
		public extern string Name { get; set; }

		/// @CSharpLua.Get = "GetHeroProperName({0})"
		/// @CSharpLua.Set = "BlzSetHeroProperName({0}, {1})"
		public extern string HeroName { get; set; }

		/// @CSharpLua.Get = "GetUnitCurrentOrder({0})"
		public extern int CurrentOrder { get; }

		/// @CSharpLua.Get = "GetUnitUserData({0})"
		/// @CSharpLua.Set = "SetUnitUserData({0}, {1})"
		public extern int UserData { get; set; }

		/// @CSharpLua.Get = "IsUnitHidden({0})"
		/// @CSharpLua.Set = "ShowUnit({0}, {1})"
		public extern int IsShown { get; set; }

		/// @CSharpLua.Get = "UnitIgnoreAlarmToggled({0})"
		/// @CSharpLua.Set = "UnitIgnoreAlarm({0}, {1})"
		public extern bool IgnoreAlarm { get; set; }

		/// @CSharpLua.Get = "GetHeroXP({0})"
		/// @CSharpLua.Set = "SetHeroXP({0}, {1}, true)"
		public extern int Xp { get; set; }

		/// @CSharpLua.Get = "GetHeroLevel({0})"
		/// @CSharpLua.Set = "SetHeroLevel({0}, {1}, true)"
		public extern int HeroLevel { get; set; }

		/// @CSharpLua.Get = "GetUnitLevel({0})"
		public extern int Level { get; }

		/// @CSharpLua.Get = "GetResourceAmount({0})"
		/// @CSharpLua.Set = "SetResourceAmount({0}, {1})"
		public extern int ResourceAmount { get; set; }

		/// @CSharpLua.Get = "WaygateGetDestinationX({0})"
		/// @CSharpLua.Set = "WaygateSetDestination({0}, {1}, WaygateGetDestinationY({0}))"
		public extern int WaygateDestinationX { get; set; }

		/// @CSharpLua.Get = "WaygateGetDestinationX({0})"
		/// @CSharpLua.Set = "WaygateSetDestination({0}, WaygateGetDestinationX({0}), {1})"
		public extern int WaygateDestinationY { get; set; }

		/// @CSharpLua.Get = "WaygateIsActive({0})"
		/// @CSharpLua.Set = "WaygateActivate({0}, {1})"
		public extern bool WaygateActive { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitArmor({0})"
		/// @CSharpLua.Set = "BlzSetUnitArmor({0}, {1})"
		public extern float Armor { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitSkin({0})"
		/// @CSharpLua.Set = "BlzSetUnitSkin({0}, {1})"
		public extern int Skin { get; set; }

		/// @CSharpLua.Get = "GetUnitFoodUsed({0})"
		public extern int FoodUsed { get; }

		/// @CSharpLua.Get = "GetUnitFoodMade({0})"
		public extern int FoodMade { get; }

		/// @CSharpLua.Get = "UnitIsSleeping({0})"
		public extern bool IsSleeping { get; }

		/// @CSharpLua.Get = "UnitCanSleep({0})"
		/// @CSharpLua.Set = "UnitAddSleep({0}, {1})"
		public extern bool CanSleep { get; set; }

		/// @CSharpLua.Get = "UnitCanSleepPerm({0})"
		/// @CSharpLua.Set = "UnitAddSleepPerm({0}, {1})"
		public extern bool CanSleepPerm { get; set; }

		/// @CSharpLua.Template = "ReviveHero({0}, {1}, {2}, {3})"
		public extern void Revive(float x, float y, bool doEyecandy);

		/// @CSharpLua.Template = "RemoveUnit({0})"
		public extern void Dispose();
	}
}
