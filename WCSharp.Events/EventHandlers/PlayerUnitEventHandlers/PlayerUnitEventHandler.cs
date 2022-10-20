using static War3Api.Common;

namespace WCSharp.Events.EventHandlers.PlayerUnitEventHandlers
{
	internal class PlayerUnitEventHandler : AbstractPlayerUnitEventHandler
	{
		public PlayerUnitEventHandler(playerunitevent @event)
		{
			var maxPlayers = GetBJMaxPlayerSlots();
			for (var i = 0; i < maxPlayers; i++)
			{
				TriggerRegisterPlayerUnitEvent(this.trigger, Player(i), @event, null);
			}
		}
	}
}
