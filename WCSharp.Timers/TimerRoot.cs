using System.Collections.Generic;
using WCSharp.Shared.Extensions;

namespace WCSharp.Timers
{
	internal class TimerRoot : ITimerAction
	{
		public bool Active { get; set; }
		public float Timeout { get; set; }
		public float TimerRemaining { get; set; }

		private readonly List<ITimerAction> items = new();

		public TimerRoot(float timeout)
		{
			Timeout = timeout;
		}

		public void Add(ITimerAction item)
		{
			if (this.items.Count == 0)
			{
				TimerSystem.Roots.Add(this);
				Active = true;
			}

			this.items.Add(item);
			item.Active = true;
		}

		public void Remove(ITimerAction timerAction)
		{
			this.items.Remove(timerAction);
		}

		public void Action()
		{
			var size = this.items.Count;
			for (var i = 1; i <= size; i++)
			{
				var item = this.items.DirectGet(i);

				if (item.Active)
					item.Action();

				if (!item.Active)
				{
					this.items.DirectMove(size, i);
					size--;
					this.items.RemoveAt(size);
					i--;
				}
			}

			if (size == 0)
				Active = this.items.Count > 0;
		}
	}
}
