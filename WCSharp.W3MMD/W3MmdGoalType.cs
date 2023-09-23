namespace WCSharp.W3MMD
{
	/// <summary>
	/// Defines the sort order on the variable, i.e. whether it's better to have high or low values.
	/// </summary>
	public enum W3MmdGoalType
	{
		/// <summary>
		/// No sort order.
		/// </summary>
		None,
		/// <summary>
		/// High is better. Sorts high to low.
		/// </summary>
		High,
		/// <summary>
		/// Low is better. Sorts low to high.
		/// </summary>
		Low
	}
}
