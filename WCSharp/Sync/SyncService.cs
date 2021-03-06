using System;
using System.Collections.Generic;
using WCSharp.Json;
using WCSharp.Utils;
using static War3Api.Common;

namespace WCSharp.Sync
{
	public static class SyncService
	{
		private static readonly List<SyncHandler> syncHandlers = new List<SyncHandler>();
		private static bool initialized = false;
		private const string SYNC_MESSAGE_PREFIX = "__WCSharpSyncMessage";

		private static void Initialize()
		{
			var trigger = CreateTrigger();
			TriggerAddAction(trigger, HandlePlayerSyncEvent);
			foreach (var player in Util.GetPlayersPresent())
			{
				BlzTriggerRegisterPlayerSyncEvent(trigger, player, SYNC_MESSAGE_PREFIX, false);
			}
		}

		private static void HandlePlayerSyncEvent()
		{
			var data = BlzGetTriggerSyncData();
			var message = JsonConvert.Deserialize<SyncMessage>(data);
			Console.WriteLine(message.TypeName);
			object concreteData = default;

			Console.WriteLine($"Count: {syncHandlers.Count}");
			foreach (var handler in syncHandlers)
			{
				Console.WriteLine($"{handler.Type.FullName}---{message.TypeName}");
				if (handler.Type.FullName == message.TypeName)
				{
					concreteData ??= JsonConvert.Deserialize(message.Message, handler.Type);
					handler.Action.Invoke(concreteData);
				}
			}
		}

		public static void Send<T>(T message)
		{
			if (message == null || !initialized)
				return;

			var syncMessage = new SyncMessage
			{
				Message = JsonConvert.Serialize(message),
				TypeName = typeof(T).FullName
			};

			var data = JsonConvert.Serialize(syncMessage);
			BlzSendSyncData(SYNC_MESSAGE_PREFIX, data);
		}

		public static void Subscribe<T>(Action<T> handler)
		{
			if (handler == null)
				return;

			if (!initialized)
			{
				initialized = true;
				Initialize();
			}

			syncHandlers.Add(SyncHandler.Create(handler));
		}

		public static void Unsubscribe<T>(Action<T> handler)
		{
			for (var i = 0; i < syncHandlers.Count; i++)
			{
				if (syncHandlers[i].InternalAction.Equals(handler))
				{
					syncHandlers.RemoveAt(i--);
				}
			}
		}
	}
}
