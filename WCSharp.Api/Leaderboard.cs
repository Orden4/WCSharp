using System;
using static War3Api.Common;

namespace WCSharp.Api
{
#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
	/// @CSharpLua.Ignore
	public class Leaderboard : Agent, IDisposable
	{
		internal Leaderboard()
		{
		}

		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator leaderboard(Leaderboard x);
		/// @CSharpLua.Template = "{0}"
		public static extern implicit operator Leaderboard(leaderboard x);

		/// @CSharpLua.Template = "CreateLeaderboard()"
		public static extern Leaderboard Create();

		/// @CSharpLua.Get = "IsLeaderboardDisplayed({0})"
		/// @CSharpLua.Set = "LeaderboardDisplay({0}, {1})"
		public extern bool IsDisplayed { get; set; }

		/// @CSharpLua.Get = "LeaderboardGetLabelText({0})"
		/// @CSharpLua.Set = "LeaderboardSetLabel({0}, {1})"
		public extern string Label { get; set; }

		/// @CSharpLua.Get = "PlayerGetLeaderboard({0})"
		/// @CSharpLua.Set = "PlayerSetLeaderboard({0}, {1})"
		public extern Player Player { get; set; }

		/// @CSharpLua.Get = "LeaderboardGetItemCount({0})"
		public extern int ItemCount { get; }

		/// @CSharpLua.Template = "LeaderboardSetSizeByItemCount({0}, {1})"
		public extern void SetSizeByItemCount(int count);

		/// @CSharpLua.Template = "LeaderboardAddItem({0}, {1}, {2}, {3})"
		public extern void AddItem(string label, int value, Player player);

		/// @CSharpLua.Template = "LeaderboardRemoveItem({0}, {1})"
		public extern void RemoveItem(int itemIndex);

		/// @CSharpLua.Template = "LeaderboardRemovePlayerItem({0}, {1})"
		public extern void RemovePlayerItem(Player player);

		/// @CSharpLua.Template = "LeaderboardClear({0})"
		public extern void Clear();

		/// @CSharpLua.Template = "LeaderboardSortItemsByValue({0}, {1})"
		public extern void SortByValue(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSortItemsByPlayer({0}, {1})"
		public extern void SortByPlayer(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSortItemsByLabel({0}, {1})"
		public extern void SortByLabel(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSetLabelColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetLabelColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetValueColor({0}, {1}, {2}, {3}, {4})"
		public extern void SetValueColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetStyle({0}, {1}, {2}, {3}, {4})"
		public extern void SetStyle(bool showLabel, bool showNames, bool showValues, bool showIcons);

		/// @CSharpLua.Template = "LeaderboardSetItemValue({0}, {1}, {2})"
		public extern void SetItemValue(int itemIndex, int value);

		/// @CSharpLua.Template = "LeaderboardSetItemLabel({0}, {1}, {2})"
		public extern void SetItemLabel(int itemIndex, string label);

		/// @CSharpLua.Template = "LeaderboardSetItemStyle({0}, {1}, {2}, {3}, {4})"
		public extern void SetItemStyle(int itemIndex, bool showLabel, bool showValue, bool showIcon);

		/// @CSharpLua.Template = "LeaderboardSetItemLabelColor({0}, {1}, {2}, {3}, {4}, {5})"
		public extern void SetItemLabelColor(int itemIndex, int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetItemValueColor({0}, {1}, {2}, {3}, {4}, {5})"
		public extern void SetItemValueColor(int itemIndex, int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "DestroyLeaderboard({0})"
		public extern void Dispose();
	}
}
