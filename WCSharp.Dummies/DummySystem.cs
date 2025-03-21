using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Shared.Extensions;
using static WCSharp.Api.Common;

namespace WCSharp.Dummies
{
	/// <summary>
	/// Tracks and recycles all dummy units on the map. Will automatically create more if necessary.
	/// </summary>
	public static class DummySystem
	{
		/// <summary>
		/// Corresponds to the code 'xxxx'
		/// </summary>
		public const int UNIT_TYPE_DUMMY = 2021161080;

		private static readonly PeriodicEvent periodicEvent = new(Countdown, 1.0);
		private static readonly List<unit> dummiesReady = new();
		private static readonly List<DummyBeingRecycled> dummiesBeingRecycled = new();

		static DummySystem()
		{
			PlayerUnitEvents.Register(UnitTypeEvent.SpellEndCast, OnDummyCast);
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
			for (var i = size - 1; i >= 0; i--)
			{
				var dummy = dummiesBeingRecycled[i];
				if (dummy.TicksLeft <= 0)
				{
					SetUnitX(dummy.Dummy, 0);
					SetUnitY(dummy.Dummy, 0);
					dummiesReady.Add(dummy.Dummy);

					size--;
					dummiesBeingRecycled[i] = dummiesBeingRecycled[size];
					dummiesBeingRecycled.RemoveAt(size);
				}
				else
				{
					dummy.TicksLeft--;
				}
			}

			return size > 0;
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
			dummiesBeingRecycled.Add(new DummyBeingRecycled(dummy, (int)(recycleTime / PeriodicEvents.SYSTEM_INTERVAL)));
		}

		/// <summary>
		/// Requests an available dummy.
		/// </summary>
		public static unit GetDummy()
		{
			var size = dummiesReady.Count;
			if (size == 0)
			{
				return CreateUnit(Player(PLAYER_NEUTRAL_PASSIVE), UNIT_TYPE_DUMMY, 0, 0, 0);
			}
			else
			{
				var dummy = dummiesReady[size - 1];
				dummiesReady.Nil(size);
				return dummy;
			}
		}

		/// <summary>
		/// Requests an available dummy at the given coordinates and under control of the given player.
		/// </summary>
		public static unit GetDummy(float x, float y, float z, player player)
		{
			var size = dummiesReady.Count;
			unit dummy;
			if (size == 0)
			{
				dummy = CreateUnit(Player(PLAYER_NEUTRAL_PASSIVE), UNIT_TYPE_DUMMY, 0, 0, 0);
			}
			else
			{
				dummy = dummiesReady[size - 1];
				dummiesReady.Nil(size);
			}
			SetUnitOwner(dummy, player, false);
			SetUnitPosition(dummy, x, y);
			SetUnitFlyHeight(dummy, z, int.MaxValue);
			return dummy;
		}
	}
}
