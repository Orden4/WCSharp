using System;
using System.Linq;

namespace WCSharp.W3MMD
{
	internal static class W3MmdExtensions
	{
		private static readonly char[] escapedChars = new char[]
		{
				' ',
				'\\'
		};

		/// <summary>
		/// Escapes the W3MMD control characters.
		/// </summary>
		public static string Pack(this string value)
		{
			var result = "";
			for (var i = 0; i < value.Length; i++)
			{
				if (escapedChars.Contains(value[i]))
				{
					result += $"\\{value[i]}";
				}
				else
				{
					result += value[i];
				}
			}
			return result;
		}

		public static string Pack(this W3MmdFlag f)
		{
			return f switch
			{
				W3MmdFlag.Drawer => "drawer",
				W3MmdFlag.Loser => "loser",
				W3MmdFlag.Winner => "winner",
				W3MmdFlag.Leaver => "leaver",
				W3MmdFlag.Practicing => "practicing",
				_ => throw new NotImplementedException($"w3mmd: unknown flag {f}")
			};
		}

		public static string Pack(this W3MmdGoalType gt)
		{
			return gt switch
			{
				W3MmdGoalType.None => "none",
				W3MmdGoalType.High => "high",
				W3MmdGoalType.Low => "low",
				_ => throw new NotImplementedException($"w3mmd: unknown goal type {gt}")
			};
		}

		public static string Pack(this W3MmdSuggestionType st)
		{
			return st switch
			{
				W3MmdSuggestionType.None => "none",
				W3MmdSuggestionType.Track => "track",
				W3MmdSuggestionType.Leaderboard => "leaderboard",
				_ => throw new NotImplementedException($"w3mmd: unknown suggestion type {st}")
			};
		}

		public static string Pack(this W3MmdVariableType vt)
		{
			return vt switch
			{
				W3MmdVariableType.String => "string",
				W3MmdVariableType.Integer => "int",
				W3MmdVariableType.Float => "real",
				_ => throw new NotImplementedException($"w3mmd: unknown variable type {vt}")
			};
		}
	}
}
