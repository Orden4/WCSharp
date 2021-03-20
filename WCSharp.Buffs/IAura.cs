using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Buffs
{
	public interface IAura : IPeriodicAction
	{
		/// <summary>
		/// The caster.
		/// </summary>
		unit Caster { get; set; }
		/// <summary>
		/// The owner of the caster. Automatically set on application.
		/// <para>Does NOT update automatically! If this is desired, you can use <see cref="BuffSystem.RegisterForOwnershipChanges"/>.</para>
		/// </summary>
		player CastingPlayer { get; set; }

		/// <summary>
		/// The range within which units must be for the aura to be applied to them.
		/// </summary>
		float Radius { get; set; }
		/// <summary>
		/// The duration in seconds of buffs applied by this aura.
		/// <para>Unless you're making a pulsing aura, you will want the <see cref="Duration"/> to be greater than the <see cref="SearchInterval"/>.</para>
		/// </summary>
		float Duration { get; set; }
		/// <summary>
		/// How long in seconds until this aura will next be applied to valid units in range.
		/// </summary>
		float SearchIntervalLeft { get; set; }
		/// <summary>
		/// How long in seconds between applications of this aura.
		/// </summary>
		float SearchInterval { get; set; }
		/// <summary>
		/// The stack behaviour of buffs applied by this aura.
		/// <para>Note that even with <see cref="StackBehaviour.None"/>, auras will still only stack once per aura instance.</para>
		/// </summary>
		StackBehaviour StackBehaviour { get; set; }

		/// <summary>
		/// The path of the effect to use. Leave empty for no effect.
		/// <para>If changed while the aura is already active, will destroy and recreate the effect.</para>
		/// </summary>
		string EffectString { get; set; }

		/// <summary>
		/// The attachment point for the effect.
		/// <para>If changed while the aura is already active, will destroy and recreate the effect at the desired attachment point.</para>
		/// <para>Defaults to origin.</para>
		/// </summary>
		string EffectAttachmentPoint { get; set; }

		/// <summary>
		/// Returns all generic buffs currently active for this aura.
		/// </summary>
		IEnumerable<Buff> GetActiveBuffs();
	}
}
