using System;
using System.Collections.Generic;
using WCSharp.Api;
using WCSharp.Shared;
using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	/// <summary>
	/// System responsible for bundling timers together in an efficient manner.
	/// </summary>
	public static class TimerSystem
	{
		/// <summary>
		/// The default interval between each tick of the system, equal to 32 ticks per second.
		/// </summary>
		public const float DEFAULT_TICK_INTERVAL = 0.03125f;

		/// <summary>
		/// The current interval between each tick of the system.
		/// <para>Use <see cref="SetTickInterval(float)"/> to adjust.</para>
		/// </summary>
		public static float TickInterval { get; private set; } = DEFAULT_TICK_INTERVAL;
		/// <summary>
		/// Event for responding to changes in the tick interval.
		/// </summary>
		public static event TickIntervalChangedEventHandler OnTickIntervalChanged;

		internal static List<TimerRoot> Roots { get; } = new();

		private static readonly Dictionary<float, TimerRoot> rootsByTimeout = new();
		private static readonly TimerRoot nativeRoot = new(DEFAULT_TICK_INTERVAL);
		private static readonly timer timer = Initialize();
		private static bool debug;

		private static timer Initialize()
		{
			var t = timer.Create();
			t.Start(DEFAULT_TICK_INTERVAL, true, Action);
			return t;
		}

		/// <summary>
		/// Changes <see cref="TickInterval"/> to <paramref name="tickInterval"/> after a 0 second delay.
		/// <para>It is strongly recommended to use multiples of 2 as tick interval (e.g. 1/16, 1/32, 1/64, etc).</para>
		/// <para>Setting this to 0 or less will pause the system.</para>
		/// </summary>
		public static void SetTickInterval(float tickInterval)
		{
			Delay.Add(() => SetTickIntervalInternal(tickInterval));
		}

		private static void SetTickIntervalInternal(float tickInterval)
		{
			if (TickInterval == tickInterval)
				return;

			if (timer.Elapsed == 0 || TickInterval <= 0)
			{
				ExecuteSetTickInterval(tickInterval);
			}
			else
			{
				timer.Start(timer.Remaining, false, () =>
				{
					if (debug)
					{
						GuardedAction();
					}
					else
					{
						Action();
					}
					ExecuteSetTickInterval(tickInterval);
				});
			}
		}

		private static void ExecuteSetTickInterval(float tickInterval)
		{
			if (TickInterval == tickInterval)
				return;

			var old = TickInterval;
			TickInterval = tickInterval;
			nativeRoot.Timeout = tickInterval;
			OnTickIntervalChanged?.Invoke(tickInterval, old);

			if (tickInterval > 0)
			{
				timer.Start(tickInterval, true, debug ? GuardedAction : Action);
			}
			else
			{
				timer.Pause();
			}
		}

		/// <summary>
		/// Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to <see cref="TimerSystem"/> will automatically output
		/// information.
		/// <para>It is recommended to use compilation time conditions to not call this on release mode.</para>
		/// </summary>
		public static void EnableDebug()
		{
			debug = true;
			timer.Start(TickInterval, true, GuardedAction);
		}

		/// <summary>
		/// Reactivates the given timer.
		/// </summary>
		public static void Add(Timer timer)
		{
			if (timer.Active)
				return;

			var root = GetOrCreate(timer.Timeout);
			root.Add(timer);
		}

		/// <summary>
		/// Creates a new dedicated timer for the given action.
		/// </summary>
		public static Timer Add(Action<Timer> timerAction, float timeout)
		{
			var leaf = new Timer(timerAction, timeout);
			Add(leaf);
			return leaf;
		}

		internal static TimerRoot GetOrCreate(float? timeout)
		{
			if (!timeout.HasValue)
				return nativeRoot;

			if (!rootsByTimeout.TryGetValue(timeout.Value, out var root))
			{
				rootsByTimeout[timeout.Value] = root = new(timeout.Value);
			}

			return root;
		}

		private static void Action()
		{
			var size = Roots.Count;
			var tickInterval = TickInterval;
			for (var i = 1; i <= size; i++)
			{
				var item = Roots.DirectGet(i);
				item.TimerRemaining -= tickInterval;

				if (item.TimerRemaining <= 0)
				{
					item.TimerRemaining += item.Timeout;
					item.Action();
				}

				if (!item.Active)
				{
					Roots.DirectMove(size, i);
					size--;
					Roots.RemoveAt(size);
					i--;
				}
			}
		}

		private static void GuardedAction()
		{
			try
			{
				Action();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}
