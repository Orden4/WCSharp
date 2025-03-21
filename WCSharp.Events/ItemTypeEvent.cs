namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in ItemTypeEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on an item type id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum ItemTypeEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		IsAbsorbed = 301,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		IsDropped,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		IsPawned,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		IsPickedUp,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		IsSold,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		IsStacked,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		IsUsed,
	}
}
