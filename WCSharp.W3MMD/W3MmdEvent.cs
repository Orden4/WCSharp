using System;
using System.Collections.Generic;
using System.Linq;

namespace WCSharp.W3MMD
{
	/// <summary>
	/// Represents a W3MMD event. For example, "X killed Y".
	/// </summary>
	public class W3MmdEvent
	{
		/// <summary>
		/// The name of the event.
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// The format of the event.
		/// <para>E.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim).</para>
		/// </summary>
		public string Format { get; }
		/// <summary>
		/// The names of the arguments. e.g., ["killer", "victim"]
		/// </summary>
		public IEnumerable<string> Arguments => this.arguments;
		/// <summary>
		/// The number of arguments.
		/// </summary>
		public int ArgumentCount => this.arguments.Count;

		private readonly List<string> arguments;
		private readonly string packedName;
		private readonly string packedArguments;

		/// <summary>
		/// Defines an event that can occur multiple times.
		/// </summary>
		/// <param name="name">Name of the event.</param>
		/// <param name="format">
		/// String to format an event into a user-consumable string.
		/// <para>e.g., for a player kills player event, we'd do "{0} killed {1}" where {0} is the first argument (the killer) and {1} is the second argument (the victim).</para>
		/// </param>
		/// <param name="arguments">Name of the arguments. e.g., ["killer", "victim"].</param>
		/// <exception cref="Exception">If the name is not between 1 and 32 characters long.</exception>
		public W3MmdEvent(string name, string format, params string[] arguments)
		{
			if (name.Length < 1 || name.Length > 32)
				throw new Exception($"w3mmd: invalid name ({name}), must be between 1 and 32 characters long");

			Name = name;
			Format = format;
			this.arguments = arguments.ToList();
			this.packedName = name.Pack();
			this.packedArguments = string.Join(' ', this.arguments.Select(x => x.Pack()));

			var finalArgs = ArgumentCount > 0 ? $"{ArgumentCount} {this.packedArguments}" : ArgumentCount.ToString();
			W3Mmd.Emit($"DefEvent {this.packedName} {finalArgs} {format.Pack()}");
		}

		/// <summary>
		/// Emits a new event with the given parameters.
		/// </summary>
		/// <param name="args">A number of arguments equal to <see cref="ArgumentCount"/>.</param>
		/// <exception cref="Exception">If the number of arguments provided does not match <see cref="ArgumentCount"/>.</exception>
		public void Emit(params string[] args)
		{
			if (args.Length != ArgumentCount)
				throw new Exception($"w3mmd: event {Name} with {ArgumentCount} arguments tried to emit with {args.Length} arguments.");

			var packedArgs = string.Join(' ', args);
			if (packedArgs.Length > 0)
			{
				packedArgs = $" {packedArgs}";
			}
			W3Mmd.Emit($"Event {this.packedName}{packedArgs}");
		}
	}
}
