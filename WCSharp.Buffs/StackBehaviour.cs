namespace WCSharp.Buffs
{
	/// <summary>
	/// An enum to indicate how buffs should be stacked.
	/// </summary>
	public enum StackBehaviour
	{
		/// <summary>
		/// This buff will not stack in any way. All buffs will be applied individually.
		/// </summary>
		None,
		/// <summary>
		/// This buff will stack with all instances of itself.
		/// </summary>
		Stack,
		/// <summary>
		/// This buff will stack with all instances of itself cast by the same unit.
		/// </summary>
		StackCaster,
		/// <summary>
		/// This buff will stack with all instances of itself cast by the same player.
		/// </summary>
		StackPlayer
	}
}
