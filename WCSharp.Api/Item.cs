using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Item : Widget, IDisposable
	{
		internal Item()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator item(Item x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Item(item x);

		/// @CSharpLua.Get = "CreateItem({0}, {1}, {2})"
		public static extern Item Create(int itemId, float x, float y);
		/// @CSharpLua.Get = "BlzCreateItemWithSkin({0}, {1}, {2}, {3})"
		public static extern Item Create(int itemId, float x, float y, int skinId);

		/// @CSharpLua.Get = "GetItemTypeId({0})"
		public extern int TypeId { get; }

		/// @CSharpLua.Get = "GetItemType({0})"
		public extern ItemType Type { get; }

		/// @CSharpLua.Get = "GetItemPlayer({0})"
		/// @CSharpLua.Set = "SetItemPlayer({0}, {1})"
		public extern Player Owner { get; set; }

		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_DROPPED_WHEN_CARRIER_DIES)"
		/// @CSharpLua.Set = "SetItemDropOnDeath({0}, {1})"
		public extern bool IsDroppedOnDeath { get; set; }

		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_CAN_BE_DROPPED)"
		/// @CSharpLua.Set = "SetItemDroppable({0}, {1})"
		public extern bool IsDroppable { get; set; }

		/// @CSharpLua.Get = "IsItemVisible({0})"
		/// @CSharpLua.Set = "SetItemVisible({0}, {1})"
		public extern bool IsVisible { get; set; }

		/// @CSharpLua.Get = "IsItemPawnable({0})"
		/// @CSharpLua.Set = "SetItemPawnable({0}, {1})"
		public extern bool IsPawnable { get; set; }

		/// @CSharpLua.Get = "IsItemInvulnerable({0})"
		/// @CSharpLua.Set = "SetItemInvulnerable({0}, {1})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "IsItemPowerup({0})"
		public extern bool IsPowerup { get; }

		/// @CSharpLua.Get = "IsItemOwned({0})"
		public extern bool IsOwned { get; }

		/// @CSharpLua.Get = "GetItemUserData({0})"
		/// @CSharpLua.Set = "SetItemUserData({0}, {1})"
		public extern int UserData { get; set; }

		/// @CSharpLua.Get = "IsItemSellable({0})"
		/// @CSharpLua.Set = "SetItemBooleanField({0}, ITEM_BF_CAN_BE_SOLD_TO_MERCHANTS, {1})"
		public extern bool IsSellable { get; set; }

		/// @CSharpLua.Get = "GetItemName({0})"
		/// @CSharpLua.Set = "BlzSetItemName({0}, {1})"
		public extern string Name { get; set; }

		/// @CSharpLua.Get = "BlzGetItemDescription({0})"
		/// @CSharpLua.Set = "BlzSetItemDescription({0}, {1})"
		public extern string Description { get; set; }

		/// @CSharpLua.Get = "BlzGetItemTooltip({0})"
		/// @CSharpLua.Set = "BlzSetItemTooltip({0}, {1})"
		public extern string Tooltip { get; set; }

		/// @CSharpLua.Get = "BlzGetItemExtendedTooltip({0})"
		/// @CSharpLua.Set = "BlzSetItemExtendedTooltip({0}, {1})"
		public extern string ExtendedDescription { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIconPath({0})"
		/// @CSharpLua.Set = "BlzSetItemIconPath({0}, {1})"
		public extern string Icon { get; set; }

		/// @CSharpLua.Get = "GetItemLevel({0})"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_LEVEL, {1})"
		public extern int Level { get; set; }

		/// @CSharpLua.Get = "GetItemCharges({0})"
		/// @CSharpLua.Set = "SetItemCharges({0}, {1})"
		public extern int Charges { get; set; }

		/// @CSharpLua.Get = "BlzGetItemSkin({0})"
		/// @CSharpLua.Set = "BlzSetItemSkin({0}, {1})"
		public extern int Skin { get; set; }

		/// @CSharpLua.Template = "SetItemDropID({0}, {1})"
		public extern void SetDropId(int unitId);

		/// @CSharpLua.Template = "BlzGetItemAbilityByIndex({0}, {1})"
		public extern Ability GetAbilityByIndex(int index);

		/// @CSharpLua.Template = "BlzGetItemAbility({0}, {1})"
		public extern Ability GetAbility(int abilityId);

		/// @CSharpLua.Template = "BlzItemAddAbility({0}, {1})"
		public extern bool AddAbility(int abilityId);

		/// @CSharpLua.Template = "BlzItemRemoveAbility({0}, {1})"
		public extern bool RemoveAbility(int abilityId);

		/// @CSharpLua.Template = "RemoveItem({0})"
		public extern void Dispose();

		#region Field editing
		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_PERISHABLE)"
		/// @CSharpLua.Set = "SetItemBooleanField({0}, ITEM_BF_PERISHABLE, {1})"
		public extern bool Perishable { get; set; }

		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_INCLUDE_AS_RANDOM_CHOICE)"
		/// @CSharpLua.Set = "SetItemBooleanField({0}, ITEM_BF_INCLUDE_AS_RANDOM_CHOICE, {1})"
		public extern bool IncludeAsRandomChoice { get; set; }

		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED)"
		/// @CSharpLua.Set = "SetItemBooleanField({0}, ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED, {1})"
		public extern bool UseAutomaticallyWhenAcquired { get; set; }

		/// @CSharpLua.Get = "GetItemBooleanField({0}, ITEM_BF_ACTIVELY_USED)"
		/// @CSharpLua.Set = "SetItemBooleanField({0}, ITEM_BF_ACTIVELY_USED, {1})"
		public extern bool ActivelyUsed { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_COOLDOWN_GROUP)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_COOLDOWN_GROUP, {1})"
		public extern int CooldownGroup { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_MAX_HIT_POINTS)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_MAX_HIT_POINTS, {1})"
		public extern int MaxHitPoints { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_PRIORITY)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_PRIORITY, {1})"
		public extern int Priority { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_ARMOR_TYPE)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_ARMOR_TYPE, {1})"
		public extern int ArmorType { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_RED)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_RED, {1})"
		public extern int TintingColorRed { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_GREEN)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_GREEN, {1})"
		public extern int TintingColorGreen { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_BLUE)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_BLUE, {1})"
		public extern int TintingColorBlue { get; set; }

		/// @CSharpLua.Get = "GetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_ALPHA)"
		/// @CSharpLua.Set = "SetItemIntegerField({0}, ITEM_IF_TINTING_COLOR_ALPHA, {1})"
		public extern int TintingColorAlpha { get; set; }

		/// @CSharpLua.Get = "GetItemRealField({0}, ITEM_RF_SCALING_VALUE)"
		/// @CSharpLua.Set = "SetItemRealField({0}, ITEM_RF_SCALING_VALUE, {1})"
		public extern float ScalingValue { get; set; }

		/// @CSharpLua.Get = "GetItemStringField({0}, ITEM_SF_MODEL_USED)"
		/// @CSharpLua.Set = "SetItemStringField({0}, ITEM_SF_MODEL_USED, {1})"
		public extern string ModelUsed { get; set; }
		#endregion
	}
}
