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
		/// @CSharpLua.Template = "BlzCreateUnitWithSkin({0}, {1}, {3}, {4}, {5}, {2})"
		public static extern unit CreateWithSkin(player player, int unitType, int skinId, float x, float y, float facing = Blizzard.bj_UNIT_FACING);

		/// @CSharpLua.Template = "GetFoodMade({0})"
		public static extern int FoodUsedBy(int unitType);
		/// @CSharpLua.Template = "GetFoodUsed({0})"
		public static extern int FoodMadeBy(int unitType);


		/// @CSharpLua.Get = "GetUnitX({this})"
		/// @CSharpLua.Set = "SetUnitX({this}, {0})"
		public extern float X { get; set; }
		/// @CSharpLua.Get = "GetUnitY({this})"
		/// @CSharpLua.Set = "SetUnitY({this}, {0})"
		public extern float Y { get; set; }
		/// @CSharpLua.Get = "GetUnitState({this}, UNIT_STATE_MANA)"
		/// @CSharpLua.Set = "SetUnitState({this}, UNIT_STATE_MANA, {0})"
		public extern float Mana { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitMaxHP({this})"
		/// @CSharpLua.Set = "BlzSetUnitMaxHP({this}, {0})"
		public extern int MaxLife { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitMaxMana({this})"
		/// @CSharpLua.Set = "BlzSetUnitMaxMana({this}, {0})"
		public extern int MaxMana { get; set; }
		/// @CSharpLua.Get = "GetOwningPlayer({this})"
		/// @CSharpLua.Set = "SetUnitOwner({this}, {0}, true)"
		public extern player Owner { get; set; }
		/// @CSharpLua.Get = "GetUnitFacing({this})"
		/// @CSharpLua.Set = "BlzSetUnitFacingEx({this}, {0})"
		public extern float Facing { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultMoveSpeed({this})"
		/// @CSharpLua.Set = "SetUnitMoveSpeed({this}, {0})"
		public extern float BaseMovementSpeed { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultTurnSpeed({this})"
		/// @CSharpLua.Set = "SetUnitTurnSpeed({this}, {0})"
		public extern float DefaultTurnSpeed { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultPropWindow({this})"
		/// @CSharpLua.Set = "SetUnitPropWindow({this}, {0})"
		public extern float DefaultPropWindow { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultAcquireRange({this})"
		/// @CSharpLua.Set = "SetUnitAcquireRange({this}, {0})"
		public extern float DefaultAcquireRange { get; set; }
		/// @CSharpLua.Get = "GetUnitDefaultFlyHeight({this})"
		/// @CSharpLua.Set = "SetUnitFlyHeight({this}, {0}, 0)"
		public extern float DefaultFlyHeight { get; set; }
		/// @CSharpLua.Get = "GetHeroStr({this}, false)"
		/// @CSharpLua.Set = "SetHeroStr({this}, {0}, false)"
		public extern int BaseStrength { get; set; }
		/// @CSharpLua.Get = "GetHeroAgi({this}, false)"
		/// @CSharpLua.Set = "SetHeroAgi({this}, {0}, false)"
		public extern int BaseAgility { get; set; }
		/// @CSharpLua.Get = "GetHeroInt({this}, false)"
		/// @CSharpLua.Set = "SetHeroInt({this}, {0}, false)"
		public extern int BaseIntelligence { get; set; }
		/// @CSharpLua.Get = "GetHeroStr({this}, true)"
		/// @CSharpLua.Set = "SetHeroStr({this}, {0}, true)"
		public extern int Strength { get; set; }
		/// @CSharpLua.Get = "GetHeroAgi({this}, true)"
		/// @CSharpLua.Set = "SetHeroAgi({this}, {0}, true)"
		public extern int Agility { get; set; }
		/// @CSharpLua.Get = "GetHeroInt({this}, true)"
		/// @CSharpLua.Set = "SetHeroInt({this}, {0}, true)"
		public extern int Intelligence { get; set; }
		/// @CSharpLua.Get = "GetHeroSkillPoints({this})"
		/// @CSharpLua.Set = "UnitModifySkillPoints({this}, {0} - GetHeroSkillPoints({this}))"
		public extern int SkillPoints { get; set; }
		/// @CSharpLua.Get = "IsSuspendedXP({this})"
		/// @CSharpLua.Set = "SuspendHeroXP({this}, {0})"
		public extern bool CanGainXP { get; set; }
		/// @CSharpLua.Get = "BlzIsUnitInvulnerable({this})"
		/// @CSharpLua.Set = "SetUnitInvulnerable({this}, {0})"
		public extern bool IsInvulnerable { get; set; }
		/// @CSharpLua.Get = "IsUnitPaused({this})"
		/// @CSharpLua.Set = "PauseUnit({this}, {0})"
		public extern bool IsPaused { get; set; }
		/// @CSharpLua.Get = "GetUnitName({this})"
		/// @CSharpLua.Set = "BlzSetUnitName({this}, {0})"
		public extern string Name { get; set; }
		/// @CSharpLua.Get = "GetHeroProperName({this})"
		/// @CSharpLua.Set = "BlzSetHeroProperName({this}, {0})"
		public extern string HeroName { get; set; }
		/// @CSharpLua.Get = "GetUnitUserData({this})"
		/// @CSharpLua.Set = "SetUnitUserData({this}, {0})"
		public extern int UserData { get; set; }
		/// @CSharpLua.Get = "IsUnitHidden({this})"
		/// @CSharpLua.Set = "ShowUnit({this}, {0})"
		public extern bool IsVisible { get; set; }
		/// @CSharpLua.Get = "UnitIgnoreAlarmToggled({this})"
		/// @CSharpLua.Set = "UnitIgnoreAlarm({this}, {0})"
		public extern bool IgnoreAlarm { get; set; }
		/// @CSharpLua.Get = "GetHeroXP({this})"
		/// @CSharpLua.Set = "SetHeroXP({this}, {0}, true)"
		public extern int Experience { get; set; }
		/// @CSharpLua.Get = "GetHeroLevel({this})"
		/// @CSharpLua.Set = "SetHeroLevel({this}, {0}, true)"
		public extern int HeroLevel { get; set; }
		/// @CSharpLua.Get = "GetResourceAmount({this})"
		/// @CSharpLua.Set = "SetResourceAmount({this}, {0})"
		public extern int ResourceAmount { get; set; }
		/// @CSharpLua.Get = "WaygateGetDestinationX({this})"
		/// @CSharpLua.Set = "WaygateSetDestination({this}, {0}, WaygateGetDestinationY({this}))"
		public extern float WaygateDestinationX { get; set; }
		/// @CSharpLua.Get = "WaygateGetDestinationY({this})"
		/// @CSharpLua.Set = "WaygateSetDestination({this}, WaygateGetDestinationX({this}), {0})"
		public extern float WaygateDestinationY { get; set; }
		/// @CSharpLua.Get = "WaygateIsActive({this})"
		/// @CSharpLua.Set = "WaygateActivate({this}, {0})"
		public extern bool WaygateActive { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitArmor({this})"
		/// @CSharpLua.Set = "BlzSetUnitArmor({this}, {0})"
		public extern float Armor { get; set; }
		/// @CSharpLua.Get = "BlzGetUnitSkin({this})"
		/// @CSharpLua.Set = "BlzSetUnitSkin({this}, {0})"
		public extern int Skin { get; set; }
		/// @CSharpLua.Get = "UnitCanSleep({this})"
		/// @CSharpLua.Set = "UnitAddSleep({this}, {0})"
		public extern bool CanSleep { get; set; }
		/// @CSharpLua.Get = "UnitCanSleepPerm({this})"
		/// @CSharpLua.Set = "UnitAddSleepPerm({this}, {0})"
		public extern bool CanSleepPerm { get; set; }
		/// @CSharpLua.Get = "BlzGetHeroStat({this}, BlzGetHeroPrimaryStat({this}))"
		/// @CSharpLua.Set = "BlzSetHeroPrimaryStat({this}, {0})"
		public extern int PrimaryAttribute { get; set; }

		/// @CSharpLua.Get = "GetUnitRallyPoint({this})"
		public extern location RallyPoint { get; }
		/// @CSharpLua.Get = "GetUnitRallyUnit({this})"
		public extern unit RallyUnit { get; }
		/// @CSharpLua.Get = "GetUnitRallyDestructable({this})"
		public extern destructable RallyDestructable { get; }

		/// @CSharpLua.Get = "BlzGetUnitZ({this})"
		public extern float Z { get; }
		/// @CSharpLua.Get = "BlzGetLocalUnitZ({this})"
		public extern float LocalZ { get; }
		/// @CSharpLua.Get = "GetUnitMoveSpeed({this})"
		public extern float MovementSpeed { get; }
		/// @CSharpLua.Get = "GetUnitTurnSpeed({this})"
		public extern float TurnSpeed { get; }
		/// @CSharpLua.Get = "GetUnitPropWindow({this})"
		public extern float PropWindow { get; }
		/// @CSharpLua.Get = "GetUnitAcquireRange({this})"
		public extern float AcquireRange { get; }
		/// @CSharpLua.Get = "GetUnitFlyHeight({this})"
		public extern float FlyHeight { get; }
		/// @CSharpLua.Get = "GetUnitPointValue({this})"
		public extern int PointValue { get; }
		/// @CSharpLua.Get = "GetUnitCurrentOrder({this})"
		public extern int CurrentOrder { get; }
		/// @CSharpLua.Get = "GetUnitLevel({this})"
		public extern int Level { get; }
		/// @CSharpLua.Get = "GetUnitFoodUsed({this})"
		public extern int FoodUsed { get; }
		/// @CSharpLua.Get = "GetUnitFoodMade({this})"
		public extern int FoodMade { get; }
		/// @CSharpLua.Get = "UnitIsSleeping({this})"
		public extern bool IsSleeping { get; }
		/// @CSharpLua.Get = "UnitInventorySize({this})"
		public extern int InventorySize { get; }
		/// @CSharpLua.Get = "IsUnitIllusion({this})"
		public extern bool IsIllusion { get; }
		/// @CSharpLua.Get = "IsUnitLoaded({this})"
		public extern bool IsLoaded { get; }
		/// @CSharpLua.Get = "BlzGetUnitCollisionSize({this})"
		public extern float CollisionSize { get; }
		/// @CSharpLua.Get = "BlzIsUnitSelectable({this})"
		public extern bool Selectable { get; }
		/// @CSharpLua.Get = "GetUnitTypeId({this})"
		public extern int UnitType { get; }
		/// @CSharpLua.Get = "GetUnitRace({this})"
		public extern race Race { get; }
		/// @CSharpLua.Get = "BlzGetUnitOrderCount({this})"
		public extern int OrderCount { get; }
		/// @CSharpLua.Get = "UnitAlive({this})"
		public extern bool Alive { get; }
		/// @CSharpLua.Get = "UnitInvis({this})"
		public extern bool IsInvisible { get; }
		/// @CSharpLua.Get = "BlzGetHeroPrimaryStat({this})"
		public extern int PrimaryAttributeType { get; }

		/// @CSharpLua.Template = "BlzGetHeroStat({this}, {0})"
		public extern int GetAttribute(int heroAttributeId);
		/// @CSharpLua.Template = "BlzSetHeroStatEx({this}, {0}, {1})"
		public extern void SetAttribute(int heroAttributeId, int value);

		/// @CSharpLua.Template = "SetUnitColor({this}, {0})"
		public extern void SetColor(playercolor color);
		/// @CSharpLua.Template = "SetUnitBlendTime({this}, {0})"
		public extern void SetBlendTime(float blendTime);
		/// @CSharpLua.Template = "UnitSetConstructionProgress({this}, {0})"
		public extern void SetConstructionProgress(int percentage);
		/// @CSharpLua.Template = "SetUnitCreepGuard({this}, {0})"
		public extern void SetCreepGuard(bool value);
		/// @CSharpLua.Template = "SetUnitFacing({this}, {0})"
		public extern void SetFacing(float facingAngle);
		/// @CSharpLua.Template = "SetUnitFacingTimed({this}, {0}, {1})"
		public extern void SetFacing(float facingAngle, float duration);
		/// @CSharpLua.Template = "SetUnitFlyHeight({this}, {0}, {1})"
		public extern void SetFlyHeight(float flyHeight, float rate);
		/// @CSharpLua.Template = "BlzShowUnitTeamGlow({this}, {0})"
		public extern void SetGlowVisibility(bool visible);
		/// @CSharpLua.Template = "SetHeroXP({this}, {0}, {1})"
		public extern void SetExperience(int xp, bool showEyeCandy = false);
		/// @CSharpLua.Template = "SetUnitExploded({this}, {0})"
		public extern void SetExploded(bool exploded);
		/// @CSharpLua.Template = "SetItemTypeSlots({this}, {0})"
		public extern void SetItemTypeSlots(int slots);
		/// @CSharpLua.Template = "SetUnitOwner({this}, {0}, {1})"
		public extern void SetOwner(player player, bool changeColor = true);
		/// @CSharpLua.Template = "SetUnitPathing({this}, {0})"
		public extern void SetPathing(bool pathing);
		/// @CSharpLua.Template = "BlzPauseUnitEx({this}, {0})"
		public extern void SetPausedEx(bool paused);
		/// @CSharpLua.Template = "SetUnitPosition({this}, {0}, {1})"
		public extern void SetPosition(float x, float y);
		/// @CSharpLua.Template = "SetUnitRescuable({this}, {0}, {1})"
		public extern void SetRescuable(player byPlayer, bool rescuable);
		/// @CSharpLua.Template = "SetUnitRescueRange({this}, {0})"
		public extern void SetRescueRange(float range);
		/// @CSharpLua.Template = "SetUnitScale({this}, {0}, {1}, {2})"
		public extern void SetScale(float scaleX, float scaleY, float scaleZ);
		/// @CSharpLua.Template = "UnitShareVision({this}, {0}, {1})"
		public extern void SetSharedVision(player player, bool share);
		/// @CSharpLua.Template = "UnitSuspendDecay({this}, {0})"
		public extern void SetSuspendDecay(bool suspend);
		/// @CSharpLua.Template = "SetUnitTimeScale({this}, {0})"
		public extern void SetTimeScale(float timeScale);
		/// @CSharpLua.Template = "UnitSetUpgradeProgress({this}, {0})"
		public extern void SetUpgradeProgress(int percentage);
		/// @CSharpLua.Template = "UnitSetUsesAltIcon({this}, {0})"
		public extern void SetUsesAltIcon(bool usesAltIcon);
		/// @CSharpLua.Template = "SetUnitTypeSlots({this}, {0})"
		public extern void SetUnitTypeSlots(int slots);
		/// @CSharpLua.Template = "SetUnitUseFood({this}, {0})"
		public extern void SetUseFood(bool useFood);
		/// @CSharpLua.Template = "SetUnitVertexColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetVertexColor(int red, int green, int blue, int alpha = 255);
		/// @CSharpLua.Template = "WaygateSetDestination({this}, {0}, {1})"
		public extern void SetWaygateDestination(float x, float y);

		/// @CSharpLua.Template = "IsUnitAlly({this}, {0})"
		public extern bool IsAllyTo(player player);
		/// @CSharpLua.Template = "IsUnitEnemy({this}, {0})"
		public extern bool IsEnemyTo(player player);
		/// @CSharpLua.Template = "IsUnitVisible({this}, {0})"
		public extern bool IsVisibleTo(player player);
		/// @CSharpLua.Template = "IsUnitDetected({this}, {0})"
		public extern bool IsDetectedBy(player player);
		/// @CSharpLua.Template = "IsUnitInvisible({this}, {0})"
		public extern bool IsInvisibleTo(player player);
		/// @CSharpLua.Template = "IsUnitFogged({this}, {0})"
		public extern bool IsFoggedTo(player player);
		/// @CSharpLua.Template = "IsUnitMasked({this}, {0})"
		public extern bool IsMaskedTo(player player);
		/// @CSharpLua.Template = "IsUnitSelected({this}, {0})"
		public extern bool IsSelectedTo(player player);
		/// @CSharpLua.Template = "IsUnitType({this}, {0})"
		public extern bool IsUnitType(unittype player);
		/// @CSharpLua.Template = "IsUnitInTransport({this}, {0})"
		public extern bool IsInTransport(unit tranportUnit);
		/// @CSharpLua.Template = "IsUnitInRange({this}, {0}, {1})"
		public extern bool IsInRange(unit target, float distance);
		/// @CSharpLua.Template = "IsUnitInRangeXY({this}, {0}, {1}, {2})"
		public extern bool IsInRange(float x, float y, float distance);

		/// @CSharpLua.Template = "UnitAddItem({this}, {0})"
		public extern bool AddItem(item item);
		/// @CSharpLua.Template = "UnitAddItemById({this}, {0})"
		public extern item AddItem(int itemId);
		/// @CSharpLua.Template = "UnitAddItemToSlotById({this}, {0}, {1})"
		public extern bool AddItem(int itemId, int itemSlot);
		/// @CSharpLua.Template = "UnitRemoveItem({this}, {0})"
		public extern void RemoveItem(item item);
		/// @CSharpLua.Template = "UnitRemoveItemFromSlot({this}, {0})"
		public extern item RemoveItem(int itemSlot);
		/// @CSharpLua.Template = "UnitDropItemPoint({this}, {0}, {1}, {2})"
		public extern bool DropItem(item item, float x, float y);
		/// @CSharpLua.Template = "UnitDropItemSlot({this}, {0}, {1})"
		public extern bool DropItem(item item, int itemSlot);
		/// @CSharpLua.Template = "UnitDropItemTarget({this}, {0}, {1})"
		public extern bool DropItem(item item, widget target);
		/// @CSharpLua.Template = "UnitUseItem({this}, {0})"
		public extern bool UseItem(item item);
		/// @CSharpLua.Template = "UnitUseItemPoint({this}, {0}, {1}, {2})"
		public extern bool UseItem(item item, float x, float y);
		/// @CSharpLua.Template = "UnitUseItemTarget({this}, {0}, {1})"
		public extern bool UseItem(item item, widget target);
		/// @CSharpLua.Template = "UnitHasItem({this}, {0})"
		public extern bool HasItem(item item);
		/// @CSharpLua.Template = "UnitItemInSlot({this}, {0})"
		public extern item ItemAtOrDefault(int itemSlot);

		/// @CSharpLua.Template = "UnitModifySkillPoints({this}, {0})"
		public extern bool AddSkillPoints(int skillPoints);
		/// @CSharpLua.Template = "UnitStripHeroLevel({this}, {0})"
		public extern bool RemoveHeroLevels(int levels);

		/// @CSharpLua.Template = "UnitAddType({this}, {0})"
		public extern bool AddType(unittype unitType);
		/// @CSharpLua.Template = "UnitRemoveType({this}, {0})"
		public extern bool RemoveType(unittype unitType);

		/// @CSharpLua.Template = "UnitAddAbility({this}, {0})"
		public extern bool AddAbility(int abilityId);
		/// @CSharpLua.Template = "UnitRemoveAbility({this}, {0})"
		public extern bool RemoveAbility(int abilityId);
		/// @CSharpLua.Template = "BlzGetUnitAbility({this}, {0})"
		public extern ability GetAbility(int abilityId);
		/// @CSharpLua.Template = "BlzGetUnitAbilityByIndex({this}, {0})"
		public extern ability GetAbilityByIndex(int index);
		/// @CSharpLua.Template = "GetUnitAbilityLevel({this}, {0})"
		public extern int GetAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "SetUnitAbilityLevel({this}, {0}, {1})"
		public extern int SetAbilityLevel(int abilityId, int level);
		/// @CSharpLua.Template = "IncUnitAbilityLevel({this}, {0})"
		public extern int IncrementAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "DecUnitAbilityLevel({this}, {0})"
		public extern int DecrementAbilityLevel(int abilityId);
		/// @CSharpLua.Template = "BlzUnitHideAbility({this}, {0}, {1})"
		public extern void HideAbility(int abilityId, bool hide);
		/// @CSharpLua.Template = "BlzUnitDisableAbility({this}, {0}, {1}, {2})"
		public extern void DisableAbility(int abilityId, bool disable, bool hide);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldown({this}, {0}, {1})"
		public extern float GetAbilityCooldown(int abilityId, int level);
		/// @CSharpLua.Template = "BlzSetUnitAbilityCooldown({this}, {0}, {1}, {2})"
		public extern void SetAbilityCooldown(int abilityId, int level, float cooldown);
		/// @CSharpLua.Template = "BlzGetUnitAbilityCooldownRemaining({this}, {0})"
		public extern float GetAbilityCooldownRemaining(int abilityId);
		/// @CSharpLua.Template = "BlzStartUnitAbilityCooldown({this}, {0}, {1})"
		public extern void SetAbilityCooldownRemaining(int abilityId, float cooldown);
		/// @CSharpLua.Template = "BlzEndUnitAbilityCooldown({this}, {0})"
		public extern void EndAbilityCooldown(int abilityId);
		/// @CSharpLua.Template = "BlzGetUnitAbilityManaCost({this}, {0}, {1})"
		public extern int GetAbilityManaCost(int abilityId, int level);
		/// @CSharpLua.Template = "BlzSetUnitAbilityManaCost({this}, {0}, {1}, {2})"
		public extern void SetAbilityManaCost(int abilityId, int level, int manaCost);
		/// @CSharpLua.Template = "UnitMakeAbilityPermanent({this}, {1}, {0})"
		public extern bool SetAbilityPermanent(int abilityId, bool permanent);
		/// @CSharpLua.Template = "BlzDeleteHeroAbility({this}, {0})"
		public extern bool DeleteHeroAbility(int abilityId);

		/// @CSharpLua.Template = "UnitRemoveBuffs({this}, {0}, {1})"
		public extern void RemoveBuffs(bool positive, bool negative);
		/// @CSharpLua.Template = "UnitRemoveBuffsEx({this}, {0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public extern void RemoveBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitHasBuffsEx({this}, {0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public extern bool HasBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);
		/// @CSharpLua.Template = "UnitCountBuffsEx({this}, {0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public extern int CountBuffs(bool positive, bool negative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);

		/// @CSharpLua.Template = "IssueImmediateOrder({this}, {0})"
		public extern bool IssueOrder(string order);
		/// @CSharpLua.Template = "IssueImmediateOrderById({this}, {0})"
		public extern bool IssueOrder(int order);
		/// @CSharpLua.Template = "IssuePointOrder({this}, {0}, {1}, {2})"
		public extern bool IssueOrder(string order, float x, float y);
		/// @CSharpLua.Template = "IssuePointOrderById({this}, {0}, {1}, {2})"
		public extern bool IssueOrder(int order, float x, float y);
		/// @CSharpLua.Template = "IssueTargetOrder({this}, {0}, {1})"
		public extern bool IssueOrder(string order, widget target);
		/// @CSharpLua.Template = "IssueTargetOrderById({this}, {0}, {1})"
		public extern bool IssueOrder(int order, widget target);

		/// @CSharpLua.Template = "IssueInstantPointOrder({this}, {0}, {1}, {2}, {3})"
		public extern bool IssueInstantOrder(string order, float x, float y, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantPointOrderById({this}, {0}, {1}, {2}, {3})"
		public extern bool IssueInstantOrder(int order, float x, float y, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantTargetOrder({this}, {0}, {1}, {2})"
		public extern bool IssueInstantOrder(string order, widget target, widget instantTarget);
		/// @CSharpLua.Template = "IssueInstantTargetOrderById({this}, {0}, {1}, {2})"
		public extern bool IssueInstantOrder(int order, widget target, widget instantTarget);

		/// @CSharpLua.Template = "IssueBuildOrder({this}, {0}, {1}, {2})"
		public extern bool IssueBuildOrder(string unitId, float x, float y);
		/// @CSharpLua.Template = "IssueBuildOrderById({this}, {0}, {1}, {2})"
		public extern bool IssueBuildOrder(int unitId, float x, float y);

		/// @CSharpLua.Template = "IssueNeutralImmediateOrder({0}, {this}, {1})"
		public extern bool IssueNeutralOrder(player player, string unitId);
		/// @CSharpLua.Template = "IssueNeutralImmediateOrderById({0}, {this}, {1})"
		public extern bool IssueNeutralOrder(player player, int unitId);
		/// @CSharpLua.Template = "IssueNeutralPointOrder({0}, {this}, {1}, {2}, {3})"
		public extern bool IssueNeutralOrder(player player, string unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralPointOrderById({0}, {this}, {1}, {2}, {3})"
		public extern bool IssueNeutralOrder(player player, int unitId, float x, float y);
		/// @CSharpLua.Template = "IssueNeutralTargetOrder({0}, {this}, {1}, {2})"
		public extern bool IssueNeutralOrder(player player, string unitId, widget target);
		/// @CSharpLua.Template = "IssueNeutralTargetOrderById({0}, {this}, {1}, {2})"
		public extern bool IssueNeutralOrder(player player, int unitId, widget target);

		/// @CSharpLua.Template = "BlzQueueImmediateOrderById({this}, {0})"
		public extern bool QueueOrder(int order);
		/// @CSharpLua.Template = "BlzQueuePointOrderById({this}, {0}, {1}, {2})"
		public extern bool QueueOrder(int order, float x, float y);
		/// @CSharpLua.Template = "BlzQueueTargetOrderById({this}, {0}, {1})"
		public extern bool QueueOrder(int order, widget target);

		/// @CSharpLua.Template = "BlzQueueInstantPointOrderById({this}, {0}, {1}, {2}, {3})"
		public extern bool QueueInstantOrder(int order, float x, float y, widget instantTarget);
		/// @CSharpLua.Template = "BlzQueueInstantTargetOrderById({this}, {0}, {1}, {2})"
		public extern bool QueueInstantOrder(int order, widget target, widget instantTarget);

		/// @CSharpLua.Template = "BlzQueueBuildOrderById({this}, {0}, {1}, {2})"
		public extern bool QueueBuildOrder(int order, float x, float y);
		/// @CSharpLua.Template = "BlzQueueNeutralImmediateOrderById({0}, {this}, {1})"

		public extern bool QueueNeutralOrder(player player, int unitId);
		/// @CSharpLua.Template = "BlzQueueNeutralPointOrderById({0}, {this}, {1}, {2}, {3})"
		public extern bool QueueNeutralOrder(player player, int unitId, float x, float y);
		/// @CSharpLua.Template = "BlzQueueNeutralTargetOrderById({0}, {this}, {1}, {2})"
		public extern bool QueueNeutralOrder(player player, int unitId, widget target);

		/// @CSharpLua.Template = "AddItemToStock({this}, {0}, {1}, {2})"
		public extern void AddItemToStock(int itemId, int stock, int stockMax);
		/// @CSharpLua.Template = "AddUnitToStock({this}, {0}, {1}, {2})"
		public extern void AddUnitToStock(int unitId, int stock, int stockMax);
		/// @CSharpLua.Template = "RemoveItemFromStock({this}, {0})"
		public extern void RemoveItemFromStock(int itemId);
		/// @CSharpLua.Template = "RemoveUnitFromStock({this}, {0})"
		public extern void RemoveUnitFromStock(int unitId);

		/// @CSharpLua.Template = "AddUnitAnimationProperties({this}, {0}, true)"
		public extern void AddAnimationProperty(string animationProperty);
		/// @CSharpLua.Template = "AddUnitAnimationProperties({this}, {0}, false)"
		public extern void RemoveAnimationProperty(string animationProperty);

		/// @CSharpLua.Template = "SetUnitLookAt({this}, {0}, {1}, {2}, {3}, {4})"
		public extern void SetLookAt(string bone, unit target, float offsetX = 0, float offsetY = 0, float offsetZ = 0);
		/// @CSharpLua.Template = "ResetUnitLookAt({this})"
		public extern void ResetLookAt();

		/// @CSharpLua.Template = "UnitApplyTimedLife({this}, {0}, {1})"
		public extern void ApplyTimedLife(int buffId, float duration);
		/// @CSharpLua.Template = "UnitPauseTimedLife({this}, true)"
		public extern void PauseTimedLife();
		/// @CSharpLua.Template = "UnitPauseTimedLife({this}, false)"
		public extern void ResumeTimedLife();
		/// @CSharpLua.Template = "BlzUnitCancelTimedLife({this})"
		public extern void CancelTimedLife();

		/// @CSharpLua.Template = "QueueUnitAnimation({this}, {0})"
		public extern void QueueAnimation(string animation);
		/// @CSharpLua.Template = "SetUnitAnimation({this}, {0})"
		public extern void SetAnimation(string animation);
		/// @CSharpLua.Template = "SetUnitAnimationByIndex({this}, {0})"
		public extern void SetAnimation(int animationId);
		/// @CSharpLua.Template = "SetUnitAnimationWithRarity({this}, {0}, {1})"
		public extern void SetAnimation(string animation, raritycontrol rarity);

		/// @CSharpLua.Template = "UnitDamagePoint({this}, {7}, {2}, {0}, {1}, {3}, {4}, {5}, {6}, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS)"
		public extern bool DealDamage(float x, float y, float radius, float damage, bool attack, bool ranged, attacktype attackType, float delay = 0);
		/// @CSharpLua.Template = "UnitDamagePoint({this}, {9}, {2}, {0}, {1}, {3}, {4}, {5}, {6}, {7}, {8})"
		public extern bool DealDamage(float x, float y, float radius, float damage, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType, float delay = 0);
		/// @CSharpLua.Template = "UnitDamageTarget({this}, {0}, {1}, {2}, {3}, {4}, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS)"
		public extern bool DealDamage(widget target, float damage, bool attack, bool ranged, attacktype attackType);
		/// @CSharpLua.Template = "UnitDamageTarget({this}, {0}, {1}, {2}, {3}, {4}, {5}, {6})"
		public extern bool DealDamage(widget target, float damage, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);

		/// @CSharpLua.Template = "AddResourceAmount({this}, {0})"
		public extern void AddResourceAmount(int amount);
		/// @CSharpLua.Template = "SelectUnit({this}, {0})"
		public extern void Select(bool value = true);
		/// @CSharpLua.Template = "SelectHeroSkill({this}, {0})"
		public extern void SelectHeroSkill(int abilityId);
		/// @CSharpLua.Template = "ReviveHero({this}, {0}, {1}, {2})"
		public extern bool Revive(float x, float y, bool doEyeCandy = true);
		/// @CSharpLua.Template = "UnitResetCooldown({this})"
		public extern void ResetCooldowns();
		/// @CSharpLua.Template = "BlzUnitInterruptAttack({this})"
		public extern void InterruptAttack();
		/// @CSharpLua.Template = "UnitWakeUp({this})"
		public extern void WakeUp();
		/// @CSharpLua.Template = "KillUnit({this})"
		public extern void Kill();
		/// @CSharpLua.Template = "RemoveUnit({this})"
		public extern void Dispose();

		#region Field editing
		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_RAISABLE)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_RAISABLE, {0})"
		public extern bool Raisable { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_DECAYABLE)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_DECAYABLE, {0})"
		public extern bool Decayable { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_IS_A_BUILDING)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_IS_A_BUILDING, {0})"
		public extern bool IsABuilding { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_USE_EXTENDED_LINE_OF_SIGHT, {0})"
		public extern bool UseExtendedLineOfSight { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_NEUTRAL_BUILDING_SHOWS_MINIMAP_ICON, {0})"
		public extern bool NeutralBuildingShowsMinimapIcon { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_INTERFACE_ICON, {0})"
		public extern bool HeroHideHeroInterfaceIcon { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_MINIMAP_DISPLAY, {0})"
		public extern bool HeroHideHeroMinimapDisplay { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_HERO_HIDE_HERO_DEATH_MESSAGE, {0})"
		public extern bool HeroHideHeroDeathMessage { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_HIDE_MINIMAP_DISPLAY)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_HIDE_MINIMAP_DISPLAY, {0})"
		public extern bool HideMinimapDisplay { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_SCALE_PROJECTILES)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_SCALE_PROJECTILES, {0})"
		public extern bool ScaleProjectiles { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_SELECTION_CIRCLE_ON_WATER)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_SELECTION_CIRCLE_ON_WATER, {0})"
		public extern bool SelectionCircleOnWater { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitBooleanField({this}, UNIT_BF_HAS_WATER_SHADOW)"
		/// @CSharpLua.Set = "BlzSetUnitBooleanField({this}, UNIT_BF_HAS_WATER_SHADOW, {0})"
		public extern bool HasWaterShadow { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_DEFENSE_TYPE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_DEFENSE_TYPE, {0})"
		public extern int DefenseType { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitArmorType({this})"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_ARMOR_TYPE, {0})"
		public extern int ArmorType { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_LOOPING_FADE_IN_RATE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_LOOPING_FADE_IN_RATE, {0})"
		public extern int LoopingFadeInRate { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_LOOPING_FADE_OUT_RATE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_LOOPING_FADE_OUT_RATE, {0})"
		public extern int LoopingFadeOutRate { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_NUMBER_OF_DICE, {0})"
		public extern int GoldBountyAwardedNumberOfDice { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_BASE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_BASE, {0})"
		public extern int GoldBountyAwardedBase { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_GOLD_BOUNTY_AWARDED_SIDES_PER_DIE, {0})"
		public extern int GoldBountyAwardedSidesPerDie { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_NUMBER_OF_DICE, {0})"
		public extern int LumberBountyAwardedNumberOfDice { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_BASE, {0})"
		public extern int LumberBountyAwardedBase { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_LUMBER_BOUNTY_AWARDED_SIDES_PER_DIE, {0})"
		public extern int LumberBountyAwardedSidesPerDie { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_FORMATION_RANK)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_FORMATION_RANK, {0})"
		public extern int FormationRank { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_ORIENTATION_INTERPOLATION)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_ORIENTATION_INTERPOLATION, {0})"
		public extern int OrientationInterpolation { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_ELEVATION_SAMPLE_POINTS)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_ELEVATION_SAMPLE_POINTS, {0})"
		public extern int ElevationSamplePoints { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_RED)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_RED, {0})"
		public extern int TintingColorRed { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_GREEN)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_GREEN, {0})"
		public extern int TintingColorGreen { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_BLUE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_BLUE, {0})"
		public extern int TintingColorBlue { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_ALPHA)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_TINTING_COLOR_ALPHA, {0})"
		public extern int TintingColorAlpha { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitMovementType({this})"
		/// @CSharpLua.Set = "BlzSetUnitMovementType({this}, {0})"
		public extern int MoveType { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_TARGETED_AS)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_TARGETED_AS, {0})"
		public extern int TargetedAs { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_UNIT_CLASSIFICATION)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_UNIT_CLASSIFICATION, {0})"
		public extern int UnitClassification { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_HIT_POINTS_REGENERATION_TYPE)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_HIT_POINTS_REGENERATION_TYPE, {0})"
		public extern int HitPointsRegenerationType { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitIntegerField({this}, UNIT_IF_PLACEMENT_PREVENTED_BY)"
		/// @CSharpLua.Set = "BlzSetUnitIntegerField({this}, UNIT_IF_PLACEMENT_PREVENTED_BY, {0})"
		public extern int PlacementPreventedBy { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_MANA_REGENERATION)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_MANA_REGENERATION, {0})"
		public extern float ManaRegeneration { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_STRENGTH_PER_LEVEL)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_STRENGTH_PER_LEVEL, {0})"
		public extern float StrengthPerLevel { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_AGILITY_PER_LEVEL)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_AGILITY_PER_LEVEL, {0})"
		public extern float AgilityPerLevel { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_INTELLIGENCE_PER_LEVEL)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_INTELLIGENCE_PER_LEVEL, {0})"
		public extern float IntelligencePerLevel { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_HIT_POINTS_REGENERATION_RATE)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_HIT_POINTS_REGENERATION_RATE, {0})"
		public extern float HitPointsRegenerationRate { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_DEATH_TIME)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_DEATH_TIME, {0})"
		public extern float DeathTime { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_ELEVATION_SAMPLE_RADIUS)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_ELEVATION_SAMPLE_RADIUS, {0})"
		public extern float ElevationSampleRadius { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_FOG_OF_WAR_SAMPLE_RADIUS, {0})"
		public extern float FogOfWarSampleRadius { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_MAXIMUM_PITCH_ANGLE_DEGREES, {0})"
		public extern float MaximumPitchAngleDegrees { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_MAXIMUM_ROLL_ANGLE_DEGREES, {0})"
		public extern float MaximumRollAngleDegrees { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SCALING_VALUE)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SCALING_VALUE, {0})"
		public extern float ScalingValue { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_ANIMATION_RUN_SPEED)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_ANIMATION_RUN_SPEED, {0})"
		public extern float AnimationRunSpeed { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SELECTION_SCALE)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SELECTION_SCALE, {0})"
		public extern float SelectionScale { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SELECTION_CIRCLE_HEIGHT)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SELECTION_CIRCLE_HEIGHT, {0})"
		public extern float SelectionCircleHeight { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_HEIGHT)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_HEIGHT, {0})"
		public extern float ShadowImageHeight { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_WIDTH)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_WIDTH, {0})"
		public extern float ShadowImageWidth { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_CENTER_X)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_CENTER_X, {0})"
		public extern float ShadowImageCenterX { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_CENTER_Y)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SHADOW_IMAGE_CENTER_Y, {0})"
		public extern float ShadowImageCenterY { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_ANIMATION_WALK_SPEED)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_ANIMATION_WALK_SPEED, {0})"
		public extern float AnimationWalkSpeed { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_DEFENSE)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_DEFENSE, {0})"
		public extern float Defense { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_SIGHT_RADIUS)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_SIGHT_RADIUS, {0})"
		public extern float SightRadius { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_PRIORITY)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_PRIORITY, {0})"
		public extern float Priority { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_OCCLUDER_HEIGHT)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_OCCLUDER_HEIGHT, {0})"
		public extern float OccluderHeight { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_CAST_BACK_SWING)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_CAST_BACK_SWING, {0})"
		public extern float CastBackSwing { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_CAST_POINT)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_CAST_POINT, {0})"
		public extern float CastPoint { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitRealField({this}, UNIT_RF_MINIMUM_ATTACK_RANGE)"
		/// @CSharpLua.Set = "BlzSetUnitRealField({this}, UNIT_RF_MINIMUM_ATTACK_RANGE, {0})"
		public extern float MinimumAttackRange { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitStringField({this}, UNIT_SF_GROUND_TEXTURE)"
		/// @CSharpLua.Set = "BlzSetUnitStringField({this}, UNIT_SF_GROUND_TEXTURE, {0})"
		public extern string GroundTexture { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitStringField({this}, UNIT_SF_SHADOW_IMAGE_UNIT)"
		/// @CSharpLua.Set = "BlzSetUnitStringField({this}, UNIT_SF_SHADOW_IMAGE_UNIT, {0})"
		public extern string ShadowImageUnit { get; set; }
		#endregion

		#region Weapon 1 field editing
		/// @CSharpLua.Get = "BlzGetUnitBaseDamage({this}, 0)"
		/// @CSharpLua.Set = "BlzSetUnitBaseDamage({this}, {0}, 0)"
		public extern int AttackBaseDamage1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitDiceNumber({this}, 0)"
		/// @CSharpLua.Set = "BlzSetUnitDiceNumber({this}, {0}, 0)"
		public extern int AttackDiceNumber1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitDiceSides({this}, 0)"
		/// @CSharpLua.Set = "BlzSetUnitDiceSides({this}, {0}, 0)"
		public extern int AttackDiceSides1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitAttackCooldown({this}, 0)"
		/// @CSharpLua.Set = "BlzSetUnitAttackCooldown({this}, {0}, 0)"
		public extern float AttackCooldown1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponBooleanField({this}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponBooleanField({this}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 0, {0})"
		public extern bool AttackEnabled1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, 0)"
		public extern int AttackMaximumNumberOfTargets1 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 0, {0})"
		public extern int AttackAttackType1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 0, {0})"
		public extern int AttackWeaponSound1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 0, {0})"
		public extern int AttackTargetsAllowed1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 0, {0})"
		public extern float AttackBackswingPoint1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 0, {0})"
		public extern float AttackDamagePoint1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, 0)"
		public extern float AttackDamageLossFactor1 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 0, {0})"
		public extern float AttackDamageFactorMedium1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 0, {0})"
		public extern float AttackDamageFactorSmall1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, 0)"
		public extern float AttackDamageSpillDistance1 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, 0)"
		public extern float AttackDamageSpillRadius1 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 0, {0})"
		public extern float AttackProjectileSpeed1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 0, {0})"
		public extern float AttackProjectileArc1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 0, {0})"
		public extern float AttackAreaOfEffectFullDamage1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 0, {0})"
		public extern float AttackAreaOfEffectMediumDamage1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 0, {0})"
		public extern float AttackAreaOfEffectSmallDamage1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 1, {0} - GetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 1))"
		public extern float AttackRange1 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponStringField({this}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 0)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponStringField({this}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 0, {0})"
		public extern string AttackProjectileArt1 { get; set; }
		#endregion

		#region Weapon 2 field editing
		/// @CSharpLua.Get = "BlzGetUnitBaseDamage({this}, 1)"
		/// @CSharpLua.Set = "BlzSetUnitBaseDamage({this}, {0}, 1)"
		public extern int AttackBaseDamage2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitDiceNumber({this}, 1)"
		/// @CSharpLua.Set = "BlzSetUnitDiceNumber({this}, {0}, 1)"
		public extern int AttackDiceNumber2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitDiceSides({this}, 1)"
		/// @CSharpLua.Set = "BlzSetUnitDiceSides({this}, {0}, 1)"
		public extern int AttackDiceSides2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitAttackCooldown({this}, 1)"
		/// @CSharpLua.Set = "BlzSetUnitAttackCooldown({this}, {0}, 1)"
		public extern float AttackCooldown2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponBooleanField({this}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponBooleanField({this}, UNIT_WEAPON_BF_ATTACKS_ENABLED, 1, {0})"
		public extern bool AttackEnabled2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, 1)"
		public extern int AttackMaximumNumberOfTargets2 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, 1, {0})"
		public extern int AttackAttackType2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, 1, {0})"
		public extern int AttackWeaponSound2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponIntegerField({this}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, 1, {0})"
		public extern int AttackTargetsAllowed2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, 1, {0})"
		public extern float AttackBackswingPoint2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, 1, {0})"
		public extern float AttackDamagePoint2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, 1)"
		public extern float AttackDamageLossFactor2 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, 1, {0})"
		public extern float AttackDamageFactorMedium2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, 1, {0})"
		public extern float AttackDamageFactorSmall2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, 1)"
		public extern float AttackDamageSpillDistance2 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, 1)"
		public extern float AttackDamageSpillRadius2 { get; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, 1, {0})"
		public extern float AttackProjectileSpeed2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, 1, {0})"
		public extern float AttackProjectileArc2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, 1, {0})"
		public extern float AttackAreaOfEffectFullDamage2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, 1, {0})"
		public extern float AttackAreaOfEffectMediumDamage2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, 1, {0})"
		public extern float AttackAreaOfEffectSmallDamage2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 2)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 2, {0} - GetUnitWeaponRealField({this}, UNIT_WEAPON_RF_ATTACK_RANGE, 2))"
		public extern float AttackRange2 { get; set; }

		/// @CSharpLua.Get = "BlzGetUnitWeaponStringField({this}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 1)"
		/// @CSharpLua.Set = "BlzSetUnitWeaponStringField({this}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, 1, {0})"
		public extern string AttackProjectileArt2 { get; set; }
		#endregion
	}
}
