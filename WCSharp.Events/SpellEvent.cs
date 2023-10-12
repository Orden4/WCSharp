namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in SpellEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a ability id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, WCSharp.Api.playerunitevent)"/>.</para>
	/// </summary>
	public enum SpellEvent
	{
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CAST
		/// </summary>
		Cast = 601,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_CHANNEL
		/// </summary>
		Channel = 602,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		Effect = 603,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		EndCast = 604,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		Finish = 605,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		Learned = 606,
	}
}
