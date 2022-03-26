using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Ability : Agent
	{
		internal Ability()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator ability(Ability x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Ability(ability x);

		/// @CSharpLua.Get = "GetAbilityBooleanField({0}, ABILITY_BF_HERO_ABILITY)"
		/// @CSharpLua.Set = "SetAbilityBooleanField({0}, ABILITY_BF_HERO_ABILITY, {1})"
		public extern bool HeroAbility { get; set; }

		/// @CSharpLua.Get = "GetAbilityBooleanField({0}, ABILITY_BF_ITEM_ABILITY)"
		/// @CSharpLua.Set = "SetAbilityBooleanField({0}, ABILITY_BF_ITEM_ABILITY, {1})"
		public extern bool ItemAbility { get; set; }

		/// @CSharpLua.Get = "GetAbilityBooleanField({0}, ABILITY_BF_CHECK_DEPENDENCIES)"
		/// @CSharpLua.Set = "SetAbilityBooleanField({0}, ABILITY_BF_CHECK_DEPENDENCIES, {1})"
		public extern bool CheckDependencies { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_NORMAL_X)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_NORMAL_X, {1})"
		public extern int ButtonPositionNormalX { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_NORMAL_Y)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_NORMAL_Y, {1})"
		public extern int ButtonPositionNormalY { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_ACTIVATED_X)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_ACTIVATED_X, {1})"
		public extern int ButtonPositionActivatedX { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_ACTIVATED_Y)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_ACTIVATED_Y, {1})"
		public extern int ButtonPositionActivatedY { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_RESEARCH_X)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_RESEARCH_X, {1})"
		public extern int ButtonPositionResearchX { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_RESEARCH_Y)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_BUTTON_POSITION_RESEARCH_Y, {1})"
		public extern int ButtonPositionResearchY { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_MISSILE_SPEED)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_MISSILE_SPEED, {1})"
		public extern int MissileSpeed { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_TARGET_ATTACHMENTS)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_TARGET_ATTACHMENTS, {1})"
		public extern int TargetAttachments { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_CASTER_ATTACHMENTS)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_CASTER_ATTACHMENTS, {1})"
		public extern int CasterAttachments { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_PRIORITY)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_PRIORITY, {1})"
		public extern int Priority { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_LEVELS)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_LEVELS, {1})"
		public extern int Levels { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_REQUIRED_LEVEL)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_REQUIRED_LEVEL, {1})"
		public extern int RequiredLevel { get; set; }

		/// @CSharpLua.Get = "GetAbilityIntegerField({0}, ABILITY_IF_LEVEL_SKIP_REQUIREMENT)"
		/// @CSharpLua.Set = "SetAbilityIntegerField({0}, ABILITY_IF_LEVEL_SKIP_REQUIREMENT, {1})"
		public extern int LevelSkipRequirement { get; set; }

		/// @CSharpLua.Get = "GetAbilityRealField({0}, ABILITY_RF_ARF_MISSILE_ARC)"
		/// @CSharpLua.Set = "SetAbilityRealField({0}, ABILITY_RF_ARF_MISSILE_ARC, {1})"
		public extern float MissileArc { get; set; }

		/// @CSharpLua.Get = "GetAbilityStringField({0}, ABILITY_SF_NAME)"
		/// @CSharpLua.Set = "SetAbilityStringField({0}, ABILITY_SF_NAME, {1})"
		public extern string Name { get; set; }

		/// @CSharpLua.Get = "GetAbilityStringField({0}, ABILITY_SF_ICON_ACTIVATED)"
		/// @CSharpLua.Set = "SetAbilityStringField({0}, ABILITY_SF_ICON_ACTIVATED, {1})"
		public extern string IconActivated { get; set; }

		/// @CSharpLua.Get = "GetAbilityStringField({0}, ABILITY_SF_ICON_RESEARCH)"
		/// @CSharpLua.Set = "SetAbilityStringField({0}, ABILITY_SF_ICON_RESEARCH, {1})"
		public extern string IconResearch { get; set; }

		/// @CSharpLua.Get = "GetAbilityStringField({0}, ABILITY_SF_EFFECT_SOUND)"
		/// @CSharpLua.Set = "SetAbilityStringField({0}, ABILITY_SF_EFFECT_SOUND, {1})"
		public extern string EffectSound { get; set; }

		/// @CSharpLua.Get = "GetAbilityStringField({0}, ABILITY_SF_EFFECT_SOUND_LOOPING)"
		/// @CSharpLua.Set = "SetAbilityStringField({0}, ABILITY_SF_EFFECT_SOUND_LOOPING, {1})"
		public extern string EffectSoundLooping { get; set; }

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Brilliance Aura</term> <description>AHab, ACba, AIba</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_HAB2, {1})"
		public extern bool GetPercentBonus_Hab2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Brilliance Aura</term> <description>AHab, ACba, AIba</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_HAB2, {1}, {2})"
		public extern void SetPercentBonus_Hab2(int level, bool percentBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_USE_TELEPORT_CLUSTERING_HMT3, {1})"
		public extern bool GetUseTeleportClustering_Hmt3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_USE_TELEPORT_CLUSTERING_HMT3, {1}, {2})"
		public extern void SetUseTeleportClustering_Hmt3(int level, bool useTeleportClustering);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_NEVER_MISS_OCR5, {1})"
		public extern bool GetNeverMiss_Ocr5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_NEVER_MISS_OCR5, {1}, {2})"
		public extern void SetNeverMiss_Ocr5(int level, bool neverMiss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_EXCLUDE_ITEM_DAMAGE, {1})"
		public extern bool GetExcludeItemDamage_Ocr6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_EXCLUDE_ITEM_DAMAGE, {1}, {2})"
		public extern void SetExcludeItemDamage_Ocr6(int level, bool excludeItemDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk, ANwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_BACKSTAB_DAMAGE, {1})"
		public extern bool GetBackstabDamage_Owk4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk, ANwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_BACKSTAB_DAMAGE, {1}, {2})"
		public extern void SetBackstabDamage_Owk4(int level, bool backstabDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan, ACad</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// <item><term>Reanimation</term> <description>AInd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_INHERIT_UPGRADES_UAN3, {1})"
		public extern bool GetInheritUpgrades_Uan3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan, ACad</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// <item><term>Reanimation</term> <description>AInd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_INHERIT_UPGRADES_UAN3, {1}, {2})"
		public extern void SetInheritUpgrades_Uan3(int level, bool inheritUpgrades);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_MANA_CONVERSION_AS_PERCENT, {1})"
		public extern bool GetManaConversionAsPercent_Udp3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_MANA_CONVERSION_AS_PERCENT, {1}, {2})"
		public extern void SetManaConversionAsPercent_Udp3(int level, bool manaConversionAsPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_LIFE_CONVERSION_AS_PERCENT, {1})"
		public extern bool GetLifeConversionAsPercent_Udp4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_LIFE_CONVERSION_AS_PERCENT, {1}, {2})"
		public extern void SetLifeConversionAsPercent_Udp4(int level, bool lifeConversionAsPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Ritual Dagger</term> <description>AIdg, AIg2</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_LEAVE_TARGET_ALIVE, {1})"
		public extern bool GetLeaveTargetAlive_Udp5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Ritual Dagger</term> <description>AIdg, AIg2</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_LEAVE_TARGET_ALIVE, {1}, {2})"
		public extern void SetLeaveTargetAlive_Udp5(int level, bool leaveTargetAlive);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_UAU3, {1})"
		public extern bool GetPercentBonus_Uau3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_UAU3, {1}, {2})"
		public extern void SetPercentBonus_Uau3(int level, bool percentBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thorns Aura</term> <description>AEah</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DAMAGE_IS_PERCENT_RECEIVED, {1})"
		public extern bool GetDamageIsPercentReceived_Eah2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thorns Aura</term> <description>AEah</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DAMAGE_IS_PERCENT_RECEIVED, {1}, {2})"
		public extern void SetDamageIsPercentReceived_Eah2(int level, bool damageIsPercentReceived);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_MELEE_BONUS, {1})"
		public extern bool GetMeleeBonus_Ear2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_MELEE_BONUS, {1}, {2})"
		public extern void SetMeleeBonus_Ear2(int level, bool meleeBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_RANGED_BONUS, {1})"
		public extern bool GetRangedBonus_Ear3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_RANGED_BONUS, {1}, {2})"
		public extern void SetRangedBonus_Ear3(int level, bool rangedBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_FLAT_BONUS, {1})"
		public extern bool GetFlatBonus_Ear4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_FLAT_BONUS, {1}, {2})"
		public extern void SetFlatBonus_Ear4(int level, bool flatBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh, ANbh, AIbx</description></item>
		/// <item><term>Maul</term> <description>ANb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_NEVER_MISS_HBH5, {1})"
		public extern bool GetNeverMiss_Hbh5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh, ANbh, AIbx</description></item>
		/// <item><term>Maul</term> <description>ANb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_NEVER_MISS_HBH5, {1}, {2})"
		public extern void SetNeverMiss_Hbh5(int level, bool neverMiss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devotion Aura</term> <description>AHad, AIad, ACav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_HAD2, {1})"
		public extern bool GetPercentBonus_Had2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devotion Aura</term> <description>AHad, AIad, ACav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENT_BONUS_HAD2, {1}, {2})"
		public extern void SetPercentBonus_Had2(int level, bool percentBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Divine Shield</term> <description>AHds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_DEACTIVATE, {1})"
		public extern bool GetCanDeactivate_Hds1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Divine Shield</term> <description>AHds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_DEACTIVATE, {1}, {2})"
		public extern void SetCanDeactivate_Hds1(int level, bool canDeactivate);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan, ACad</description></item>
		/// <item><term>Greater Rune Resurrection</term> <description>APrr</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// <item><term>Item Resurrection</term> <description>AIrs</description></item>
		/// <item><term>Lesser Rune Resurrection</term> <description>APrl</description></item>
		/// <item><term>Resurrection</term> <description>AHre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_RAISED_UNITS_ARE_INVULNERABLE, {1})"
		public extern bool GetRaisedUnitsAreInvulnerable_Hre2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan, ACad</description></item>
		/// <item><term>Greater Rune Resurrection</term> <description>APrr</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// <item><term>Item Resurrection</term> <description>AIrs</description></item>
		/// <item><term>Lesser Rune Resurrection</term> <description>APrl</description></item>
		/// <item><term>Resurrection</term> <description>AHre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_RAISED_UNITS_ARE_INVULNERABLE, {1}, {2})"
		public extern void SetRaisedUnitsAreInvulnerable_Hre2(int level, bool raisedUnitsAreInvulnerable);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aura of Blight</term> <description>Aabr</description></item>
		/// <item><term>Healing Ward Aura</term> <description>Aoar</description></item>
		/// <item><term>Life Regeneration Aura</term> <description>ACnr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENTAGE_OAR2, {1})"
		public extern bool GetPercentage_Oar2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aura of Blight</term> <description>Aabr</description></item>
		/// <item><term>Healing Ward Aura</term> <description>Aoar</description></item>
		/// <item><term>Life Regeneration Aura</term> <description>ACnr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENTAGE_OAR2, {1}, {2})"
		public extern void SetPercentage_Oar2(int level, bool percentage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Stations</term> <description>Abtl, Sbtl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_SUMMON_BUSY_UNITS, {1})"
		public extern bool GetSummonBusyUnits_Btl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Stations</term> <description>Abtl, Sbtl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_SUMMON_BUSY_UNITS, {1}, {2})"
		public extern void SetSummonBusyUnits_Btl2(int level, bool summonBusyUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blight Dispel Large</term> <description>Abdl</description></item>
		/// <item><term>Blight Dispel Small</term> <description>Abds</description></item>
		/// <item><term>Blight Growth Large</term> <description>Abgl</description></item>
		/// <item><term>Blight Growth Small</term> <description>Abgs</description></item>
		/// <item><term>Blight Placement</term> <description>Ablp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CREATES_BLIGHT, {1})"
		public extern bool GetCreatesBlight_Bli2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blight Dispel Large</term> <description>Abdl</description></item>
		/// <item><term>Blight Dispel Small</term> <description>Abds</description></item>
		/// <item><term>Blight Growth Large</term> <description>Abgl</description></item>
		/// <item><term>Blight Growth Small</term> <description>Abgs</description></item>
		/// <item><term>Blight Placement</term> <description>Ablp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CREATES_BLIGHT, {1}, {2})"
		public extern void SetCreatesBlight_Bli2(int level, bool createsBlight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Kaboom!</term> <description>Asds, Asdg, Asd2, Asd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_EXPLODES_ON_DEATH, {1})"
		public extern bool GetExplodesOnDeath_Sds6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Kaboom!</term> <description>Asds, Asdg, Asd2, Asd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_EXPLODES_ON_DEATH, {1}, {2})"
		public extern void SetExplodesOnDeath_Sds6(int level, bool explodesOnDeath);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Faerie Fire</term> <description>Afae, Afa2, ACff</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ALWAYS_AUTOCAST_FAE2, {1})"
		public extern bool GetAlwaysAutocast_Fae2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Faerie Fire</term> <description>Afae, Afa2, ACff</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ALWAYS_AUTOCAST_FAE2, {1}, {2})"
		public extern void SetAlwaysAutocast_Fae2(int level, bool alwaysAutocast);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_REGENERATE_ONLY_AT_NIGHT, {1})"
		public extern bool GetRegenerateOnlyAtNight_Mbt5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_REGENERATE_ONLY_AT_NIGHT, {1}, {2})"
		public extern void SetRegenerateOnlyAtNight_Mbt5(int level, bool regenerateOnlyAtNight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_SHOW_SELECT_UNIT_BUTTON, {1})"
		public extern bool GetShowSelectUnitButton_Neu3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_SHOW_SELECT_UNIT_BUTTON, {1}, {2})"
		public extern void SetShowSelectUnitButton_Neu3(int level, bool showSelectUnitButton);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_SHOW_UNIT_INDICATOR, {1})"
		public extern bool GetShowUnitIndicator_Neu4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_SHOW_UNIT_INDICATOR, {1}, {2})"
		public extern void SetShowUnitIndicator_Neu4(int level, bool showUnitIndicator);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CHARGE_OWNING_PLAYER, {1})"
		public extern bool GetChargeOwningPlayer_Ans6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CHARGE_OWNING_PLAYER, {1}, {2})"
		public extern void SetChargeOwningPlayer_Ans6(int level, bool chargeOwningPlayer);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Regeneration Aura</term> <description>Aarm</description></item>
		/// <item><term>Mana Regeneration, Life Regeneration Aura</term> <description>ANre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENTAGE_ARM2, {1})"
		public extern bool GetPercentage_Arm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Regeneration Aura</term> <description>Aarm</description></item>
		/// <item><term>Mana Regeneration, Life Regeneration Aura</term> <description>ANre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PERCENTAGE_ARM2, {1}, {2})"
		public extern void SetPercentage_Arm2(int level, bool percentage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_TARGET_IS_INVULNERABLE, {1})"
		public extern bool GetTargetIsInvulnerable_Pos3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_TARGET_IS_INVULNERABLE, {1}, {2})"
		public extern void SetTargetIsInvulnerable_Pos3(int level, bool targetIsInvulnerable);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_TARGET_IS_MAGIC_IMMUNE, {1})"
		public extern bool GetTargetIsMagicImmune_Pos4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_TARGET_IS_MAGIC_IMMUNE, {1}, {2})"
		public extern void SetTargetIsMagicImmune_Pos4(int level, bool targetIsMagicImmune);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_KILL_ON_CASTER_DEATH, {1})"
		public extern bool GetKillOnCasterDeath_Ucb6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_KILL_ON_CASTER_DEATH, {1}, {2})"
		public extern void SetKillOnCasterDeath_Ucb6(int level, bool killOnCasterDeath);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_NO_TARGET_REQUIRED_REJ4, {1})"
		public extern bool GetNoTargetRequired_Rej4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_NO_TARGET_REQUIRED_REJ4, {1}, {2})"
		public extern void SetNoTargetRequired_Rej4(int level, bool noTargetRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Return Gold and Lumber</term> <description>Argl</description></item>
		/// <item><term>Return Gold</term> <description>Argd</description></item>
		/// <item><term>Return Lumber</term> <description>Arlm</description></item>
		/// <item><term>Return</term> <description>Artn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ACCEPTS_GOLD, {1})"
		public extern bool GetAcceptsGold_Rtn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Return Gold and Lumber</term> <description>Argl</description></item>
		/// <item><term>Return Gold</term> <description>Argd</description></item>
		/// <item><term>Return Lumber</term> <description>Arlm</description></item>
		/// <item><term>Return</term> <description>Artn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ACCEPTS_GOLD, {1}, {2})"
		public extern void SetAcceptsGold_Rtn1(int level, bool acceptsGold);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Return Gold and Lumber</term> <description>Argl</description></item>
		/// <item><term>Return Gold</term> <description>Argd</description></item>
		/// <item><term>Return Lumber</term> <description>Arlm</description></item>
		/// <item><term>Return</term> <description>Artn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ACCEPTS_LUMBER, {1})"
		public extern bool GetAcceptsLumber_Rtn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Return Gold and Lumber</term> <description>Argl</description></item>
		/// <item><term>Return Gold</term> <description>Argd</description></item>
		/// <item><term>Return Lumber</term> <description>Arlm</description></item>
		/// <item><term>Return</term> <description>Artn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ACCEPTS_LUMBER, {1}, {2})"
		public extern void SetAcceptsLumber_Rtn2(int level, bool acceptsLumber);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PREFER_HOSTILES_ROA5, {1})"
		public extern bool GetPreferHostiles_Roa5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PREFER_HOSTILES_ROA5, {1}, {2})"
		public extern void SetPreferHostiles_Roa5(int level, bool preferHostiles);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_PREFER_FRIENDLIES_ROA6, {1})"
		public extern bool GetPreferFriendlies_Roa6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_PREFER_FRIENDLIES_ROA6, {1}, {2})"
		public extern void SetPreferFriendlies_Roa6(int level, bool preferFriendlies);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ROOTED_TURNING, {1})"
		public extern bool GetRootedTurning_Roo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ROOTED_TURNING, {1}, {2})"
		public extern void SetRootedTurning_Roo3(int level, bool rootedTurning);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ALWAYS_AUTOCAST_SLO3, {1})"
		public extern bool GetAlwaysAutocast_Slo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ALWAYS_AUTOCAST_SLO3, {1}, {2})"
		public extern void SetAlwaysAutocast_Slo3(int level, bool alwaysAutocast);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_HIDE_BUTTON, {1})"
		public extern bool GetHideButton_Ihid(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_HIDE_BUTTON, {1}, {2})"
		public extern void SetHideButton_Ihid(int level, bool hideButton);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Recall</term> <description>AIrt</description></item>
		/// <item><term>Item Town Portal</term> <description>AItp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_USE_TELEPORT_CLUSTERING_ITP2, {1})"
		public extern bool GetUseTeleportClustering_Itp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Recall</term> <description>AIrt</description></item>
		/// <item><term>Item Town Portal</term> <description>AItp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_USE_TELEPORT_CLUSTERING_ITP2, {1}, {2})"
		public extern void SetUseTeleportClustering_Itp2(int level, bool useTeleportClustering);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Aeth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS, {1})"
		public extern bool GetImmuneToMorphEffects_Eth1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Aeth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS, {1}, {2})"
		public extern void SetImmuneToMorphEffects_Eth1(int level, bool immuneToMorphEffects);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Aeth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DOES_NOT_BLOCK_BUILDINGS, {1})"
		public extern bool GetDoesNotBlockBuildings_Eth2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Aeth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DOES_NOT_BLOCK_BUILDINGS, {1}, {2})"
		public extern void SetDoesNotBlockBuildings_Eth2(int level, bool doesNotBlockBuildings);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// <item><term>Permanent Invisibility</term> <description>Apiv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_AUTO_ACQUIRE_ATTACK_TARGETS, {1})"
		public extern bool GetAutoAcquireAttackTargets_Gho1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// <item><term>Permanent Invisibility</term> <description>Apiv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_AUTO_ACQUIRE_ATTACK_TARGETS, {1}, {2})"
		public extern void SetAutoAcquireAttackTargets_Gho1(int level, bool autoAcquireAttackTargets);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS_GHO2, {1})"
		public extern bool GetImmuneToMorphEffects_Gho2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_IMMUNE_TO_MORPH_EFFECTS_GHO2, {1}, {2})"
		public extern void SetImmuneToMorphEffects_Gho2(int level, bool immuneToMorphEffects);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DO_NOT_BLOCK_BUILDINGS, {1})"
		public extern bool GetDoNotBlockBuildings_Gho3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ghost</term> <description>Agho</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DO_NOT_BLOCK_BUILDINGS, {1}, {2})"
		public extern void SetDoNotBlockBuildings_Gho3(int level, bool doNotBlockBuildings);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_INCLUDE_RANGED_DAMAGE, {1})"
		public extern bool GetIncludeRangedDamage_Ssk4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_INCLUDE_RANGED_DAMAGE, {1}, {2})"
		public extern void SetIncludeRangedDamage_Ssk4(int level, bool includeRangedDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_INCLUDE_MELEE_DAMAGE, {1})"
		public extern bool GetIncludeMeleeDamage_Ssk5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_INCLUDE_MELEE_DAMAGE, {1}, {2})"
		public extern void SetIncludeMeleeDamage_Ssk5(int level, bool includeMeleeDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_MOVE_TO_PARTNER, {1})"
		public extern bool GetMoveToPartner_coa2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_MOVE_TO_PARTNER, {1}, {2})"
		public extern void SetMoveToPartner_coa2(int level, bool moveToPartner);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cyclone</term> <description>Acyc, ACcy, SCc1, AIcy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_BE_DISPELLED, {1})"
		public extern bool GetCanBeDispelled_cyc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cyclone</term> <description>Acyc, ACcy, SCc1, AIcy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_BE_DISPELLED, {1}, {2})"
		public extern void SetCanBeDispelled_cyc1(int level, bool canBeDispelled);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm, ACde</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_IGNORE_FRIENDLY_BUFFS, {1})"
		public extern bool GetIgnoreFriendlyBuffs_dvm6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm, ACde</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_IGNORE_FRIENDLY_BUFFS, {1}, {2})"
		public extern void SetIgnoreFriendlyBuffs_dvm6(int level, bool ignoreFriendlyBuffs);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DROP_ITEMS_ON_DEATH, {1})"
		public extern bool GetDropItemsOnDeath_inv2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DROP_ITEMS_ON_DEATH, {1}, {2})"
		public extern void SetDropItemsOnDeath_inv2(int level, bool dropItemsOnDeath);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_USE_ITEMS, {1})"
		public extern bool GetCanUseItems_inv3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_USE_ITEMS, {1}, {2})"
		public extern void SetCanUseItems_inv3(int level, bool canUseItems);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_GET_ITEMS, {1})"
		public extern bool GetCanGetItems_inv4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_GET_ITEMS, {1}, {2})"
		public extern void SetCanGetItems_inv4(int level, bool canGetItems);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_DROP_ITEMS, {1})"
		public extern bool GetCanDropItems_inv5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CAN_DROP_ITEMS, {1}, {2})"
		public extern void SetCanDropItems_inv5(int level, bool canDropItems);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_REPAIRS_ALLOWED, {1})"
		public extern bool GetRepairsAllowed_liq4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_REPAIRS_ALLOWED, {1}, {2})"
		public extern void SetRepairsAllowed_liq4(int level, bool repairsAllowed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_CASTER_ONLY_SPLASH, {1})"
		public extern bool GetCasterOnlySplash_mfl6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_CASTER_ONLY_SPLASH, {1}, {2})"
		public extern void SetCasterOnlySplash_mfl6(int level, bool casterOnlySplash);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_NO_TARGET_REQUIRED_IRL4, {1})"
		public extern bool GetNoTargetRequired_irl4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_NO_TARGET_REQUIRED_IRL4, {1}, {2})"
		public extern void SetNoTargetRequired_irl4(int level, bool noTargetRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DISPEL_ON_ATTACK, {1})"
		public extern bool GetDispelOnAttack_irl5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DISPEL_ON_ATTACK, {1}, {2})"
		public extern void SetDispelOnAttack_irl5(int level, bool dispelOnAttack);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_AMOUNT_IS_RAW_VALUE, {1})"
		public extern bool GetAmountIsRawValue_ipv3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_AMOUNT_IS_RAW_VALUE, {1}, {2})"
		public extern void SetAmountIsRawValue_ipv3(int level, bool amountIsRawValue);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_SHARED_SPELL_COOLDOWN, {1})"
		public extern bool GetSharedSpellCooldown_spb2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_SHARED_SPELL_COOLDOWN, {1}, {2})"
		public extern void SetSharedSpellCooldown_spb2(int level, bool sharedSpellCooldown);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep Always</term> <description>Asla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_SLEEP_ONCE, {1})"
		public extern bool GetSleepOnce_sla1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep Always</term> <description>Asla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_SLEEP_ONCE, {1}, {2})"
		public extern void SetSleepOnce_sla1(int level, bool sleepOnce);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep Always</term> <description>Asla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ALLOW_ON_ANY_PLAYER_SLOT, {1})"
		public extern bool GetAllowOnAnyPlayerSlot_sla2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep Always</term> <description>Asla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ALLOW_ON_ANY_PLAYER_SLOT, {1}, {2})"
		public extern void SetAllowOnAnyPlayerSlot_sla2(int level, bool allowOnAnyPlayerSlot);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_DISABLE_OTHER_ABILITIES, {1})"
		public extern bool GetDisableOtherAbilities_Ncl5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_DISABLE_OTHER_ABILITIES, {1}, {2})"
		public extern void SetDisableOtherAbilities_Ncl5(int level, bool disableOtherAbilities);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityBooleanLevelField({0}, ABILITY_BLF_ALLOW_BOUNTY, {1})"
		public extern bool GetAllowBounty_Ntm4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityBooleanLevelField({0}, ABILITY_BLF_ALLOW_BOUNTY, {1}, {2})"
		public extern void SetAllowBounty_Ntm4(int level, bool allowBounty);

		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_COST, {1})"
		public extern int GetManaCost_amcs(int level);
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_COST, {1}, {2})"
		public extern void SetManaCost_amcs(int level, int manaCost);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_WAVES, {1})"
		public extern int GetNumberOfWaves_Hbz1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_WAVES, {1}, {2})"
		public extern void SetNumberOfWaves_Hbz1(int level, int numberOfWaves);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SHARDS, {1})"
		public extern int GetNumberOfShards_Hbz3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SHARDS, {1}, {2})"
		public extern void SetNumberOfShards_Hbz3(int level, int numberOfShards);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_TELEPORTED, {1})"
		public extern int GetNumberOfUnitsTeleported_Hmt1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_TELEPORTED, {1}, {2})"
		public extern void SetNumberOfUnitsTeleported_Hmt1(int level, int numberOfUnitsTeleported);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix</term> <description>AHpx</description></item>
		/// <item><term>Scout</term> <description>AEst</description></item>
		/// <item><term>Serpent Ward</term> <description>AOsw</description></item>
		/// <item><term>Spawn Tentacle</term> <description>ACtn</description></item>
		/// <item><term>Summon Bear</term> <description>ANsg</description></item>
		/// <item><term>Summon Hawk</term> <description>ANsw</description></item>
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// <item><term>Summon Quilbeast</term> <description>ANsq</description></item>
		/// <item><term>Summon Sea Elemental</term> <description>ACwe</description></item>
		/// <item><term>Summon Water Elemental</term> <description>AHwe</description></item>
		/// <item><term>Watery Minion</term> <description>ANwm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_COUNT_HWE2, {1})"
		public extern int GetSummonedUnitCount_Hwe2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix</term> <description>AHpx</description></item>
		/// <item><term>Scout</term> <description>AEst</description></item>
		/// <item><term>Serpent Ward</term> <description>AOsw</description></item>
		/// <item><term>Spawn Tentacle</term> <description>ACtn</description></item>
		/// <item><term>Summon Bear</term> <description>ANsg</description></item>
		/// <item><term>Summon Hawk</term> <description>ANsw</description></item>
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// <item><term>Summon Quilbeast</term> <description>ANsq</description></item>
		/// <item><term>Summon Sea Elemental</term> <description>ACwe</description></item>
		/// <item><term>Summon Water Elemental</term> <description>AHwe</description></item>
		/// <item><term>Watery Minion</term> <description>ANwm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_COUNT_HWE2, {1}, {2})"
		public extern void SetSummonedUnitCount_Hwe2(int level, int summonedUnitCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_IMAGES, {1})"
		public extern int GetNumberOfImages_Omi1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_IMAGES, {1}, {2})"
		public extern void SetNumberOfImages_Omi1(int level, int numberOfImages);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_UAN1, {1})"
		public extern int GetNumberOfCorpsesRaised_Uan1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>AUan</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_UAN1, {1}, {2})"
		public extern void SetNumberOfCorpsesRaised_Uan1(int level, int numberOfCorpsesRaised);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MORPHING_FLAGS, {1})"
		public extern int GetMorphingFlags_Eme2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MORPHING_FLAGS, {1}, {2})"
		public extern void SetMorphingFlags_Eme2(int level, int morphingFlags);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STRENGTH_BONUS_NRG5, {1})"
		public extern int GetStrengthBonus_Nrg5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STRENGTH_BONUS_NRG5, {1}, {2})"
		public extern void SetStrengthBonus_Nrg5(int level, int strengthBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_BONUS_NRG6, {1})"
		public extern int GetDefenseBonus_Nrg6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_BONUS_NRG6, {1}, {2})"
		public extern void SetDefenseBonus_Nrg6(int level, int defenseBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_TARGETS_HIT, {1})"
		public extern int GetNumberOfTargetsHit_Ocl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_TARGETS_HIT, {1}, {2})"
		public extern void SetNumberOfTargetsHit_Ocl2(int level, int numberOfTargetsHit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Far Sight</term> <description>AOfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_OFS1, {1})"
		public extern int GetDetectionType_Ofs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Far Sight</term> <description>AOfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_OFS1, {1}, {2})"
		public extern void SetDetectionType_Ofs1(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feral Spirit</term> <description>AOsf, ACsf, ACs9</description></item>
		/// <item><term>Summon Headhunter</term> <description>AIsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_OSF2, {1})"
		public extern int GetNumberOfSummonedUnits_Osf2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feral Spirit</term> <description>AOsf, ACsf, ACs9</description></item>
		/// <item><term>Summon Headhunter</term> <description>AIsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_OSF2, {1}, {2})"
		public extern void SetNumberOfSummonedUnits_Osf2(int level, int numberOfSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Force of Nature</term> <description>AEfn, ACfr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_EFN1, {1})"
		public extern int GetNumberOfSummonedUnits_Efn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Force of Nature</term> <description>AEfn, ACfr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_EFN1, {1}, {2})"
		public extern void SetNumberOfSummonedUnits_Efn1(int level, int numberOfSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Resurrection</term> <description>AIrs</description></item>
		/// <item><term>Resurrection</term> <description>AHre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_HRE1, {1})"
		public extern int GetNumberOfCorpsesRaised_Hre1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Resurrection</term> <description>AIrs</description></item>
		/// <item><term>Resurrection</term> <description>AHre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_HRE1, {1}, {2})"
		public extern void SetNumberOfCorpsesRaised_Hre1(int level, int numberOfCorpsesRaised);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STACK_FLAGS, {1})"
		public extern int GetStackFlags_Hca4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STACK_FLAGS, {1}, {2})"
		public extern void SetStackFlags_Hca4(int level, int stackFlags);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MINIMUM_NUMBER_OF_UNITS, {1})"
		public extern int GetMinimumNumberOfUnits_Ndp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MINIMUM_NUMBER_OF_UNITS, {1}, {2})"
		public extern void SetMinimumNumberOfUnits_Ndp2(int level, int minimumNumberOfUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_NDP3, {1})"
		public extern int GetMaximumNumberOfUnits_Ndp3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_NDP3, {1}, {2})"
		public extern void SetMaximumNumberOfUnits_Ndp3(int level, int maximumNumberOfUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rain of Chaos</term> <description>ANrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_CREATED_NRC2, {1})"
		public extern int GetNumberOfUnitsCreated_Nrc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rain of Chaos</term> <description>ANrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_CREATED_NRC2, {1}, {2})"
		public extern void SetNumberOfUnitsCreated_Nrc2(int level, int numberOfUnitsCreated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SHIELD_LIFE, {1})"
		public extern int GetShieldLife_Ams3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SHIELD_LIFE, {1}, {2})"
		public extern void SetShieldLife_Ams3(int level, int shieldLife);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam, Aam2</description></item>
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_AMS4, {1})"
		public extern int GetManaLoss_Ams4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam, Aam2</description></item>
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_AMS4, {1}, {2})"
		public extern void SetManaLoss_Ams4(int level, int manaLoss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_PER_INTERVAL_BGM1, {1})"
		public extern int GetGoldPerInterval_Bgm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_PER_INTERVAL_BGM1, {1}, {2})"
		public extern void SetGoldPerInterval_Bgm1(int level, int goldPerInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_NUMBER_OF_MINERS, {1})"
		public extern int GetMaxNumberOfMiners_Bgm3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_NUMBER_OF_MINERS, {1}, {2})"
		public extern void SetMaxNumberOfMiners_Bgm3(int level, int maxNumberOfMiners);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold (Orc Burrow)</term> <description>Abun</description></item>
		/// <item><term>Cargo Hold</term> <description>Sch2, Sch3, Sch4, Sch5</description></item>
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// <item><term>Load</term> <description>Aenc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_CARGO_CAPACITY, {1})"
		public extern int GetCargoCapacity_Car1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold (Orc Burrow)</term> <description>Abun</description></item>
		/// <item><term>Cargo Hold</term> <description>Sch2, Sch3, Sch4, Sch5</description></item>
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// <item><term>Load</term> <description>Aenc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_CARGO_CAPACITY, {1}, {2})"
		public extern void SetCargoCapacity_Car1(int level, int cargoCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_DEV3, {1})"
		public extern int GetMaximumCreepLevel_Dev3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_DEV3, {1}, {2})"
		public extern void SetMaximumCreepLevel_Dev3(int level, int maximumCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour</term> <description>Adev, ACdv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_CREEP_LEVEL_DEV1, {1})"
		public extern int GetMaxCreepLevel_Dev1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour</term> <description>Adev, ACdv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_CREEP_LEVEL_DEV1, {1}, {2})"
		public extern void SetMaxCreepLevel_Dev1(int level, int maxCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangled Gold Mine Ability</term> <description>Aegm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_PER_INTERVAL_EGM1, {1})"
		public extern int GetGoldPerInterval_Egm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangled Gold Mine Ability</term> <description>Aegm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_PER_INTERVAL_EGM1, {1}, {2})"
		public extern void SetGoldPerInterval_Egm1(int level, int goldPerInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Faerie Fire</term> <description>Afae, Afa2, ACff</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_REDUCTION, {1})"
		public extern int GetDefenseReduction_Fae1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Faerie Fire</term> <description>Afae, Afa2, ACff</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_REDUCTION, {1}, {2})"
		public extern void SetDefenseReduction_Fae1(int level, int defenseReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_FLA1, {1})"
		public extern int GetDetectionType_Fla1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_FLA1, {1}, {2})"
		public extern void SetDetectionType_Fla1(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_FLARE_COUNT, {1})"
		public extern int GetFlareCount_Fla3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_FLARE_COUNT, {1}, {2})"
		public extern void SetFlareCount_Fla3(int level, int flareCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_GOLD, {1})"
		public extern int GetMaxGold_Gld1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_GOLD, {1}, {2})"
		public extern void SetMaxGold_Gld1(int level, int maxGold);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MINING_CAPACITY, {1})"
		public extern int GetMiningCapacity_Gld3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MINING_CAPACITY, {1}, {2})"
		public extern void SetMiningCapacity_Gld3(int level, int miningCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_GYD1, {1})"
		public extern int GetMaximumNumberOfCorpses_Gyd1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_GYD1, {1}, {2})"
		public extern void SetMaximumNumberOfCorpses_Gyd1(int level, int maximumNumberOfCorpses);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar, Ahrl, Ahr2, Ahr3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_TO_TREE, {1})"
		public extern int GetDamageToTree_Har1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar, Ahrl, Ahr2, Ahr3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_TO_TREE, {1}, {2})"
		public extern void SetDamageToTree_Har1(int level, int damageToTree);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar, Ahrl, Ahr2, Ahr3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_CAPACITY, {1})"
		public extern int GetLumberCapacity_Har2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar, Ahrl, Ahr2, Ahr3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_CAPACITY, {1}, {2})"
		public extern void SetLumberCapacity_Har2(int level, int lumberCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_CAPACITY, {1})"
		public extern int GetGoldCapacity_Har3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Harvest</term> <description>Ahar</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_CAPACITY, {1}, {2})"
		public extern void SetGoldCapacity_Har3(int level, int goldCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_INCREASE_INF2, {1})"
		public extern int GetDefenseIncrease_Inf2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_INCREASE_INF2, {1}, {2})"
		public extern void SetDefenseIncrease_Inf2(int level, int defenseIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_INTERACTION_TYPE, {1})"
		public extern int GetInteractionType_Neu2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_INTERACTION_TYPE, {1}, {2})"
		public extern void SetInteractionType_Neu2(int level, int interactionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_COST_NDT1, {1})"
		public extern int GetGoldCost_Ndt1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_COST_NDT1, {1}, {2})"
		public extern void SetGoldCost_Ndt1(int level, int goldCost);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_COST_NDT2, {1})"
		public extern int GetLumberCost_Ndt2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_COST_NDT2, {1}, {2})"
		public extern void SetLumberCost_Ndt2(int level, int lumberCost);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_NDT3, {1})"
		public extern int GetDetectionType_Ndt3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Reveal</term> <description>Andt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_NDT3, {1}, {2})"
		public extern void SetDetectionType_Ndt3(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_POI4, {1})"
		public extern int GetStackingType_Poi4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_POI4, {1}, {2})"
		public extern void SetStackingType_Poi4(int level, int stackingType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_POA5, {1})"
		public extern int GetStackingType_Poa5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_POA5, {1}, {2})"
		public extern void SetStackingType_Poa5(int level, int stackingType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_PLY1, {1})"
		public extern int GetMaximumCreepLevel_Ply1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_PLY1, {1}, {2})"
		public extern void SetMaximumCreepLevel_Ply1(int level, int maximumCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Apos, ACps, Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_POS1, {1})"
		public extern int GetMaximumCreepLevel_Pos1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Apos, ACps, Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_POS1, {1}, {2})"
		public extern void SetMaximumCreepLevel_Pos1(int level, int maximumCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MOVEMENT_UPDATE_FREQUENCY_PRG1, {1})"
		public extern int GetMovementUpdateFrequency_Prg1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MOVEMENT_UPDATE_FREQUENCY_PRG1, {1}, {2})"
		public extern void SetMovementUpdateFrequency_Prg1(int level, int movementUpdateFrequency);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_UPDATE_FREQUENCY_PRG2, {1})"
		public extern int GetAttackUpdateFrequency_Prg2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_UPDATE_FREQUENCY_PRG2, {1}, {2})"
		public extern void SetAttackUpdateFrequency_Prg2(int level, int attackUpdateFrequency);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu, Apg2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_PRG6, {1})"
		public extern int GetManaLoss_Prg6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu, Apg2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_PRG6, {1}, {2})"
		public extern void SetManaLoss_Prg6(int level, int manaLoss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNITS_SUMMONED_TYPE_ONE, {1})"
		public extern int GetUnitsSummonedTypeOne_Rai1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNITS_SUMMONED_TYPE_ONE, {1}, {2})"
		public extern void SetUnitsSummonedTypeOne_Rai1(int level, int unitsSummonedTypeOne);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNITS_SUMMONED_TYPE_TWO, {1})"
		public extern int GetUnitsSummonedTypeTwo_Rai2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNITS_SUMMONED_TYPE_TWO, {1}, {2})"
		public extern void SetUnitsSummonedTypeTwo_Rai2(int level, int unitsSummonedTypeTwo);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_SUMMONED, {1})"
		public extern int GetMaxUnitsSummoned_Ucb5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_SUMMONED, {1}, {2})"
		public extern void SetMaxUnitsSummoned_Ucb5(int level, int maxUnitsSummoned);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOW_WHEN_FULL_REJ3, {1})"
		public extern int GetAllowWhenFull_Rej3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOW_WHEN_FULL_REJ3, {1}, {2})"
		public extern void SetAllowWhenFull_Rej3(int level, int allowWhenFull);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS_CHARGED_TO_CASTER, {1})"
		public extern int GetMaximumUnitsChargedToCaster_Rpb5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS_CHARGED_TO_CASTER, {1}, {2})"
		public extern void SetMaximumUnitsChargedToCaster_Rpb5(int level, int maximumUnitsChargedToCaster);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS_AFFECTED, {1})"
		public extern int GetMaximumUnitsAffected_Rpb6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS_AFFECTED, {1}, {2})"
		public extern void SetMaximumUnitsAffected_Rpb6(int level, int maximumUnitsAffected);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_INCREASE_ROA2, {1})"
		public extern int GetDefenseIncrease_Roa2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_INCREASE_ROA2, {1}, {2})"
		public extern void SetDefenseIncrease_Roa2(int level, int defenseIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_ROA7, {1})"
		public extern int GetMaxUnits_Roa7(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_ROA7, {1}, {2})"
		public extern void SetMaxUnits_Roa7(int level, int maxUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ROOTED_WEAPONS, {1})"
		public extern int GetRootedWeapons_Roo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ROOTED_WEAPONS, {1}, {2})"
		public extern void SetRootedWeapons_Roo1(int level, int rootedWeapons);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UPROOTED_WEAPONS, {1})"
		public extern int GetUprootedWeapons_Roo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UPROOTED_WEAPONS, {1}, {2})"
		public extern void SetUprootedWeapons_Roo2(int level, int uprootedWeapons);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UPROOTED_DEFENSE_TYPE, {1})"
		public extern int GetUprootedDefenseType_Roo4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Root</term> <description>Aroo, Aro1, Aro2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UPROOTED_DEFENSE_TYPE, {1}, {2})"
		public extern void SetUprootedDefenseType_Roo4(int level, int uprootedDefenseType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pillage</term> <description>Asal</description></item>
		/// <item><term>Unsummon Building</term> <description>Auns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ACCUMULATION_STEP, {1})"
		public extern int GetAccumulationStep_Sal2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pillage</term> <description>Asal</description></item>
		/// <item><term>Unsummon Building</term> <description>Auns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ACCUMULATION_STEP, {1}, {2})"
		public extern void SetAccumulationStep_Sal2(int level, int accumulationStep);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_OWLS, {1})"
		public extern int GetNumberOfOwls_Esn4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_OWLS, {1}, {2})"
		public extern void SetNumberOfOwls_Esn4(int level, int numberOfOwls);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_SPO4, {1})"
		public extern int GetStackingType_Spo4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STACKING_TYPE_SPO4, {1}, {2})"
		public extern void SetStackingType_Spo4(int level, int stackingType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spawn Hydra Hatchling</term> <description>Aspt</description></item>
		/// <item><term>Spawn Hydra</term> <description>Aspy</description></item>
		/// <item><term>Spawn Skeleton</term> <description>Asod</description></item>
		/// <item><term>Spawn Spiderlings</term> <description>Assp</description></item>
		/// <item><term>Spawn Spiders</term> <description>Aspd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS, {1})"
		public extern int GetNumberOfUnits_Sod1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spawn Hydra Hatchling</term> <description>Aspt</description></item>
		/// <item><term>Spawn Hydra</term> <description>Aspy</description></item>
		/// <item><term>Spawn Skeleton</term> <description>Asod</description></item>
		/// <item><term>Spawn Spiderlings</term> <description>Assp</description></item>
		/// <item><term>Spawn Spiders</term> <description>Aspd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS, {1}, {2})"
		public extern void SetNumberOfUnits_Sod1(int level, int numberOfUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spider Attack</term> <description>Aspa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SPIDER_CAPACITY, {1})"
		public extern int GetSpiderCapacity_Spa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spider Attack</term> <description>Aspa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SPIDER_CAPACITY, {1}, {2})"
		public extern void SetSpiderCapacity_Spa1(int level, int spiderCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_INTERVALS_BEFORE_CHANGING_TREES, {1})"
		public extern int GetIntervalsBeforeChangingTrees_Wha2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_INTERVALS_BEFORE_CHANGING_TREES, {1}, {2})"
		public extern void SetIntervalsBeforeChangingTrees_Wha2(int level, int intervalsBeforeChangingTrees);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_AGILITY_BONUS, {1})"
		public extern int GetAgilityBonus_Iagi(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_AGILITY_BONUS, {1}, {2})"
		public extern void SetAgilityBonus_Iagi(int level, int agilityBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_INTELLIGENCE_BONUS, {1})"
		public extern int GetIntelligenceBonus_Iint(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_INTELLIGENCE_BONUS, {1}, {2})"
		public extern void SetIntelligenceBonus_Iint(int level, int intelligenceBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_STRENGTH_BONUS_ISTR, {1})"
		public extern int GetStrengthBonus_Istr(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Attribute Bonus</term> <description>Aamk</description></item>
		/// <item><term>Item Agility Gain</term> <description>AIam, AIgm</description></item>
		/// <item><term>Item Hero Stat Bonus</term> <description>AIab, AIa1, AIa3, AIa4, AIa5, AIa6, AIx5, AIx1, AIx2, AIx3, AIx4, AIs1, AIs3, AIs4, AIs5, AIs6, AIi1, AIi3, AIi4, AIi5, AIi6</description></item>
		/// <item><term>Item Int/Agi/Str gain</term> <description>AIxm</description></item>
		/// <item><term>Item Intelligence Gain</term> <description>AIim, AItm</description></item>
		/// <item><term>Item Strength Gain</term> <description>AIsm, AInm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_STRENGTH_BONUS_ISTR, {1}, {2})"
		public extern void SetStrengthBonus_Istr(int level, int strengthBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Damage Bonus</term> <description>AIat, AIt6, AIt9, AItc, AItf, AItg, AIth, AIti, AItj, AItk, AItl, AItn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_BONUS, {1})"
		public extern int GetAttackBonus_Iatt(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Damage Bonus</term> <description>AIat, AIt6, AIt9, AItc, AItf, AItg, AIth, AIti, AItj, AItk, AItl, AItn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_BONUS, {1}, {2})"
		public extern void SetAttackBonus_Iatt(int level, int attackBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Armor Bonus</term> <description>AIde, AId1, AId2, AId3, AId4, AId5</description></item>
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_BONUS_IDEF, {1})"
		public extern int GetDefenseBonus_Idef(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Armor Bonus</term> <description>AIde, AId1, AId2, AId3, AId4, AId5</description></item>
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DEFENSE_BONUS_IDEF, {1}, {2})"
		public extern void SetDefenseBonus_Idef(int level, int defenseBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMON_1_AMOUNT, {1})"
		public extern int GetSummon1Amount_Isn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMON_1_AMOUNT, {1}, {2})"
		public extern void SetSummon1Amount_Isn1(int level, int summon1Amount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMON_2_AMOUNT, {1})"
		public extern int GetSummon2Amount_Isn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMON_2_AMOUNT, {1}, {2})"
		public extern void SetSummon2Amount_Isn2(int level, int summon2Amount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Experience Gain</term> <description>AIem, AIe2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_EXPERIENCE_GAINED, {1})"
		public extern int GetExperienceGained_Ixpg(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Experience Gain</term> <description>AIem, AIe2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_EXPERIENCE_GAINED, {1}, {2})"
		public extern void SetExperienceGained_Ixpg(int level, int experienceGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Healing</term> <description>AIha, AIhb</description></item>
		/// <item><term>Item Healing</term> <description>AIhe, AIh1, AIh2</description></item>
		/// <item><term>Least Healing</term> <description>AIh3</description></item>
		/// <item><term>Ritual Dagger</term> <description>AIdg, AIg2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_GAINED_IHPG, {1})"
		public extern int GetHitPointsGained_Ihpg(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Healing</term> <description>AIha, AIhb</description></item>
		/// <item><term>Item Healing</term> <description>AIhe, AIh1, AIh2</description></item>
		/// <item><term>Least Healing</term> <description>AIh3</description></item>
		/// <item><term>Ritual Dagger</term> <description>AIdg, AIg2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_GAINED_IHPG, {1}, {2})"
		public extern void SetHitPointsGained_Ihpg(int level, int hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Mana Regain</term> <description>AImr</description></item>
		/// <item><term>Item Mana Regain</term> <description>AIm1, AIm2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_GAINED_IMPG, {1})"
		public extern int GetManaPointsGained_Impg(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Mana Regain</term> <description>AImr</description></item>
		/// <item><term>Item Mana Regain</term> <description>AIm1, AIm2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_GAINED_IMPG, {1}, {2})"
		public extern void SetManaPointsGained_Impg(int level, int manaPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_GAINED_IHP2, {1})"
		public extern int GetHitPointsGained_Ihp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_GAINED_IHP2, {1}, {2})"
		public extern void SetHitPointsGained_Ihp2(int level, int hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_GAINED_IMP2, {1})"
		public extern int GetManaPointsGained_Imp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Area Armor Bonus</term> <description>AIda, AIdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_GAINED_IMP2, {1}, {2})"
		public extern void SetManaPointsGained_Imp2(int level, int manaPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_BONUS_DICE, {1})"
		public extern int GetDamageBonusDice_Idic(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_BONUS_DICE, {1}, {2})"
		public extern void SetDamageBonusDice_Idic(int level, int damageBonusDice);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ARMOR_PENALTY_IARP, {1})"
		public extern int GetArmorPenalty_Iarp(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ARMOR_PENALTY_IARP, {1}, {2})"
		public extern void SetArmorPenalty_Iarp(int level, int armorPenalty);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// <item><term>Item Attack Fire Bonus</term> <description>AIfb</description></item>
		/// <item><term>Item Attack Frost Bonus</term> <description>AIob</description></item>
		/// <item><term>Item Attack Heal Reduction Bonus</term> <description>AIf2</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// <item><term>Item Freeze Damage Bonus</term> <description>AIzb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ENABLED_ATTACK_INDEX_IOB5, {1})"
		public extern int GetEnabledAttackIndex_Iob5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Corruption Bonus</term> <description>AIcb</description></item>
		/// <item><term>Item Attack Fire Bonus</term> <description>AIfb</description></item>
		/// <item><term>Item Attack Frost Bonus</term> <description>AIob</description></item>
		/// <item><term>Item Attack Heal Reduction Bonus</term> <description>AIf2</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// <item><term>Item Freeze Damage Bonus</term> <description>AIzb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ENABLED_ATTACK_INDEX_IOB5, {1}, {2})"
		public extern void SetEnabledAttackIndex_Iob5(int level, int enabledAttackIndex);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Level Gain</term> <description>AIlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LEVELS_GAINED, {1})"
		public extern int GetLevelsGained_Ilev(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Level Gain</term> <description>AIlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LEVELS_GAINED, {1}, {2})"
		public extern void SetLevelsGained_Ilev(int level, int levelsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Bonus</term> <description>AIml, AIlf, AIl1, AIl2</description></item>
		/// <item><term>Item Permanent Life Gain, Item Life Gain</term> <description>AImi</description></item>
		/// <item><term>Item Permanent Life Gain</term> <description>AImh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_LIFE_GAINED, {1})"
		public extern int GetMaxLifeGained_Ilif(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Bonus</term> <description>AIml, AIlf, AIl1, AIl2</description></item>
		/// <item><term>Item Permanent Life Gain, Item Life Gain</term> <description>AImi</description></item>
		/// <item><term>Item Permanent Life Gain</term> <description>AImh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_LIFE_GAINED, {1}, {2})"
		public extern void SetMaxLifeGained_Ilif(int level, int maxLifeGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Mana Bonus</term> <description>AImm, AImb, AIbm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_MANA_GAINED, {1})"
		public extern int GetMaxManaGained_Iman(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Mana Bonus</term> <description>AImm, AImb, AIbm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_MANA_GAINED, {1}, {2})"
		public extern void SetMaxManaGained_Iman(int level, int maxManaGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chest of Gold</term> <description>AIgo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_GIVEN, {1})"
		public extern int GetGoldGiven_Igol(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chest of Gold</term> <description>AIgo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_GIVEN, {1}, {2})"
		public extern void SetGoldGiven_Igol(int level, int goldGiven);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bundle of Lumber</term> <description>AIlu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_GIVEN, {1})"
		public extern int GetLumberGiven_Ilum(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bundle of Lumber</term> <description>AIlu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_GIVEN, {1}, {2})"
		public extern void SetLumberGiven_Ilum(int level, int lumberGiven);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare Gun</term> <description>AIfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_IFA1, {1})"
		public extern int GetDetectionType_Ifa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare Gun</term> <description>AIfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_IFA1, {1}, {2})"
		public extern void SetDetectionType_Ifa1(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Command</term> <description>AIco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_ICRE, {1})"
		public extern int GetMaximumCreepLevel_Icre(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Command</term> <description>AIco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_ICRE, {1}, {2})"
		public extern void SetMaximumCreepLevel_Icre(int level, int maximumCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Move Speed Bonus</term> <description>AIms</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MOVEMENT_SPEED_BONUS, {1})"
		public extern int GetMovementSpeedBonus_Imvb(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Move Speed Bonus</term> <description>AIms</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MOVEMENT_SPEED_BONUS, {1}, {2})"
		public extern void SetMovementSpeedBonus_Imvb(int level, int movementSpeedBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Regeneration</term> <description>Arel, Arll</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_REGENERATED_PER_SECOND, {1})"
		public extern int GetHitPointsRegeneratedPerSecond_Ihpr(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Regeneration</term> <description>Arel, Arll</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_REGENERATED_PER_SECOND, {1}, {2})"
		public extern void SetHitPointsRegeneratedPerSecond_Ihpr(int level, int hitPointsRegeneratedPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Sight Range Bonus</term> <description>AIsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SIGHT_RANGE_BONUS, {1})"
		public extern int GetSightRangeBonus_Isib(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Sight Range Bonus</term> <description>AIsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SIGHT_RANGE_BONUS, {1}, {2})"
		public extern void SetSightRangeBonus_Isib(int level, int sightRangeBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_PER_DURATION, {1})"
		public extern int GetDamagePerDuration_Icfd(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_PER_DURATION, {1}, {2})"
		public extern void SetDamagePerDuration_Icfd(int level, int damagePerDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_USED_PER_SECOND, {1})"
		public extern int GetManaUsedPerSecond_Icfm(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_USED_PER_SECOND, {1}, {2})"
		public extern void SetManaUsedPerSecond_Icfm(int level, int manaUsedPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_EXTRA_MANA_REQUIRED, {1})"
		public extern int GetExtraManaRequired_Icfx(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Immolation</term> <description>AIcf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_EXTRA_MANA_REQUIRED, {1}, {2})"
		public extern void SetExtraManaRequired_Icfx(int level, int extraManaRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Detection</term> <description>AIta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_RADIUS_IDET, {1})"
		public extern int GetDetectionRadius_Idet(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Detection</term> <description>AIta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_RADIUS_IDET, {1}, {2})"
		public extern void SetDetectionRadius_Idet(int level, int detectionRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Dispel</term> <description>AIdi, AIds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_PER_UNIT_IDIM, {1})"
		public extern int GetManaLossPerUnit_Idim(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Dispel</term> <description>AIdi, AIds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_LOSS_PER_UNIT_IDIM, {1}, {2})"
		public extern void SetManaLossPerUnit_Idim(int level, int manaLossPerUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Dispel</term> <description>AIdi, AIds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_TO_SUMMONED_UNITS_IDID, {1})"
		public extern int GetDamageToSummonedUnits_Idid(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Dispel</term> <description>AIdi, AIds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DAMAGE_TO_SUMMONED_UNITS_IDID, {1}, {2})"
		public extern void SetDamageToSummonedUnits_Idid(int level, int damageToSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Recall</term> <description>AIrt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_IREC, {1})"
		public extern int GetMaximumNumberOfUnits_Irec(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Recall</term> <description>AIrt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_IREC, {1}, {2})"
		public extern void SetMaximumNumberOfUnits_Irec(int level, int maximumNumberOfUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DELAY_AFTER_DEATH_SECONDS, {1})"
		public extern int GetDelayAfterDeathSeconds_Ircd(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DELAY_AFTER_DEATH_SECONDS, {1}, {2})"
		public extern void SetDelayAfterDeathSeconds_Ircd(int level, int delayAfterDeathSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_RESTORED_LIFE, {1})"
		public extern int GetRestoredLife_irc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_RESTORED_LIFE, {1}, {2})"
		public extern void SetRestoredLife_irc2(int level, int restoredLife);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_RESTORED_MANA__1_FOR_CURRENT, {1})"
		public extern int GetRestoredMana_1ForCurrent_irc3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Reincarnation</term> <description>AIrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_RESTORED_MANA__1_FOR_CURRENT, {1}, {2})"
		public extern void SetRestoredMana_1ForCurrent_irc3(int level, int restoredMana_1ForCurrent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Heal/Mana Regain</term> <description>AIra</description></item>
		/// <item><term>Item Heal/Mana Regain</term> <description>AIre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_RESTORED, {1})"
		public extern int GetHitPointsRestored_Ihps(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Heal/Mana Regain</term> <description>AIra</description></item>
		/// <item><term>Item Heal/Mana Regain</term> <description>AIre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_HIT_POINTS_RESTORED, {1}, {2})"
		public extern void SetHitPointsRestored_Ihps(int level, int hitPointsRestored);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Heal/Mana Regain</term> <description>AIra</description></item>
		/// <item><term>Item Heal/Mana Regain</term> <description>AIre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_RESTORED, {1})"
		public extern int GetManaPointsRestored_Imps(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Area Heal/Mana Regain</term> <description>AIra</description></item>
		/// <item><term>Item Heal/Mana Regain</term> <description>AIre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MANA_POINTS_RESTORED, {1}, {2})"
		public extern void SetManaPointsRestored_Imps(int level, int manaPointsRestored);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Town Portal</term> <description>AItp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_ITPM, {1})"
		public extern int GetMaximumNumberOfUnits_Itpm(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Town Portal</term> <description>AItp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_UNITS_ITPM, {1}, {2})"
		public extern void SetMaximumNumberOfUnits_Itpm(int level, int maximumNumberOfUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>ACad</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_CAD1, {1})"
		public extern int GetNumberOfCorpsesRaised_Cad1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Animate Dead</term> <description>ACad</description></item>
		/// <item><term>Item Animate Dead</term> <description>AIan</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_CORPSES_RAISED_CAD1, {1}, {2})"
		public extern void SetNumberOfCorpsesRaised_Cad1(int level, int numberOfCorpsesRaised);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_TERRAIN_DEFORMATION_DURATION_MS, {1})"
		public extern int GetTerrainDeformationDurationMs_Wrs3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_TERRAIN_DEFORMATION_DURATION_MS, {1}, {2})"
		public extern void SetTerrainDeformationDurationMs_Wrs3(int level, int terrainDeformationDurationMs);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS, {1})"
		public extern int GetMaximumUnits_Uds1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_UNITS, {1}, {2})"
		public extern void SetMaximumUnits_Uds1(int level, int maximumUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burrow Detection</term> <description>Abdt</description></item>
		/// <item><term>Detector</term> <description>Adet, Adt1</description></item>
		/// <item><term>Dust of Appearance</term> <description>AItb</description></item>
		/// <item><term>Item Reveal Entire Map</term> <description>AIrv</description></item>
		/// <item><term>Magic Sentry</term> <description>Adts</description></item>
		/// <item><term>True Sight</term> <description>Atru, Agyv, Adtg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_DET1, {1})"
		public extern int GetDetectionType_Det1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burrow Detection</term> <description>Abdt</description></item>
		/// <item><term>Detector</term> <description>Adet, Adt1</description></item>
		/// <item><term>Dust of Appearance</term> <description>AItb</description></item>
		/// <item><term>Item Reveal Entire Map</term> <description>AIrv</description></item>
		/// <item><term>Magic Sentry</term> <description>Adts</description></item>
		/// <item><term>True Sight</term> <description>Atru, Agyv, Adtg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_DET1, {1}, {2})"
		public extern void SetDetectionType_Det1(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_COST_PER_STRUCTURE, {1})"
		public extern int GetGoldCostPerStructure_Nsp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GOLD_COST_PER_STRUCTURE, {1}, {2})"
		public extern void SetGoldCostPerStructure_Nsp1(int level, int goldCostPerStructure);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_COST_PER_USE, {1})"
		public extern int GetLumberCostPerUse_Nsp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LUMBER_COST_PER_USE, {1}, {2})"
		public extern void SetLumberCostPerUse_Nsp2(int level, int lumberCostPerUse);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_NSP3, {1})"
		public extern int GetDetectionType_Nsp3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spy</term> <description>Ansp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DETECTION_TYPE_NSP3, {1}, {2})"
		public extern void SetDetectionType_Nsp3(int level, int detectionType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SWARM_UNITS, {1})"
		public extern int GetNumberOfSwarmUnits_Uls1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SWARM_UNITS, {1}, {2})"
		public extern void SetNumberOfSwarmUnits_Uls1(int level, int numberOfSwarmUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_SWARM_UNITS_PER_TARGET, {1})"
		public extern int GetMaxSwarmUnitsPerTarget_Uls3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_SWARM_UNITS_PER_TARGET, {1}, {2})"
		public extern void SetMaxSwarmUnitsPerTarget_Uls3(int level, int maxSwarmUnitsPerTarget);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NBA2, {1})"
		public extern int GetNumberOfSummonedUnits_Nba2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NBA2, {1}, {2})"
		public extern void SetNumberOfSummonedUnits_Nba2(int level, int numberOfSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charm</term> <description>ANch, ACch</description></item>
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_NCH1, {1})"
		public extern int GetMaximumCreepLevel_Nch1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charm</term> <description>ANch, ACch</description></item>
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_CREEP_LEVEL_NCH1, {1}, {2})"
		public extern void SetMaximumCreepLevel_Nch1(int level, int maximumCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACKS_PREVENTED, {1})"
		public extern int GetAttacksPrevented_Nsi1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACKS_PREVENTED, {1}, {2})"
		public extern void SetAttacksPrevented_Nsi1(int level, int attacksPrevented);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_EFK3, {1})"
		public extern int GetMaximumNumberOfTargets_Efk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_EFK3, {1}, {2})"
		public extern void SetMaximumNumberOfTargets_Efk3(int level, int maximumNumberOfTargets);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vengeance</term> <description>AEsv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_ESV1, {1})"
		public extern int GetNumberOfSummonedUnits_Esv1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vengeance</term> <description>AEsv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_ESV1, {1}, {2})"
		public extern void SetNumberOfSummonedUnits_Esv1(int level, int numberOfSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Exhume Corpses</term> <description>Aexh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_EXH1, {1})"
		public extern int GetMaximumNumberOfCorpses_exh1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Exhume Corpses</term> <description>Aexh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_CORPSES_EXH1, {1}, {2})"
		public extern void SetMaximumNumberOfCorpses_exh1(int level, int maximumNumberOfCorpses);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ITEM_CAPACITY, {1})"
		public extern int GetItemCapacity_inv1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inventory</term> <description>AInv</description></item>
		/// <item><term>Pack Mule</term> <description>Apak</description></item>
		/// <item><term>Unit Inventory</term> <description>Aiun</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ITEM_CAPACITY, {1}, {2})"
		public extern void SetItemCapacity_inv1(int level, int itemCapacity);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spirit Link</term> <description>Aspl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_SPL2, {1})"
		public extern int GetMaximumNumberOfTargets_spl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spirit Link</term> <description>Aspl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_NUMBER_OF_TARGETS_SPL2, {1}, {2})"
		public extern void SetMaximumNumberOfTargets_spl2(int level, int maximumNumberOfTargets);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOW_WHEN_FULL_IRL3, {1})"
		public extern int GetAllowWhenFull_irl3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOW_WHEN_FULL_IRL3, {1}, {2})"
		public extern void SetAllowWhenFull_irl3(int level, int allowWhenFull);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_DISPELLED_UNITS, {1})"
		public extern int GetMaximumDispelledUnits_idc3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_DISPELLED_UNITS, {1}, {2})"
		public extern void SetMaximumDispelledUnits_idc3(int level, int maximumDispelledUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_LURES, {1})"
		public extern int GetNumberOfLures_imo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_LURES, {1}, {2})"
		public extern void SetNumberOfLures_imo1(int level, int numberOfLures);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Change Time of Day</term> <description>AIct</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_TIME_OF_DAY_HOUR, {1})"
		public extern int GetNewTimeOfDayHour_ict1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Change Time of Day</term> <description>AIct</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_TIME_OF_DAY_HOUR, {1}, {2})"
		public extern void SetNewTimeOfDayHour_ict1(int level, int newTimeOfDayHour);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Change Time of Day</term> <description>AIct</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_TIME_OF_DAY_MINUTE, {1})"
		public extern int GetNewTimeOfDayMinute_ict2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Change Time of Day</term> <description>AIct</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_TIME_OF_DAY_MINUTE, {1}, {2})"
		public extern void SetNewTimeOfDayMinute_ict2(int level, int newTimeOfDayMinute);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mechanical Critter</term> <description>Amec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_CREATED_MEC1, {1})"
		public extern int GetNumberOfUnitsCreated_mec1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mechanical Critter</term> <description>Amec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_UNITS_CREATED_MEC1, {1}, {2})"
		public extern void SetNumberOfUnitsCreated_mec1(int level, int numberOfUnitsCreated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MINIMUM_SPELLS, {1})"
		public extern int GetMinimumSpells_spb3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MINIMUM_SPELLS, {1}, {2})"
		public extern void SetMinimumSpells_spb3(int level, int minimumSpells);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_SPELLS, {1})"
		public extern int GetMaximumSpells_spb4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_SPELLS, {1}, {2})"
		public extern void SetMaximumSpells_spb4(int level, int maximumSpells);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DISABLED_ATTACK_INDEX, {1})"
		public extern int GetDisabledAttackIndex_gra3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DISABLED_ATTACK_INDEX, {1}, {2})"
		public extern void SetDisabledAttackIndex_gra3(int level, int disabledAttackIndex);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ENABLED_ATTACK_INDEX_GRA4, {1})"
		public extern int GetEnabledAttackIndex_gra4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ENABLED_ATTACK_INDEX_GRA4, {1}, {2})"
		public extern void SetEnabledAttackIndex_gra4(int level, int enabledAttackIndex);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_ATTACKS, {1})"
		public extern int GetMaximumAttacks_gra5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAXIMUM_ATTACKS, {1}, {2})"
		public extern void SetMaximumAttacks_gra5(int level, int maximumAttacks);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Preservation</term> <description>ANpr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_BUILDING_TYPES_ALLOWED_NPR1, {1})"
		public extern int GetBuildingTypesAllowed_Npr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Preservation</term> <description>ANpr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_BUILDING_TYPES_ALLOWED_NPR1, {1}, {2})"
		public extern void SetBuildingTypesAllowed_Npr1(int level, int buildingTypesAllowed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_BUILDING_TYPES_ALLOWED_NSA1, {1})"
		public extern int GetBuildingTypesAllowed_Nsa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_BUILDING_TYPES_ALLOWED_NSA1, {1}, {2})"
		public extern void SetBuildingTypesAllowed_Nsa1(int level, int buildingTypesAllowed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Permanent Damage Gain, Item Attack Damage Gain</term> <description>AIaa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_MODIFICATION, {1})"
		public extern int GetAttackModification_Iaa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Permanent Damage Gain, Item Attack Damage Gain</term> <description>AIaa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ATTACK_MODIFICATION, {1}, {2})"
		public extern void SetAttackModification_Iaa1(int level, int attackModification);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_COUNT_NPA5, {1})"
		public extern int GetSummonedUnitCount_Npa5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_COUNT_NPA5, {1}, {2})"
		public extern void SetSummonedUnitCount_Npa5(int level, int summonedUnitCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Glyph of Fortification</term> <description>AIgf, AIgu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UPGRADE_LEVELS, {1})"
		public extern int GetUpgradeLevels_Igl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Glyph of Fortification</term> <description>AIgf, AIgu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UPGRADE_LEVELS, {1}, {2})"
		public extern void SetUpgradeLevels_Igl1(int level, int upgradeLevels);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NDO2, {1})"
		public extern int GetNumberOfSummonedUnits_Ndo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_SUMMONED_UNITS_NDO2, {1}, {2})"
		public extern void SetNumberOfSummonedUnits_Ndo2(int level, int numberOfSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_BEASTS_PER_SECOND, {1})"
		public extern int GetBeastsPerSecond_Nst1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_BEASTS_PER_SECOND, {1}, {2})"
		public extern void SetBeastsPerSecond_Nst1(int level, int beastsPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_TARGET_TYPE, {1})"
		public extern int GetTargetType_Ncl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_TARGET_TYPE, {1}, {2})"
		public extern void SetTargetType_Ncl2(int level, int targetType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_OPTIONS, {1})"
		public extern int GetOptions_Ncl3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_OPTIONS, {1}, {2})"
		public extern void SetOptions_Ncl3(int level, int options);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ARMOR_PENALTY_NAB3, {1})"
		public extern int GetArmorPenalty_Nab3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ARMOR_PENALTY_NAB3, {1}, {2})"
		public extern void SetArmorPenalty_Nab3(int level, int armorPenalty);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_WAVE_COUNT_NHS6, {1})"
		public extern int GetWaveCount_Nhs6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_WAVE_COUNT_NHS6, {1}, {2})"
		public extern void SetWaveCount_Nhs6(int level, int waveCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_CREEP_LEVEL_NTM3, {1})"
		public extern int GetMaxCreepLevel_Ntm3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_CREEP_LEVEL_NTM3, {1}, {2})"
		public extern void SetMaxCreepLevel_Ntm3(int level, int maxCreepLevel);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MISSILE_COUNT, {1})"
		public extern int GetMissileCount_Ncs3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MISSILE_COUNT, {1}, {2})"
		public extern void SetMissileCount_Ncs3(int level, int missileCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SPLIT_ATTACK_COUNT, {1})"
		public extern int GetSplitAttackCount_Nlm3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SPLIT_ATTACK_COUNT, {1}, {2})"
		public extern void SetSplitAttackCount_Nlm3(int level, int splitAttackCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_GENERATION_COUNT, {1})"
		public extern int GetGenerationCount_Nlm6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_GENERATION_COUNT, {1}, {2})"
		public extern void SetGenerationCount_Nlm6(int level, int generationCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ROCK_RING_COUNT, {1})"
		public extern int GetRockRingCount_Nvc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ROCK_RING_COUNT, {1}, {2})"
		public extern void SetRockRingCount_Nvc1(int level, int rockRingCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_WAVE_COUNT_NVC2, {1})"
		public extern int GetWaveCount_Nvc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_WAVE_COUNT_NVC2, {1}, {2})"
		public extern void SetWaveCount_Nvc2(int level, int waveCount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_PREFER_HOSTILES_TAU1, {1})"
		public extern int GetPreferHostiles_Tau1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_PREFER_HOSTILES_TAU1, {1}, {2})"
		public extern void SetPreferHostiles_Tau1(int level, int preferHostiles);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_PREFER_FRIENDLIES_TAU2, {1})"
		public extern int GetPreferFriendlies_Tau2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_PREFER_FRIENDLIES_TAU2, {1}, {2})"
		public extern void SetPreferFriendlies_Tau2(int level, int preferFriendlies);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_TAU3, {1})"
		public extern int GetMaxUnits_Tau3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_MAX_UNITS_TAU3, {1}, {2})"
		public extern void SetMaxUnits_Tau3(int level, int maxUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_PULSES, {1})"
		public extern int GetNumberOfPulses_Tau4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NUMBER_OF_PULSES, {1}, {2})"
		public extern void SetNumberOfPulses_Tau4(int level, int numberOfPulses);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix</term> <description>AHpx</description></item>
		/// <item><term>Scout</term> <description>AEst</description></item>
		/// <item><term>Serpent Ward</term> <description>AOsw</description></item>
		/// <item><term>Spawn Tentacle</term> <description>ACtn</description></item>
		/// <item><term>Summon Bear</term> <description>ANsg</description></item>
		/// <item><term>Summon Hawk</term> <description>ANsw</description></item>
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// <item><term>Summon Quilbeast</term> <description>ANsq</description></item>
		/// <item><term>Summon Sea Elemental</term> <description>ACwe</description></item>
		/// <item><term>Summon Water Elemental</term> <description>AHwe</description></item>
		/// <item><term>Watery Minion</term> <description>ANwm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_HWE1, {1})"
		public extern int GetSummonedUnitType_Hwe1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix</term> <description>AHpx</description></item>
		/// <item><term>Scout</term> <description>AEst</description></item>
		/// <item><term>Serpent Ward</term> <description>AOsw</description></item>
		/// <item><term>Spawn Tentacle</term> <description>ACtn</description></item>
		/// <item><term>Summon Bear</term> <description>ANsg</description></item>
		/// <item><term>Summon Hawk</term> <description>ANsw</description></item>
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// <item><term>Summon Quilbeast</term> <description>ANsq</description></item>
		/// <item><term>Summon Sea Elemental</term> <description>ACwe</description></item>
		/// <item><term>Summon Water Elemental</term> <description>AHwe</description></item>
		/// <item><term>Watery Minion</term> <description>ANwm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_HWE1, {1}, {2})"
		public extern void SetSummonedUnitType_Hwe1(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_UIN4, {1})"
		public extern int GetSummonedUnit_Uin4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_UIN4, {1}, {2})"
		public extern void SetSummonedUnit_Uin4(int level, int summonedUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feral Spirit</term> <description>AOsf, ACsf, ACs9</description></item>
		/// <item><term>Summon Headhunter</term> <description>AIsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_OSF1, {1})"
		public extern int GetSummonedUnit_Osf1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feral Spirit</term> <description>AOsf, ACsf, ACs9</description></item>
		/// <item><term>Summon Headhunter</term> <description>AIsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_OSF1, {1}, {2})"
		public extern void SetSummonedUnit_Osf1(int level, int summonedUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Force of Nature</term> <description>AEfn, ACfr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_EFNU, {1})"
		public extern int GetSummonedUnitType_Efnu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Force of Nature</term> <description>AEfn, ACfr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_EFNU, {1}, {2})"
		public extern void SetSummonedUnitType_Efnu(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NBAU, {1})"
		public extern int GetSummonedUnitType_Nbau(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NBAU, {1}, {2})"
		public extern void SetSummonedUnitType_Nbau(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado</term> <description>ANto</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NTOU, {1})"
		public extern int GetSummonedUnitType_Ntou(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado</term> <description>ANto</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NTOU, {1}, {2})"
		public extern void SetSummonedUnitType_Ntou(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vengeance</term> <description>AEsv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_ESVU, {1})"
		public extern int GetSummonedUnitType_Esvu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vengeance</term> <description>AEsv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_ESVU, {1}, {2})"
		public extern void SetSummonedUnitType_Esvu(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Storm, Earth, And Fire"</term> <description>ANef</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPES, {1})"
		public extern int GetSummonedUnitTypes_Nef1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Storm, Earth, And Fire"</term> <description>ANef</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPES, {1}, {2})"
		public extern void SetSummonedUnitTypes_Nef1(int level, int summonedUnitTypes);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NDOU, {1})"
		public extern int GetSummonedUnitType_Ndou(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SUMMONED_UNIT_TYPE_NDOU, {1}, {2})"
		public extern void SetSummonedUnitType_Ndou(int level, int summonedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ALTERNATE_FORM_UNIT_EMEU, {1})"
		public extern int GetAlternateFormUnit_Emeu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ALTERNATE_FORM_UNIT_EMEU, {1}, {2})"
		public extern void SetAlternateFormUnit_Emeu(int level, int alternateFormUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_PLAGUE_WARD_UNIT_TYPE, {1})"
		public extern int GetPlagueWardUnitType_Aplu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_PLAGUE_WARD_UNIT_TYPE, {1}, {2})"
		public extern void SetPlagueWardUnitType_Aplu(int level, int plagueWardUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Stations</term> <description>Abtl, Sbtl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOWED_UNIT_TYPE_BTL1, {1})"
		public extern int GetAllowedUnitType_Btl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Stations</term> <description>Abtl, Sbtl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOWED_UNIT_TYPE_BTL1, {1}, {2})"
		public extern void SetAllowedUnitType_Btl1(int level, int allowedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserker Upgrade</term> <description>Sbsk</description></item>
		/// <item><term>Chaos</term> <description>Acha, Sca1, Sca2, Sca3, Sca4, Sca5, Sca6, Srtt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_UNIT_TYPE, {1})"
		public extern int GetNewUnitType_Cha1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserker Upgrade</term> <description>Sbsk</description></item>
		/// <item><term>Chaos</term> <description>Acha, Sca1, Sca2, Sca3, Sca4, Sca5, Sca6, Srtt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_NEW_UNIT_TYPE, {1}, {2})"
		public extern void SetNewUnitType_Cha1(int level, int newUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangle Gold Mine</term> <description>Aent</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_RESULTING_UNIT_TYPE_ENT1, {1})"
		public extern int GetResultingUnitType_ent1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangle Gold Mine</term> <description>Aent</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_RESULTING_UNIT_TYPE_ENT1, {1}, {2})"
		public extern void SetResultingUnitType_ent1(int level, int resultingUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_CORPSE_UNIT_TYPE, {1})"
		public extern int GetCorpseUnitType_Gydu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_CORPSE_UNIT_TYPE, {1}, {2})"
		public extern void SetCorpseUnitType_Gydu(int level, int corpseUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Load Wisp</term> <description>Slo2</description></item>
		/// <item><term>Load</term> <description>Aloa, Sloa, Slo3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOWED_UNIT_TYPE_LOA1, {1})"
		public extern int GetAllowedUnitType_Loa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Load Wisp</term> <description>Slo2</description></item>
		/// <item><term>Load</term> <description>Aloa, Sloa, Slo3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_ALLOWED_UNIT_TYPE_LOA1, {1}, {2})"
		public extern void SetAllowedUnitType_Loa1(int level, int allowedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_FOR_LIMIT_CHECK, {1})"
		public extern int GetUnitTypeForLimitCheck_Raiu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_FOR_LIMIT_CHECK, {1}, {2})"
		public extern void SetUnitTypeForLimitCheck_Raiu(int level, int unitTypeForLimitCheck);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_WARD_UNIT_TYPE_STAU, {1})"
		public extern int GetWardUnitType_Stau(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_WARD_UNIT_TYPE_STAU, {1}, {2})"
		public extern void SetWardUnitType_Stau(int level, int wardUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_EFFECT_ABILITY, {1})"
		public extern int GetEffectAbility_Iobu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_EFFECT_ABILITY, {1}, {2})"
		public extern void SetEffectAbility_Iobu(int level, int effectAbility);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Conversion</term> <description>ANdc, SNdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_CONVERSION_UNIT, {1})"
		public extern int GetConversionUnit_Ndc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Conversion</term> <description>ANdc, SNdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_CONVERSION_UNIT, {1}, {2})"
		public extern void SetConversionUnit_Ndc2(int level, int conversionUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Preservation</term> <description>ANsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TO_PRESERVE, {1})"
		public extern int GetUnitToPreserve_Nsl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Preservation</term> <description>ANsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TO_PRESERVE, {1}, {2})"
		public extern void SetUnitToPreserve_Nsl1(int level, int unitToPreserve);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chaos Cargo Load</term> <description>Achl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_ALLOWED, {1})"
		public extern int GetUnitTypeAllowed_Chl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chaos Cargo Load</term> <description>Achl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_ALLOWED, {1}, {2})"
		public extern void SetUnitTypeAllowed_Chl1(int level, int unitTypeAllowed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SWARM_UNIT_TYPE, {1})"
		public extern int GetSwarmUnitType_Ulsu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SWARM_UNIT_TYPE, {1}, {2})"
		public extern void SetSwarmUnitType_Ulsu(int level, int swarmUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Acoa, Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Acoh, Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_RESULTING_UNIT_TYPE_COAU, {1})"
		public extern int GetResultingUnitType_coau(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Acoa, Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Acoh, Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_RESULTING_UNIT_TYPE_COAU, {1}, {2})"
		public extern void SetResultingUnitType_coau(int level, int resultingUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Exhume Corpses</term> <description>Aexh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_EXHU, {1})"
		public extern int GetUnitType_exhu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Exhume Corpses</term> <description>Aexh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_EXHU, {1}, {2})"
		public extern void SetUnitType_exhu(int level, int unitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Apts</description></item>
		/// <item><term>Healing Ward</term> <description>Ahwd, AChw, AIhw</description></item>
		/// <item><term>Sentry Ward</term> <description>Aeye, AIsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_WARD_UNIT_TYPE_HWDU, {1})"
		public extern int GetWardUnitType_hwdu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Apts</description></item>
		/// <item><term>Healing Ward</term> <description>Ahwd, AChw, AIhw</description></item>
		/// <item><term>Sentry Ward</term> <description>Aeye, AIsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_WARD_UNIT_TYPE_HWDU, {1}, {2})"
		public extern void SetWardUnitType_hwdu(int level, int wardUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_LURE_UNIT_TYPE, {1})"
		public extern int GetLureUnitType_imou(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_LURE_UNIT_TYPE, {1}, {2})"
		public extern void SetLureUnitType_imou(int level, int lureUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Place Goblin Land Mine</term> <description>AIpm</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_IPMU, {1})"
		public extern int GetUnitType_ipmu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Place Goblin Land Mine</term> <description>AIpm</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UNIT_TYPE_IPMU, {1}, {2})"
		public extern void SetUnitType_ipmu(int level, int unitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_FACTORY_UNIT_ID, {1})"
		public extern int GetFactoryUnitId_Nsyu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_FACTORY_UNIT_ID, {1}, {2})"
		public extern void SetFactoryUnitId_Nsyu(int level, int factoryUnitId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_SPAWN_UNIT_ID_NFYU, {1})"
		public extern int GetSpawnUnitId_Nfyu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_SPAWN_UNIT_ID_NFYU, {1}, {2})"
		public extern void SetSpawnUnitId_Nfyu(int level, int spawnUnitId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_DESTRUCTIBLE_ID, {1})"
		public extern int GetDestructibleId_Nvcu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_DESTRUCTIBLE_ID, {1}, {2})"
		public extern void SetDestructibleId_Nvcu(int level, int destructibleId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Glyph of Fortification</term> <description>AIgf, AIgu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityIntegerLevelField({0}, ABILITY_ILF_UPGRADE_TYPE, {1})"
		public extern int GetUpgradeType_Iglu(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Glyph of Fortification</term> <description>AIgf, AIgu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityIntegerLevelField({0}, ABILITY_ILF_UPGRADE_TYPE, {1}, {2})"
		public extern void SetUpgradeType_Iglu(int level, int upgradeType);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_TIME, {1})"
		public extern float GetCastingTime_acas(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_TIME, {1}, {2})"
		public extern void SetCastingTime_acas(int level, float castingTime);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_NORMAL, {1})"
		public extern float GetDurationNormal_adur(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_NORMAL, {1}, {2})"
		public extern void SetDurationNormal_adur(int level, float durationNormal);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_HERO, {1})"
		public extern float GetDurationHero_ahdu(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_HERO, {1}, {2})"
		public extern void SetDurationHero_ahdu(int level, float durationHero);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_COOLDOWN, {1})"
		public extern float GetCooldown_acdn(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_COOLDOWN, {1}, {2})"
		public extern void SetCooldown_acdn(int level, float cooldown);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AREA_OF_EFFECT, {1})"
		public extern float GetAreaOfEffect_aare(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AREA_OF_EFFECT, {1}, {2})"
		public extern void SetAreaOfEffect_aare(int level, float areaOfEffect);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CAST_RANGE, {1})"
		public extern float GetCastRange_aran(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CAST_RANGE, {1}, {2})"
		public extern void SetCastRange_aran(int level, float castRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_HBZ2, {1})"
		public extern float GetDamage_Hbz2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_HBZ2, {1}, {2})"
		public extern void SetDamage_Hbz2(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_HBZ4, {1})"
		public extern float GetBuildingReduction_Hbz4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_HBZ4, {1}, {2})"
		public extern void SetBuildingReduction_Hbz4(int level, float buildingReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_HBZ5, {1})"
		public extern float GetDamagePerSecond_Hbz5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_HBZ5, {1}, {2})"
		public extern void SetDamagePerSecond_Hbz5(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_PER_WAVE, {1})"
		public extern float GetMaximumDamagePerWave_Hbz6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blizzard</term> <description>AHbz, ACbz</description></item>
		/// <item><term>Rain of Fire</term> <description>ANrf, ACrf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_PER_WAVE, {1}, {2})"
		public extern void SetMaximumDamagePerWave_Hbz6(int level, float maximumDamagePerWave);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Brilliance Aura</term> <description>AHab, ACba, AIba</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATION_INCREASE, {1})"
		public extern float GetManaRegenerationIncrease_Hab1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Brilliance Aura</term> <description>AHab, ACba, AIba</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATION_INCREASE, {1}, {2})"
		public extern void SetManaRegenerationIncrease_Hab1(int level, float manaRegenerationIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_DELAY, {1})"
		public extern float GetCastingDelay_Hmt2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mass Teleport</term> <description>AHmt</description></item>
		/// <item><term>Staff of Teleportation</term> <description>AImt</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_DELAY, {1}, {2})"
		public extern void SetCastingDelay_Hmt2(int level, float castingDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bladestorm</term> <description>AOww</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_OWW1, {1})"
		public extern float GetDamagePerSecond_Oww1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bladestorm</term> <description>AOww</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_OWW1, {1}, {2})"
		public extern void SetDamagePerSecond_Oww1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bladestorm</term> <description>AOww</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_OWW2, {1})"
		public extern float GetMagicDamageReduction_Oww2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bladestorm</term> <description>AOww</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_OWW2, {1}, {2})"
		public extern void SetMagicDamageReduction_Oww2(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_CRITICAL_STRIKE, {1})"
		public extern float GetChanceToCriticalStrike_Ocr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_CRITICAL_STRIKE, {1}, {2})"
		public extern void SetChanceToCriticalStrike_Ocr1(int level, float chanceToCriticalStrike);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_OCR2, {1})"
		public extern float GetDamageMultiplier_Ocr2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_OCR2, {1}, {2})"
		public extern void SetDamageMultiplier_Ocr2(int level, float damageMultiplier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_OCR3, {1})"
		public extern float GetDamageBonus_Ocr3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_OCR3, {1}, {2})"
		public extern void SetDamageBonus_Ocr3(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_EVADE_OCR4, {1})"
		public extern float GetChanceToEvade_Ocr4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Critical Strike</term> <description>AOcr, ACct</description></item>
		/// <item><term>Drunken Brawler</term> <description>ANdb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_EVADE_OCR4, {1}, {2})"
		public extern void SetChanceToEvade_Ocr4(int level, float chanceToEvade);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_OMI2, {1})"
		public extern float GetDamageDealtPercent_Omi2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_OMI2, {1}, {2})"
		public extern void SetDamageDealtPercent_Omi2(int level, float damageDealtPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_PERCENT_OMI3, {1})"
		public extern float GetDamageTakenPercent_Omi3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_PERCENT_OMI3, {1}, {2})"
		public extern void SetDamageTakenPercent_Omi3(int level, float damageTakenPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ANIMATION_DELAY, {1})"
		public extern float GetAnimationDelay_Omi4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mirror Image</term> <description>AOmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ANIMATION_DELAY, {1}, {2})"
		public extern void SetAnimationDelay_Omi4(int level, float animationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_TRANSITION_TIME, {1})"
		public extern float GetTransitionTime_Owk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_TRANSITION_TIME, {1}, {2})"
		public extern void SetTransitionTime_Owk1(int level, float transitionTime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OWK2, {1})"
		public extern float GetMovementSpeedIncreasePercent_Owk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OWK2, {1}, {2})"
		public extern void SetMovementSpeedIncreasePercent_Owk2(int level, float movementSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BACKSTAB_DAMAGE, {1})"
		public extern float GetBackstabDamage_Owk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Wind Walk</term> <description>AOwk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BACKSTAB_DAMAGE, {1}, {2})"
		public extern void SetBackstabDamage_Owk3(int level, float backstabDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death Coil</term> <description>AUdc, ACdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_HEALED_DAMAGED_UDC1, {1})"
		public extern float GetAmountHealedDamaged_Udc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death Coil</term> <description>AUdc, ACdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_HEALED_DAMAGED_UDC1, {1}, {2})"
		public extern void SetAmountHealedDamaged_Udc1(int level, float amountHealedDamaged);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_CONVERTED_TO_MANA, {1})"
		public extern float GetLifeConvertedToMana_Udp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_CONVERTED_TO_MANA, {1}, {2})"
		public extern void SetLifeConvertedToMana_Udp1(int level, float lifeConvertedToMana);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_CONVERTED_TO_LIFE, {1})"
		public extern float GetLifeConvertedToLife_Udp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Ritual</term> <description>AUdr</description></item>
		/// <item><term>Death Pact</term> <description>AUdp</description></item>
		/// <item><term>Steal</term> <description>Aste</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_CONVERTED_TO_LIFE, {1}, {2})"
		public extern void SetLifeConvertedToLife_Udp2(int level, float lifeConvertedToLife);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_UAU1, {1})"
		public extern float GetMovementSpeedIncreasePercent_Uau1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_UAU1, {1}, {2})"
		public extern void SetMovementSpeedIncreasePercent_Uau1(int level, float movementSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_INCREASE_PERCENT, {1})"
		public extern float GetLifeRegenerationIncreasePercent_Uau2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unholy Aura</term> <description>AUau, AIau, ACua</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_INCREASE_PERCENT, {1}, {2})"
		public extern void SetLifeRegenerationIncreasePercent_Uau2(int level, float lifeRegenerationIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Evasion</term> <description>AEev, AIev, ACev, ACes</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_EVADE_EEV1, {1})"
		public extern float GetChanceToEvade_Eev1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Evasion</term> <description>AEev, AIev, ACev, ACes</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_EVADE_EEV1, {1}, {2})"
		public extern void SetChanceToEvade_Eev1(int level, float chanceToEvade);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_INTERVAL, {1})"
		public extern float GetDamagePerInterval_Eim1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_INTERVAL, {1}, {2})"
		public extern void SetDamagePerInterval_Eim1(int level, float damagePerInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_DRAINED_PER_SECOND_EIM2, {1})"
		public extern float GetManaDrainedPerSecond_Eim2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_DRAINED_PER_SECOND_EIM2, {1}, {2})"
		public extern void SetManaDrainedPerSecond_Eim2(int level, float manaDrainedPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUFFER_MANA_REQUIRED, {1})"
		public extern float GetBufferManaRequired_Eim3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Immolation</term> <description>AEim, ACim</description></item>
		/// <item><term>Permanent Immolation</term> <description>ANpi, Apig</description></item>
		/// <item><term>Phoenix Fire</term> <description>Apmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUFFER_MANA_REQUIRED, {1}, {2})"
		public extern void SetBufferManaRequired_Eim3(int level, float bufferManaRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED, {1})"
		public extern float GetMaxManaDrained_Emb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED, {1}, {2})"
		public extern void SetMaxManaDrained_Emb1(int level, float maxManaDrained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BOLT_DELAY, {1})"
		public extern float GetBoltDelay_Emb2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BOLT_DELAY, {1}, {2})"
		public extern void SetBoltDelay_Emb2(int level, float boltDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BOLT_LIFETIME, {1})"
		public extern float GetBoltLifetime_Emb3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Burn</term> <description>AEmb, Amnb, Ambd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BOLT_LIFETIME, {1}, {2})"
		public extern void SetBoltLifetime_Emb3(int level, float boltLifetime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ALTITUDE_ADJUSTMENT_DURATION, {1})"
		public extern float GetAltitudeAdjustmentDuration_Eme3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ALTITUDE_ADJUSTMENT_DURATION, {1}, {2})"
		public extern void SetAltitudeAdjustmentDuration_Eme3(int level, float altitudeAdjustmentDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LANDING_DELAY_TIME, {1})"
		public extern float GetLandingDelayTime_Eme4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LANDING_DELAY_TIME, {1}, {2})"
		public extern void SetLandingDelayTime_Eme4(int level, float landingDelayTime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ALTERNATE_FORM_HIT_POINT_BONUS, {1})"
		public extern float GetAlternateFormHitPointBonus_Eme5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ALTERNATE_FORM_HIT_POINT_BONUS, {1}, {2})"
		public extern void SetAlternateFormHitPointBonus_Eme5(int level, float alternateFormHitPointBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_INFO_PANEL_ONLY, {1})"
		public extern float GetMoveSpeedBonusInfoPanelOnly_Ncr5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_INFO_PANEL_ONLY, {1}, {2})"
		public extern void SetMoveSpeedBonusInfoPanelOnly_Ncr5(int level, float moveSpeedBonusInfoPanelOnly);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_BONUS_INFO_PANEL_ONLY, {1})"
		public extern float GetAttackSpeedBonusInfoPanelOnly_Ncr6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_BONUS_INFO_PANEL_ONLY, {1}, {2})"
		public extern void SetAttackSpeedBonusInfoPanelOnly_Ncr6(int level, float attackSpeedBonusInfoPanelOnly);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_RATE_PER_SECOND, {1})"
		public extern float GetLifeRegenerationRatePerSecond_ave5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_RATE_PER_SECOND, {1}, {2})"
		public extern void SetLifeRegenerationRatePerSecond_ave5(int level, float lifeRegenerationRatePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep</term> <description>AUsl, ACsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_STUN_DURATION_USL1, {1})"
		public extern float GetStunDuration_Usl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sleep</term> <description>AUsl, ACsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_STUN_DURATION_USL1, {1}, {2})"
		public extern void SetStunDuration_Usl1(int level, float stunDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Aura</term> <description>AUav, AIav, ACvp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_STOLEN_PERCENT, {1})"
		public extern float GetAttackDamageStolenPercent_Uav1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Aura</term> <description>AUav, AIav, ACvp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_STOLEN_PERCENT, {1}, {2})"
		public extern void SetAttackDamageStolenPercent_Uav1(int level, float attackDamageStolenPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_UCS1, {1})"
		public extern float GetDamage_Ucs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_UCS1, {1}, {2})"
		public extern void SetDamage_Ucs1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_UCS2, {1})"
		public extern float GetMaxDamage_Ucs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_UCS2, {1}, {2})"
		public extern void SetMaxDamage_Ucs2(int level, float maxDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DISTANCE_UCS3, {1})"
		public extern float GetDistance_Ucs3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DISTANCE_UCS3, {1}, {2})"
		public extern void SetDistance_Ucs3(int level, float distance);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_UCS4, {1})"
		public extern float GetFinalArea_Ucs4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// <item><term>Carrion Swarm</term> <description>AUcs, ACca</description></item>
		/// <item><term>Crushing Wave</term> <description>ACcv</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_UCS4, {1}, {2})"
		public extern void SetFinalArea_Ucs4(int level, float finalArea);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_UIN1, {1})"
		public extern float GetDamage_Uin1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_UIN1, {1}, {2})"
		public extern void SetDamage_Uin1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DURATION, {1})"
		public extern float GetDuration_Uin2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DURATION, {1}, {2})"
		public extern void SetDuration_Uin2(int level, float duration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_IMPACT_DELAY, {1})"
		public extern float GetImpactDelay_Uin3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inferno</term> <description>AUin, ANin, SNin, AIin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_IMPACT_DELAY, {1}, {2})"
		public extern void SetImpactDelay_Uin3(int level, float impactDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_TARGET_OCL1, {1})"
		public extern float GetDamagePerTarget_Ocl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Forked Lightning</term> <description>ANfl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_TARGET_OCL1, {1}, {2})"
		public extern void SetDamagePerTarget_Ocl1(int level, float damagePerTarget);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_PER_TARGET, {1})"
		public extern float GetDamageReductionPerTarget_Ocl3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Chain Lightning</term> <description>AOcl, ACcl</description></item>
		/// <item><term>Healing Wave</term> <description>AOhw, AChv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_PER_TARGET, {1}, {2})"
		public extern void SetDamageReductionPerTarget_Ocl3(int level, float damageReductionPerTarget);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DELAY_OEQ1, {1})"
		public extern float GetEffectDelay_Oeq1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DELAY_OEQ1, {1}, {2})"
		public extern void SetEffectDelay_Oeq1(int level, float effectDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_TO_BUILDINGS, {1})"
		public extern float GetDamagePerSecondToBuildings_Oeq2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_TO_BUILDINGS, {1}, {2})"
		public extern void SetDamagePerSecondToBuildings_Oeq2(int level, float damagePerSecondToBuildings);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNITS_SLOWED_PERCENT, {1})"
		public extern float GetUnitsSlowedPercent_Oeq3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNITS_SLOWED_PERCENT, {1}, {2})"
		public extern void SetUnitsSlowedPercent_Oeq3(int level, float unitsSlowedPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_OEQ4, {1})"
		public extern float GetFinalArea_Oeq4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Earthquake</term> <description>AOeq, SNeq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_OEQ4, {1}, {2})"
		public extern void SetFinalArea_Oeq4(int level, float finalArea);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangling Roots</term> <description>AEer, Aenr, Aenw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_EER1, {1})"
		public extern float GetDamagePerSecond_Eer1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangling Roots</term> <description>AEer, Aenr, Aenw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_EER1, {1}, {2})"
		public extern void SetDamagePerSecond_Eer1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thorns Aura</term> <description>AEah</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_TO_ATTACKERS, {1})"
		public extern float GetDamageDealtToAttackers_Eah1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thorns Aura</term> <description>AEah</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_TO_ATTACKERS, {1}, {2})"
		public extern void SetDamageDealtToAttackers_Eah1(int level, float damageDealtToAttackers);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_HEALED, {1})"
		public extern float GetLifeHealed_Etq1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_HEALED, {1}, {2})"
		public extern void SetLifeHealed_Etq1(int level, float lifeHealed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HEAL_INTERVAL, {1})"
		public extern float GetHealInterval_Etq2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HEAL_INTERVAL, {1}, {2})"
		public extern void SetHealInterval_Etq2(int level, float healInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_ETQ3, {1})"
		public extern float GetBuildingReduction_Etq3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_ETQ3, {1}, {2})"
		public extern void SetBuildingReduction_Etq3(int level, float buildingReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_IMMUNITY_DURATION, {1})"
		public extern float GetInitialImmunityDuration_Etq4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tranquility</term> <description>AEtq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_IMMUNITY_DURATION, {1}, {2})"
		public extern void SetInitialImmunityDuration_Etq4(int level, float initialImmunityDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death And Decay</term> <description>AUdd, SNdd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_LIFE_DRAINED_PER_SECOND_PERCENT, {1})"
		public extern float GetMaxLifeDrainedPerSecondPercent_Udd1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death And Decay</term> <description>AUdd, SNdd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_LIFE_DRAINED_PER_SECOND_PERCENT, {1}, {2})"
		public extern void SetMaxLifeDrainedPerSecondPercent_Udd1(int level, float maxLifeDrainedPerSecondPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death And Decay</term> <description>AUdd, SNdd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_UDD2, {1})"
		public extern float GetBuildingReduction_Udd2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Death And Decay</term> <description>AUdd, SNdd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_UDD2, {1}, {2})"
		public extern void SetBuildingReduction_Udd2(int level, float buildingReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Armor</term> <description>AUfa, AUfu, ACfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_DURATION, {1})"
		public extern float GetArmorDuration_Ufa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Armor</term> <description>AUfa, AUfu, ACfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_DURATION, {1}, {2})"
		public extern void SetArmorDuration_Ufa1(int level, float armorDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Armor</term> <description>AUfa, AUfu, ACfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_BONUS_UFA2, {1})"
		public extern float GetArmorBonus_Ufa2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Armor</term> <description>AUfa, AUfu, ACfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_BONUS_UFA2, {1}, {2})"
		public extern void SetArmorBonus_Ufa2(int level, float armorBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Nova</term> <description>AUfn, ACfn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AREA_OF_EFFECT_DAMAGE, {1})"
		public extern float GetAreaOfEffectDamage_Ufn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Nova</term> <description>AUfn, ACfn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AREA_OF_EFFECT_DAMAGE, {1}, {2})"
		public extern void SetAreaOfEffectDamage_Ufn1(int level, float areaOfEffectDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Nova</term> <description>AUfn, ACfn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_UFN2, {1})"
		public extern float GetSpecificTargetDamage_Ufn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Frost Nova</term> <description>AUfn, ACfn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_UFN2, {1}, {2})"
		public extern void SetSpecificTargetDamage_Ufn2(int level, float specificTargetDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Searing Arrows</term> <description>AHfa, ACsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HFA1, {1})"
		public extern float GetDamageBonus_Hfa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Searing Arrows</term> <description>AHfa, ACsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HFA1, {1}, {2})"
		public extern void SetDamageBonus_Hfa1(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_ESF1, {1})"
		public extern float GetDamageDealt_Esf1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_ESF1, {1}, {2})"
		public extern void SetDamageDealt_Esf1(int level, float damageDealt);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_ESF2, {1})"
		public extern float GetDamageInterval_Esf2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_ESF2, {1}, {2})"
		public extern void SetDamageInterval_Esf2(int level, float damageInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_ESF3, {1})"
		public extern float GetBuildingReduction_Esf3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monsoon</term> <description>ANmo, ACmo</description></item>
		/// <item><term>Starfall</term> <description>AEsf, AEsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_ESF3, {1}, {2})"
		public extern void SetBuildingReduction_Esf3(int level, float buildingReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_PERCENT, {1})"
		public extern float GetDamageBonusPercent_Ear1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Trueshot Aura</term> <description>AEar, AIar, ACat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_PERCENT, {1}, {2})"
		public extern void SetDamageBonusPercent_Ear1(int level, float damageBonusPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEFENSE_BONUS_HAV1, {1})"
		public extern float GetDefenseBonus_Hav1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEFENSE_BONUS_HAV1, {1}, {2})"
		public extern void SetDefenseBonus_Hav1(int level, float defenseBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINT_BONUS, {1})"
		public extern float GetHitPointBonus_Hav2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINT_BONUS, {1}, {2})"
		public extern void SetHitPointBonus_Hav2(int level, float hitPointBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HAV3, {1})"
		public extern float GetDamageBonus_Hav3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HAV3, {1}, {2})"
		public extern void SetDamageBonus_Hav3(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_HAV4, {1})"
		public extern float GetMagicDamageReduction_Hav4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Avatar</term> <description>AHav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_HAV4, {1}, {2})"
		public extern void SetMagicDamageReduction_Hav4(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_BASH, {1})"
		public extern float GetChanceToBash_Hbh1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_BASH, {1}, {2})"
		public extern void SetChanceToBash_Hbh1(int level, float chanceToBash);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_HBH2, {1})"
		public extern float GetDamageMultiplier_Hbh2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_HBH2, {1}, {2})"
		public extern void SetDamageMultiplier_Hbh2(int level, float damageMultiplier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HBH3, {1})"
		public extern float GetDamageBonus_Hbh3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_HBH3, {1}, {2})"
		public extern void SetDamageBonus_Hbh3(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_HBH4, {1})"
		public extern float GetChanceToMiss_Hbh4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bash</term> <description>AHbh, ACbh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_HBH4, {1}, {2})"
		public extern void SetChanceToMiss_Hbh4(int level, float chanceToMiss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Firebolt</term> <description>ANfb, Awfb, ACfb</description></item>
		/// <item><term>Frost Bolt</term> <description>ACcb</description></item>
		/// <item><term>Storm Bolt</term> <description>AHtb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_HTB1, {1})"
		public extern float GetDamage_Htb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Firebolt</term> <description>ANfb, Awfb, ACfb</description></item>
		/// <item><term>Frost Bolt</term> <description>ACcb</description></item>
		/// <item><term>Storm Bolt</term> <description>AHtb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_HTB1, {1}, {2})"
		public extern void SetDamage_Htb1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AOE_DAMAGE, {1})"
		public extern float GetAoeDamage_Htc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AOE_DAMAGE, {1}, {2})"
		public extern void SetAoeDamage_Htc1(int level, float aoeDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_HTC2, {1})"
		public extern float GetSpecificTargetDamage_Htc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPECIFIC_TARGET_DAMAGE_HTC2, {1}, {2})"
		public extern void SetSpecificTargetDamage_Htc2(int level, float specificTargetDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HTC3, {1})"
		public extern float GetMovementSpeedReductionPercent_Htc3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HTC3, {1}, {2})"
		public extern void SetMovementSpeedReductionPercent_Htc3(int level, float movementSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HTC4, {1})"
		public extern float GetAttackSpeedReductionPercent_Htc4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Thunder Clap</term> <description>AHtc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HTC4, {1}, {2})"
		public extern void SetAttackSpeedReductionPercent_Htc4(int level, float attackSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devotion Aura</term> <description>AHad, AIad, ACav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_BONUS_HAD1, {1})"
		public extern float GetArmorBonus_Had1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devotion Aura</term> <description>AHad, AIad, ACav</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ARMOR_BONUS_HAD1, {1}, {2})"
		public extern void SetArmorBonus_Had1(int level, float armorBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Holy Light</term> <description>AHhb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_HEALED_DAMAGED_HHB1, {1})"
		public extern float GetAmountHealedDamaged_Hhb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Holy Light</term> <description>AHhb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_HEALED_DAMAGED_HHB1, {1}, {2})"
		public extern void SetAmountHealedDamaged_Hhb1(int level, float amountHealedDamaged);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_HCA1, {1})"
		public extern float GetExtraDamage_Hca1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_HCA1, {1}, {2})"
		public extern void SetExtraDamage_Hca1(int level, float extraDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_HCA2, {1})"
		public extern float GetMovementSpeedFactor_Hca2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_HCA2, {1}, {2})"
		public extern void SetMovementSpeedFactor_Hca2(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_HCA3, {1})"
		public extern float GetAttackSpeedFactor_Hca3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cold Arrows</term> <description>AHca, ACcw</description></item>
		/// <item><term>Frost Arrows</term> <description>ANfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_HCA3, {1}, {2})"
		public extern void SetAttackSpeedFactor_Hca3(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Endurance Aura</term> <description>AOae, AIae, SCae</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OAE1, {1})"
		public extern float GetMovementSpeedIncreasePercent_Oae1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Endurance Aura</term> <description>AOae, AIae, SCae</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_OAE1, {1}, {2})"
		public extern void SetMovementSpeedIncreasePercent_Oae1(int level, float movementSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Endurance Aura</term> <description>AOae, AIae, SCae</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_OAE2, {1})"
		public extern float GetAttackSpeedIncreasePercent_Oae2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Endurance Aura</term> <description>AOae, AIae, SCae</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_OAE2, {1}, {2})"
		public extern void SetAttackSpeedIncreasePercent_Oae2(int level, float attackSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Reincarnation</term> <description>AOre, ACrn, ANrn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_REINCARNATION_DELAY, {1})"
		public extern float GetReincarnationDelay_Ore1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Reincarnation</term> <description>AOre, ACrn, ANrn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_REINCARNATION_DELAY, {1}, {2})"
		public extern void SetReincarnationDelay_Ore1(int level, float reincarnationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_OSH1, {1})"
		public extern float GetDamage_Osh1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_OSH1, {1}, {2})"
		public extern void SetDamage_Osh1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_OSH2, {1})"
		public extern float GetMaximumDamage_Osh2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_OSH2, {1}, {2})"
		public extern void SetMaximumDamage_Osh2(int level, float maximumDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DISTANCE_OSH3, {1})"
		public extern float GetDistance_Osh3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DISTANCE_OSH3, {1}, {2})"
		public extern void SetDistance_Osh3(int level, float distance);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_OSH4, {1})"
		public extern float GetFinalArea_Osh4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shockwave</term> <description>AOsh, ACsh, ACst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FINAL_AREA_OSH4, {1}, {2})"
		public extern void SetFinalArea_Osh4(int level, float finalArea);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DELAY_NFD1, {1})"
		public extern float GetGraphicDelay_Nfd1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DELAY_NFD1, {1}, {2})"
		public extern void SetGraphicDelay_Nfd1(int level, float graphicDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DURATION_NFD2, {1})"
		public extern float GetGraphicDuration_Nfd2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DURATION_NFD2, {1}, {2})"
		public extern void SetGraphicDuration_Nfd2(int level, float graphicDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_NFD3, {1})"
		public extern float GetDamage_Nfd3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Finger of Death</term> <description>ANfd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_NFD3, {1}, {2})"
		public extern void SetDamage_Nfd3(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_AMS1, {1})"
		public extern float GetSummonedUnitDamage_Ams1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_AMS1, {1}, {2})"
		public extern void SetSummonedUnitDamage_Ams1(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_AMS2, {1})"
		public extern float GetMagicDamageReduction_Ams2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Anti-magic Shell</term> <description>Aams, ACam</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_AMS2, {1}, {2})"
		public extern void SetMagicDamageReduction_Ams2(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AURA_DURATION, {1})"
		public extern float GetAuraDuration_Apl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AURA_DURATION, {1}, {2})"
		public extern void SetAuraDuration_Apl1(int level, float auraDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_APL2, {1})"
		public extern float GetDamagePerSecond_Apl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_APL2, {1}, {2})"
		public extern void SetDamagePerSecond_Apl2(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_OF_PLAGUE_WARD, {1})"
		public extern float GetDurationOfPlagueWard_Apl3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Disease Cloud</term> <description>Aapl, Aap1, Aap2, Aap3, Aap4</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_OF_PLAGUE_WARD, {1}, {2})"
		public extern void SetDurationOfPlagueWard_Apl3(int level, float durationOfPlagueWard);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aura of Blight</term> <description>Aabr</description></item>
		/// <item><term>Healing Ward Aura</term> <description>Aoar</description></item>
		/// <item><term>Life Regeneration Aura</term> <description>ACnr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_OF_HIT_POINTS_REGENERATED, {1})"
		public extern float GetAmountOfHitPointsRegenerated_Oar1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aura of Blight</term> <description>Aabr</description></item>
		/// <item><term>Healing Ward Aura</term> <description>Aoar</description></item>
		/// <item><term>Life Regeneration Aura</term> <description>ACnr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_OF_HIT_POINTS_REGENERATED, {1}, {2})"
		public extern void SetAmountOfHitPointsRegenerated_Oar1(int level, float amountOfHitPointsRegenerated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_INCREASE_AKB1, {1})"
		public extern float GetAttackDamageIncrease_Akb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Drums</term> <description>Aakb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_INCREASE_AKB1, {1}, {2})"
		public extern void SetAttackDamageIncrease_Akb1(int level, float attackDamageIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Abolish Magic</term> <description>Aadm, ACdm</description></item>
		/// <item><term>Disenchant</term> <description>Adch</description></item>
		/// <item><term>Dispel Magic</term> <description>Adis, Adsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_ADM1, {1})"
		public extern float GetManaLoss_Adm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Abolish Magic</term> <description>Aadm, ACdm</description></item>
		/// <item><term>Disenchant</term> <description>Adch</description></item>
		/// <item><term>Dispel Magic</term> <description>Adis, Adsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_ADM1, {1}, {2})"
		public extern void SetManaLoss_Adm1(int level, float manaLoss);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Abolish Magic</term> <description>Aadm, ACdm</description></item>
		/// <item><term>Disenchant</term> <description>Adch</description></item>
		/// <item><term>Dispel Magic</term> <description>Adis, Adsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_ADM2, {1})"
		public extern float GetSummonedUnitDamage_Adm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Abolish Magic</term> <description>Aadm, ACdm</description></item>
		/// <item><term>Disenchant</term> <description>Adch</description></item>
		/// <item><term>Dispel Magic</term> <description>Adis, Adsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_ADM2, {1}, {2})"
		public extern void SetSummonedUnitDamage_Adm2(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blight Dispel Large</term> <description>Abdl</description></item>
		/// <item><term>Blight Dispel Small</term> <description>Abds</description></item>
		/// <item><term>Blight Growth Large</term> <description>Abgl</description></item>
		/// <item><term>Blight Growth Small</term> <description>Abgs</description></item>
		/// <item><term>Blight Placement</term> <description>Ablp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EXPANSION_AMOUNT, {1})"
		public extern float GetExpansionAmount_Bli1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blight Dispel Large</term> <description>Abdl</description></item>
		/// <item><term>Blight Dispel Small</term> <description>Abds</description></item>
		/// <item><term>Blight Growth Large</term> <description>Abgl</description></item>
		/// <item><term>Blight Growth Small</term> <description>Abgs</description></item>
		/// <item><term>Blight Placement</term> <description>Ablp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EXPANSION_AMOUNT, {1}, {2})"
		public extern void SetExpansionAmount_Bli1(int level, float expansionAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_DURATION_BGM2, {1})"
		public extern float GetIntervalDuration_Bgm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_DURATION_BGM2, {1}, {2})"
		public extern void SetIntervalDuration_Bgm2(int level, float intervalDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_MINING_RING, {1})"
		public extern float GetRadiusOfMiningRing_Bgm4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blighted Gold Mine Ability</term> <description>Abgm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_MINING_RING, {1}, {2})"
		public extern void SetRadiusOfMiningRing_Bgm4(int level, float radiusOfMiningRing);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_BLO1, {1})"
		public extern float GetAttackSpeedIncreasePercent_Blo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_PERCENT_BLO1, {1}, {2})"
		public extern void SetAttackSpeedIncreasePercent_Blo1(int level, float attackSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_BLO2, {1})"
		public extern float GetMovementSpeedIncreasePercent_Blo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_PERCENT_BLO2, {1}, {2})"
		public extern void SetMovementSpeedIncreasePercent_Blo2(int level, float movementSpeedIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SCALING_FACTOR, {1})"
		public extern float GetScalingFactor_Blo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bloodlust</term> <description>Ablo, ACbl</description></item>
		/// <item><term>Frenzy</term> <description>Afzy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SCALING_FACTOR, {1}, {2})"
		public extern void SetScalingFactor_Blo3(int level, float scalingFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cannibalize</term> <description>Acan, ACcn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_PER_SECOND_CAN1, {1})"
		public extern float GetHitPointsPerSecond_Can1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cannibalize</term> <description>Acan, ACcn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_PER_SECOND_CAN1, {1}, {2})"
		public extern void SetHitPointsPerSecond_Can1(int level, float hitPointsPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cannibalize</term> <description>Acan, ACcn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_HIT_POINTS, {1})"
		public extern float GetMaxHitPoints_Can2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cannibalize</term> <description>Acan, ACcn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_HIT_POINTS, {1}, {2})"
		public extern void SetMaxHitPoints_Can2(int level, float maxHitPoints);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_DEV2, {1})"
		public extern float GetDamagePerSecond_Dev2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Cargo</term> <description>Advc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_DEV2, {1}, {2})"
		public extern void SetDamagePerSecond_Dev2(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_UPDATE_FREQUENCY_CHD1, {1})"
		public extern float GetMovementUpdateFrequency_Chd1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_UPDATE_FREQUENCY_CHD1, {1}, {2})"
		public extern void SetMovementUpdateFrequency_Chd1(int level, float movementUpdateFrequency);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_UPDATE_FREQUENCY_CHD2, {1})"
		public extern float GetAttackUpdateFrequency_Chd2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_UPDATE_FREQUENCY_CHD2, {1}, {2})"
		public extern void SetAttackUpdateFrequency_Chd2(int level, float attackUpdateFrequency);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_CHD3, {1})"
		public extern float GetSummonedUnitDamage_Chd3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cargo Hold Death</term> <description>Achd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_CHD3, {1}, {2})"
		public extern void SetSummonedUnitDamage_Chd3(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_CRI1, {1})"
		public extern float GetMovementSpeedReductionPercent_Cri1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_CRI1, {1}, {2})"
		public extern void SetMovementSpeedReductionPercent_Cri1(int level, float movementSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_CRI2, {1})"
		public extern float GetAttackSpeedReductionPercent_Cri2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_CRI2, {1}, {2})"
		public extern void SetAttackSpeedReductionPercent_Cri2(int level, float attackSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_CRI3, {1})"
		public extern float GetDamageReduction_Cri3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cripple</term> <description>Acri, Scri, ACcr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_CRI3, {1}, {2})"
		public extern void SetDamageReduction_Cri3(int level, float damageReduction);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_CRS, {1})"
		public extern float GetChanceToMissCrs_Crs1(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_CRS, {1}, {2})"
		public extern void SetChanceToMissCrs_Crs1(int level, float chanceToMissCrs);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_DDA1, {1})"
		public extern float GetFullDamageRadius_Dda1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_DDA1, {1}, {2})"
		public extern void SetFullDamageRadius_Dda1(int level, float fullDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_DDA2, {1})"
		public extern float GetFullDamageAmount_Dda2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_DDA2, {1}, {2})"
		public extern void SetFullDamageAmount_Dda2(int level, float fullDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_PARTIAL_DAMAGE_RADIUS, {1})"
		public extern float GetPartialDamageRadius_Dda3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_PARTIAL_DAMAGE_RADIUS, {1}, {2})"
		public extern void SetPartialDamageRadius_Dda3(int level, float partialDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_PARTIAL_DAMAGE_AMOUNT, {1})"
		public extern float GetPartialDamageAmount_Dda4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>AOE damage upon death</term> <description>Adda, Amnx, Amnz</description></item>
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_PARTIAL_DAMAGE_AMOUNT, {1}, {2})"
		public extern void SetPartialDamageAmount_Dda4(int level, float partialDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_SDS1, {1})"
		public extern float GetBuildingDamageFactor_Sds1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Kaboom!</term> <description>Asds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_SDS1, {1}, {2})"
		public extern void SetBuildingDamageFactor_Sds1(int level, float buildingDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_UCO5, {1})"
		public extern float GetMaxDamage_Uco5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_UCO5, {1}, {2})"
		public extern void SetMaxDamage_Uco5(int level, float maxDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_UCO6, {1})"
		public extern float GetMoveSpeedBonus_Uco6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Unstable Concoction</term> <description>Auco</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_UCO6, {1}, {2})"
		public extern void SetMoveSpeedBonus_Uco6(int level, float moveSpeedBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_PERCENT_DEF1, {1})"
		public extern float GetDamageTakenPercent_Def1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_PERCENT_DEF1, {1}, {2})"
		public extern void SetDamageTakenPercent_Def1(int level, float damageTakenPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_DEF2, {1})"
		public extern float GetDamageDealtPercent_Def2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_DEF2, {1}, {2})"
		public extern void SetDamageDealtPercent_Def2(int level, float damageDealtPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_DEF3, {1})"
		public extern float GetMovementSpeedFactor_Def3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_DEF3, {1}, {2})"
		public extern void SetMovementSpeedFactor_Def3(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_DEF4, {1})"
		public extern float GetAttackSpeedFactor_Def4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_DEF4, {1}, {2})"
		public extern void SetAttackSpeedFactor_Def4(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_DEF5, {1})"
		public extern float GetMagicDamageReduction_Def5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_DEF5, {1}, {2})"
		public extern void SetMagicDamageReduction_Def5(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_DEFLECT, {1})"
		public extern float GetChanceToDeflect_Def6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_DEFLECT, {1}, {2})"
		public extern void SetChanceToDeflect_Def6(int level, float chanceToDeflect);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_PIERCING, {1})"
		public extern float GetDeflectDamageTakenPiercing_Def7(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_PIERCING, {1}, {2})"
		public extern void SetDeflectDamageTakenPiercing_Def7(int level, float deflectDamageTakenPiercing);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_SPELLS, {1})"
		public extern float GetDeflectDamageTakenSpells_Def8(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Defend, Passive Defense</term> <description>AIdd</description></item>
		/// <item><term>Defend</term> <description>Adef</description></item>
		/// <item><term>Elune's Grace</term> <description>Aegr</description></item>
		/// <item><term>Magic Defense</term> <description>Amdf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEFLECT_DAMAGE_TAKEN_SPELLS, {1}, {2})"
		public extern void SetDeflectDamageTakenSpells_Def8(int level, float deflectDamageTakenSpells);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RIP_DELAY, {1})"
		public extern float GetRipDelay_Eat1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RIP_DELAY, {1}, {2})"
		public extern void SetRipDelay_Eat1(int level, float ripDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EAT_DELAY, {1})"
		public extern float GetEatDelay_Eat2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EAT_DELAY, {1}, {2})"
		public extern void SetEatDelay_Eat2(int level, float eatDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_EAT3, {1})"
		public extern float GetHitPointsGained_Eat3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Eat Tree</term> <description>Aeat</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_EAT3, {1}, {2})"
		public extern void SetHitPointsGained_Eat3(int level, float hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AIR_UNIT_LOWER_DURATION, {1})"
		public extern float GetAirUnitLowerDuration_Ens1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AIR_UNIT_LOWER_DURATION, {1}, {2})"
		public extern void SetAirUnitLowerDuration_Ens1(int level, float airUnitLowerDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AIR_UNIT_HEIGHT, {1})"
		public extern float GetAirUnitHeight_Ens2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AIR_UNIT_HEIGHT, {1}, {2})"
		public extern void SetAirUnitHeight_Ens2(int level, float airUnitHeight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MELEE_ATTACK_RANGE, {1})"
		public extern float GetMeleeAttackRange_Ens3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ensnare</term> <description>Aens, ACen</description></item>
		/// <item><term>Item Web</term> <description>AIwb</description></item>
		/// <item><term>Web</term> <description>Aweb, ACwb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MELEE_ATTACK_RANGE, {1}, {2})"
		public extern void SetMeleeAttackRange_Ens3(int level, float meleeAttackRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangled Gold Mine Ability</term> <description>Aegm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_DURATION_EGM2, {1})"
		public extern float GetIntervalDuration_Egm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Entangled Gold Mine Ability</term> <description>Aegm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_DURATION_EGM2, {1}, {2})"
		public extern void SetIntervalDuration_Egm2(int level, float intervalDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DELAY_FLA2, {1})"
		public extern float GetEffectDelay_Fla2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare</term> <description>Afla</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DELAY_FLA2, {1}, {2})"
		public extern void SetEffectDelay_Fla2(int level, float effectDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINING_DURATION, {1})"
		public extern float GetMiningDuration_Gld2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gold Mine ability</term> <description>Agld</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINING_DURATION, {1}, {2})"
		public extern void SetMiningDuration_Gld2(int level, float miningDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_GRAVESTONES, {1})"
		public extern float GetRadiusOfGravestones_Gyd2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_GRAVESTONES, {1}, {2})"
		public extern void SetRadiusOfGravestones_Gyd2(int level, float radiusOfGravestones);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_CORPSES, {1})"
		public extern float GetRadiusOfCorpses_Gyd3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Create Corpse</term> <description>Agyd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RADIUS_OF_CORPSES, {1}, {2})"
		public extern void SetRadiusOfCorpses_Gyd3(int level, float radiusOfCorpses);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Heal</term> <description>Ahea, Anh1, Anh2, Anhe</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_HEA1, {1})"
		public extern float GetHitPointsGained_Hea1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Heal</term> <description>Ahea, Anh1, Anh2, Anhe</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_HEA1, {1}, {2})"
		public extern void SetHitPointsGained_Hea1(int level, float hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE_PERCENT_INF1, {1})"
		public extern float GetDamageIncreasePercent_Inf1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE_PERCENT_INF1, {1}, {2})"
		public extern void SetDamageIncreasePercent_Inf1(int level, float damageIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AUTOCAST_RANGE, {1})"
		public extern float GetAutocastRange_Inf3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AUTOCAST_RANGE, {1}, {2})"
		public extern void SetAutocastRange_Inf3(int level, float autocastRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGEN_RATE, {1})"
		public extern float GetLifeRegenRate_Inf4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Inner Fire</term> <description>Ainf, ACif</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGEN_RATE, {1}, {2})"
		public extern void SetLifeRegenRate_Inf4(int level, float lifeRegenRate);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Attack</term> <description>Alit</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DELAY_LIT1, {1})"
		public extern float GetGraphicDelay_Lit1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Attack</term> <description>Alit</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DELAY_LIT1, {1}, {2})"
		public extern void SetGraphicDelay_Lit1(int level, float graphicDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Attack</term> <description>Alit</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DURATION_LIT2, {1})"
		public extern float GetGraphicDuration_Lit2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Attack</term> <description>Alit</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_GRAPHIC_DURATION_LIT2, {1}, {2})"
		public extern void SetGraphicDuration_Lit2(int level, float graphicDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Shield</term> <description>Alsh, ACls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_LSH1, {1})"
		public extern float GetDamagePerSecond_Lsh1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Shield</term> <description>Alsh, ACls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_LSH1, {1}, {2})"
		public extern void SetDamagePerSecond_Lsh1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_GAINED, {1})"
		public extern float GetManaGained_Mbt1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_GAINED, {1}, {2})"
		public extern void SetManaGained_Mbt1(int level, float manaGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_MBT2, {1})"
		public extern float GetHitPointsGained_Mbt2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_MBT2, {1}, {2})"
		public extern void SetHitPointsGained_Mbt2(int level, float hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AUTOCAST_REQUIREMENT, {1})"
		public extern float GetAutocastRequirement_Mbt3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AUTOCAST_REQUIREMENT, {1}, {2})"
		public extern void SetAutocastRequirement_Mbt3(int level, float autocastRequirement);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_WATER_HEIGHT, {1})"
		public extern float GetWaterHeight_Mbt4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish Mana and Life</term> <description>Ambt</description></item>
		/// <item><term>Replenish Mana</term> <description>Amb2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_WATER_HEIGHT, {1}, {2})"
		public extern void SetWaterHeight_Mbt4(int level, float waterHeight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mine - exploding</term> <description>Amin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_MIN1, {1})"
		public extern float GetActivationDelay_Min1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mine - exploding</term> <description>Amin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_MIN1, {1}, {2})"
		public extern void SetActivationDelay_Min1(int level, float activationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mine - exploding</term> <description>Amin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INVISIBILITY_TRANSITION_TIME, {1})"
		public extern float GetInvisibilityTransitionTime_Min2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mine - exploding</term> <description>Amin</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INVISIBILITY_TRANSITION_TIME, {1}, {2})"
		public extern void SetInvisibilityTransitionTime_Min2(int level, float invisibilityTransitionTime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_RADIUS, {1})"
		public extern float GetActivationRadius_Neu1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>"Shop Sharing, Allied Bldg."</term> <description>Aall</description></item>
		/// <item><term>Select Hero</term> <description>Aneu</description></item>
		/// <item><term>Select Unit</term> <description>Ane2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_RADIUS, {1}, {2})"
		public extern void SetActivationRadius_Neu1(int level, float activationRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Regeneration Aura</term> <description>Aarm</description></item>
		/// <item><term>Mana Regeneration, Life Regeneration Aura</term> <description>ANre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_REGENERATED, {1})"
		public extern float GetAmountRegenerated_Arm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Regeneration Aura</term> <description>Aarm</description></item>
		/// <item><term>Mana Regeneration, Life Regeneration Aura</term> <description>ANre</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AMOUNT_REGENERATED, {1}, {2})"
		public extern void SetAmountRegenerated_Arm1(int level, float amountRegenerated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_POI1, {1})"
		public extern float GetDamagePerSecond_Poi1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_POI1, {1}, {2})"
		public extern void SetDamagePerSecond_Poi1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_POI2, {1})"
		public extern float GetAttackSpeedFactor_Poi2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_POI2, {1}, {2})"
		public extern void SetAttackSpeedFactor_Poi2(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POI3, {1})"
		public extern float GetMovementSpeedFactor_Poi3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Envenomed Spears</term> <description>Aven</description></item>
		/// <item><term>Envenomed Weapons</term> <description>ACvs</description></item>
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// <item><term>Poison Sting</term> <description>Apoi, Apo2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POI3, {1}, {2})"
		public extern void SetMovementSpeedFactor_Poi3(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_POA1, {1})"
		public extern float GetExtraDamage_Poa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_POA1, {1}, {2})"
		public extern void SetExtraDamage_Poa1(int level, float extraDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_POA2, {1})"
		public extern float GetDamagePerSecond_Poa2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_POA2, {1}, {2})"
		public extern void SetDamagePerSecond_Poa2(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_POA3, {1})"
		public extern float GetAttackSpeedFactor_Poa3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Poison Arrows</term> <description>AEpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_POA3, {1}, {2})"
		public extern void SetAttackSpeedFactor_Poa3(int level, float attackSpeedFactor);

		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POA4, {1})"
		public extern float GetMovementSpeedFactorPoa4_(int level);
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_POA4, {1}, {2})"
		public extern void SetMovementSpeedFactorPoa4_(int level, float movementSpeedFactorPoa4);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMPLIFICATION, {1})"
		public extern float GetDamageAmplification_Pos2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Possession</term> <description>Aps2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMPLIFICATION, {1}, {2})"
		public extern void SetDamageAmplification_Pos2(int level, float damageAmplification);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_STOMP_PERCENT, {1})"
		public extern float GetChanceToStompPercent_War1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_STOMP_PERCENT, {1}, {2})"
		public extern void SetChanceToStompPercent_War1(int level, float chanceToStompPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_WAR2, {1})"
		public extern float GetDamageDealt_War2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_WAR2, {1}, {2})"
		public extern void SetDamageDealt_War2(int level, float damageDealt);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_WAR3, {1})"
		public extern float GetFullDamageRadius_War3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_WAR3, {1}, {2})"
		public extern void SetFullDamageRadius_War3(int level, float fullDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_RADIUS_WAR4, {1})"
		public extern float GetHalfDamageRadius_War4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pulverize,Pulverize</term> <description>Awar</description></item>
		/// <item><term>Pulverize</term> <description>ACpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_RADIUS_WAR4, {1}, {2})"
		public extern void SetHalfDamageRadius_War4(int level, float halfDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_PRG3, {1})"
		public extern float GetSummonedUnitDamage_Prg3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_PRG3, {1}, {2})"
		public extern void SetSummonedUnitDamage_Prg3(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_PAUSE_DURATION, {1})"
		public extern float GetUnitPauseDuration_Prg4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_PAUSE_DURATION, {1}, {2})"
		public extern void SetUnitPauseDuration_Prg4(int level, float unitPauseDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HERO_PAUSE_DURATION, {1})"
		public extern float GetHeroPauseDuration_Prg5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Purge</term> <description>AIlp, AIpg</description></item>
		/// <item><term>Purge</term> <description>Aprg, ACpu</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HERO_PAUSE_DURATION, {1}, {2})"
		public extern void SetHeroPauseDuration_Prg5(int level, float heroPauseDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_REJ1, {1})"
		public extern float GetHitPointsGained_Rej1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_GAINED_REJ1, {1}, {2})"
		public extern void SetHitPointsGained_Rej1(int level, float hitPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_POINTS_GAINED_REJ2, {1})"
		public extern float GetManaPointsGained_Rej2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rejuvenation</term> <description>Arej, ACrj, ACr2</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_POINTS_GAINED_REJ2, {1}, {2})"
		public extern void SetManaPointsGained_Rej2(int level, float manaPointsGained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_LIFE_REQUIRED, {1})"
		public extern float GetMinimumLifeRequired_Rpb3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Essence of Blight</term> <description>Arpl</description></item>
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_LIFE_REQUIRED, {1}, {2})"
		public extern void SetMinimumLifeRequired_Rpb3(int level, float minimumLifeRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_MANA_REQUIRED, {1})"
		public extern float GetMinimumManaRequired_Rpb4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Replenish</term> <description>Arpb</description></item>
		/// <item><term>Spirit Touch</term> <description>Arpm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_MANA_REQUIRED, {1}, {2})"
		public extern void SetMinimumManaRequired_Rpb4(int level, float minimumManaRequired);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_REPAIR_COST_RATIO, {1})"
		public extern float GetRepairCostRatio_Rep1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_REPAIR_COST_RATIO, {1}, {2})"
		public extern void SetRepairCostRatio_Rep1(int level, float repairCostRatio);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_REPAIR_TIME_RATIO, {1})"
		public extern float GetRepairTimeRatio_Rep2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_REPAIR_TIME_RATIO, {1}, {2})"
		public extern void SetRepairTimeRatio_Rep2(int level, float repairTimeRatio);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_POWERBUILD_COST, {1})"
		public extern float GetPowerbuildCost_Rep3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_POWERBUILD_COST, {1}, {2})"
		public extern void SetPowerbuildCost_Rep3(int level, float powerbuildCost);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_POWERBUILD_RATE, {1})"
		public extern float GetPowerbuildRate_Rep4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_POWERBUILD_RATE, {1}, {2})"
		public extern void SetPowerbuildRate_Rep4(int level, float powerbuildRate);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_NAVAL_RANGE_BONUS, {1})"
		public extern float GetNavalRangeBonus_Rep5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Renew</term> <description>Aren</description></item>
		/// <item><term>Repair</term> <description>Ahrp, Arep</description></item>
		/// <item><term>Restore</term> <description>Arst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_NAVAL_RANGE_BONUS, {1}, {2})"
		public extern void SetNavalRangeBonus_Rep5(int level, float navalRangeBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE_PERCENT_ROA1, {1})"
		public extern float GetDamageIncreasePercent_Roa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE_PERCENT_ROA1, {1}, {2})"
		public extern void SetDamageIncreasePercent_Roa1(int level, float damageIncreasePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_RATE, {1})"
		public extern float GetLifeRegenerationRate_Roa3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATION_RATE, {1}, {2})"
		public extern void SetLifeRegenerationRate_Roa3(int level, float lifeRegenerationRate);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGEN, {1})"
		public extern float GetManaRegen_Roa4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// <item><term>Howl of Terror</term> <description>ANht</description></item>
		/// <item><term>Roar</term> <description>Aroa, Ara2, ACro, ACr1, AIrr</description></item>
		/// <item><term>Summoning Ritual</term> <description>Ahnl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGEN, {1}, {2})"
		public extern void SetManaRegen_Roa4(int level, float manaRegen);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE, {1})"
		public extern float GetDamageIncrease_Nbr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Battle Roar</term> <description>ANbr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INCREASE, {1}, {2})"
		public extern void SetDamageIncrease_Nbr1(int level, float damageIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pillage</term> <description>Asal</description></item>
		/// <item><term>Unsummon Building</term> <description>Auns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SALVAGE_COST_RATIO, {1})"
		public extern float GetSalvageCostRatio_Sal1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pillage</term> <description>Asal</description></item>
		/// <item><term>Unsummon Building</term> <description>Auns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SALVAGE_COST_RATIO, {1}, {2})"
		public extern void SetSalvageCostRatio_Sal1(int level, float salvageCostRatio);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_IN_FLIGHT_SIGHT_RADIUS, {1})"
		public extern float GetInFlightSightRadius_Esn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_IN_FLIGHT_SIGHT_RADIUS, {1}, {2})"
		public extern void SetInFlightSightRadius_Esn1(int level, float inFlightSightRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HOVERING_SIGHT_RADIUS, {1})"
		public extern float GetHoveringSightRadius_Esn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HOVERING_SIGHT_RADIUS, {1}, {2})"
		public extern void SetHoveringSightRadius_Esn2(int level, float hoveringSightRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HOVERING_HEIGHT, {1})"
		public extern float GetHoveringHeight_Esn3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HOVERING_HEIGHT, {1}, {2})"
		public extern void SetHoveringHeight_Esn3(int level, float hoveringHeight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_OF_OWLS, {1})"
		public extern float GetDurationOfOwls_Esn5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Sentinel</term> <description>Aesn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DURATION_OF_OWLS, {1}, {2})"
		public extern void SetDurationOfOwls_Esn5(int level, float durationOfOwls);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FADE_DURATION, {1})"
		public extern float GetFadeDuration_Shm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FADE_DURATION, {1}, {2})"
		public extern void SetFadeDuration_Shm1(int level, float fadeDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAY_NIGHT_DURATION, {1})"
		public extern float GetDayNightDuration_Shm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAY_NIGHT_DURATION, {1}, {2})"
		public extern void SetDayNightDuration_Shm2(int level, float dayNightDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ACTION_DURATION, {1})"
		public extern float GetActionDuration_Shm3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Meld (Item)</term> <description>AIhm</description></item>
		/// <item><term>Shadow Meld</term> <description>Ashm, Sshm, Ahid</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ACTION_DURATION, {1}, {2})"
		public extern void SetActionDuration_Shm3(int level, float actionDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SLO1, {1})"
		public extern float GetMovementSpeedFactor_Slo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SLO1, {1}, {2})"
		public extern void SetMovementSpeedFactor_Slo1(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_SLO2, {1})"
		public extern float GetAttackSpeedFactor_Slo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Slow</term> <description>AIos</description></item>
		/// <item><term>Slow Aura</term> <description>Aasl</description></item>
		/// <item><term>Slow</term> <description>Aslo, ACsw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_SLO2, {1}, {2})"
		public extern void SetAttackSpeedFactor_Slo2(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_SPO1, {1})"
		public extern float GetDamagePerSecond_Spo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_SPO1, {1}, {2})"
		public extern void SetDamagePerSecond_Spo1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SPO2, {1})"
		public extern float GetMovementSpeedFactor_Spo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_SPO2, {1}, {2})"
		public extern void SetMovementSpeedFactor_Spo2(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_SPO3, {1})"
		public extern float GetAttackSpeedFactor_Spo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slow Poison</term> <description>Aspo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_SPO3, {1}, {2})"
		public extern void SetAttackSpeedFactor_Spo3(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_STA1, {1})"
		public extern float GetActivationDelay_Sta1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_STA1, {1}, {2})"
		public extern void SetActivationDelay_Sta1(int level, float activationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DETECTION_RADIUS_STA2, {1})"
		public extern float GetDetectionRadius_Sta2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DETECTION_RADIUS_STA2, {1}, {2})"
		public extern void SetDetectionRadius_Sta2(int level, float detectionRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DETONATION_RADIUS, {1})"
		public extern float GetDetonationRadius_Sta3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DETONATION_RADIUS, {1}, {2})"
		public extern void SetDetonationRadius_Sta3(int level, float detonationRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_STUN_DURATION_STA4, {1})"
		public extern float GetStunDuration_Sta4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stasis Trap</term> <description>Asta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_STUN_DURATION_STA4, {1}, {2})"
		public extern void SetStunDuration_Sta4(int level, float stunDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Unholy Frenzy</term> <description>Auhf, Suhf, ACuf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_BONUS_PERCENT, {1})"
		public extern float GetAttackSpeedBonusPercent_Uhf1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Unholy Frenzy</term> <description>Auhf, Suhf, ACuf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_BONUS_PERCENT, {1}, {2})"
		public extern void SetAttackSpeedBonusPercent_Uhf1(int level, float attackSpeedBonusPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Unholy Frenzy</term> <description>Auhf, Suhf, ACuf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_UHF2, {1})"
		public extern float GetDamagePerSecond_Uhf2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incite Unholy Frenzy</term> <description>Auuf</description></item>
		/// <item><term>Unholy Frenzy</term> <description>Auhf, Suhf, ACuf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_UHF2, {1}, {2})"
		public extern void SetDamagePerSecond_Uhf2(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LUMBER_PER_INTERVAL, {1})"
		public extern float GetLumberPerInterval_Wha1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LUMBER_PER_INTERVAL, {1}, {2})"
		public extern void SetLumberPerInterval_Wha1(int level, float lumberPerInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ART_ATTACHMENT_HEIGHT, {1})"
		public extern float GetArtAttachmentHeight_Wha3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Gather</term> <description>Awha, Awh2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ART_ATTACHMENT_HEIGHT, {1}, {2})"
		public extern void SetArtAttachmentHeight_Wha3(int level, float artAttachmentHeight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Waygate ability</term> <description>Awrp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_TELEPORT_AREA_WIDTH, {1})"
		public extern float GetTeleportAreaWidth_Wrp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Waygate ability</term> <description>Awrp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_TELEPORT_AREA_WIDTH, {1}, {2})"
		public extern void SetTeleportAreaWidth_Wrp1(int level, float teleportAreaWidth);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Waygate ability</term> <description>Awrp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_TELEPORT_AREA_HEIGHT, {1})"
		public extern float GetTeleportAreaHeight_Wrp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Waygate ability</term> <description>Awrp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_TELEPORT_AREA_HEIGHT, {1}, {2})"
		public extern void SetTeleportAreaHeight_Wrp2(int level, float teleportAreaHeight);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Steal</term> <description>AIva</description></item>
		/// <item><term>Life Steal</term> <description>SCva</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_STOLEN_PER_ATTACK, {1})"
		public extern float GetLifeStolenPerAttack_Ivam(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Life Steal</term> <description>AIva</description></item>
		/// <item><term>Life Steal</term> <description>SCva</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_STOLEN_PER_ATTACK, {1}, {2})"
		public extern void SetLifeStolenPerAttack_Ivam(int level, float lifeStolenPerAttack);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Fire Bonus</term> <description>AIfb</description></item>
		/// <item><term>Item Attack Frost Bonus</term> <description>AIob</description></item>
		/// <item><term>Item Attack Heal Reduction Bonus</term> <description>AIf2</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// <item><term>Item Freeze Damage Bonus</term> <description>AIzb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_IDAM, {1})"
		public extern float GetDamageBonus_Idam(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Fire Bonus</term> <description>AIfb</description></item>
		/// <item><term>Item Attack Frost Bonus</term> <description>AIob</description></item>
		/// <item><term>Item Attack Heal Reduction Bonus</term> <description>AIf2</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Lightning Bonus</term> <description>AIlb</description></item>
		/// <item><term>Item Attack Poison Bonus</term> <description>AIpb</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// <item><term>Item Freeze Damage Bonus</term> <description>AIzb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_IDAM, {1}, {2})"
		public extern void SetDamageBonus_Idam(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_UNITS_PERCENT, {1})"
		public extern float GetChanceToHitUnitsPercent_Iob2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_UNITS_PERCENT, {1}, {2})"
		public extern void SetChanceToHitUnitsPercent_Iob2(int level, float chanceToHitUnitsPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_HEROS_PERCENT, {1})"
		public extern float GetChanceToHitHerosPercent_Iob3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_HEROS_PERCENT, {1}, {2})"
		public extern void SetChanceToHitHerosPercent_Iob3(int level, float chanceToHitHerosPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_SUMMONS_PERCENT, {1})"
		public extern float GetChanceToHitSummonsPercent_Iob4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Black Arrow Bonus</term> <description>AIdf</description></item>
		/// <item><term>Item Attack Lightning Bonus (new)</term> <description>AIll</description></item>
		/// <item><term>Item Attack Slow Bonus</term> <description>AIsb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_HIT_SUMMONS_PERCENT, {1}, {2})"
		public extern void SetChanceToHitSummonsPercent_Iob4(int level, float chanceToHitSummonsPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare Gun</term> <description>AIfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DELAY_FOR_TARGET_EFFECT, {1})"
		public extern float GetDelayForTargetEffect_Idel(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flare Gun</term> <description>AIfa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DELAY_FOR_TARGET_EFFECT, {1}, {2})"
		public extern void SetDelayForTargetEffect_Idel(int level, float delayForTargetEffect);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Illusions</term> <description>AIil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_OF_NORMAL, {1})"
		public extern float GetDamageDealtPercentOfNormal_Iild(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Illusions</term> <description>AIil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_PERCENT_OF_NORMAL, {1}, {2})"
		public extern void SetDamageDealtPercentOfNormal_Iild(int level, float damageDealtPercentOfNormal);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Illusions</term> <description>AIil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RECEIVED_MULTIPLIER, {1})"
		public extern float GetDamageReceivedMultiplier_Iilw(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Illusions</term> <description>AIil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RECEIVED_MULTIPLIER, {1}, {2})"
		public extern void SetDamageReceivedMultiplier_Iilw(int level, float damageReceivedMultiplier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Mana Regeneration</term> <description>AIrm, AIrn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATION_BONUS_AS_FRACTION_OF_NORMAL, {1})"
		public extern float GetManaRegenerationBonusAsFractionOfNormal_Imrp(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Mana Regeneration</term> <description>AIrm, AIrn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATION_BONUS_AS_FRACTION_OF_NORMAL, {1}, {2})"
		public extern void SetManaRegenerationBonusAsFractionOfNormal_Imrp(int level, float manaRegenerationBonusAsFractionOfNormal);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Speed Bonus</term> <description>AIsp</description></item>
		/// <item><term>Scroll of Haste</term> <description>AIsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_ISPI, {1})"
		public extern float GetMovementSpeedIncrease_Ispi(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Temporary Speed Bonus</term> <description>AIsp</description></item>
		/// <item><term>Scroll of Haste</term> <description>AIsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_ISPI, {1}, {2})"
		public extern void SetMovementSpeedIncrease_Ispi(int level, float movementSpeedIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Shield</term> <description>AIls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_IDPS, {1})"
		public extern float GetDamagePerSecond_Idps(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Lightning Shield</term> <description>AIls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_IDPS, {1}, {2})"
		public extern void SetDamagePerSecond_Idps(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_INCREASE_CAC1, {1})"
		public extern float GetAttackDamageIncrease_Cac1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Command Aura</term> <description>ACac, AIcd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_DAMAGE_INCREASE_CAC1, {1}, {2})"
		public extern void SetAttackDamageIncrease_Cac1(int level, float attackDamageIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Corrosive Breath</term> <description>Acor</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_COR1, {1})"
		public extern float GetDamagePerSecond_Cor1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Corrosive Breath</term> <description>Acor</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_COR1, {1}, {2})"
		public extern void SetDamagePerSecond_Cor1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Speed Bonus</term> <description>AIas, AIsx, AIs2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_ISX1, {1})"
		public extern float GetAttackSpeedIncrease_Isx1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Attack Speed Bonus</term> <description>AIas, AIsx, AIs2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_ISX1, {1}, {2})"
		public extern void SetAttackSpeedIncrease_Isx1(int level, float attackSpeedIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg, AOws</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_WRS1, {1})"
		public extern float GetDamage_Wrs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg, AOws</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_WRS1, {1}, {2})"
		public extern void SetDamage_Wrs1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_TERRAIN_DEFORMATION_AMPLITUDE, {1})"
		public extern float GetTerrainDeformationAmplitude_Wrs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Stomp</term> <description>Awrs, Awrh, Awrg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_TERRAIN_DEFORMATION_AMPLITUDE, {1}, {2})"
		public extern void SetTerrainDeformationAmplitude_Wrs2(int level, float terrainDeformationAmplitude);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_CTC1, {1})"
		public extern float GetDamage_Ctc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_CTC1, {1}, {2})"
		public extern void SetDamage_Ctc1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_TO_TARGET, {1})"
		public extern float GetExtraDamageToTarget_Ctc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_TO_TARGET, {1}, {2})"
		public extern void SetExtraDamageToTarget_Ctc2(int level, float extraDamageToTarget);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_CTC3, {1})"
		public extern float GetMovementSpeedReduction_Ctc3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_CTC3, {1}, {2})"
		public extern void SetMovementSpeedReduction_Ctc3(int level, float movementSpeedReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_CTC4, {1})"
		public extern float GetAttackSpeedReduction_Ctc4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Slam</term> <description>ACtc, ACt2</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_CTC4, {1}, {2})"
		public extern void SetAttackSpeedReduction_Ctc4(int level, float attackSpeedReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hurl Boulder</term> <description>ACtb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_CTB1, {1})"
		public extern float GetDamage_Ctb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hurl Boulder</term> <description>ACtb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_CTB1, {1}, {2})"
		public extern void SetDamage_Ctb1(int level, float damage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_DELAY_SECONDS, {1})"
		public extern float GetCastingDelaySeconds_Uds2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Summoning</term> <description>AUds</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CASTING_DELAY_SECONDS, {1}, {2})"
		public extern void SetCastingDelaySeconds_Uds2(int level, float castingDelaySeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Detonate</term> <description>Adtn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_PER_UNIT_DTN1, {1})"
		public extern float GetManaLossPerUnit_Dtn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Detonate</term> <description>Adtn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_PER_UNIT_DTN1, {1}, {2})"
		public extern void SetManaLossPerUnit_Dtn1(int level, float manaLossPerUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Detonate</term> <description>Adtn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_DTN2, {1})"
		public extern float GetDamageToSummonedUnits_Dtn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Detonate</term> <description>Adtn</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_DTN2, {1}, {2})"
		public extern void SetDamageToSummonedUnits_Dtn2(int level, float damageToSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Invisibility</term> <description>Aivs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_TRANSITION_TIME_SECONDS, {1})"
		public extern float GetTransitionTimeSeconds_Ivs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Invisibility</term> <description>Aivs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_TRANSITION_TIME_SECONDS, {1}, {2})"
		public extern void SetTransitionTimeSeconds_Ivs1(int level, float transitionTimeSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mind Rot</term> <description>ANmr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_DRAINED_PER_SECOND_NMR1, {1})"
		public extern float GetManaDrainedPerSecond_Nmr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mind Rot</term> <description>ANmr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_DRAINED_PER_SECOND_NMR1, {1}, {2})"
		public extern void SetManaDrainedPerSecond_Nmr1(int level, float manaDrainedPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_REDUCE_DAMAGE_PERCENT, {1})"
		public extern float GetChanceToReduceDamagePercent_Ssk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_REDUCE_DAMAGE_PERCENT, {1}, {2})"
		public extern void SetChanceToReduceDamagePercent_Ssk1(int level, float chanceToReduceDamagePercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_DAMAGE, {1})"
		public extern float GetMinimumDamage_Ssk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_DAMAGE, {1}, {2})"
		public extern void SetMinimumDamage_Ssk2(int level, float minimumDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_IGNORED_DAMAGE, {1})"
		public extern float GetIgnoredDamage_Ssk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hardened Skin</term> <description>Assk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_IGNORED_DAMAGE, {1}, {2})"
		public extern void SetIgnoredDamage_Ssk3(int level, float ignoredDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_DEALT, {1})"
		public extern float GetFullDamageDealt_Hfs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_DEALT, {1}, {2})"
		public extern void SetFullDamageDealt_Hfs1(int level, float fullDamageDealt);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_INTERVAL, {1})"
		public extern float GetFullDamageInterval_Hfs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_INTERVAL, {1}, {2})"
		public extern void SetFullDamageInterval_Hfs2(int level, float fullDamageInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_DEALT, {1})"
		public extern float GetHalfDamageDealt_Hfs3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_DEALT, {1}, {2})"
		public extern void SetHalfDamageDealt_Hfs3(int level, float halfDamageDealt);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_INTERVAL, {1})"
		public extern float GetHalfDamageInterval_Hfs4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_INTERVAL, {1}, {2})"
		public extern void SetHalfDamageInterval_Hfs4(int level, float halfDamageInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_HFS5, {1})"
		public extern float GetBuildingReduction_Hfs5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_REDUCTION_HFS5, {1}, {2})"
		public extern void SetBuildingReduction_Hfs5(int level, float buildingReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_HFS6, {1})"
		public extern float GetMaximumDamage_Hfs6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Burning Oil</term> <description>Abof</description></item>
		/// <item><term>Flame Strike</term> <description>AHfs, ACfs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_DAMAGE_HFS6, {1}, {2})"
		public extern void SetMaximumDamage_Hfs6(int level, float maximumDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Shield</term> <description>ANms, ACmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_HIT_POINT, {1})"
		public extern float GetManaPerHitPoint_Nms1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Shield</term> <description>ANms, ACmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_HIT_POINT, {1}, {2})"
		public extern void SetManaPerHitPoint_Nms1(int level, float manaPerHitPoint);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Shield</term> <description>ANms, ACmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_ABSORBED_PERCENT, {1})"
		public extern float GetDamageAbsorbedPercent_Nms2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Shield</term> <description>ANms, ACmf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_ABSORBED_PERCENT, {1}, {2})"
		public extern void SetDamageAbsorbedPercent_Nms2(int level, float damageAbsorbedPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_DISTANCE, {1})"
		public extern float GetWaveDistance_Uim1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_DISTANCE, {1}, {2})"
		public extern void SetWaveDistance_Uim1(int level, float waveDistance);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_TIME_SECONDS, {1})"
		public extern float GetWaveTimeSeconds_Uim2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_TIME_SECONDS, {1}, {2})"
		public extern void SetWaveTimeSeconds_Uim2(int level, float waveTimeSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_UIM3, {1})"
		public extern float GetDamageDealt_Uim3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DEALT_UIM3, {1}, {2})"
		public extern void SetDamageDealt_Uim3(int level, float damageDealt);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AIR_TIME_SECONDS_UIM4, {1})"
		public extern float GetAirTimeSeconds_Uim4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Impale</term> <description>AUim, ACmp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AIR_TIME_SECONDS_UIM4, {1}, {2})"
		public extern void SetAirTimeSeconds_Uim4(int level, float airTimeSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_RELEASE_INTERVAL_SECONDS, {1})"
		public extern float GetUnitReleaseIntervalSeconds_Uls2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_RELEASE_INTERVAL_SECONDS, {1}, {2})"
		public extern void SetUnitReleaseIntervalSeconds_Uls2(int level, float unitReleaseIntervalSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RETURN_FACTOR, {1})"
		public extern float GetDamageReturnFactor_Uls4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RETURN_FACTOR, {1}, {2})"
		public extern void SetDamageReturnFactor_Uls4(int level, float damageReturnFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RETURN_THRESHOLD, {1})"
		public extern float GetDamageReturnThreshold_Uls5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Locust Swarm</term> <description>AUls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RETURN_THRESHOLD, {1}, {2})"
		public extern void SetDamageReturnThreshold_Uls5(int level, float damageReturnThreshold);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RETURNED_DAMAGE_FACTOR, {1})"
		public extern float GetReturnedDamageFactor_Uts1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RETURNED_DAMAGE_FACTOR, {1}, {2})"
		public extern void SetReturnedDamageFactor_Uts1(int level, float returnedDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_RECEIVED_DAMAGE_FACTOR, {1})"
		public extern float GetReceivedDamageFactor_Uts2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_RECEIVED_DAMAGE_FACTOR, {1}, {2})"
		public extern void SetReceivedDamageFactor_Uts2(int level, float receivedDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEFENSE_BONUS_UTS3, {1})"
		public extern float GetDefenseBonus_Uts3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spiked Carapace</term> <description>AUts</description></item>
		/// <item><term>Spiked Shell</term> <description>ANth</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEFENSE_BONUS_UTS3, {1}, {2})"
		public extern void SetDefenseBonus_Uts3(int level, float defenseBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_NBA1, {1})"
		public extern float GetDamageBonus_Nba1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_NBA1, {1}, {2})"
		public extern void SetDamageBonus_Nba1(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NBA3, {1})"
		public extern float GetSummonedUnitDurationSeconds_Nba3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Black Arrow</term> <description>ANba</description></item>
		/// <item><term>Item Black Arrow</term> <description>ANbs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NBA3, {1}, {2})"
		public extern void SetSummonedUnitDurationSeconds_Nba3(int level, float summonedUnitDurationSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_SUMMONED_HITPOINT, {1})"
		public extern float GetManaPerSummonedHitpoint_Cmg2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_SUMMONED_HITPOINT, {1}, {2})"
		public extern void SetManaPerSummonedHitpoint_Cmg2(int level, float manaPerSummonedHitpoint);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHARGE_FOR_CURRENT_LIFE, {1})"
		public extern float GetChargeForCurrentLife_Cmg3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Control Magic</term> <description>Acmg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHARGE_FOR_CURRENT_LIFE, {1}, {2})"
		public extern void SetChargeForCurrentLife_Cmg3(int level, float chargeForCurrentLife);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_DRAINED, {1})"
		public extern float GetHitPointsDrained_Ndr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_DRAINED, {1}, {2})"
		public extern void SetHitPointsDrained_Ndr1(int level, float hitPointsDrained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_POINTS_DRAINED, {1})"
		public extern float GetManaPointsDrained_Ndr2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_POINTS_DRAINED, {1}, {2})"
		public extern void SetManaPointsDrained_Ndr2(int level, float manaPointsDrained);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DRAIN_INTERVAL_SECONDS, {1})"
		public extern float GetDrainIntervalSeconds_Ndr3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DRAIN_INTERVAL_SECONDS, {1}, {2})"
		public extern void SetDrainIntervalSeconds_Ndr3(int level, float drainIntervalSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_TRANSFERRED_PER_SECOND, {1})"
		public extern float GetLifeTransferredPerSecond_Ndr4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_TRANSFERRED_PER_SECOND, {1}, {2})"
		public extern void SetLifeTransferredPerSecond_Ndr4(int level, float lifeTransferredPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_TRANSFERRED_PER_SECOND, {1})"
		public extern float GetManaTransferredPerSecond_Ndr5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_TRANSFERRED_PER_SECOND, {1}, {2})"
		public extern void SetManaTransferredPerSecond_Ndr5(int level, float manaTransferredPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_LIFE_FACTOR, {1})"
		public extern float GetBonusLifeFactor_Ndr6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_LIFE_FACTOR, {1}, {2})"
		public extern void SetBonusLifeFactor_Ndr6(int level, float bonusLifeFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_LIFE_DECAY, {1})"
		public extern float GetBonusLifeDecay_Ndr7(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_LIFE_DECAY, {1}, {2})"
		public extern void SetBonusLifeDecay_Ndr7(int level, float bonusLifeDecay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_MANA_FACTOR, {1})"
		public extern float GetBonusManaFactor_Ndr8(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_MANA_FACTOR, {1}, {2})"
		public extern void SetBonusManaFactor_Ndr8(int level, float bonusManaFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_MANA_DECAY, {1})"
		public extern float GetBonusManaDecay_Ndr9(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Life Drain</term> <description>ANdr, ACdr</description></item>
		/// <item><term>Siphon Mana</term> <description>AHdr, ACsm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_MANA_DECAY, {1}, {2})"
		public extern void SetBonusManaDecay_Ndr9(int level, float bonusManaDecay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_PERCENT, {1})"
		public extern float GetChanceToMissPercent_Nsi2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_MISS_PERCENT, {1}, {2})"
		public extern void SetChanceToMissPercent_Nsi2(int level, float chanceToMissPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_MODIFIER, {1})"
		public extern float GetMovementSpeedModifier_Nsi3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_MODIFIER, {1}, {2})"
		public extern void SetMovementSpeedModifier_Nsi3(int level, float movementSpeedModifier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_MODIFIER, {1})"
		public extern float GetAttackSpeedModifier_Nsi4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cloud of Fog</term> <description>AIfg</description></item>
		/// <item><term>Cloud</term> <description>Aclf</description></item>
		/// <item><term>Drunken Haze</term> <description>ANdh</description></item>
		/// <item><term>Item Silence</term> <description>AIse</description></item>
		/// <item><term>Silence</term> <description>ANsi, ACsi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_MODIFIER, {1}, {2})"
		public extern void SetAttackSpeedModifier_Nsi4(int level, float attackSpeedModifier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_TDG1, {1})"
		public extern float GetDamagePerSecond_Tdg1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_TDG1, {1}, {2})"
		public extern void SetDamagePerSecond_Tdg1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_TDG2, {1})"
		public extern float GetMediumDamageRadius_Tdg2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_TDG2, {1}, {2})"
		public extern void SetMediumDamageRadius_Tdg2(int level, float mediumDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_PER_SECOND, {1})"
		public extern float GetMediumDamagePerSecond_Tdg3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_PER_SECOND, {1}, {2})"
		public extern void SetMediumDamagePerSecond_Tdg3(int level, float mediumDamagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_RADIUS_TDG4, {1})"
		public extern float GetSmallDamageRadius_Tdg4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_RADIUS_TDG4, {1}, {2})"
		public extern void SetSmallDamageRadius_Tdg4(int level, float smallDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_PER_SECOND, {1})"
		public extern float GetSmallDamagePerSecond_Tdg5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Building Damage Aura</term> <description>Atdg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_PER_SECOND, {1}, {2})"
		public extern void SetSmallDamagePerSecond_Tdg5(int level, float smallDamagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado Spin</term> <description>Atsp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_AIR_TIME_SECONDS_TSP1, {1})"
		public extern float GetAirTimeSeconds_Tsp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado Spin</term> <description>Atsp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_AIR_TIME_SECONDS_TSP1, {1}, {2})"
		public extern void SetAirTimeSeconds_Tsp1(int level, float airTimeSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado Spin</term> <description>Atsp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_HIT_INTERVAL_SECONDS, {1})"
		public extern float GetMinimumHitIntervalSeconds_Tsp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Tornado Spin</term> <description>Atsp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_HIT_INTERVAL_SECONDS, {1}, {2})"
		public extern void SetMinimumHitIntervalSeconds_Tsp2(int level, float minimumHitIntervalSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_NBF5, {1})"
		public extern float GetDamagePerSecond_Nbf5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Breath of Fire</term> <description>ANbf, ACbc</description></item>
		/// <item><term>Breath of Frost</term> <description>ACbf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_NBF5, {1}, {2})"
		public extern void SetDamagePerSecond_Nbf5(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blink</term> <description>AEbl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_RANGE, {1})"
		public extern float GetMaximumRange_Ebl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blink</term> <description>AEbl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_RANGE, {1}, {2})"
		public extern void SetMaximumRange_Ebl1(int level, float maximumRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blink</term> <description>AEbl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_RANGE, {1})"
		public extern float GetMinimumRange_Ebl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Blink</term> <description>AEbl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MINIMUM_RANGE, {1}, {2})"
		public extern void SetMinimumRange_Ebl2(int level, float minimumRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_TARGET_EFK1, {1})"
		public extern float GetDamagePerTarget_Efk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_TARGET_EFK1, {1}, {2})"
		public extern void SetDamagePerTarget_Efk1(int level, float damagePerTarget);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_TOTAL_DAMAGE, {1})"
		public extern float GetMaximumTotalDamage_Efk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Barrage</term> <description>Aroc</description></item>
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_TOTAL_DAMAGE, {1}, {2})"
		public extern void SetMaximumTotalDamage_Efk2(int level, float maximumTotalDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_SPEED_ADJUSTMENT, {1})"
		public extern float GetMaximumSpeedAdjustment_Efk4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Fan of Knives</term> <description>AEfk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_SPEED_ADJUSTMENT, {1}, {2})"
		public extern void SetMaximumSpeedAdjustment_Efk4(int level, float maximumSpeedAdjustment);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DECAYING_DAMAGE, {1})"
		public extern float GetDecayingDamage_Esh1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DECAYING_DAMAGE, {1}, {2})"
		public extern void SetDecayingDamage_Esh1(int level, float decayingDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_ESH2, {1})"
		public extern float GetMovementSpeedFactor_Esh2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_FACTOR_ESH2, {1}, {2})"
		public extern void SetMovementSpeedFactor_Esh2(int level, float movementSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_ESH3, {1})"
		public extern float GetAttackSpeedFactor_Esh3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_FACTOR_ESH3, {1}, {2})"
		public extern void SetAttackSpeedFactor_Esh3(int level, float attackSpeedFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DECAY_POWER, {1})"
		public extern float GetDecayPower_Esh4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DECAY_POWER, {1}, {2})"
		public extern void SetDecayPower_Esh4(int level, float decayPower);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_DAMAGE_ESH5, {1})"
		public extern float GetInitialDamage_Esh5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Shadow Strike</term> <description>AEsh, ACss</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_DAMAGE_ESH5, {1}, {2})"
		public extern void SetInitialDamage_Esh5(int level, float initialDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Absorb Mana</term> <description>Aabs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_LIFE_ABSORBED, {1})"
		public extern float GetMaximumLifeAbsorbed_abs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Absorb Mana</term> <description>Aabs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_LIFE_ABSORBED, {1}, {2})"
		public extern void SetMaximumLifeAbsorbed_abs1(int level, float maximumLifeAbsorbed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Absorb Mana</term> <description>Aabs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_MANA_ABSORBED, {1})"
		public extern float GetMaximumManaAbsorbed_abs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Absorb Mana</term> <description>Aabs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAXIMUM_MANA_ABSORBED, {1}, {2})"
		public extern void SetMaximumManaAbsorbed_abs2(int level, float maximumManaAbsorbed);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_BSK1, {1})"
		public extern float GetMovementSpeedIncrease_bsk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_INCREASE_BSK1, {1}, {2})"
		public extern void SetMovementSpeedIncrease_bsk1(int level, float movementSpeedIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_BSK2, {1})"
		public extern float GetAttackSpeedIncrease_bsk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_INCREASE_BSK2, {1}, {2})"
		public extern void SetAttackSpeedIncrease_bsk2(int level, float attackSpeedIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_INCREASE, {1})"
		public extern float GetDamageTakenIncrease_bsk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Berserk</term> <description>Absk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TAKEN_INCREASE, {1}, {2})"
		public extern void SetDamageTakenIncrease_bsk3(int level, float damageTakenIncrease);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_PER_UNIT, {1})"
		public extern float GetLifePerUnit_dvm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_PER_UNIT, {1}, {2})"
		public extern void SetLifePerUnit_dvm1(int level, float lifePerUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_UNIT, {1})"
		public extern float GetManaPerUnit_dvm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_UNIT, {1}, {2})"
		public extern void SetManaPerUnit_dvm2(int level, float manaPerUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_PER_BUFF, {1})"
		public extern float GetLifePerBuff_dvm3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_PER_BUFF, {1}, {2})"
		public extern void SetLifePerBuff_dvm3(int level, float lifePerBuff);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_BUFF, {1})"
		public extern float GetManaPerBuff_dvm4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_PER_BUFF, {1}, {2})"
		public extern void SetManaPerBuff_dvm4(int level, float manaPerBuff);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_DVM5, {1})"
		public extern float GetSummonedUnitDamage_dvm5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Devour Magic</term> <description>Advm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_DVM5, {1}, {2})"
		public extern void SetSummonedUnitDamage_dvm5(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_FAK1, {1})"
		public extern float GetDamageBonus_fak1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_FAK1, {1}, {2})"
		public extern void SetDamageBonus_fak1(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_FACTOR_FAK2, {1})"
		public extern float GetMediumDamageFactor_fak2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_FACTOR_FAK2, {1}, {2})"
		public extern void SetMediumDamageFactor_fak2(int level, float mediumDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_FACTOR_FAK3, {1})"
		public extern float GetSmallDamageFactor_fak3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_FACTOR_FAK3, {1}, {2})"
		public extern void SetSmallDamageFactor_fak3(int level, float smallDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_FAK4, {1})"
		public extern float GetFullDamageRadius_fak4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_RADIUS_FAK4, {1}, {2})"
		public extern void SetFullDamageRadius_fak4(int level, float fullDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_RADIUS_FAK5, {1})"
		public extern float GetHalfDamageRadius_fak5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Orb of Annihilation</term> <description>Afak</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_RADIUS_FAK5, {1}, {2})"
		public extern void SetHalfDamageRadius_fak5(int level, float halfDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_PER_SECOND, {1})"
		public extern float GetExtraDamagePerSecond_liq1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EXTRA_DAMAGE_PER_SECOND, {1}, {2})"
		public extern void SetExtraDamagePerSecond_liq1(int level, float extraDamagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_LIQ2, {1})"
		public extern float GetMovementSpeedReduction_liq2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_LIQ2, {1}, {2})"
		public extern void SetMovementSpeedReduction_liq2(int level, float movementSpeedReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_LIQ3, {1})"
		public extern float GetAttackSpeedReduction_liq3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Liquid Fire</term> <description>Aliq</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_LIQ3, {1}, {2})"
		public extern void SetAttackSpeedReduction_liq3(int level, float attackSpeedReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Immunity, Spell Immunity</term> <description>ACm2, ACm3</description></item>
		/// <item><term>Spell Immunity</term> <description>Amim, AImx, ACmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_FACTOR, {1})"
		public extern float GetMagicDamageFactor_mim1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Immunity, Spell Immunity</term> <description>ACm2, ACm3</description></item>
		/// <item><term>Spell Immunity</term> <description>Amim, AImx, ACmi</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_FACTOR, {1}, {2})"
		public extern void SetMagicDamageFactor_mim1(int level, float magicDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_DAMAGE_PER_MANA_POINT, {1})"
		public extern float GetUnitDamagePerManaPoint_mfl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_DAMAGE_PER_MANA_POINT, {1}, {2})"
		public extern void SetUnitDamagePerManaPoint_mfl1(int level, float unitDamagePerManaPoint);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HERO_DAMAGE_PER_MANA_POINT, {1})"
		public extern float GetHeroDamagePerManaPoint_mfl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HERO_DAMAGE_PER_MANA_POINT, {1}, {2})"
		public extern void SetHeroDamagePerManaPoint_mfl2(int level, float heroDamagePerManaPoint);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_MAXIMUM_DAMAGE, {1})"
		public extern float GetUnitMaximumDamage_mfl3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_MAXIMUM_DAMAGE, {1}, {2})"
		public extern void SetUnitMaximumDamage_mfl3(int level, float unitMaximumDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HERO_MAXIMUM_DAMAGE, {1})"
		public extern float GetHeroMaximumDamage_mfl4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HERO_MAXIMUM_DAMAGE, {1}, {2})"
		public extern void SetHeroMaximumDamage_mfl4(int level, float heroMaximumDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_COOLDOWN, {1})"
		public extern float GetDamageCooldown_mfl5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mana Flare</term> <description>Amfl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_COOLDOWN, {1}, {2})"
		public extern void SetDamageCooldown_mfl5(int level, float damageCooldown);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spirit Link</term> <description>Aspl, Aspp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_SPL1, {1})"
		public extern float GetDistributedDamageFactor_spl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spirit Link</term> <description>Aspl, Aspp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_SPL1, {1}, {2})"
		public extern void SetDistributedDamageFactor_spl1(int level, float distributedDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATED, {1})"
		public extern float GetLifeRegenerated_irl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_REGENERATED, {1}, {2})"
		public extern void SetLifeRegenerated_irl1(int level, float lifeRegenerated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATED, {1})"
		public extern float GetManaRegenerated_irl2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Clarity Potion</term> <description>AIpr</description></item>
		/// <item><term>Generic Item-Rejuv Effect</term> <description>AIp1, AIp2, AIp3, AIp4, AIp5, AIp6</description></item>
		/// <item><term>Healing Salve</term> <description>AIrl</description></item>
		/// <item><term>Lesser Clarity Potion</term> <description>AIpl</description></item>
		/// <item><term>Scroll of Regeneration</term> <description>AIsl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_REGENERATED, {1}, {2})"
		public extern void SetManaRegenerated_irl2(int level, float manaRegenerated);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_PER_UNIT_IDC1, {1})"
		public extern float GetManaLossPerUnit_idc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_LOSS_PER_UNIT_IDC1, {1}, {2})"
		public extern void SetManaLossPerUnit_idc1(int level, float manaLossPerUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_IDC2, {1})"
		public extern float GetSummonedUnitDamage_idc2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Chain Dispel</term> <description>AIdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DAMAGE_IDC2, {1}, {2})"
		public extern void SetSummonedUnitDamage_idc2(int level, float summonedUnitDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_IMO2, {1})"
		public extern float GetActivationDelay_imo2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ACTIVATION_DELAY_IMO2, {1}, {2})"
		public extern void SetActivationDelay_imo2(int level, float activationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LURE_INTERVAL_SECONDS, {1})"
		public extern float GetLureIntervalSeconds_imo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Monster Lure</term> <description>AImo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LURE_INTERVAL_SECONDS, {1}, {2})"
		public extern void SetLureIntervalSeconds_imo3(int level, float lureIntervalSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Damage Reduction</term> <description>AIsr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_ISR1, {1})"
		public extern float GetDamageBonus_isr1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Damage Reduction</term> <description>AIsr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_ISR1, {1}, {2})"
		public extern void SetDamageBonus_isr1(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Damage Reduction</term> <description>AIsr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_ISR2, {1})"
		public extern float GetDamageReduction_isr2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Damage Reduction</term> <description>AIsr</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_REDUCTION_ISR2, {1}, {2})"
		public extern void SetDamageReduction_isr2(int level, float damageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_IPV1, {1})"
		public extern float GetDamageBonus_ipv1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_IPV1, {1}, {2})"
		public extern void SetDamageBonus_ipv1(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_STEAL_AMOUNT, {1})"
		public extern float GetLifeStealAmount_ipv2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Vampiric Potion</term> <description>AIpv</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_STEAL_AMOUNT, {1}, {2})"
		public extern void SetLifeStealAmount_ipv2(int level, float lifeStealAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ancestral Spirit</term> <description>Aast</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_RESTORED_FACTOR, {1})"
		public extern float GetLifeRestoredFactor_ast1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ancestral Spirit</term> <description>Aast</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_RESTORED_FACTOR, {1}, {2})"
		public extern void SetLifeRestoredFactor_ast1(int level, float lifeRestoredFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ancestral Spirit</term> <description>Aast</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MANA_RESTORED_FACTOR, {1})"
		public extern float GetManaRestoredFactor_ast2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Ancestral Spirit</term> <description>Aast</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MANA_RESTORED_FACTOR, {1}, {2})"
		public extern void SetManaRestoredFactor_ast2(int level, float manaRestoredFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACH_DELAY, {1})"
		public extern float GetAttachDelay_gra1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACH_DELAY, {1}, {2})"
		public extern void SetAttachDelay_gra1(int level, float attachDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_REMOVE_DELAY, {1})"
		public extern float GetRemoveDelay_gra2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>War Club</term> <description>Agra</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_REMOVE_DELAY, {1}, {2})"
		public extern void SetRemoveDelay_gra2(int level, float removeDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HERO_REGENERATION_DELAY, {1})"
		public extern float GetHeroRegenerationDelay_Nsa2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HERO_REGENERATION_DELAY, {1}, {2})"
		public extern void SetHeroRegenerationDelay_Nsa2(int level, float heroRegenerationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_REGENERATION_DELAY, {1})"
		public extern float GetUnitRegenerationDelay_Nsa3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_UNIT_REGENERATION_DELAY, {1}, {2})"
		public extern void SetUnitRegenerationDelay_Nsa3(int level, float unitRegenerationDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_NSA4, {1})"
		public extern float GetMagicDamageReduction_Nsa4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_NSA4, {1}, {2})"
		public extern void SetMagicDamageReduction_Nsa4(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_PER_SECOND_NSA5, {1})"
		public extern float GetHitPointsPerSecond_Nsa5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Staff of Sanctuary</term> <description>ANsa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HIT_POINTS_PER_SECOND_NSA5, {1}, {2})"
		public extern void SetHitPointsPerSecond_Nsa5(int level, float hitPointsPerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_IXS1, {1})"
		public extern float GetDamageToSummonedUnits_Ixs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_TO_SUMMONED_UNITS_IXS1, {1}, {2})"
		public extern void SetDamageToSummonedUnits_Ixs1(int level, float damageToSummonedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_IXS2, {1})"
		public extern float GetMagicDamageReduction_Ixs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Anti-Magic Shell</term> <description>AIxs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAGIC_DAMAGE_REDUCTION_IXS2, {1}, {2})"
		public extern void SetMagicDamageReduction_Ixs2(int level, float magicDamageReduction);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION, {1})"
		public extern float GetSummonedUnitDuration_Npa6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Parasite</term> <description>ANpa</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION, {1}, {2})"
		public extern void SetSummonedUnitDuration_Npa6(int level, float summonedUnitDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Shield</term> <description>ANse</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SHIELD_COOLDOWN_TIME, {1})"
		public extern float GetShieldCooldownTime_Nse1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Shield</term> <description>ANse</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SHIELD_COOLDOWN_TIME, {1}, {2})"
		public extern void SetShieldCooldownTime_Nse1(int level, float shieldCooldownTime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_NDO1, {1})"
		public extern float GetDamagePerSecond_Ndo1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_NDO1, {1}, {2})"
		public extern void SetDamagePerSecond_Ndo1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NDO3, {1})"
		public extern float GetSummonedUnitDurationSeconds_Ndo3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Doom</term> <description>ANdo</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_UNIT_DURATION_SECONDS_NDO3, {1}, {2})"
		public extern void SetSummonedUnitDurationSeconds_Ndo3(int level, float summonedUnitDurationSeconds);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_FLK1, {1})"
		public extern float GetMediumDamageRadius_flk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_RADIUS_FLK1, {1}, {2})"
		public extern void SetMediumDamageRadius_flk1(int level, float mediumDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_RADIUS_FLK2, {1})"
		public extern float GetSmallDamageRadius_flk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_RADIUS_FLK2, {1}, {2})"
		public extern void SetSmallDamageRadius_flk2(int level, float smallDamageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_FLK3, {1})"
		public extern float GetFullDamageAmount_flk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_FLK3, {1}, {2})"
		public extern void SetFullDamageAmount_flk3(int level, float fullDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_AMOUNT, {1})"
		public extern float GetMediumDamageAmount_flk4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MEDIUM_DAMAGE_AMOUNT, {1}, {2})"
		public extern void SetMediumDamageAmount_flk4(int level, float mediumDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_AMOUNT, {1})"
		public extern float GetSmallDamageAmount_flk5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Flak Cannons</term> <description>Aflk</description></item>
		/// <item><term>Fragmentation Shards</term> <description>Afsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SMALL_DAMAGE_AMOUNT, {1}, {2})"
		public extern void SetSmallDamageAmount_flk5(int level, float smallDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Banish</term> <description>AHbn</description></item>
		/// <item><term>Phase Shift</term> <description>Apsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HBN1, {1})"
		public extern float GetMovementSpeedReductionPercent_Hbn1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Banish</term> <description>AHbn</description></item>
		/// <item><term>Phase Shift</term> <description>Apsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_HBN1, {1}, {2})"
		public extern void SetMovementSpeedReductionPercent_Hbn1(int level, float movementSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Banish</term> <description>AHbn</description></item>
		/// <item><term>Phase Shift</term> <description>Apsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HBN2, {1})"
		public extern float GetAttackSpeedReductionPercent_Hbn2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Banish</term> <description>AHbn</description></item>
		/// <item><term>Phase Shift</term> <description>Apsh</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_HBN2, {1}, {2})"
		public extern void SetAttackSpeedReductionPercent_Hbn2(int level, float attackSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED_UNITS, {1})"
		public extern float GetMaxManaDrainedUnits_fbk1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED_UNITS, {1}, {2})"
		public extern void SetMaxManaDrainedUnits_fbk1(int level, float maxManaDrainedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RATIO_UNITS_PERCENT, {1})"
		public extern float GetDamageRatioUnitsPercent_fbk2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RATIO_UNITS_PERCENT, {1}, {2})"
		public extern void SetDamageRatioUnitsPercent_fbk2(int level, float damageRatioUnitsPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED_HEROS, {1})"
		public extern float GetMaxManaDrainedHeros_fbk3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_MANA_DRAINED_HEROS, {1}, {2})"
		public extern void SetMaxManaDrainedHeros_fbk3(int level, float maxManaDrainedHeros);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RATIO_HEROS_PERCENT, {1})"
		public extern float GetDamageRatioHerosPercent_fbk4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RATIO_HEROS_PERCENT, {1}, {2})"
		public extern void SetDamageRatioHerosPercent_fbk4(int level, float damageRatioHerosPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk, Afbt, Afbb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_DAMAGE, {1})"
		public extern float GetSummonedDamage_fbk5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Feedback</term> <description>Afbk, Afbt, Afbb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SUMMONED_DAMAGE, {1}, {2})"
		public extern void SetSummonedDamage_fbk5(int level, float summonedDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cleaving Attack</term> <description>ANca</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_NCA1, {1})"
		public extern float GetDistributedDamageFactor_nca1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cleaving Attack</term> <description>ANca</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DISTRIBUTED_DAMAGE_FACTOR_NCA1, {1}, {2})"
		public extern void SetDistributedDamageFactor_nca1(int level, float distributedDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix Fire</term> <description>Apxf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_DAMAGE_PXF1, {1})"
		public extern float GetInitialDamage_pxf1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix Fire</term> <description>Apxf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INITIAL_DAMAGE_PXF1, {1}, {2})"
		public extern void SetInitialDamage_pxf1(int level, float initialDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix Fire</term> <description>Apxf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_PXF2, {1})"
		public extern float GetDamagePerSecond_pxf2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Phoenix Fire</term> <description>Apxf</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_PXF2, {1}, {2})"
		public extern void SetDamagePerSecond_pxf2(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aerial Shackles</term> <description>Amls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_MLS1, {1})"
		public extern float GetDamagePerSecond_mls1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Aerial Shackles</term> <description>Amls</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PER_SECOND_MLS1, {1}, {2})"
		public extern void SetDamagePerSecond_mls1(int level, float damagePerSecond);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BEAST_COLLISION_RADIUS, {1})"
		public extern float GetBeastCollisionRadius_Nst2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BEAST_COLLISION_RADIUS, {1}, {2})"
		public extern void SetBeastCollisionRadius_Nst2(int level, float beastCollisionRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NST3, {1})"
		public extern float GetDamageAmount_Nst3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NST3, {1}, {2})"
		public extern void SetDamageAmount_Nst3(int level, float damageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RADIUS, {1})"
		public extern float GetDamageRadius_Nst4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_RADIUS, {1}, {2})"
		public extern void SetDamageRadius_Nst4(int level, float damageRadius);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DELAY, {1})"
		public extern float GetDamageDelay_Nst5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Stampede</term> <description>ANst</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_DELAY, {1}, {2})"
		public extern void SetDamageDelay_Nst5(int level, float damageDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FOLLOW_THROUGH_TIME, {1})"
		public extern float GetFollowThroughTime_Ncl1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FOLLOW_THROUGH_TIME, {1}, {2})"
		public extern void SetFollowThroughTime_Ncl1(int level, float followThroughTime);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ART_DURATION, {1})"
		public extern float GetArtDuration_Ncl4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ART_DURATION, {1}, {2})"
		public extern void SetArtDuration_Ncl4(int level, float artDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NAB1, {1})"
		public extern float GetMovementSpeedReductionPercent_Nab1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NAB1, {1}, {2})"
		public extern void SetMovementSpeedReductionPercent_Nab1(int level, float movementSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NAB2, {1})"
		public extern float GetAttackSpeedReductionPercent_Nab2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NAB2, {1}, {2})"
		public extern void SetAttackSpeedReductionPercent_Nab2(int level, float attackSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_PRIMARY_DAMAGE, {1})"
		public extern float GetPrimaryDamage_Nab4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_PRIMARY_DAMAGE, {1}, {2})"
		public extern void SetPrimaryDamage_Nab4(int level, float primaryDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SECONDARY_DAMAGE, {1})"
		public extern float GetSecondaryDamage_Nab5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SECONDARY_DAMAGE, {1}, {2})"
		public extern void SetSecondaryDamage_Nab5(int level, float secondaryDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_NAB6, {1})"
		public extern float GetDamageInterval_Nab6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Acid Bomb</term> <description>ANab</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_NAB6, {1}, {2})"
		public extern void SetDamageInterval_Nab6(int level, float damageInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_GOLD_COST_FACTOR, {1})"
		public extern float GetGoldCostFactor_Ntm1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_GOLD_COST_FACTOR, {1}, {2})"
		public extern void SetGoldCostFactor_Ntm1(int level, float goldCostFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LUMBER_COST_FACTOR, {1})"
		public extern float GetLumberCostFactor_Ntm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Transmute</term> <description>AIts</description></item>
		/// <item><term>Transmute</term> <description>ANtm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LUMBER_COST_FACTOR, {1}, {2})"
		public extern void SetLumberCostFactor_Ntm2(int level, float lumberCostFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_NEG1, {1})"
		public extern float GetMoveSpeedBonus_Neg1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVE_SPEED_BONUS_NEG1, {1}, {2})"
		public extern void SetMoveSpeedBonus_Neg1(int level, float moveSpeedBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_NEG2, {1})"
		public extern float GetDamageBonus_Neg2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_BONUS_NEG2, {1}, {2})"
		public extern void SetDamageBonus_Neg2(int level, float damageBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NCS1, {1})"
		public extern float GetDamageAmount_Ncs1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NCS1, {1}, {2})"
		public extern void SetDamageAmount_Ncs1(int level, float damageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_NCS2, {1})"
		public extern float GetDamageInterval_Ncs2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_INTERVAL_NCS2, {1}, {2})"
		public extern void SetDamageInterval_Ncs2(int level, float damageInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_NCS4, {1})"
		public extern float GetMaxDamage_Ncs4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_DAMAGE_NCS4, {1}, {2})"
		public extern void SetMaxDamage_Ncs4(int level, float maxDamage);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NCS5, {1})"
		public extern float GetBuildingDamageFactor_Ncs5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// <item><term>Healing Spray</term> <description>ANhs</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NCS5, {1}, {2})"
		public extern void SetBuildingDamageFactor_Ncs5(int level, float buildingDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DURATION, {1})"
		public extern float GetEffectDuration_Ncs6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Cluster Rockets</term> <description>ANcs, ANc1, ANc2, ANc3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_EFFECT_DURATION, {1}, {2})"
		public extern void SetEffectDuration_Ncs6(int level, float effectDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_INTERVAL_NSY1, {1})"
		public extern float GetSpawnInterval_Nsy1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_INTERVAL_NSY1, {1}, {2})"
		public extern void SetSpawnInterval_Nsy1(int level, float spawnInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_UNIT_DURATION, {1})"
		public extern float GetSpawnUnitDuration_Nsy3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_UNIT_DURATION, {1}, {2})"
		public extern void SetSpawnUnitDuration_Nsy3(int level, float spawnUnitDuration);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_UNIT_OFFSET, {1})"
		public extern float GetSpawnUnitOffset_Nsy4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_UNIT_OFFSET, {1}, {2})"
		public extern void SetSpawnUnitOffset_Nsy4(int level, float spawnUnitOffset);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LEASH_RANGE_NSY5, {1})"
		public extern float GetLeashRange_Nsy5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LEASH_RANGE_NSY5, {1}, {2})"
		public extern void SetLeashRange_Nsy5(int level, float leashRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_INTERVAL_NFY1, {1})"
		public extern float GetSpawnInterval_Nfy1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPAWN_INTERVAL_NFY1, {1}, {2})"
		public extern void SetSpawnInterval_Nfy1(int level, float spawnInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LEASH_RANGE_NFY2, {1})"
		public extern float GetLeashRange_Nfy2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Factory</term> <description>ANfy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LEASH_RANGE_NFY2, {1}, {2})"
		public extern void SetLeashRange_Nfy2(int level, float leashRange);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_DEMOLISH, {1})"
		public extern float GetChanceToDemolish_Nde1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_CHANCE_TO_DEMOLISH, {1}, {2})"
		public extern void SetChanceToDemolish_Nde1(int level, float chanceToDemolish);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_BUILDINGS, {1})"
		public extern float GetDamageMultiplierBuildings_Nde2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_BUILDINGS, {1}, {2})"
		public extern void SetDamageMultiplierBuildings_Nde2(int level, float damageMultiplierBuildings);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_UNITS, {1})"
		public extern float GetDamageMultiplierUnits_Nde3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_UNITS, {1}, {2})"
		public extern void SetDamageMultiplierUnits_Nde3(int level, float damageMultiplierUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_HEROES, {1})"
		public extern float GetDamageMultiplierHeroes_Nde4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Demolish</term> <description>ANde, ANd1, ANd2, ANd3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_MULTIPLIER_HEROES, {1}, {2})"
		public extern void SetDamageMultiplierHeroes_Nde4(int level, float damageMultiplierHeroes);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_DAMAGE_MULTIPLIER, {1})"
		public extern float GetBonusDamageMultiplier_Nic1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BONUS_DAMAGE_MULTIPLIER, {1}, {2})"
		public extern void SetBonusDamageMultiplier_Nic1(int level, float bonusDamageMultiplier);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_FULL_AMOUNT, {1})"
		public extern float GetDeathDamageFullAmount_Nic2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_FULL_AMOUNT, {1}, {2})"
		public extern void SetDeathDamageFullAmount_Nic2(int level, float deathDamageFullAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_FULL_AREA, {1})"
		public extern float GetDeathDamageFullArea_Nic3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_FULL_AREA, {1}, {2})"
		public extern void SetDeathDamageFullArea_Nic3(int level, float deathDamageFullArea);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_HALF_AMOUNT, {1})"
		public extern float GetDeathDamageHalfAmount_Nic4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_HALF_AMOUNT, {1}, {2})"
		public extern void SetDeathDamageHalfAmount_Nic4(int level, float deathDamageHalfAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_HALF_AREA, {1})"
		public extern float GetDeathDamageHalfArea_Nic5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_HALF_AREA, {1}, {2})"
		public extern void SetDeathDamageHalfArea_Nic5(int level, float deathDamageHalfArea);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_DELAY, {1})"
		public extern float GetDeathDamageDelay_Nic6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Incinerate</term> <description>ANic</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DEATH_DAMAGE_DELAY, {1}, {2})"
		public extern void SetDeathDamageDelay_Nic6(int level, float deathDamageDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NSO1, {1})"
		public extern float GetDamageAmount_Nso1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_AMOUNT_NSO1, {1}, {2})"
		public extern void SetDamageAmount_Nso1(int level, float damageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PERIOD, {1})"
		public extern float GetDamagePeriod_Nso2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PERIOD, {1}, {2})"
		public extern void SetDamagePeriod_Nso2(int level, float damagePeriod);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PENALTY, {1})"
		public extern float GetDamagePenalty_Nso3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_DAMAGE_PENALTY, {1}, {2})"
		public extern void SetDamagePenalty_Nso3(int level, float damagePenalty);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NSO4, {1})"
		public extern float GetMovementSpeedReductionPercent_Nso4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MOVEMENT_SPEED_REDUCTION_PERCENT_NSO4, {1}, {2})"
		public extern void SetMovementSpeedReductionPercent_Nso4(int level, float movementSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NSO5, {1})"
		public extern float GetAttackSpeedReductionPercent_Nso5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Soul Burn</term> <description>ANso</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_ATTACK_SPEED_REDUCTION_PERCENT_NSO5, {1}, {2})"
		public extern void SetAttackSpeedReductionPercent_Nso5(int level, float attackSpeedReductionPercent);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_SPLIT_DELAY, {1})"
		public extern float GetSplitDelay_Nlm2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_SPLIT_DELAY, {1}, {2})"
		public extern void SetSplitDelay_Nlm2(int level, float splitDelay);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_MAX_HITPOINT_FACTOR, {1})"
		public extern float GetMaxHitpointFactor_Nlm4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_MAX_HITPOINT_FACTOR, {1}, {2})"
		public extern void SetMaxHitpointFactor_Nlm4(int level, float maxHitpointFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_DURATION_SPLIT_BONUS, {1})"
		public extern float GetLifeDurationSplitBonus_Nlm5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Summon Lava Spawn</term> <description>ANlm</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_LIFE_DURATION_SPLIT_BONUS, {1}, {2})"
		public extern void SetLifeDurationSplitBonus_Nlm5(int level, float lifeDurationSplitBonus);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_INTERVAL, {1})"
		public extern float GetWaveInterval_Nvc3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_WAVE_INTERVAL, {1}, {2})"
		public extern void SetWaveInterval_Nvc3(int level, float waveInterval);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NVC4, {1})"
		public extern float GetBuildingDamageFactor_Nvc4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_BUILDING_DAMAGE_FACTOR_NVC4, {1}, {2})"
		public extern void SetBuildingDamageFactor_Nvc4(int level, float buildingDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_NVC5, {1})"
		public extern float GetFullDamageAmount_Nvc5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_FULL_DAMAGE_AMOUNT_NVC5, {1}, {2})"
		public extern void SetFullDamageAmount_Nvc5(int level, float fullDamageAmount);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_FACTOR, {1})"
		public extern float GetHalfDamageFactor_Nvc6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Volcano</term> <description>ANvc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_HALF_DAMAGE_FACTOR, {1}, {2})"
		public extern void SetHalfDamageFactor_Nvc6(int level, float halfDamageFactor);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_BETWEEN_PULSES, {1})"
		public extern float GetIntervalBetweenPulses_Tau5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Taunt</term> <description>Atau, ANta</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityRealLevelField({0}, ABILITY_RLF_INTERVAL_BETWEEN_PULSES, {1}, {2})"
		public extern void SetIntervalBetweenPulses_Tau5(int level, float intervalBetweenPulses);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ICON_NORMAL, {1})"
		public extern string GetIconNormal_aart(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ICON_NORMAL, {1}, {2})"
		public extern void SetIconNormal_aart(int level, string iconNormal);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_CASTER, {1})"
		public extern string GetCaster_acat(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_CASTER, {1}, {2})"
		public extern void SetCaster_acat(int level, string caster);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TARGET, {1})"
		public extern string GetTarget_atat(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TARGET, {1}, {2})"
		public extern void SetTarget_atat(int level, string target);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SPECIAL, {1})"
		public extern string GetSpecial_asat(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SPECIAL, {1}, {2})"
		public extern void SetSpecial_asat(int level, string special);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_EFFECT, {1})"
		public extern string GetEffect_aeat(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_EFFECT, {1}, {2})"
		public extern void SetEffect_aeat(int level, string effect);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_AREA_EFFECT, {1})"
		public extern string GetAreaEffect_aaea(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_AREA_EFFECT, {1}, {2})"
		public extern void SetAreaEffect_aaea(int level, string areaEffect);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_LIGHTNING_EFFECTS, {1})"
		public extern string GetLightningEffects_alig(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_LIGHTNING_EFFECTS, {1}, {2})"
		public extern void SetLightningEffects_alig(int level, string lightningEffects);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_MISSILE_ART, {1})"
		public extern string GetMissileArt_amat(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_MISSILE_ART, {1}, {2})"
		public extern void SetMissileArt_amat(int level, string missileArt);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_LEARN, {1})"
		public extern string GetTooltipLearn_aret(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_LEARN, {1}, {2})"
		public extern void SetTooltipLearn_aret(int level, string tooltipLearn);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_LEARN_EXTENDED, {1})"
		public extern string GetTooltipLearnExtended_arut(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_LEARN_EXTENDED, {1}, {2})"
		public extern void SetTooltipLearnExtended_arut(int level, string tooltipLearnExtended);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_NORMAL, {1})"
		public extern string GetTooltipNormal_atp1(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_NORMAL, {1}, {2})"
		public extern void SetTooltipNormal_atp1(int level, string tooltipNormal);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_TURN_OFF, {1})"
		public extern string GetTooltipTurnOff_aut1(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_TURN_OFF, {1}, {2})"
		public extern void SetTooltipTurnOff_aut1(int level, string tooltipTurnOff);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_NORMAL_EXTENDED, {1})"
		public extern string GetTooltipNormalExtended_aub1(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_NORMAL_EXTENDED, {1}, {2})"
		public extern void SetTooltipNormalExtended_aub1(int level, string tooltipNormalExtended);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_TURN_OFF_EXTENDED, {1})"
		public extern string GetTooltipTurnOffExtended_auu1(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_TOOLTIP_TURN_OFF_EXTENDED, {1}, {2})"
		public extern void SetTooltipTurnOffExtended_auu1(int level, string tooltipTurnOffExtended);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_NORMAL_FORM_UNIT_EME1, {1})"
		public extern string GetNormalFormUnit_Eme1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Bear Form</term> <description>Abrf</description></item>
		/// <item><term>Burrow</term> <description>Abur, Abu2, Abu3</description></item>
		/// <item><term>Chemical Rage</term> <description>ANcr</description></item>
		/// <item><term>Corporeal Form</term> <description>Acpf</description></item>
		/// <item><term>Crow Form</term> <description>Amrf</description></item>
		/// <item><term>Destroyer Form</term> <description>Aave</description></item>
		/// <item><term>Ethereal Form</term> <description>Aetf</description></item>
		/// <item><term>Metamorphosis</term> <description>AEme, AEIl, AEvi</description></item>
		/// <item><term>Phoenix Morphing (Egg Related)</term> <description>Aphx</description></item>
		/// <item><term>Robo-Goblin</term> <description>ANrg, ANg1, ANg2, ANg3</description></item>
		/// <item><term>Stone Form</term> <description>Astn</description></item>
		/// <item><term>Storm Crow Form</term> <description>Arav</description></item>
		/// <item><term>Submerge</term> <description>Asb1, Asb2, Asb3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_NORMAL_FORM_UNIT_EME1, {1}, {2})"
		public extern void SetNormalFormUnit_Eme1(int level, string normalFormUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SPAWNED_UNITS, {1})"
		public extern string GetSpawnedUnits_Ndp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Portal</term> <description>ANdp</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SPAWNED_UNITS, {1}, {2})"
		public extern void SetSpawnedUnits_Ndp1(int level, string spawnedUnits);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rain of Chaos</term> <description>ANrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_FOR_UNIT_CREATION, {1})"
		public extern string GetAbilityForUnitCreation_Nrc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Rain of Chaos</term> <description>ANrc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_FOR_UNIT_CREATION, {1}, {2})"
		public extern void SetAbilityForUnitCreation_Nrc1(int level, string abilityForUnitCreation);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Call to Arms</term> <description>Amil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_NORMAL_FORM_UNIT_MIL1, {1})"
		public extern string GetNormalFormUnit_Mil1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Call to Arms</term> <description>Amil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_NORMAL_FORM_UNIT_MIL1, {1}, {2})"
		public extern void SetNormalFormUnit_Mil1(int level, string normalFormUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Call to Arms</term> <description>Amil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ALTERNATE_FORM_UNIT_MIL2, {1})"
		public extern string GetAlternateFormUnit_Mil2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Call to Arms</term> <description>Amil</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ALTERNATE_FORM_UNIT_MIL2, {1}, {2})"
		public extern void SetAlternateFormUnit_Mil2(int level, string alternateFormUnit);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_ANS5, {1})"
		public extern string GetBaseOrderId_Ans5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Charge Gold and Lumber</term> <description>AAns</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_ANS5, {1}, {2})"
		public extern void SetBaseOrderId_Ans5(int level, string baseOrderId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_GROUND, {1})"
		public extern string GetMorphUnitsGround_Ply2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_GROUND, {1}, {2})"
		public extern void SetMorphUnitsGround_Ply2(int level, string morphUnitsGround);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_AIR, {1})"
		public extern string GetMorphUnitsAir_Ply3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_AIR, {1}, {2})"
		public extern void SetMorphUnitsAir_Ply3(int level, string morphUnitsAir);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_AMPHIBIOUS, {1})"
		public extern string GetMorphUnitsAmphibious_Ply4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_AMPHIBIOUS, {1}, {2})"
		public extern void SetMorphUnitsAmphibious_Ply4(int level, string morphUnitsAmphibious);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_WATER, {1})"
		public extern string GetMorphUnitsWater_Ply5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Hex</term> <description>AOhx, AChx</description></item>
		/// <item><term>Polymorph</term> <description>Aply, ACpy</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_MORPH_UNITS_WATER, {1}, {2})"
		public extern void SetMorphUnitsWater_Ply5(int level, string morphUnitsWater);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_ONE, {1})"
		public extern string GetUnitTypeOne_Rai3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_ONE, {1}, {2})"
		public extern void SetUnitTypeOne_Rai3(int level, string unitTypeOne);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_TWO, {1})"
		public extern string GetUnitTypeTwo_Rai4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Carrion Beetles</term> <description>AUcb</description></item>
		/// <item><term>Raise Dead (Item)</term> <description>AIrd</description></item>
		/// <item><term>Raise Dead</term> <description>Arai, ACrd</description></item>
		/// <item><term>Spirit of Vengeance</term> <description>Avng</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_TWO, {1}, {2})"
		public extern void SetUnitTypeTwo_Rai4(int level, string unitTypeTwo);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spawn Hydra Hatchling</term> <description>Aspt</description></item>
		/// <item><term>Spawn Hydra</term> <description>Aspy</description></item>
		/// <item><term>Spawn Skeleton</term> <description>Asod</description></item>
		/// <item><term>Spawn Spiderlings</term> <description>Assp</description></item>
		/// <item><term>Spawn Spiders</term> <description>Aspd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_SOD2, {1})"
		public extern string GetUnitType_Sod2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spawn Hydra Hatchling</term> <description>Aspt</description></item>
		/// <item><term>Spawn Hydra</term> <description>Aspy</description></item>
		/// <item><term>Spawn Skeleton</term> <description>Asod</description></item>
		/// <item><term>Spawn Spiderlings</term> <description>Assp</description></item>
		/// <item><term>Spawn Spiders</term> <description>Aspd</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_UNIT_TYPE_SOD2, {1}, {2})"
		public extern void SetUnitType_Sod2(int level, string unitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SUMMON_1_UNIT_TYPE, {1})"
		public extern string GetSummon1UnitType_Ist1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SUMMON_1_UNIT_TYPE, {1}, {2})"
		public extern void SetSummon1UnitType_Ist1(int level, string summon1UnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SUMMON_2_UNIT_TYPE, {1})"
		public extern string GetSummon2UnitType_Ist2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Item Blue Dragonspawn Overseer Summon</term> <description>AIff</description></item>
		/// <item><term>Item Blue Drake Summon</term> <description>AIfd</description></item>
		/// <item><term>Item Doom Guard Summon</term> <description>AIfu</description></item>
		/// <item><term>Item Fel Stalker Summon</term> <description>AIfh</description></item>
		/// <item><term>Item Furbolg Tracker Summon</term> <description>AIut</description></item>
		/// <item><term>Item Ice Revenant Summon</term> <description>AIir</description></item>
		/// <item><term>Item Rock Golem Summon</term> <description>AIfr</description></item>
		/// <item><term>Item Skeleton Summon</term> <description>AIfs, AIbd, AIes</description></item>
		/// <item><term>Item Ursa Warrior Summon</term> <description>AIuw</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SUMMON_2_UNIT_TYPE, {1}, {2})"
		public extern void SetSummon2UnitType_Ist2(int level, string summon2UnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Conversion</term> <description>ANdc, SNdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_RACE_TO_CONVERT, {1})"
		public extern string GetRaceToConvert_Ndc1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dark Conversion</term> <description>ANdc, SNdc</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_RACE_TO_CONVERT, {1}, {2})"
		public extern void SetRaceToConvert_Ndc1(int level, string raceToConvert);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Acoa, Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Acoh, Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE, {1})"
		public extern string GetPartnerUnitType_coa1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Mount Hippogryph</term> <description>Acoa, Aco2</description></item>
		/// <item><term>Pick up Archer</term> <description>Acoh, Aco3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE, {1}, {2})"
		public extern void SetPartnerUnitType_coa1(int level, string partnerUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dismount</term> <description>Adec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE_ONE, {1})"
		public extern string GetPartnerUnitTypeOne_dcp1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dismount</term> <description>Adec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE_ONE, {1}, {2})"
		public extern void SetPartnerUnitTypeOne_dcp1(int level, string partnerUnitTypeOne);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dismount</term> <description>Adec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE_TWO, {1})"
		public extern string GetPartnerUnitTypeTwo_dcp2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Dismount</term> <description>Adec</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_PARTNER_UNIT_TYPE_TWO, {1}, {2})"
		public extern void SetPartnerUnitTypeTwo_dcp2(int level, string partnerUnitTypeTwo);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_REQUIRED_UNIT_TYPE, {1})"
		public extern string GetRequiredUnitType_tpi1(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_REQUIRED_UNIT_TYPE, {1}, {2})"
		public extern void SetRequiredUnitType_tpi1(int level, string requiredUnitType);

		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_CONVERTED_UNIT_TYPE, {1})"
		public extern string GetConvertedUnitType_tpi2(int level);
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_CONVERTED_UNIT_TYPE, {1}, {2})"
		public extern void SetConvertedUnitType_tpi2(int level, string convertedUnitType);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SPELL_LIST, {1})"
		public extern string GetSpellList_spb1(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SPELL_LIST, {1}, {2})"
		public extern void SetSpellList_spb1(int level, string spellList);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_SPB5, {1})"
		public extern string GetBaseOrderId_spb5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Spell Book</term> <description>Aspb</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_SPB5, {1}, {2})"
		public extern void SetBaseOrderId_spb5(int level, string baseOrderId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_NCL6, {1})"
		public extern string GetBaseOrderId_Ncl6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Channel</term> <description>ANcl</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_BASE_ORDER_ID_NCL6, {1}, {2})"
		public extern void SetBaseOrderId_Ncl6(int level, string baseOrderId);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_1, {1})"
		public extern string GetAbilityUpgrade1_Neg3(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_1, {1}, {2})"
		public extern void SetAbilityUpgrade1_Neg3(int level, string abilityUpgrade1);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_2, {1})"
		public extern string GetAbilityUpgrade2_Neg4(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_2, {1}, {2})"
		public extern void SetAbilityUpgrade2_Neg4(int level, string abilityUpgrade2);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_3, {1})"
		public extern string GetAbilityUpgrade3_Neg5(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_3, {1}, {2})"
		public extern void SetAbilityUpgrade3_Neg5(int level, string abilityUpgrade3);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_4, {1})"
		public extern string GetAbilityUpgrade4_Neg6(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Engineering Upgrade</term> <description>ANeg</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_ABILITY_UPGRADE_4, {1}, {2})"
		public extern void SetAbilityUpgrade4_Neg6(int level, string abilityUpgrade4);

		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "GetAbilityStringLevelField({0}, ABILITY_SLF_SPAWN_UNIT_ID_NSY2, {1})"
		public extern string GetSpawnUnitId_Nsy2(int level);
		/// <summary>
		/// <para>Used by:</para>
		/// <list type="bullet">
		/// <item><term>Pocket Factory</term> <description>ANsy, ANs1, ANs2, ANs3</description></item>
		/// </list>
		/// </summary>
		/// @CSharpLua.Template = "SetAbilityStringLevelField({0}, ABILITY_SLF_SPAWN_UNIT_ID_NSY2, {1}, {2})"
		public extern void SetSpawnUnitId_Nsy2(int level, string spawnUnitId);
	}
}
