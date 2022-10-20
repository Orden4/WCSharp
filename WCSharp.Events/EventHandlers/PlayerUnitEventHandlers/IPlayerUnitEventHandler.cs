using System;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal interface IPlayerUnitEventHandler
	{
		void Register(Action action, Func<int> filterFunc, int filterId);
		void Unregister(Action action, Func<int> filterFunc, int filterId);
	}
}
