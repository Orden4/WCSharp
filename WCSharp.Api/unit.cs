using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class unit : widget, IDisposable
	{
		internal unit()
		{
		}

		/// @CSharpLua.Get = "GetUnitX({0})"
		/// @CSharpLua.Set = "SetUnitX({0}, {1})"
		public extern float X { get; set; }

		/// @CSharpLua.Get = "GetUnitY({0})"
		/// @CSharpLua.Set = "SetUnitY({0}, {1})"
		public extern float Y { get; set; }

		/// @CSharpLua.Get = "BlzGetLocalUnitZ({0})"
		public extern float Z { get; }

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

		/// @CSharpLua.Get = "GetOwningPlayer({0})"
		/// @CSharpLua.Set = "SetUnitOwner({0}, {1}, true)"
		public extern player Owner { get; set; }

		/// @CSharpLua.Get = "GetUnitFacing({0})"
		/// @CSharpLua.Set = "BlzSetUnitFacingEx({0}, {1})"
		public extern float Facing { get; set; }

		/// @CSharpLua.Get = "GetUnitMoveSpeed({0})"
		public extern float MovementSpeed { get; }

		/// @CSharpLua.Get = "GetUnitDefaultMoveSpeed({0})"
		/// @CSharpLua.Set = "SetUnitMoveSpeed({0}, {1})"
		public extern float BaseMovementSpeed { get; set; }

		/// @CSharpLua.Get = "GetUnitTurnSpeed({0})"
		public extern float TurnSpeed { get; }

		/// @CSharpLua.Get = "GetUnitPropWindow({0})"
		public extern float PropWindow { get; }

		/// @CSharpLua.Get = "GetUnitAcquireRange({0})"
		public extern float AcquireRange { get; }

		/// @CSharpLua.Get = "GetUnitFlyHeight({0})"
		public extern float FlyHeight { get; }

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

		/// @CSharpLua.Template = "KillUnit({0})"
		public extern void Kill();

		/// @CSharpLua.Template = "SetUnitFacing({0})"
		public extern void SetFacing(float facingAngle, float duration);

		/// @CSharpLua.Template = "SetUnitFlyHeight({0})"
		public extern void SetFlyHeight(float flyHeight, float rate);

		/// @CSharpLua.Template = "SetUnitOwner({0}, {1}, false)"
		public extern void SetOwner(player player);

		/// @CSharpLua.Template = "SetUnitColor({0}, {1})"
		public extern void SetColor(playercolor color);

		/// @CSharpLua.Template = "SetUnitTimeScale({0}, {1})"
		public extern void SetTimeScale(float timeScale);

		/// @CSharpLua.Template = "SetUnitBlendTime({0}, {1})"
		public extern void SetBlendTime(float blendTime);

		/// @CSharpLua.Template = "SetUnitVertexColor({0}, {1}, {2}, {3})"
		public extern void SetVertexColor(int red, int green, int blue, int alpha = 255);

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
		public extern int defensetype { get; set; }

		/// @CSharpLua.Get = "GetUnitIntegerField({0}, UNIT_IF_ARMOR_TYPE)"
		/// @CSharpLua.Set = "SetUnitIntegerField({0}, UNIT_IF_ARMOR_TYPE, {1})"
		public extern int armortype { get; set; }

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
		public extern int movetype { get; set; }

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

		/// @CSharpLua.Template = "GetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACK_SHOW_UI, {1})"
		public extern bool GetAttackShowUi(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACK_SHOW_UI, {1}, {2})"
		public extern void SetAttackShowUi(int attackIndex, bool attackShowUi);

		/// @CSharpLua.Template = "GetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, {1})"
		public extern bool GetAttacksEnabled(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACKS_ENABLED, {1}, {2})"
		public extern void SetAttacksEnabled(int attackIndex, bool attacksEnabled);

		/// @CSharpLua.Template = "GetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACK_PROJECTILE_HOMING_ENABLED, {1})"
		public extern bool GetAttackProjectileHomingEnabled(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponBooleanField({0}, UNIT_WEAPON_BF_ATTACK_PROJECTILE_HOMING_ENABLED, {1}, {2})"
		public extern void SetAttackProjectileHomingEnabled(int attackIndex, bool attackProjectileHomingEnabled);

		/// @CSharpLua.Template = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, {1})"
		public extern int GetAttackMaximumNumberOfTargets(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_MAXIMUM_NUMBER_OF_TARGETS, {1}, {2})"
		public extern void SetAttackMaximumNumberOfTargets(int attackIndex, int attackMaximumNumberOfTargets);

		/// @CSharpLua.Template = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, {1})"
		public extern int GetAttackAttackType(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_ATTACK_TYPE, {1}, {2})"
		public extern void SetAttackAttackType(int attackIndex, int attackAttackType);

		/// @CSharpLua.Template = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, {1})"
		public extern int GetAttackWeaponSound(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_WEAPON_SOUND, {1}, {2})"
		public extern void SetAttackWeaponSound(int attackIndex, int attackWeaponSound);

		/// @CSharpLua.Template = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_AREA_OF_EFFECT_TARGETS, {1})"
		public extern int GetAttackAreaOfEffectTargets(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_AREA_OF_EFFECT_TARGETS, {1}, {2})"
		public extern void SetAttackAreaOfEffectTargets(int attackIndex, int attackAreaOfEffectTargets);

		/// @CSharpLua.Template = "GetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, {1})"
		public extern int GetAttackTargetsAllowed(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponIntegerField({0}, UNIT_WEAPON_IF_ATTACK_TARGETS_ALLOWED, {1}, {2})"
		public extern void SetAttackTargetsAllowed(int attackIndex, int attackTargetsAllowed);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, {1})"
		public extern float GetAttackBackswingPoint(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_BACKSWING_POINT, {1}, {2})"
		public extern void SetAttackBackswingPoint(int attackIndex, float attackBackswingPoint);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, {1})"
		public extern float GetAttackDamagePoint(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_POINT, {1}, {2})"
		public extern void SetAttackDamagePoint(int attackIndex, float attackDamagePoint);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, {1})"
		public extern float GetAttackDamageLossFactor(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_LOSS_FACTOR, {1}, {2})"
		public extern void SetAttackDamageLossFactor(int attackIndex, float attackDamageLossFactor);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, {1})"
		public extern float GetAttackDamageFactorMedium(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_MEDIUM, {1}, {2})"
		public extern void SetAttackDamageFactorMedium(int attackIndex, float attackDamageFactorMedium);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, {1})"
		public extern float GetAttackDamageFactorSmall(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_FACTOR_SMALL, {1}, {2})"
		public extern void SetAttackDamageFactorSmall(int attackIndex, float attackDamageFactorSmall);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, {1})"
		public extern float GetAttackDamageSpillDistance(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_DISTANCE, {1}, {2})"
		public extern void SetAttackDamageSpillDistance(int attackIndex, float attackDamageSpillDistance);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, {1})"
		public extern float GetAttackDamageSpillRadius(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_DAMAGE_SPILL_RADIUS, {1}, {2})"
		public extern void SetAttackDamageSpillRadius(int attackIndex, float attackDamageSpillRadius);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, {1})"
		public extern float GetAttackProjectileSpeed(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_SPEED, {1}, {2})"
		public extern void SetAttackProjectileSpeed(int attackIndex, float attackProjectileSpeed);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, {1})"
		public extern float GetAttackProjectileArc(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_PROJECTILE_ARC, {1}, {2})"
		public extern void SetAttackProjectileArc(int attackIndex, float attackProjectileArc);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, {1})"
		public extern float GetAttackAreaOfEffectFullDamage(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_FULL_DAMAGE, {1}, {2})"
		public extern void SetAttackAreaOfEffectFullDamage(int attackIndex, float attackAreaOfEffectFullDamage);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, {1})"
		public extern float GetAttackAreaOfEffectMediumDamage(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_MEDIUM_DAMAGE, {1}, {2})"
		public extern void SetAttackAreaOfEffectMediumDamage(int attackIndex, float attackAreaOfEffectMediumDamage);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, {1})"
		public extern float GetAttackAreaOfEffectSmallDamage(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_AREA_OF_EFFECT_SMALL_DAMAGE, {1}, {2})"
		public extern void SetAttackAreaOfEffectSmallDamage(int attackIndex, float attackAreaOfEffectSmallDamage);

		/// @CSharpLua.Template = "GetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, {1})"
		public extern float GetAttackRange(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponRealField({0}, UNIT_WEAPON_RF_ATTACK_RANGE, {1}, {2})"
		public extern void SetAttackRange(int attackIndex, float attackRange);

		/// @CSharpLua.Template = "GetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, {1})"
		public extern string GetAttackProjectileArt(int attackIndex);
		/// @CSharpLua.Template = "SetUnitWeaponStringField({0}, UNIT_WEAPON_SF_ATTACK_PROJECTILE_ART, {1}, {2})"
		public extern void SetAttackProjectileArt(int attackIndex, string attackProjectileArt);
		#endregion
	}
}
