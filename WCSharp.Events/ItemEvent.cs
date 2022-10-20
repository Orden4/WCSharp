namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in ItemEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on an item filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, War3Api.Common.playerunitevent)"/>.</para>
	/// </summary>
	public enum ItemEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		IsAbsorbed = 201,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DROP_ITEM
		/// </summary>
		IsDropped = 202,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PAWN_ITEM
		/// </summary>
		IsPawned = 203,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_PICKUP_ITEM
		/// </summary>
		IsPickedUp = 204,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELL_ITEM
		/// </summary>
		IsSold = 205,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_STACK_ITEM
		/// </summary>
		IsStacked = 206,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_USE_ITEM
		/// </summary>
		IsUsed = 207,
	}
}
