namespace WCSharp.Buffs
{
	/// <summary>
	/// Represents a dispel attempt on a buff. Will be returned even if the dispel was resisted (i.e. no stacks were dispelled).
	/// </summary>
	public class Dispel
	{
		/// <summary>
		/// The buff that was (attempted to be) dispelled.
		/// </summary>
		public Buff Buff { get; }
		/// <summary>
		/// Whether the buff was fully dispelled.
		/// </summary>
		public bool FullyDispelled { get; }
		/// <summary>
		/// How many dispel charges were consumed. If negative, it added to the dispel charges remaining.
		/// </summary>
		public int DispelChargesConsumed { get; }
		/// <summary>
		/// How many buff charges were dispelled. If negative, the charges were increased.
		/// </summary>
		public int BuffStacksDispelled { get; }

		internal Dispel(Buff buff, int dispelChargesConsumed, int buffStacksDispelled)
		{
			Buff = buff;
			FullyDispelled = !buff.Active;
			DispelChargesConsumed = dispelChargesConsumed;
			BuffStacksDispelled = buffStacksDispelled;
		}
	}
}
