using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class group : agent, IDisposable
	{
		internal group()
		{
		}

		/// @CSharpLua.Template = "CreateGroup()"
		public static extern group Create();

		/// @CSharpLua.Get = "FirstOfGroup({0})"
		public extern unit First { get; }
		/// @CSharpLua.Get = "BlzGroupGetSize({0})"
		public extern int Count { get; }

		/// @CSharpLua.Template = "IsUnitInGroup({0}, {this})"
		public extern bool Contains(unit unit);
		/// @CSharpLua.Template = "GroupAddUnit({this}, {0})"
		public extern bool Add(unit unit);
		/// @CSharpLua.Template = "BlzGroupAddGroupFast({this}, {0})"
		public extern int Add(group group);
		/// @CSharpLua.Template = "GroupRemoveUnit({this}, {0})"
		public extern bool Remove(unit unit);
		/// @CSharpLua.Template = "BlzGroupRemoveGroupFast({this}, {0})"
		public extern int Remove(group group);
		/// @CSharpLua.Template = "GroupClear({this})"
		public extern void Clear();
		/// @CSharpLua.Template = "BlzGroupUnitAt({this}, {0})"
		public extern unit UnitAtOrDefault(int index);

		/// @CSharpLua.Template = "GroupEnumUnitsOfType({this}, {0}, {1})"
		public extern void EnumUnitsOfType(string unitType, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsOfPlayer({this}, {0}, {1})"
		public extern void EnumUnitsOfPlayer(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsInRect({this}, {0}, {1})"
		public extern void EnumUnitsInRect(rect rect, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsInRange({this}, {0}, {1}, {2}, {3})"
		public extern void EnumUnitsInRange(float x, float y, float radius, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsSelected({this}, {0}, {1})"
		public extern void EnumUnitsSelected(player player, boolexpr filter = null);

		/// @CSharpLua.Template = "GroupImmediateOrder({this}, {0})"
		public extern bool IssueImmediateOrder(string order);
		/// @CSharpLua.Template = "GroupImmediateOrderById({this}, {0})"
		public extern bool IssueImmediateOrder(int order);
		/// @CSharpLua.Template = "GroupPointOrder({this}, {0}, {1}, {2})"
		public extern bool IssuePointOrder(string order, float x, float y);
		/// @CSharpLua.Template = "GroupPointOrderById({this}, {0}, {1}, {2})"
		public extern bool IssuePointOrder(int order, float x, float y);
		/// @CSharpLua.Template = "GroupTargetOrder({this}, {0}, {1})"
		public extern bool IssueTargetOrder(string order, widget target);
		/// @CSharpLua.Template = "GroupTargetOrderById({this}, {0}, {1})"
		public extern bool IssueTargetOrder(int order, widget target);

		/// @CSharpLua.Template = "ForGroup({this}, {0})"
		public extern void ForEach(Action action);

		/// @CSharpLua.Template = "DestroyGroup({this})"
		public extern void Dispose();
	}
}
