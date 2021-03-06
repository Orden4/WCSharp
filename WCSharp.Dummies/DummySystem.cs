using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace WCSharp.Dummies
{
	public static partial class DummySystem
	{
		public const int UNIT_TYPE_DUMMY = 2021161080;

		private static readonly PeriodicEvent periodicEvent = new PeriodicEvent(Countdown, 1.0);
		private static readonly List<unit> dummiesReady = new List<unit>();
		private static readonly List<DummyBeingRecycled> dummiesBeingRecycled = new List<DummyBeingRecycled>();

#pragma warning disable IDE0052 // Remove unread private members
		private static readonly object initialiser = Initialise();
#pragma warning restore IDE0052 // Remove unread private members
		private static object Initialise()
		{
			PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeSpellEndCast, OnDummyCast);

			return null;
		}

		private static void OnDummyCast()
		{
			var unit = GetTriggerUnit();
			if (GetUnitTypeId(unit) == UNIT_TYPE_DUMMY)
			{
				UnitRemoveAbility(unit, GetSpellAbilityId());
			}
		}

		private static bool Countdown()
		{
			var size = dummiesBeingRecycled.Count;
			if (size == 0)
			{
				return false;
			}

			var i = 0;
			while (i < size)
			{
				var dummy = dummiesBeingRecycled[i];
				if (dummy.TicksLeft <= 0)
				{
					dummiesReady.Add(dummy.Dummy);
					size--;
					dummiesBeingRecycled[i] = dummiesBeingRecycled[size];
					dummiesBeingRecycled.RemoveAt(size);
				}
				else
				{
					i++;
					dummy.TicksLeft--;
				}
			}

			return true;
		}

		/// <summary>
		/// Call this when you are done with a dummy. The dummy will become available for use again after the <paramref name="recycleTime"/>.
		/// </summary>
		public static void RecycleDummy(unit dummy, float recycleTime = 2.0f)
		{
			if (dummiesBeingRecycled.Count == 0)
			{
				PeriodicEvents.AddPeriodicEvent(periodicEvent);
			}
			dummiesBeingRecycled.Add(new DummyBeingRecycled(dummy, recycleTime));
		}

		/// <summary>
		/// Requests an available dummy.
		/// </summary>
		public static unit GetDummy()
		{
			var size = dummiesReady.Count - 1;
			if (size == -1)
			{
				return CreateUnit(Player(PLAYER_NEUTRAL_PASSIVE), UNIT_TYPE_DUMMY, 0, 0, 0);
			}
			else
			{
				var dummy = dummiesReady[size];
				dummiesReady.RemoveAt(size);
				return dummy;
			}
		}

		/// <summary>
		/// Requests an available dummy at the given coordinates and under control of the given player.
		/// </summary>
		public static unit GetDummy(float x, float y, float z, player player)
		{
			var size = dummiesReady.Count - 1;
			unit dummy;
			if (size == -1)
			{
				dummy = CreateUnit(Player(PLAYER_NEUTRAL_PASSIVE), UNIT_TYPE_DUMMY, 0, 0, 0);
			}
			else
			{
				dummy = dummiesReady[size];
				dummiesReady.RemoveAt(size);
			}
			SetUnitOwner(dummy, player, false);
			SetUnitPosition(dummy, x, y);
			SetUnitFlyHeight(dummy, z, int.MaxValue);
			return dummy;
		}
	}
}
