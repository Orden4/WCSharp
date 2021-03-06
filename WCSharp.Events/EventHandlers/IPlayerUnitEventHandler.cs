using System;

namespace WCSharp.Events.EventHandlers
{
	internal interface IPlayerUnitEventHandler
	{
		void Register(Action action);
		void Register(PlayerUnitEvent @event, Action action, int filterId);
		void Register(string @event, Action action, int filterId);
		void Unregister(Action action);
		void Unregister(PlayerUnitEvent @event, int filterId);
		void Unregister(string @event, int filterId);
	}
}
