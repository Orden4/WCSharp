namespace WCSharp.Buffs
{
	/// <summary>
	/// Helper class to track the duration of a buff specific to an aura applying it. Used to handle the case of multiple auras applying the same buff to a single unit.
	/// </summary>
	/// <typeparam name="T">The specific type of the buff being tracked.</typeparam>
	public class AuraBuff<T>
		where T : Buff
	{
		/// <summary>
		/// This is the duration relative to the aura containing this instance of <see cref="AuraBuff{T}"/>.
		/// <para>If there are multiple sources applying an aura buff, the buff itself may persist even if this duration expires (i.e. moves away from this aura source).</para>
		/// </summary>
		public float Duration { get; set; }
		/// <summary>
		/// The actual buff being applied.
		/// </summary>
		public T Buff { get; set; }
	}
}
