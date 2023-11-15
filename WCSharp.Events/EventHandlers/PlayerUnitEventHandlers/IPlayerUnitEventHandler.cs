using System;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal interface IPlayerUnitEventHandler
	{
		void Register<T>(Action action, int filterId, Func<T> filterFunc, T filterValue);
		void Unregister<T>(Action action, int filterId, Func<T> filterFunc, T filterValue);
	}
}
