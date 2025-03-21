using System.Collections.Generic;
using WCSharp.Shared.Extensions;

namespace WCSharp.Events.EventHandlers
{
	internal class EventAddRemoveResolver<T>
	{
		public class Entry
		{
			public List<T> List { get; }
			public T Item { get; }
			public bool Add { get; }

			public Entry(List<T> list, T item, bool add)
			{
				List = list;
				Item = item;
				Add = add;
			}
		}

		private readonly List<Entry> entries = new();

		public void Add(List<T> list, T item)
		{
			this.entries.Add(new(list, item, true));
		}

		public void Remove(List<T> list, T item)
		{
			this.entries.Add(new(list, item, false));
		}

		public bool Resolve()
		{
			var cleanRequired = false;

			for (var i = 0; i < this.entries.Count; i++)
			{
				var entry = this.entries[i];
				var list = entry.List;
				if (entry.Add)
				{
					list.Add(entry.Item);
				}
				else
				{
					var index = list.IndexOf(entry.Item);
					if (index >= 0)
					{
						var count = list.Count;
						list[index] = list[count - 1];
						list.Nil(count);

						if (count == 1)
						{
							cleanRequired = true;
						}
					}
				}
			}

			this.entries.Clear();
			return cleanRequired;
		}
	}
}
