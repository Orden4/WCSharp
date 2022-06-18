namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in HeroTypeEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a unit type id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, War3Api.Common.playerunitevent)"/>.</para>
	/// </summary>
	public enum HeroTypeEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVABLE
		/// </summary>
		BecomesRevivable = 101,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_CANCEL
		/// </summary>
		CancelsRevive = 102,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_FINISH
		/// </summary>
		FinishesRevive = 103,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		LearnsSpell = 104,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_LEVEL
		/// </summary>
		Levels = 105,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_START
		/// </summary>
		StartsRevive = 106,
	}
}
