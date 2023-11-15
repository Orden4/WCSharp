using WCSharp.Api;

namespace WCSharp.Buffs
{
	/// <summary>
	/// Helper class to track the duration of a buff specific to an aura applying it. Used to handle the case of multiple auras applying the same buff to a single unit.
	/// </summary>
	/// <typeparam name="T">The specific type of the buff being tracked.</typeparam>
	internal class AuraBuffDuration<T>
		where T : Buff
	{
		/// <summary>
		/// The handle id of the unit affected by the aura.
		/// </summary>
		public unit Unit { get; }
		/// <summary>
		/// The actual buff being applied.
		/// </summary>
		public T Buff { get; }
		/// <summary>
		/// This is the duration relative to the aura containing this instance of <see cref="AuraBuffDuration{T}"/>.
		/// <para>If there are multiple sources applying an aura buff, the buff itself may persist even if this duration expires (i.e. moves away from this aura source).</para>
		/// </summary>
		public float Duration { get; internal set; }

		public AuraBuffDuration(unit unit, T buff, float duration)
		{
			Unit = unit;
			Buff = buff;
			Duration = duration;
		}
	}
}
