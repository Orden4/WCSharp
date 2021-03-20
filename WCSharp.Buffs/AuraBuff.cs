namespace WCSharp.Buffs
{
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
