using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.Cascading
{
	public static class Cascade<T>
	{
		private static readonly Dictionary<int, List<CascadingAction<T>>> actionsByHandleId = new Dictionary<int, List<CascadingAction<T>>>();

		private static bool addRemoveRequired;
		private static readonly List<Action> addRemoveActions;

		public static void Register(Action<T> action, int priority, unit unit)
		{
			Register(action, priority, GetHandleId(unit));
		}

		public static void Register(Action<T> action, int priority, int handleId)
		{
			addRemoveActions.Add(() => RegisterInternal(action, priority, handleId));
			addRemoveRequired = true;
		}

		private static void RegisterInternal(Action<T> action, int priority, int handleId)
		{
			if (!actionsByHandleId.TryGetValue(handleId, out var actions))
			{
				actionsByHandleId[handleId] = actions = new List<CascadingAction<T>>();
			}

			var min = 0;
			var max = actions.Count - 1;
			while (min <= max)
			{
				var mid = min + ((max - min) >> 1);
				var item = actions[mid];
				if (item.Priority > priority)
				{
					max = mid - 1;
				}
				else if (item.Priority < priority)
				{
					min = mid + 1;
				}
				else
				{
					min = mid + 1;
					for (var i = min + 1; i < actions.Count; i++)
					{
						if (actions[i].Priority == priority)
						{
							min++;
						}
						else
						{
							break;
						}
					}
					max = -1;
				}
			}


			actions.Insert(min, new CascadingAction<T>(action, priority));
		}

		public static void Unregister(Action<T> action, unit unit)
		{
			Unregister(action, GetHandleId(unit));
		}

		public static void Unregister(Action<T> action, int handleId)
		{
			addRemoveActions.Add(() => UnregisterInternal(action, handleId));
			addRemoveRequired = true;
		}

		private static void UnregisterInternal(Action<T> action, int handleId)
		{
			if (actionsByHandleId.TryGetValue(handleId, out var actions))
			{
				for (var i = 0; i < actions.Count; i++)
				{
					if (actions[i].Action == action)
					{
						if (actions.Count == 1)
						{
							actionsByHandleId.Remove(handleId);
						}
						else
						{
							actions.RemoveAt(i);
						}
						return;
					}
				}
			}
		}

		public static void Start(unit unit, T obj)
		{
			Start(GetHandleId(unit), obj);
		}

		public static void Start(int handleId, T obj)
		{
			if (addRemoveRequired)
			{
				ExecuteAddRemove();
			}

			if (actionsByHandleId.TryGetValue(handleId, out var actions))
			{
				for (var i = 0; i < actions.Count; i++)
				{
					actions[i].Action.Invoke(obj);
				}
			}
		}

		private static void ExecuteAddRemove()
		{
			for (var i = 0; i < addRemoveActions.Count; i++)
			{
				addRemoveActions[i].Invoke();
			}
			addRemoveActions.Clear();
			addRemoveRequired = false;
		}
	}
}
