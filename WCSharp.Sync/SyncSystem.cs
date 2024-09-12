using System;
using System.Collections.Generic;
using System.Linq;
using WCSharp.Json;
using WCSharp.Shared;
using static WCSharp.Api.Common;

namespace WCSharp.Sync
{
	/// <summary>
	/// The <see cref="SyncSystem"/> sets up a communication channel via the BlzSync functions and allows for the transfer of generically typed data
	/// across it. Data is automatically split into packets to allow for any amount of data to be transferred across.
	/// </summary>
	/// <remarks>
	/// This system reserves the sync prefixes __WCSharpSyncHeaders and __WCSharpSyncPackets. Nothing else should use these prefixes to send data.
	/// </remarks>
	/// This system is set up so that it can process a single message type per player simultaneously. This is based on the assumption that messages
	/// will never be interrupted midway during sending, and always arrive in the same order as they were sent (tests seem to confirm this).
	/// Tests also seem to confirm that messages from different players do not get mixed, but since it's hard to be certain without large scale tests
	/// the system is set up to process one message for each player at any time. If it is true that the player sequence is always the same, this
	/// could be skipped. But realistically, this only saves a few table lookups anyway, and the table is kept empty when not receiving, meaning the
	/// memory footprint is basically the same as well.
	public static class SyncSystem
	{
		// Maximum size is 255 characters, but messages are sent as json so we need 15 characters for formatting.
		private const int PACKET_SIZE = 240;

		private const string SYNC_HEADER_PREFIX = "__WCSharpSyncHeaders";
		private const string SYNC_PACKET_PREFIX = "__WCSharpSyncPackets";

		private static readonly List<SyncHandler> syncHandlers = new();
		private static readonly Dictionary<int, SyncMessage> messages = new();
		private static readonly HashSet<char> escapeChars = new()
		{
			'"',
			'\\',
			'\b',
			'\f',
			'\n',
			'\r',
			'\t'
		};
		private static readonly List<SyncTrigger> syncTriggers = new()
		{
			RegisterForPrefix(HandleSyncHeader, SYNC_HEADER_PREFIX),
			RegisterForPrefix(HandleSyncPacket, SYNC_PACKET_PREFIX)
		};

		private static SyncTrigger RegisterForPrefix(Func<bool> action, string prefix)
		{
			var trigger = CreateTrigger();
			var condition = Condition(action);
			TriggerAddCondition(trigger, condition);
			foreach (var player in Util.EnumeratePlayers())
			{
				BlzTriggerRegisterPlayerSyncEvent(trigger, player, prefix, false);
			}

			return new SyncTrigger
			{
				Condition = condition,
				Trigger = trigger
			};
		}

		private static bool HandleSyncHeader()
		{
			var header = JsonConvert.Deserialize<SyncHeader>(BlzGetTriggerSyncData());
			if (messages.TryGetValue(header.PlayerId, out var message))
			{
				// If this ever happens we can't really recover, as this is most likely grounds for an immediate desync anyway
				// For now we just ignore the new header, there isn't really a good solution for this
				Console.WriteLine($"ERROR: A new sync message of type {header.TypeName} was received for player {header.PlayerId} while still processing {message.SyncHeader.TypeName}");
				return false;
			}

			messages.Add(header.PlayerId, new SyncMessage(header));
			return false;
		}

		private static bool HandleSyncPacket()
		{
			var packet = JsonConvert.Deserialize<SyncPacket>(BlzGetTriggerSyncData());
			if (!messages.TryGetValue(packet.P, out var message))
			{
				// If this ever happens we can't really recover, as this is most likely grounds for an immediate desync anyway
				// For now we just ignore the message, as we don't know what its type or anything is anyway
				Console.WriteLine("ERROR: A sync packet was received without header.");
				Console.WriteLine(BlzGetTriggerSyncData());
			}

			message.Packets.Add(packet);
			if (message.IsComplete)
			{
				FinalizeMessage(message);
			}

			return false;
		}

		private static void FinalizeMessage(SyncMessage message)
		{
			messages.Remove(message.SyncHeader.PlayerId);

			object concreteData = null;

			for (var i = 0; i < syncHandlers.Count; i++)
			{
				var handler = syncHandlers[i];
				if (handler.Type.FullName == message.SyncHeader.TypeName)
				{
					if (concreteData == null)
					{
						var contents = message.GetContents();
						concreteData = JsonConvert.Deserialize(contents, handler.Type);
					}
					handler.Action.Invoke(concreteData);
				}
			}
		}

