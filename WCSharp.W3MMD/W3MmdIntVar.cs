using System;
using static War3Api.Common;
using static WCSharp.W3MMD.W3Mmd;

namespace WCSharp.W3MMD
{
	/// <summary>
	/// Controls a W3MMD variable of type <see cref="W3MmdVariableType.Integer"/>.
	/// </summary>
	public class W3MmdIntVar : IW3MmdVar
	{
		/// <inheritdoc/>
		public string Name { get; }
		/// <inheritdoc/>
		public W3MmdVariableType VariableType => W3MmdVariableType.Integer;
		/// <inheritdoc/>
		public W3MmdGoalType GoalType { get; }
		/// <inheritdoc/>
		public W3MmdSuggestionType SuggestionType { get; }

		private readonly string packedName;

		/// <summary>
		/// Defines a player int variable that can be mutated throughout the game.
		/// </summary>
		/// <param name="name">Name of the variable.</param>
		/// <param name="goalType">Whether the player is trying to get a high or low value (or none).</param>
		/// <param name="suggestionType">A suggestion for how a parser/viewer should treat the output values.</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public W3MmdIntVar(string name, W3MmdGoalType goalType, W3MmdSuggestionType suggestionType)
		{
			if (name.Length < 1 || name.Length > 32)
				throw new Exception($"w3mmd: invalid name ({name}), must be between 1 and 32 characters long");

			Name = name;
			GoalType = goalType;
			SuggestionType = suggestionType;
			this.packedName = name.Pack();

			DefineVar(this.packedName, VariableType, GoalType, SuggestionType);
		}

		/// <summary>
		/// Sets this variable to the given <paramref name="value"/> for the given <paramref name="player"/>.
		/// </summary>
		public void Set(player player, int value)
		{
			Set(GetPlayerId(player), value);
		}

		/// <summary>
		/// Sets this variable to the given <paramref name="value"/> for the given <paramref name="playerId"/>.
		/// </summary>
		public void Set(int playerId, int value)
		{
			Emit($"VarP {playerId} {this.packedName} = {value}");
		}

		/// <summary>
		/// Adds the given <paramref name="value"/> to this variable for the given <paramref name="player"/>.
		/// </summary>
		public void Add(player player, int value)
		{
			Add(GetPlayerId(player), value);
		}

		/// <summary>
		/// Adds the given <paramref name="value"/> to this variable for the given <paramref name="playerId"/>.
		/// </summary>
		public void Add(int playerId, int value)
		{
			Emit($"VarP {playerId} {this.packedName} += {value}");
		}

		/// <summary>
		/// Subtracts the given <paramref name="value"/> to this variable for the given <paramref name="player"/>.
		/// </summary>
		public void Subtract(player player, int value)
		{
			Subtract(GetPlayerId(player), value);
		}

		/// <summary>
		/// Subtracts the given <paramref name="value"/> to this variable for the given <paramref name="playerId"/>.
		/// </summary>
		public void Subtract(int playerId, int value)
		{
			Emit($"VarP {playerId} {this.packedName} -= {value}");
		}
	}
}
