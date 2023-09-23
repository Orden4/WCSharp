namespace WCSharp.W3MMD
{
	/// <summary>
	/// An arbitrary W3MMD variable of any type.
	/// </summary>
	public interface IW3MmdVar
	{
		/// <summary>
		/// The name of the W3MMD variable.
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// The variable's type.
		/// </summary>
		public W3MmdVariableType VariableType { get; }
		/// <summary>
		/// The variable's sort order, i.e. whether it's better to have high or low values.
		/// </summary>
		public W3MmdGoalType GoalType { get; }
		/// <summary>
		/// A suggestion for what the parser should do for tracking the variable.
		/// </summary>
		public W3MmdSuggestionType SuggestionType { get; }
	}
}
