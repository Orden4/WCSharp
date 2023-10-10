using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class leaderboard : agent, IDisposable
	{
		internal leaderboard()
		{
		}

		/// @CSharpLua.Template = "CreateLeaderboard()"
		public static extern leaderboard Create();

		/// @CSharpLua.Get = "IsLeaderboardDisplayed({this})"
		/// @CSharpLua.Set = "LeaderboardDisplay({this}, {0})"
		public extern bool IsDisplayed { get; set; }

		/// @CSharpLua.Get = "LeaderboardGetLabelText({this})"
		/// @CSharpLua.Set = "LeaderboardSetLabel({this}, {0})"
		public extern string Label { get; set; }

		/// @CSharpLua.Get = "PlayerGetLeaderboard({this})"
		/// @CSharpLua.Set = "PlayerSetLeaderboard({this}, {0})"
		public extern player Player { get; set; }

		/// @CSharpLua.Get = "LeaderboardGetItemCount({this})"
		public extern int ItemCount { get; }

		/// @CSharpLua.Template = "LeaderboardSetSizeByItemCount({this}, {0})"
		public extern void SetSizeByItemCount(int count);

		/// @CSharpLua.Template = "LeaderboardAddItem({this}, {0}, {1}, {2})"
		public extern void AddItem(string label, int value, player player);

		/// @CSharpLua.Template = "LeaderboardRemoveItem({this}, {0})"
		public extern void RemoveItem(int itemIndex);

		/// @CSharpLua.Template = "LeaderboardRemovePlayerItem({this}, {0})"
		public extern void RemovePlayerItem(player player);

		/// @CSharpLua.Template = "LeaderboardClear({this})"
		public extern void Clear();

		/// @CSharpLua.Template = "LeaderboardSortItemsByValue({this}, {0})"
		public extern void SortByValue(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSortItemsByPlayer({this}, {0})"
		public extern void SortByPlayer(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSortItemsByLabel({this}, {0})"
		public extern void SortByLabel(bool ascending = true);

		/// @CSharpLua.Template = "LeaderboardSetLabelColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetLabelColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetValueColor({this}, {0}, {1}, {2}, {3})"
		public extern void SetValueColor(int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetStyle({this}, {0}, {1}, {2}, {3})"
		public extern void SetStyle(bool showLabel, bool showNames, bool showValues, bool showIcons);

		/// @CSharpLua.Template = "LeaderboardSetItemValue({this}, {0}, {1})"
		public extern void SetItemValue(int itemIndex, int value);

		/// @CSharpLua.Template = "LeaderboardSetItemLabel({this}, {0}, {1})"
		public extern void SetItemLabel(int itemIndex, string label);

		/// @CSharpLua.Template = "LeaderboardSetItemStyle({this}, {0}, {1}, {2}, {3})"
		public extern void SetItemStyle(int itemIndex, bool showLabel, bool showValue, bool showIcon);

		/// @CSharpLua.Template = "LeaderboardSetItemLabelColor({this}, {0}, {1}, {2}, {3}, {4})"
		public extern void SetItemLabelColor(int itemIndex, int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "LeaderboardSetItemValueColor({this}, {0}, {1}, {2}, {3}, {4})"
		public extern void SetItemValueColor(int itemIndex, int red, int green, int blue, int alpha = 255);

		/// @CSharpLua.Template = "DestroyLeaderboard({this})"
		public extern void Dispose();
	}
}
