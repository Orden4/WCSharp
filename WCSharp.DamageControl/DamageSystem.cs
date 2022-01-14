using System;
using System.Collections.Generic;
using static War3Api.Common;

namespace WCSharp.DamageControl
{
	public static class DamageSystem<T>
		where T : IDamage
	{
		private static readonly List<Action<T>> actions = new List<Action<T>>();
		private static readonly Dictionary<int, List<Action<T>>> unitTypeActions = new Dictionary<int, List<Action<T>>>();
		private static readonly Dictionary<unit, List<Action<T>>> unitActions = new Dictionary<unit, List<Action<T>>>();



		public static void Subscribe(Action<T> action)
		{

		}

		public static void Subscribe(Action<T> action, int unitType)
		{

		}

		public static void Subscribe(Action<T> action, unit unit)
		{

		}

		public static void Unsubscribe(Action<T> action)
		{

		}

		public static void Unsubscribe(Action<T> action, int unitType)
		{

		}

		public static void Unsubscribe(Action<T> action, unit unit)
		{

		}

		public static void Damage(T damage)
		{

		}
	}
}
