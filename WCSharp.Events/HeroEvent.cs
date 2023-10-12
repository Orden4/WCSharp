namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in HeroEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a unit handle filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, WCSharp.Api.playerunitevent)"/>.</para>
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
		CancelsRevive = 2,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_FINISH
		/// </summary>
		FinishesRevive = 3,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		LearnsSpell = 4,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_LEVEL
		/// </summary>
		Levels = 5,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_REVIVE_START
		/// </summary>
		StartsRevive = 6,
	}
}
