using System;
using WCSharp.Api.Enums;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class item : widget, IDisposable
	{
		internal item()
		{
		}

		/// @CSharpLua.Template = "CreateItem({0}, {1}, {2})"
		public static extern item Create(int itemId, float x, float y);
		/// @CSharpLua.Template = "BlzCreateItemWithSkin({0}, {1}, {2}, {3})"
		public static extern item Create(int itemId, float x, float y, int skinId);

		/// @CSharpLua.Template = "IsItemIdPowerup({0})"
		public static extern bool IsIdPowerup(int itemId);
		/// @CSharpLua.Template = "IsItemIdSellable({0})"
		public static extern bool IsIdSellable(int itemId);
		/// @CSharpLua.Template = "IsItemIdPawnable({0})"
		public static extern bool IsIdPawnable(int itemId);
		/// @CSharpLua.Template = "EnumItemsInRect({0}, {1}, {2})"
		public static extern void EnumInRect(rect rect, boolexpr filter, Action action);

		/// @CSharpLua.Get = "GetItemTypeId({this})"
		public extern int TypeId { get; }

		/// @CSharpLua.Get = "GetItemType({this})"
		public extern itemtype Type { get; }

		/// @CSharpLua.Get = "GetWidgetX({this})"
		/// @CSharpLua.Set = "SetItemPosition({this}, {0}, GetWidgetY({this}))"
		public extern float X { get; set; }

		/// @CSharpLua.Get = "GetWidgetY({this})"
		/// @CSharpLua.Set = "SetItemPosition({this}, GetWidgetX({this}), {0})"
		public extern float Y { get; set; }

		/// @CSharpLua.Get = "GetItemPlayer({this})"
		/// @CSharpLua.Set = "SetItemPlayer({this}, {0}, true)"
		public extern player Owner { get; set; }

		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_DROPPED_WHEN_CARRIER_DIES)"
		/// @CSharpLua.Set = "SetItemDropOnDeath({this}, {0})"
		public extern bool IsDroppedOnDeath { get; set; }

		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_CAN_BE_DROPPED)"
		/// @CSharpLua.Set = "SetItemDroppable({this}, {0})"
		public extern bool IsDroppable { get; set; }

		/// @CSharpLua.Get = "IsItemVisible({this})"
		/// @CSharpLua.Set = "SetItemVisible({this}, {0})"
		public extern bool IsVisible { get; set; }

		/// @CSharpLua.Get = "IsItemPawnable({this})"
		/// @CSharpLua.Set = "SetItemPawnable({this}, {0})"
		public extern bool IsPawnable { get; set; }

		/// @CSharpLua.Get = "IsItemInvulnerable({this})"
		/// @CSharpLua.Set = "SetItemInvulnerable({this}, {0})"
		public extern bool IsInvulnerable { get; set; }

		/// @CSharpLua.Get = "IsItemPowerup({this})"
		public extern bool IsPowerup { get; }

		/// @CSharpLua.Get = "IsItemOwned({this})"
		public extern bool IsOwned { get; }

		/// @CSharpLua.Get = "GetItemUserData({this})"
		/// @CSharpLua.Set = "SetItemUserData({this}, {0})"
		public extern int UserData { get; set; }

		/// @CSharpLua.Get = "IsItemSellable({this})"
		/// @CSharpLua.Set = "BlzSetItemBooleanField({this}, ITEM_BF_CAN_BE_SOLD_TO_MERCHANTS, {0})"
		public extern bool IsSellable { get; set; }

		/// @CSharpLua.Get = "GetItemName({this})"
		/// @CSharpLua.Set = "BlzSetItemName({this}, {0})"
		public extern string Name { get; set; }

		/// @CSharpLua.Get = "BlzGetItemDescription({this})"
		/// @CSharpLua.Set = "BlzSetItemDescription({this}, {0})"
		public extern string Description { get; set; }

		/// @CSharpLua.Get = "BlzGetItemTooltip({this})"
		/// @CSharpLua.Set = "BlzSetItemTooltip({this}, {0})"
		public extern string Tooltip { get; set; }

		/// @CSharpLua.Get = "BlzGetItemExtendedTooltip({this})"
		/// @CSharpLua.Set = "BlzSetItemExtendedTooltip({this}, {0})"
		public extern string ExtendedDescription { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIconPath({this})"
		/// @CSharpLua.Set = "BlzSetItemIconPath({this}, {0})"
		public extern string Icon { get; set; }

		/// @CSharpLua.Get = "GetItemLevel({this})"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_LEVEL, {0})"
		public extern int Level { get; set; }

		/// @CSharpLua.Get = "GetItemCharges({this})"
		/// @CSharpLua.Set = "SetItemCharges({this}, {0})"
		public extern int Charges { get; set; }

		/// @CSharpLua.Get = "BlzGetItemSkin({this})"
		/// @CSharpLua.Set = "BlzSetItemSkin({this}, {0})"
		public extern int Skin { get; set; }

		/// @CSharpLua.Template = "SetItemPosition({this}, {0}, {1})"
		public extern void SetPosition(float x, float y);
		/// @CSharpLua.Template = "SetItemPlayer({this}, {0}, {1})"
		public extern void SetOwner(player player, bool changeColor = true);
		/// @CSharpLua.Template = "SetItemDropID({this}, {0})"
		public extern void SetDropId(int unitId);
		/// @CSharpLua.Template = "BlzGetItemAbilityByIndex({this}, {0})"
		public extern ability GetAbilityByIndex(int index);
		/// @CSharpLua.Template = "BlzGetItemAbility({this}, {0})"
		public extern ability GetAbility(int abilityId);
		/// @CSharpLua.Template = "BlzItemAddAbility({this}, {0})"
		public extern bool AddAbility(int abilityId);
		/// @CSharpLua.Template = "BlzItemRemoveAbility({this}, {0})"
		public extern bool RemoveAbility(int abilityId);
		/// @CSharpLua.Template = "RemoveItem({this})"
		public extern void Dispose();

		#region Field editing
		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_PERISHABLE)"
		/// @CSharpLua.Set = "BlzSetItemBooleanField({this}, ITEM_BF_PERISHABLE, {0})"
		public extern bool Perishable { get; set; }

		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_INCLUDE_AS_RANDOM_CHOICE)"
		/// @CSharpLua.Set = "BlzSetItemBooleanField({this}, ITEM_BF_INCLUDE_AS_RANDOM_CHOICE, {0})"
		public extern bool IncludeAsRandomChoice { get; set; }

		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED)"
		/// @CSharpLua.Set = "BlzSetItemBooleanField({this}, ITEM_BF_USE_AUTOMATICALLY_WHEN_ACQUIRED, {0})"
		public extern bool UseAutomaticallyWhenAcquired { get; set; }

		/// @CSharpLua.Get = "BlzGetItemBooleanField({this}, ITEM_BF_ACTIVELY_USED)"
		/// @CSharpLua.Set = "BlzSetItemBooleanField({this}, ITEM_BF_ACTIVELY_USED, {0})"
		public extern bool ActivelyUsed { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_COOLDOWN_GROUP)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_COOLDOWN_GROUP, {0})"
		public extern int CooldownGroup { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_MAX_HIT_POINTS)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_MAX_HIT_POINTS, {0})"
		public extern int MaxHitPoints { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_PRIORITY)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_PRIORITY, {0})"
		public extern int Priority { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_ARMOR_TYPE)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_ARMOR_TYPE, {0})"
		public extern ArmorType armortype { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_RED)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_RED, {0})"
		public extern int TintingColorRed { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_GREEN)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_GREEN, {0})"
		public extern int TintingColorGreen { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_BLUE)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_BLUE, {0})"
		public extern int TintingColorBlue { get; set; }

		/// @CSharpLua.Get = "BlzGetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_ALPHA)"
		/// @CSharpLua.Set = "BlzSetItemIntegerField({this}, ITEM_IF_TINTING_COLOR_ALPHA, {0})"
		public extern int TintingColorAlpha { get; set; }

		/// @CSharpLua.Get = "BlzGetItemRealField({this}, ITEM_RF_SCALING_VALUE)"
		/// @CSharpLua.Set = "BlzSetItemRealField({this}, ITEM_RF_SCALING_VALUE, {0})"
		public extern float ScalingValue { get; set; }

		/// @CSharpLua.Get = "BlzGetItemStringField({this}, ITEM_SF_MODEL_USED)"
		/// @CSharpLua.Set = "BlzSetItemStringField({this}, ITEM_SF_MODEL_USED, {0})"
		public extern string ModelUsed { get; set; }
		#endregion
	}
}
