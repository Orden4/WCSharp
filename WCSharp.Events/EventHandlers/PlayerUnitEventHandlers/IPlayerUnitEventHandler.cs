using System;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal interface IPlayerUnitEventHandler
	{
		void Register(Func<int> filterFunc, Action action, int filterId);
		void Unregister(Func<int> filterFunc, Action action, int filterId);
	}
}