		/// <summary>
		/// Syncs the given data across all clients. Use <see cref="Subscribe{T}(Action{T})"/> in order to set up receiving of certain types of messages.
		/// </summary>
		public static void Send<T>(T message)
			where T : class
		{
			if (message == null)
			{
				return;
			}

			var contents = JsonConvert.Serialize(message);
			var playerId = GetPlayerId(GetLocalPlayer());
			var packets = BuildPackets(contents, playerId).ToList();
			var header = new SyncHeader
			{
				PacketCount = packets.Count,
				PlayerId = playerId,
				TypeName = typeof(T).FullName
			};

			BlzSendSyncData(SYNC_HEADER_PREFIX, JsonConvert.Serialize(header));

			for (var i = 0; i < packets.Count; i++)
			{
				var text = JsonConvert.Serialize(packets[i]);
				BlzSendSyncData(SYNC_PACKET_PREFIX, text);
			}
		}

		/// <summary>
		/// Splits packets, taking into account added length from escaping the message data.
		/// </summary>
		private static IEnumerable<SyncPacket> BuildPackets(string content, int playerId)
		{
			var startIndex = 0;
			var escapedLength = 0;
			for (var i = 0; i < content.Length; i++)
			{
				if (escapeChars.Contains(content[i]))
				{
					escapedLength += 2;
				}
				else
				{
					escapedLength++;
				}

				if (escapedLength == PACKET_SIZE)
				{
					yield return new SyncPacket
					{
						P = playerId,
						M = content.Substring(startIndex, i - startIndex)
					};
					startIndex = i;
					escapedLength = 0;
				}
				else if (escapedLength == PACKET_SIZE + 1)
				{
					yield return new SyncPacket
					{
						P = playerId,
						M = content.Substring(startIndex, i - startIndex - 1)
					};
					startIndex = i - 1;
					escapedLength = 2;
				}
			}

			if (startIndex < content.Length)
			{
				yield return new SyncPacket
				{
					P = playerId,
					M = content.Substring(startIndex)
				};
			}
		}

		/// <summary>
		/// Subscribes the given <paramref name="handler"/> to be called when messages of type <typeparamref name="T"/> are sent across the <see cref="SyncSystem"/>.
		/// </summary>
		public static void Subscribe<T>(Action<T> handler)
			where T : class
		{
			if (handler == null)
			{
				return;
			}

			syncHandlers.Add(SyncHandler.Create(handler));
		}

		/// <summary>
		/// Unsubscribes the given <paramref name="handler"/> from the <see cref="SyncSystem"/>.
		/// </summary>
		public static void Unsubscribe<T>(Action<T> handler)
			where T : class
		{
			for (var i = 0; i < syncHandlers.Count; i++)
			{
				if (syncHandlers[i].InternalAction.Equals(handler))
				{
					syncHandlers.RemoveAt(i);
					return;
				}
			}
		}

		/// <summary>
		/// Call this method to automatically wrap your actions in a try/catch, so that exceptions that lead back to the SyncSystem will automatically output information.
		/// <para>It is recommended to use compilation time conditions to not call this on release mode.</para>
		/// </summary>
		public static void EnableDebug()
		{
			for (var i = 0; i < syncTriggers.Count; i++)
			{
				var syncTrigger = syncTriggers[i];
				DestroyCondition(syncTrigger.Condition);
				DisableTrigger(syncTrigger.Trigger);
				DestroyTrigger(syncTrigger.Trigger);
			}

			syncTriggers.Clear();
			syncTriggers.Add(RegisterForPrefix(headerAction, SYNC_HEADER_PREFIX));
			syncTriggers.Add(RegisterForPrefix(packetAction, SYNC_PACKET_PREFIX));

			static bool headerAction()
			{
				try
				{
					HandleSyncHeader();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.StackTrace);
				}

				return false;
			}
			static bool packetAction()
			{
				try
				{
					HandleSyncPacket();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.StackTrace);
				}

				return false;
			}
		}
	}
}
