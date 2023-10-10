using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unit : widget, IDisposable
	{
		internal unit()
		{
		}

		/// @CSharpLua.Template = "CreateUnit({0}, {1}, {2}, {3}, {4})"
		public static extern unit Create(player player, int unitType, float x, float y, float facing = Blizzard.bj_UNIT_FACING);
		/// @CSharpLua.Template = "CreateUnitByName({0}, {1}, {2}, {3}, {4})"
		public static extern unit Create(player player, string unitType, float x, float y, float facing = Blizzard.bj_UNIT_FACING);
		/// @CSharpLua.Template = "CreateCorpse({0}, {1}, {2}, {3}, {4})"
		public static extern unit CreateCorpse(player player, int unitType, float x, float y, float facing = Blizzard.bj_UNIT_FACING);

		/// @CSharpLua.Template = "GetFoodMade({0})"
		public static extern int FoodUsedBy(int unitType);
		/// @CSharpLua.Template = "GetFoodUsed({0})"
		public static extern int FoodMadeBy(int unitType);


		/// @CSharpLua.Get = "GetUnitX({0})"
		/// @CSharpLua.Set = "SetUnitX({0}, {1})"
		public extern float X { get; set; }
		/// @CSharpLua.Get = "GetUnitY({0})"
		/// @CSharpLua.Set = "SetUnitY({0}, {1})"
		public extern float Y { get; set; }
		/// @CSharpLua.Get = "GetUnitState({0}, UNIT_STATE_MANA)"
		/// @CSharpLua.Set = "SetUnitState({0}, {1}, UNIT_STATE_MANA)"
		public extern float Mana { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitMaxHP({0})"
		/// @CSharpLua.Set = "BlzSetUnitMaxHP({0}, {1})"
		public extern int MaxLife { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitMaxMana({0})"
		/// @CSharpLua.Set = "BlzSetUnitMaxMana({0}, {1})"
		public extern int MaxMana { get; set; }
		/// @CSharpLua.Get = "GetOwningPlayer({0})"
		/// @CSharpLua.Set = "SetUnitOwner({0}, {1}, true)"
		public extern player Owner { get; set; }
		/// @CSharpLua.Get = "GetUnitFacing({0})"
		/// @CSharpLua.Set = "BlzSetUnitFacingEx({0}, {1})"
		public extern float Facing { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultMoveSpeed({0})"
		/// @CSharpLua.Set = "SetUnitMoveSpeed({0}, {1})"
		public extern float BaseMovementSpeed { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultTurnSpeed({0})"
		/// @CSharpLua.Set = "SetUnitTurnSpeed({0}, {1})"
		public extern float DefaultTurnSpeed { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultPropWindow({0})"
		/// @CSharpLua.Set = "SetUnitPropWindow({0}, {1})"
		public extern float DefaultPropWindow { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultAcquireRange({0})"
		/// @CSharpLua.Set = "SetUnitAcquireRange({0}, {1})"
		public extern float DefaultAcquireRange { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultFlyHeight({0})"
		/// @CSharpLua.Set = "SetUnitFlyHeight({0}, {1}, 0)"
		public extern float DefaultFlyHeight { get; set; }
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
		/// @CSharpLua.Get = "GetUnitName({0})"
		/// @CSharpLua.Set = "BlzSetUnitName({0}, {1})"
		public extern string Name { get; set; }
		/// @CSharpLua.Get = "GetHeroProperName({0})"
		/// @CSharpLua.Set = "BlzSetHeroProperName({0}, {1})"
		public extern string HeroName { get; set; }
		/// @CSharpLua.Get = "GetUnitUserData({0})"
		/// @CSharpLua.Set = "SetUnitUserData({0}, {1})"
		public extern int UserData { get; set; }
		/// @CSharpLua.Get = "IsUnitHidden({0})"
		/// @CSharpLua.Set = "ShowUnit({0}, {1})"
		public extern int IsVisible { get; set; }
		/// @CSharpLua.Get = "UnitIgnoreAlarmToggled({0})"
		/// @CSharpLua.Set = "UnitIgnoreAlarm({0}, {1})"
		public extern bool IgnoreAlarm { get; set; }
		/// @CSharpLua.Get = "GetHeroXP({0})"
		/// @CSharpLua.Set = "SetHeroXP({0}, {1}, true)"
		public extern int Experience { get; set; }
		/// @CSharpLua.Get = "GetHeroLevel({0})"
		/// @CSharpLua.Set = "SetHeroLevel({0}, {1}, true)"
		public extern int HeroLevel { get; set; }
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
		/// @CSharpLua.Get = "UnitCanSleep({0})"
		/// @CSharpLua.Set = "UnitAddSleep({0}, {1})"
		public extern bool CanSleep { get; set; }
		/// @CSharpLua.Get = "UnitCanSleepPerm({0})"
		/// @CSharpLua.Set = "UnitAddSleepPerm({0}, {1})"
		public extern bool CanSleepPerm { get; set; }

		/// @CSharpLua.Get = "GetUnitRallyPoint({0})"
		public extern location RallyPoint { get; }
		/// @CSharpLua.Get = "GetUnitRallyUnit({0})"
		public extern unit RallyUnit { get; }
		/// @CSharpLua.Get = "GetUnitRallyDestructable({0})"
		public extern destructable RallyDestructable { get; }

		/// @CSharpLua.Get = "BlzGetUnitZ({0})"
		public extern float Z { get; }
		/// @CSharpLua.Get = "BlzGetLocalUnitZ({0})"
		public extern float LocalZ { get; }
		/// @CSharpLua.Get = "GetUnitMoveSpeed({0})"
		public extern float MovementSpeed { get; }
		/// @CSharpLua.Get = "GetUnitTurnSpeed({0})"
		public extern float TurnSpeed { get; }
		/// @CSharpLua.Get = "GetUnitPropWindow({0})"
		public extern float PropWindow { get; }
		/// @CSharpLua.Get = "GetUnitAcquireRange({0})"
		public extern float AcquireRange { get; }
		/// @CSharpLua.Get = "GetUnitFlyHeight({0})"
		public extern float FlyHeight { get; }
		/// @CSharpLua.Get = "GetUnitPointValue({0})"
		public extern bool PointValue { get; }
		/// @CSharpLua.Get = "GetUnitCurrentOrder({0})"
		public extern int CurrentOrder { get; }
		/// @CSharpLua.Get = "GetUnitLevel({0})"
		public extern int Level { get; }
		/// @CSharpLua.Get = "GetUnitFoodUsed({0})"
		public extern int FoodUsed { get; }
		/// @CSharpLua.Get = "GetUnitFoodMade({0})"
		public extern int FoodMade { get; }
		/// @CSharpLua.Get = "UnitIsSleeping({0})"
		public extern bool IsSleeping { get; }
		/// @CSharpLua.Get = "UnitInventorySize({0})"
		public extern int InventorySize { get; }
		/// @CSharpLua.Get = "IsUnitIllusion({0})"
		public extern bool IsIllusion { get; }
		/// @CSharpLua.Get = "IsUnitLoaded({0})"
		public extern bool IsLoaded { get; }
		/// @CSharpLua.Get = "BlzGetUnitCollisionSize({0})"
		public extern float CollisionSize { get; }
		/// @CSharpLua.Get = "BlzIsUnitSelectable({0})"
		public extern bool Selectable { get; }

		/// @CSharpLua.Template = "SetUnitColor({0}, {1})"
		public extern void SetColor(playercolor color);
		/// @CSharpLua.Template = "SetUnitBlendTime({0}, {1})"
		public extern void SetBlendTime(float blendTime);
		/// @CSharpLua.Template = "UnitSetConstructionProgress({0}, {1})"
		public extern void SetConstructionProgress(int percentage);
		/// @CSharpLua.Template = "SetUnitFacing({0}, {1})"
		public extern void SetFacing(float facingAngle);
		/// @CSharpLua.Template = "SetUnitFacingTimed({0}, {1}, {2})"
		public extern void SetFacing(float facingAngle, float duration);
		/// @CSharpLua.Template = "SetUnitFlyHeight({0}, {1}, {2})"
		public extern void SetFlyHeight(float flyHeight, float rate);
		/// @CSharpLua.Template = "BlzShowUnitTeamGlow({0}, {1})"
		public extern void SetGlowVisibility(bool visible);
		/// @CSharpLua.Template = "SetHeroXP({0}, {1}, {2})"
		public extern void SetExperience(int xp, bool showEyeCandy = false);
		/// @CSharpLua.Template = "SetUnitExploded({0}, {1})"
		public extern void SetExploded(bool exploded);
		/// @CSharpLua.Template = "SetItemTypeSlots({0}, {1})"
		public extern void SetItemTypeSlots(int slots);
		/// @CSharpLua.Template = "SetUnitOwner({0}, {1}, {2})"
		public extern void SetOwner(player player, bool changeColor = true);
		/// @CSharpLua.Template = "SetUnitPosition({0}, {1})"
		public extern void SetPosition(float x, float y);
		/// @CSharpLua.Template = "SetUnitRescuable({0}, {1})"
		public extern void SetRescuable(bool rescuable);
		/// @CSharpLua.Template = "SetUnitRescueRange({0}, {1})"
		public extern void SetRescueRange(float range);
		/// @CSharpLua.Template = "SetUnitScale({0}, {1}, {2}, {3})"
		public extern void SetScale(float scaleX, float scaleY, float scaleZ);
		/// @CSharpLua.Template = "UnitShareVision({0}, {1}, {2})"
		public extern void SetSharedVision(player player, bool share);
		/// @CSharpLua.Template = "UnitSuspendDecay({0}, {1})"
		public extern void SetSuspendDecay(bool suspend);
		/// @CSharpLua.Template = "SetUnitTimeScale({0}, {1})"
		public extern void SetTimeScale(float timeScale);
		/// @CSharpLua.Template = "UnitSetUpgradeProgress({0}, {1})"
		public extern void SetUpgradeProgress(int percentage);
		/// @CSharpLua.Template = "UnitSetUsesAltIcon({0}, {1})"
		public extern void SetUsesAltIcon(bool usesAltIcon);
		/// @CSharpLua.Template = "SetUnitTypeSlots({0}, {1})"
		public extern void SetUnitTypeSlots(int slots);
		/// @CSharpLua.Template = "SetUnitVertexColor({0}, {1}, {2}, {3})"
		public extern void SetVertexColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "WaygateSetDestination({0}, {1}, {2})"
		public extern void SetWaygateDestination(float x, float y);

		/// @CSharpLua.Template = "IsUnitAlly({0}, {1})"
		public extern bool IsAllyTo(player player);
		/// @CSharpLua.Template = "IsUnitEnemy({0}, {1})"
		public extern bool IsEnemyTo(player player);
		/// @CSharpLua.Template = "IsUnitVisible({0}, {1})"
		public extern bool IsVisibleTo(player player);
		/// @CSharpLua.Template = "IsUnitDetected({0}, {1})"
		public extern bool IsDetectedBy(player player);
		/// @CSharpLua.Template = "IsUnitInvisible({0}, {1})"
		public extern bool IsInvisibleTo(player player);
		/// @CSharpLua.Template = "IsUnitFogged({0}, {1})"
		public extern bool IsFoggedTo(player player);
		/// @CSharpLua.Template = "IsUnitMasked({0}, {1})"
		public extern bool IsMaskedTo(player player);
		/// @CSharpLua.Template = "IsUnitSelected({0}, {1})"
		public extern bool IsSelectedTo(player player);
		/// @CSharpLua.Template = "IsUnitType({0}, {1})"
		public extern bool IsUnitType(unittype player);
		/// @CSharpLua.Template = "IsUnitInTransport({0}, {1})"
		public extern bool IsInTransport(unit tranportUnit);
		/// @CSharpLua.Template = "IsUnitInRange({0}, {1}, {2})"
		public extern bool IsInRange(unit target, float distance);
		/// @CSharpLua.Template = "IsUnitInRange({0}, {1}, {2}, {3})"
		public extern bool IsInRange(float x, float y, float distance);

		/// @CSharpLua.Template = "UnitAddItem({0}, {1})"
		public extern bool AddItem(item item);
		/// @CSharpLua.Template = "UnitAddItemById({0}, {1})"
		public extern item AddItem(int itemId);
		/// @CSharpLua.Template = "UnitAddItemToSlotById({0}, {1}, {2})"
		public extern item AddItem(int itemId, int itemSlot);
		/// @CSharpLua.Template = "UnitRemoveItem({0}, {1})"
		public extern void RemoveItem(item item);
		/// @CSharpLua.Template = "UnitRemoveItemFromSlot({0}, {1})"
		public extern item RemoveItem(int itemSlot);
		/// @CSharpLua.Template = "UnitDropItemPoint({0}, {1}, {2}, {3})"
		public extern bool DropItem(item item, float x, float y);
		/// @CSharpLua.Template = "UnitDropItemSlot({0}, {1}, {2})"
		public extern bool DropItem(item item, int itemSlot);
		/// @CSharpLua.Template = "UnitDropItemTarget({0}, {1}, {2})"
		public extern bool DropItem(item item, widget target);
		/// @CSharpLua.Template = "UnitUseItem({0}, {1}, {2}, {3})"
		public extern bool UseItem(item item, float x, float y);
		/// @CSharpLua.Template = "UnitUseItemPoint({0}, {1}, {2})"
		public extern bool UseItem(item item, int itemSlot);
		/// @CSharpLua.Template = "UnitUseItemTarget({0}, {1}, {2})"
		public extern bool UseItem(item item, widget target);
		/// @CSharpLua.Template = "UnitHasItem({0}, {1})"
		public extern bool HasItem(item item);
		/// @CSharpLua.Template = "UnitItemInSlot({0}, {1})"
		public extern item ItemAtOrDefault(item item);

		/// @CSharpLua.Template = "BlzGetUnitBaseDamage({0}, {1})"
		public extern int GetBaseDamage(int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitBaseDamage({0}, {1}, {2})"
		public extern void SetBaseDamage(int baseDamage, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitDiceNumber({0}, {1})"
		public extern int GetDiceNumber(int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitDiceNumber({0}, {1}, {2})"
		public extern void SetDiceNumber(int diceNumber, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitDiceSides({0}, {1})"
		public extern int GetDiceSides(int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitDiceSides({0}, {1}, {2})"
		public extern void SetDiceSides(int diceSides, int weaponIndex);
		/// @CSharpLua.Template = "BlzGetUnitAttackCooldown({0}, {1})"
		public extern float GetAttackCooldown(int weaponIndex);
		/// @CSharpLua.Template = "BlzSetUnitAttackCooldown({0}, {1}, {2})"
		public extern void SetAttackCooldown(float attackCooldown, int weaponIndex);

		/// @CSharpLua.Template = "UnitModifySkillPoints({0}, {1})"
		public extern bool AddSkillPoints(int skillPoints);
		/// @CSharpLua.Template = "UnitStripHeroLevel({0}, {1})"
		public extern bool RemoveHeroLevels(int levels);

		/// @CSharpLua.Template = "UnitAddType({0}, {1})"
		public extern bool AddType(unittype unitType);
		/// @CSharpLua.Template = "UnitRemoveType({0}, {1})"
		public extern bool RemoveType(unittype unitType);

		/// @CSharpLua.Template = "UnitAddAbility({0}, {1})"
		public extern bool AddAbility(int abilityId);
		/// @CSharpLua.Template = "UnitRemoveAbility({0}, {1})"
		public extern bool RemoveAbility(int abilityId);
		/// @CSharpLua.Template = "GetUnitAbilityLevel({0}, {1})"
		public extern int GetAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "SetUnitAbilityLevel({0}, {1}, {2})"
		public extern int SetAbilityLevel(int abilityId, int level);
		/// @CSharpLua.Template = "IncUnitAbilityLevel({0}, {1})"
		public extern int IncrementAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "DecUnitAbilityLevel({0}, {1})"
		public extern int DecrementAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "BlzUnitHideAbility({0}, {1}, {2})"
		public extern void HideAbility(int abilityId, bool hide);
		/// @CSharpLua.Template = "BlzUnitDisableAbility({0}, {1}, {2}, {3})"
		public extern void DisableAbility(int abilityId, bool disable, bool hide);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldown({0}, {1}, {2})"
		public extern void GetAbilityCooldown(int abilityId, int level);
		/// @CSharpLua.Template = "BlzSetUnitAbilityCooldown({0}, {1}, {2}, {3})"
		public extern void SetAbilityCooldown(int abilityId, int level, float cooldown);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldownRemaining({0}, {1})"
		public extern void GetAbilityCooldownRemaining(int abilityId);
		/// @CSharpLua.Template = "BlzStartUnitAbilityCooldown({0}, {1}, {2})"
		public extern void SetAbilityCooldownRemaining(int abilityId, float cooldown);
		/// @CSharpLua.Template = "BlzGetUnitAbilityManaCost({0}, {1})"
		public extern void GetAbilityManaCost(int abilityId, int manaCost);
		/// @CSharpLua.Template = "BlzSetUnitAbilityManaCost({0}, {1}, {2})"
		public extern void SetAbilityManaCost(int abilityId, int manaCost);
		/// @CSharpLua.Template = "UnitMakeAbilityPermanent({0}, {2}, {1})"
		public extern bool SetAbilityPermanent(int abilityId, bool permanent);

		/// @CSharpLua.Template = "UnitRemoveBuffsEx({0}, {1}, {2})"
		public extern void RemoveBuffs(bool positive, bool negative);
		/// @CSharpLua.Template = "UnitRemoveBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public extern void RemoveBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitHasBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public extern bool HasBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitCountBuffsEx({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public extern int CountBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);

		/// @CSharpLua.Template = "IssueImmediateOrder({0}, {1})"
		public extern bool IssueImmediateOrder(string order);
		/// @CSharpLua.Template = "IssueImmediateOrderById({0}, {1})"
		public extern bool IssueImmediateOrder(int order);
		/// @CSharpLua.Template = "IssuePointOrder({0}, {1}, {2}, {3})"
		public extern bool IssuePointOrder(string order, float x, float y);
		/// @CSharpLua.Template = "IssuePointOrderById({0}, {1}, {2}, {3})"
		public extern bool IssuePointOrder(int order, float x, float y);
		/// @CSharpLua.Template = "IssueTargetOrder({0}, {1}, {2})"
		public extern bool IssueTargetOrder(string order, widget target);
		/// @CSharpLua.Template = "IssueTargetOrderById({0}, {1}, {2})"
		public extern bool IssueTargetOrder(int order, widget target);
		/// @CSharpLua.Template = "IssueInstantPointOrder({0}, {1}, {2}, {3}, {4})"
		public extern bool IssueInstantPointOrder(string order, float x, float y, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantPointOrderById({0}, {1}, {2}, {3}, {4})"
		public extern bool IssueInstantPointOrder(int order, float x, float y, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantTargetOrder({0}, {1}, {2}, {3})"
		public extern bool IssueInstantTargetOrder(string order, widget target, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantTargetOrderById({0}, {1}, {2}, {3})"
		public extern bool IssueInstantTargetOrder(int order, widget target, widget instantTarget);
		/// @CSharpLua.Template = "IssueBuildOrder({0}, {1}, {2}, {3}, {4})"
		public extern bool IssueBuildOrder(string order, int unitId, float x, float y);
		/// @CSharpLua.Template = "IssueBuildOrderById({0}, {1}, {2}, {3}, {4})"
		public extern bool IssueBuildOrder(int order, int unitId, float x, float y);

		/// @CSharpLua.Template = "IssueNeutralImmediateOrder({1}, {0}, {2})"
		public extern bool IssueNeutralImmediateOrder(player player, string unitId);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrderById({1}, {0}, {2})"
		public extern bool IssueNeutralImmediateOrder(player player, int unitId);
		/// @CSharpLua.Template = "IssueNeutralPointOrder({1}, {0}, {2}, {3}, {4})"
		public extern bool IssueNeutralPointOrder(player player, string unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralPointOrderById({1}, {0}, {2}, {3}, {4})"
		public extern bool IssueNeutralPointOrder(player player, int unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralTargetOrder({1}, {0}, {2}, {3})"
		public extern bool IssueNeutralTargetOrder(player player, string unitId, widget target);
		/// @CSharpLua.Template = "IssueNeutralTargetOrderById({1}, {0}, {2}, {3})"
		public extern bool IssueNeutralTargetOrder(player player, int unitId, widget target);

		/// @CSharpLua.Template = "AddItemToStock({0}, {1}, {2}, {3})"
		public extern void AddItemToStock(int itemId, int stock, int stockMax);
		/// @CSharpLua.Template = "AddUnitToStock({0}, {1}, {2}, {3})"
		public extern void AddUnitToStock(int unitId, int stock, int stockMax);
		/// @CSharpLua.Template = "RemoveItemFromStock({0}, {1})"
		public extern void RemoveItemFromStock(int itemId);
		/// @CSharpLua.Template = "RemoveUnitFromStock({0}, {1})"
		public extern void RemoveUnitFromStock(int unitId);

		/// @CSharpLua.Template = "AddUnitAnimationProperties({0}, {1}, true)"
		public extern void AddAnimationProperty(string animationProperty);
		/// @CSharpLua.Template = "AddUnitAnimationProperties({0}, {1}, false)"
		public extern void RemoveAnimationProperty(string animationProperty);

		/// @CSharpLua.Template = "SetUnitLookAt({0}, {1}, {2}, {3}, {4}, {5})"
		public extern void SetLookAt(string bone, unit target, float offsetX = 0, float offsetY = 0, float offsetZ = 0);
		/// @CSharpLua.Template = "ResetUnitLookAt({0})"
		public extern void ResetLookAt();

		/// @CSharpLua.Template = "UnitApplyTimedLife({0}, {1}, {2})"
		public extern void ApplyTimedLife(int buffId, float duration);
		/// @CSharpLua.Template = "UnitPauseTimedLife({0}, true)"
		public extern void PauseTimedLife();
		/// @CSharpLua.Template = "UnitPauseTimedLife({0}, false)"
		public extern void ResumeTimedLife();
		/// @CSharpLua.Template = "BlzUnitCancelTimedLife({0})"
		public extern void CancelTimedLife();

		/// @CSharpLua.Template = "QueueUnitAnimation({0}, {1})"
		public extern void QueueAnimation(string animation);
		/// @CSharpLua.Template = "SetUnitAnimation({0}, {1})"
		public extern void SetAnimation(string animation);
		/// @CSharpLua.Template = "SetUnitAnimationByIndex({0}, {1})"
		public extern void SetAnimation(int animationId);
		/// @CSharpLua.Template = "SetUnitAnimationWithRarity({0}, {1}, {2})"
		public extern void SetAnimation(string animation, raritycontrol rarity);

		/// @CSharpLua.Template = "UnitDamagePoint({0}, {8}, {3}, {1}, {2}, {4}, {5}, {6}, {7}, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS)"
		public extern bool DealDamage(float x, float y, float radius, float damage, bool attack, bool ranged, attacktype attackType, float delay = 0);
		/// @CSharpLua.Template = "UnitDamagePoint({0}, {10}, {3}, {1}, {2}, {4}, {5}, {6}, {7}, {8}, {9})"
		public extern bool DealDamage(float x, float y, float radius, float damage, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType, float delay = 0);
		/// @CSharpLua.Template = "UnitDamageTarget({0}, {1}, {2}, {3}, {4}, {5}, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS)"
		public extern bool DealDamage(widget target, float damage, bool attack, bool ranged, attacktype attackType);
		/// @CSharpLua.Template = "UnitDamageTarget({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})"
		public extern bool DealDamage(widget target, float damage, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);

		/// @CSharpLua.Template = "AddResourceAmount({0}, {1})"
		public extern void AddResourceAmount(int amount);
		/// @CSharpLua.Template = "SelectUnit({0}, {1})"
		public extern void Select(bool value = true);
		/// @CSharpLua.Template = "SelectHeroSkill({0}, {1}, {2}, {3})"
		public extern void SelectHeroSkill(int abilityId);
		/// @CSharpLua.Template = "ReviveHero({0}, {1}, {2}, {3})"
		public extern void Revive(float x, float y, bool doEyeCandy = true);
		/// @CSharpLua.Template = "UnitResetCooldown({0})"
		public extern void ResetCooldowns();
		/// @CSharpLua.Template = "BlzUnitInterruptAttack({0})"
		public extern void InterruptAttack();
		/// @CSharpLua.Template = "UnitWakeUp({0})"
		public extern void WakeUp();
		/// @CSharpLua.Template = "KillUnit({0})"
		public extern void Kill();
		/// @CSharpLua.Template = "RemoveUnit({0})"
		public extern void Dispose();

		#region Field editing
		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_RAISABLE)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_RAISABLE, {1})"
		public extern bool Raisable { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_DECAYABLE)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_DECAYABLE, {1})"
		public extern bool Decayable { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_IS_A_BUILDING)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_IS_A_BUILDING, {1})"
		public extern bool IsABuilding { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT, {1})"
		public extern bool UseExtendedLineOfSight { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON, {1})"
		public extern bool NeutralBuildingShowsMinimapIcon { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON, {1})"
		public extern bool HeroHideHeroInterfaceIcon { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY, {1})"
		public extern bool HeroHideHeroMinimapDisplay { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE, {1})"
		public extern bool HeroHideHeroDeathMessage { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_HIDE_MINIMAP_DISPLAY)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_HIDE_MINIMAP_DISPLAY, {1})"
		public extern bool HideMinimapDisplay { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_SCALE_PROJECTILES)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_SCALE_PROJECTILES, {1})"
		public extern bool ScaleProjectiles { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_SELECTION_CIRCLE_ON_WATER)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_SELECTION_CIRCLE_ON_WATER, {1})"
		public extern bool SelectionCircleOnWater { get; set; }

		/// @CSharpLua.Get = "GetUnitBooleanField({0}, UNIT_BF_HAS_WATER_SHADOW)"
		/// @CSharpLua.Set = "SetUnitBooleanField({0}, UNIT_BF_HAS_WATER_SHADOW, {1})"
		public extern bool HasWaterShadow { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_DEFENSE_TYPE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_DEFENSE_TYPE, {1})"
		public extern int DefenseType { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_ARMOR_TYPE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_ARMOR_TYPE, {1})"
		public extern int ArmorType { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_LOOPING_FADE_IN_RATE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_LOOPING_FADE_IN_RATE, {1})"
		public extern int LoopingFadeInRate { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_LOOPING_FADE_OUT_RATE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_LOOPING_FADE_OUT_RATE, {1})"
		public extern int LoopingFadeOutRate { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE, {1})"
		public extern int GoldBountyAwardedNumberOfDice { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_BASE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_BASE, {1})"
		public extern int GoldBountyAwardedBase { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE, {1})"
		public extern int GoldBountyAwardedSidesPerDie { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE, {1})"
		public extern int LumberBountyAwardedNumberOfDice { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE, {1})"
		public extern int LumberBountyAwardedBase { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE, {1})"
		public extern int LumberBountyAwardedSidesPerDie { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_FORMATION_RANK)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_FORMATION_RANK, {1})"
		public extern int FormationRank { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_ORIENTATION_INTERPOLATION)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_ORIENTATION_INTERPOLATION, {1})"
		public extern int OrientationInterpolation { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_ELEVATION_SAMPLE_POINTS)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_ELEVATION_SAMPLE_POINTS, {1})"
		public extern int ElevationSamplePoints { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_RED)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_RED, {1})"
		public extern int TintingColorRed { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_GREEN)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_GREEN, {1})"
		public extern int TintingColorGreen { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_BLUE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_BLUE, {1})"
		public extern int TintingColorBlue { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_ALPHA)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_TINTING_COLOR_ALPHA, {1})"
		public extern int TintingColorAlpha { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_MOVE_TYPE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_MOVE_TYPE, {1})"
		public extern int MoveType { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_TARGETED_AS)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_TARGETED_AS, {1})"
		public extern int TargetedAs { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_UNIT_CLASSIFICATION)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_UNIT_CLASSIFICATION, {1})"
		public extern int UnitClassification { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_HIT_POINTS_REGENERATION_TYPE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_HIT_POINTS_REGENERATION_TYPE, {1})"
		public extern int HitPointsRegenerationType { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_PLACEMENT_PREVENTED_BY)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_PLACEMENT_PREVENTED_BY, {1})"
		public extern int PlacementPreventedBy { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_PRIMARY_ATTRIBUTE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_PRIMARY_ATTRIBUTE, {1})"
		public extern int PrimaryAttribute { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_STRENGTH_PER_LEVEL)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_STRENGTH_PER_LEVEL, {1})"
		public extern float StrengthPerLevel { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_AGILITY_PER_LEVEL)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_AGILITY_PER_LEVEL, {1})"
		public extern float AgilityPerLevel { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_INTELLIGENCE_PER_LEVEL)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_INTELLIGENCE_PER_LEVEL, {1})"
		public extern float IntelligencePerLevel { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_HIT_POINTS_REGENERATION_RATE)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_HIT_POINTS_REGENERATION_RATE, {1})"
		public extern float HitPointsRegenerationRate { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_DEATH_TIME)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_DEATH_TIME, {1})"
		public extern float DeathTime { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_ELEVATION_SAMPLE_RADIUS)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_ELEVATION_SAMPLE_RADIUS, {1})"
		public extern float ElevationSampleRadius { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS, {1})"
		public extern float FogOfWarSampleRadius { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES, {1})"
		public extern float MaximumPitchAngleDegrees { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES, {1})"
		public extern float MaximumRollAngleDegrees { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SCALING_VALUE)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SCALING_VALUE, {1})"
		public extern float ScalingValue { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_ANIMATION_RUN_SPEED)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_ANIMATION_RUN_SPEED, {1})"
		public extern float AnimationRunSpeed { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SELECTION_SCALE)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SELECTION_SCALE, {1})"
		public extern float SelectionScale { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SELECTION_CIRCLE_HEIGHT)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SELECTION_CIRCLE_HEIGHT, {1})"
		public extern float SelectionCircleHeight { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_HEIGHT)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_HEIGHT, {1})"
		public extern float ShadowImageHeight { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_WIDTH)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_WIDTH, {1})"
		public extern float ShadowImageWidth { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_CENTER_X)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_CENTER_X, {1})"
		public extern float ShadowImageCenterX { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_CENTER_Y)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SHADOW_IMAGE_CENTER_Y, {1})"
		public extern float ShadowImageCenterY { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_ANIMATION_WALK_SPEED)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_ANIMATION_WALK_SPEED, {1})"
		public extern float AnimationWalkSpeed { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_DEFENSE)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_DEFENSE, {1})"
		public extern float Defense { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_SIGHT_RADIUS)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_SIGHT_RADIUS, {1})"
		public extern float SightRadius { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_PRIORITY)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_PRIORITY, {1})"
		public extern float Priority { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_OCCLUDER_HEIGHT)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_OCCLUDER_HEIGHT, {1})"
		public extern float OccluderHeight { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_CAST_BACK_SWING)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_CAST_BACK_SWING, {1})"
		public extern float CastBackSwing { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_CAST_POINT)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_CAST_POINT, {1})"
		public extern float CastPoint { get; set; }

		/// @CSharpLua.Get = "GetUnitRealField({0}, UNIT_RF_MINIMUM_ATTACK_RANGE)"
		/// @CSharpLua.Set = "SetUnitRealField({0}, UNIT_RF_MINIMUM_ATTACK_RANGE, {1})"
		public extern float MinimumAttackRange { get; set; }

		/// @CSharpLua.Get = "GetUnitStringField({0}, UNIT_SF_GROUND_TEXTURE)"
		/// @CSharpLua.Set = "SetUnitStringField({0}, UNIT_SF_GROUND_TEXTURE, {1})"
		public extern string GroundTexture { get; set; }

		/// @CSharpLua.Get = "GetUnitStringField({0}, UNIT_SF_SHADOW_IMAGE_UNIT)"
		/// @CSharpLua.Set = "SetUnitStringField({0}, UNIT_SF_SHADOW_IMAGE_UNIT, {1})"
		public extern string ShadowImageUnit { get; set; }
		#endregion

		#region Weapon 1 field editing
		/// @CSharpLua.Get = "GetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, {1}, 0)"
		public extern bool AttacksEnabled1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, 0)"
		public extern int AttackMaximumNumberOfTargets1 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, {1}, 0)"
		public extern int AttackAttackType1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, {1}, 0)"
		public extern int AttackWeaponSound1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, {1}, 0)"
		public extern int AttackTargetsAllowed1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, {1}, 0)"
		public extern float AttackBackswingPoint1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, {1}, 0)"
		public extern float AttackDamagePoint1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, 0)"
		public extern float AttackDamageLossFactor1 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, {1}, 0)"
		public extern float AttackDamageFactorMedium1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, {1}, 0)"
		public extern float AttackDamageFactorSmall1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, 0)"
		public extern float AttackDamageSpillDistance1 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, 0)"
		public extern float AttackDamageSpillRadius1 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, {1}, 0)"
		public extern float AttackProjectileSpeed1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, {1}, 0)"
		public extern float AttackProjectileArc1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, {1}, 0)"
		public extern float AttackAreaOfEffectFullDamage1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, {1}, 0)"
		public extern float AttackAreaOfEffectMediumDamage1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, {1}, 0)"
		public extern float AttackAreaOfEffectSmallDamage1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, {1} - GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, 1), 1)"
		public extern float AttackRange1 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 0)"
		/// @CSharpLua.Set = "SetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, {1}, 0)"
		public extern string AttackProjectileArt1 { get; set; }
		#endregion

		#region Weapon 2 field editing
		/// @CSharpLua.Get = "GetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, {1}, 1)"
		public extern bool AttacksEnabled2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, 1)"
		public extern int AttackMaximumNumberOfTargets2 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, {1}, 1)"
		public extern int AttackAttackType2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, {1}, 1)"
		public extern int AttackWeaponSound2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, {1}, 1)"
		public extern int AttackTargetsAllowed2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, {1}, 1)"
		public extern float AttackBackswingPoint2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, {1}, 1)"
		public extern float AttackDamagePoint2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, 1)"
		public extern float AttackDamageLossFactor2 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, {1}, 1)"
		public extern float AttackDamageFactorMedium2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, {1}, 1)"
		public extern float AttackDamageFactorSmall2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, 1)"
		public extern float AttackDamageSpillDistance2 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, 1)"
		public extern float AttackDamageSpillRadius2 { get; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, {1}, 1)"
		public extern float AttackProjectileSpeed2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, {1}, 1)"
		public extern float AttackProjectileArc2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, {1}, 1)"
		public extern float AttackAreaOfEffectFullDamage2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, {1}, 1)"
		public extern float AttackAreaOfEffectMediumDamage2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, {1}, 1)"
		public extern float AttackAreaOfEffectSmallDamage2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, 2)"
		/// @CSharpLua.Set = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, {1} - GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, 2), 2)"
		public extern float AttackRange2 { get; set; }

		/// @CSharpLua.Get = "GetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 1)"
		/// @CSharpLua.Set = "SetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, {1}, 1)"
		public extern string AttackProjectileArt2 { get; set; }
		#endregion
	}
}
