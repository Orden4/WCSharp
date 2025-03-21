namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in PlayerEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a player id.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum PlayerEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_DESELECTED
		/// </summary>
		DeselectsUnit = 401,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		GainsOwnership,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_CHANGE_OWNER
		/// </summary>
		LosesOwnership,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SELECTED
		/// </summary>
		SelectsUnit,
	}
}
