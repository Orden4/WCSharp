namespace WCSharp.Buffs
{
	/// <summary>
	/// An enum to indicate how the buffs were stacked.
	/// </summary>
	public enum StackResult
	{
		/// <summary>
		/// Reject the stack attempt (apply separately).
		/// </summary>
		Reject,
		/// <summary>
		/// Keep old buff, discard new buff.
		/// </summary>
		Stack,
		/// <summary>
		/// Keep new buff, discard old buff.
		/// </summary>
		Consume
	}
}
