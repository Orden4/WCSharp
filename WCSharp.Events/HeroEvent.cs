namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in HeroEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a unit handle filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum HeroEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVABLE
		/// </summary>
		BecomesRevivable = 1,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_CANCEL
		/// </summary>
		CancelsRevive,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_FINISH
		/// </summary>
		FinishesRevive,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		LearnsSpell,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_LEVEL
		/// </summary>
		Levels,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_START
		/// </summary>
		StartsRevive,
	}
}
