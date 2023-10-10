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

		/// @CSharpLua.Get = "FirstOfGroup({1})"
		public extern unit First { get; }
		/// @CSharpLua.Get = "BlzGroupGetSize({1})"
		public extern int Count { get; }

		/// @CSharpLua.Template = "IsUnitInGroup({1}, {0})"
		public extern bool Contains(unit unit);
		/// @CSharpLua.Template = "GroupAddUnit({0}, {1})"
		public extern bool Add(unit unit);
		/// @CSharpLua.Template = "BlzGroupAddGroupFast({0}, {1})"
		public extern int Add(group group);
		/// @CSharpLua.Template = "GroupRemoveUnit({0}, {1})"
		public extern bool Remove(unit unit);
		/// @CSharpLua.Template = "BlzGroupRemoveGroupFast({0}, {1})"
		public extern int Remove(group group);
		/// @CSharpLua.Template = "GroupClear({0})"
		public extern void Clear();
		/// @CSharpLua.Template = "BlzGroupUnitAt({0}, {1})"
		public extern unit UnitAtOrDefault();

		/// @CSharpLua.Template = "GroupEnumUnitsOfPlayer({0}, {1}, {2})"
		public extern void EnumUnitsOfType(string unitType, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsOfPlayer({0}, {1}, {2})"
		public extern void EnumUnitsOfPlayer(player player, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsOfPlayer({0}, {1}, {2})"
		public extern void EnumUnitsInRect(rect rect, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsInRange({0}, {1}, {2}, {3}, {4})"
		public extern void EnumUnitsInRange(float x, float y, float radius, boolexpr filter = null);
		/// @CSharpLua.Template = "GroupEnumUnitsSelected({0}, {1}, {2})"
		public extern void EnumUnitsSelected(player player, boolexpr filter = null);

		/// @CSharpLua.Template = "GroupImmediateOrder({0}, {1})"
		public extern bool IssueImmediateOrder(string order);
		/// @CSharpLua.Template = "GroupImmediateOrderById({0}, {1})"
		public extern bool IssueImmediateOrder(int order);
		/// @CSharpLua.Template = "GroupPointOrder({0}, {1}, {2}, {3})"
		public extern bool IssuePointOrder(string order, float x, float y);
		/// @CSharpLua.Template = "GroupPointOrderById({0}, {1}, {2}, {3})"
		public extern bool IssuePointOrder(int order, float x, float y);
		/// @CSharpLua.Template = "GroupTargetOrder({0}, {1}, {2})"
		public extern bool IssueTargetOrder(string order, widget target);
		/// @CSharpLua.Template = "GroupTargetOrderById({0}, {1}, {2})"
		public extern bool IssueTargetOrder(int order, widget target);

		/// @CSharpLua.Template = "ForGroup({0})"
		public extern void ForEach(Action action);

		/// @CSharpLua.Template = "DestroyGroup({0})"
		public extern void Dispose();
	}
}
