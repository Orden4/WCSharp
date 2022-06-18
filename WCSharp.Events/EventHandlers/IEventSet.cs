using System;

namespace WCSharp.Events.EventHandlers
{
	internal interface IEventSet
	{
		Func<int> FilterFunc { get; init; }
		int Count { get; }
		void Add(Action action, int filterId);
		bool Remove(Action action, int filterId);
		void Run();
	}
}
