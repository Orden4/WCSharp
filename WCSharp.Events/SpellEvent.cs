namespace WCSharp.Events
{
	/// <summary>
	/// Defines all built-in SpellEvents supported by <see cref="PlayerUnitEvents"/>.
	/// <para>All of these events fire based on a ability id filter.</para>
	/// <para>Custom events can also be specified via <see cref="PlayerUnitEvents.AddCustomEvent(string, System.Func{int}, Api.playerunitevent)"/>.</para>
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
		Channel,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_EFFECT
		/// </summary>
		Effect,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_ENDCAST
		/// </summary>
		EndCast,
		/// <summary>
		/// Based on EVENT_PLAYER_UNIT_SPELL_FINISH
		/// </summary>
		Finish,
		/// <summary>
		/// Based on EVENT_PLAYER_HERO_SKILL
		/// </summary>
		Learned,
	}
}
