using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Events;
using WCSharp.Shared.Extensions;
using WCSharp.Timers;
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

		private const float RECYCLE_INTERVAL = 0.125f;

		private static readonly Timer timer = TimerSystem.Add(Countdown, RECYCLE_INTERVAL);
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

		private static void Countdown(Timer timer)
		{
			var size = dummiesBeingRecycled.Count;
			for (var i = size; i > 0; i--)
			{
				var dummy = dummiesBeingRecycled.DirectGet(i);
				if (dummy.TimeLeft <= 0)
				{
					SetUnitX(dummy.Dummy, 0);
					SetUnitY(dummy.Dummy, 0);
					dummiesReady.DirectAdd(dummy.Dummy);

					dummiesBeingRecycled.DirectMove(size, i);
					size--;
					dummiesBeingRecycled.RemoveAt(size);
					i++;
				}
				else
				{
					dummy.TimeLeft -= RECYCLE_INTERVAL;
				}
			}
		}

		/// <summary>
		/// Call this when you are done with a dummy. The dummy will become available for use again after the <paramref name="recycleTime"/>.
		/// </summary>
		public static void RecycleDummy(unit dummy, float recycleTime = 2.0f)
		{
			if (dummiesBeingRecycled.Count == 0)
			{
				TimerSystem.Add(timer);
			}
			dummiesBeingRecycled.DirectAdd(new DummyBeingRecycled(dummy, recycleTime));
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
				var dummy = dummiesReady.DirectGet(size);
				dummiesReady.DirectNil(size);
				return dummy;
			}
		}

		/// <summary>
		/// Requests an available dummy at the given coordinates, optionally under control of the given player.
		/// </summary>
		public static unit GetDummy(float x, float y, player player = null)
		{
			var dummy = GetDummy();
			if (player != null)
				SetUnitOwner(dummy, player, false);
			SetUnitPosition(dummy, x, y);
			return dummy;
		}

		/// <summary>
		/// Requests an available dummy at the given coordinates and under control of the given player.
		/// </summary>
		public static unit GetDummy(float x, float y, float z, player player)
		{
			var dummy = GetDummy(x, y, player);
			SetUnitFlyHeight(dummy, z, int.MaxValue);
			return dummy;
		}
	}
}
