using System;

namespace WCSharp.Events.EventHandlers
{
	internal interface IEventSet
	{
		int FilterId { get; }
		int Count { get; }
		void Add(Action action, object filterObj);
		bool Remove(Action action, object filterObj);
		void Run();
	}
}
