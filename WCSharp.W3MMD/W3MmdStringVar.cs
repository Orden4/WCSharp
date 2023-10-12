using System;
using WCSharp.Api;
using static WCSharp.Api.Common;
using static WCSharp.W3MMD.W3Mmd;

namespace WCSharp.W3MMD
{
	/// <summary>
	/// Controls a W3MMD variable of type <see cref="W3MmdVariableType.String"/>.
	/// </summary>
	public class W3MmdStringVar : IW3MmdVar
	{
		/// <inheritdoc/>
		public string Name { get; }
		/// <inheritdoc/>
		public W3MmdVariableType VariableType => W3MmdVariableType.String;
		/// <inheritdoc/>
		public W3MmdGoalType GoalType => W3MmdGoalType.None;
		/// <inheritdoc/>
		public W3MmdSuggestionType SuggestionType { get; }

		private readonly string packedName;

		/// <summary>
		/// Defines a player string variable that can be mutated throughout the game.
		/// <para>Useful to classifications.</para>
		/// </summary>
		/// <param name="name">Name of the variable.</param>
		/// <param name="suggestionType">A suggestion for how a parser/viewer should treat the output values.</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public W3MmdStringVar(string name, W3MmdSuggestionType suggestionType)
		{
			if (name.Length < 1 || name.Length > 32)
				throw new Exception($"w3mmd: invalid name ({name}), must be between 1 and 32 characters long");

			Name = name;
			SuggestionType = suggestionType;
			this.packedName = name.Pack();

			DefineVar(this.packedName, VariableType, GoalType, SuggestionType);
		}

		/// <summary>
		/// Sets this variable to the given <paramref name="value"/> for the given <paramref name="player"/>.
		/// </summary>
		public void Set(player player, string value)
		{
			Set(GetPlayerId(player), value);
		}

		/// <summary>
		/// Sets this variable to the given <paramref name="value"/> for the given <paramref name="playerId"/>.
		/// </summary>
		public void Set(int playerId, string value)
		{
			Emit($"VarP {playerId} {this.packedName} = {value.Pack()}");
		}
	}
}
