using System;
namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class trigger : agent, IDisposable
	{
		internal trigger()
		{
		}

		/// @CSharpLua.Template = "CreateTrigger({0})"
		public static extern trigger Create();

		/// @CSharpLua.Get = "IsTriggerEnabled({0})"
		/// @CSharpLua.Set = "if {1} then EnableTrigger({0}) else DisableTrigger({0}) end"
		public extern bool Enabled { get; set; }
		/// @CSharpLua.Get = "IsTriggerWaitOnSleeps({0})"
		/// @CSharpLua.Set = "TriggerWaitOnSleeps({0}, {1})"
		public extern bool WaitOnSleeps { get; }
		/// @CSharpLua.Get = "GetTriggerEvalCount({0})"
		public extern int EvalCount { get; }
		/// @CSharpLua.Get = "GetTriggerExecCount({0})"
		public extern int ExecCount { get; }

		/// @CSharpLua.Template = "TriggerAddCondition({0}, {2})"
		public extern triggercondition AddCondition(boolexpr condition);
		/// @CSharpLua.Template = "TriggerRemoveCondition({0}, {1})"
		public extern void RemoveCondition(triggercondition condition);
		/// @CSharpLua.Template = "TriggerClearConditions({0})"
		public extern void ClearConditions();

		/// @CSharpLua.Template = "TriggerAddAction({0}, {2})"
		public extern triggeraction AddAction(Action action);
		/// @CSharpLua.Template = "TriggerRemoveAction({0}, {1})"
		public extern void RemoveAction(triggeraction action);
		/// @CSharpLua.Template = "TriggerClearActions({0})"
		public extern void ClearActions();

		/// @CSharpLua.Template = "EnableTrigger({0})"
		public extern void Enable();
		/// @CSharpLua.Template = "DisableTrigger({0})"
		public extern void Disable();
		/// @CSharpLua.Template = "ResetTrigger({0})"
		public extern void Reset();
		/// @CSharpLua.Template = "TriggerEvaluate({0})"
		public extern void Evaluate();
		/// @CSharpLua.Template = "TriggerExecute({0})"
		public extern void Execute();
		/// @CSharpLua.Template = "TriggerExecuteWait({0})"
		public extern void ExecuteWait();
		/// @CSharpLua.Template = "DestroyTrigger({0})"
		public extern void Dispose();

		/// @CSharpLua.Template = "TriggerRegisterVariableEvent({0}, {1}, {2}, {3})"
		public extern @event RegisterVariableEvent(string varName, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterTimerEvent({0}, {1}, {2})"
		public extern @event RegisterTimerEvent(float timeout, bool periodic);
		/// @CSharpLua.Template = "TriggerRegisterTimerExpireEvent({0}, {1})"
		public extern @event RegisterTimerExpireEvent(timer timer);
		/// @CSharpLua.Template = "TriggerRegisterDialogEvent({0}, {1})"
		public extern @event RegisterDialogEvent(dialog dialog);
		/// @CSharpLua.Template = "TriggerRegisterDialogButtonEvent({0}, {1})"
		public extern @event RegisterButtonEvent(button button);
		/// @CSharpLua.Template = "TriggerRegisterGameEvent({0}, {1})"
		public extern @event RegisterGameEvent(gameevent gameEvent);
		/// @CSharpLua.Template = "TriggerRegisterEnterRegion({0}, {1}, {2})"
		public extern @event RegisterEnterRegion(region region, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterLeaveRegion({0}, {1}, {2})"
		public extern @event RegisterLeaveRegion(region region, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterTrackableHitEvent({0}, {1})"
		public extern @event RegisterTrackableHitEvent(trackable trackable);
		/// @CSharpLua.Template = "TriggerRegisterTrackableTrackEvent({0}, {1})"
		public extern @event RegisterTrackableTrackEvent(trackable trackable);
		/// @CSharpLua.Template = "TriggerRegisterCommandEvent({0}, {1}, {2})"
		public extern @event RegisterCommandEvent(int abilityId, string order);
		/// @CSharpLua.Template = "TriggerRegisterUpgradeCommandEvent({0}, {1})"
		public extern @event RegisterUpgradeCommandEvent(int upgradeId);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEvent({0}, {1}, {2})"
		public extern @event RegisterPlayerEvent(player player, playerevent playerEvent);
		/// @CSharpLua.Template = "TriggerRegisterPlayerUnitEvent({0}, {1}, {2}, {3})"
		public extern @event RegisterPlayerUnitEvent(player player, playerunitevent playerUnitEvent, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterPlayerAllianceChange({0}, {1}, {2})"
		public extern @event RegisterPlayerAllianceChange(player player, alliancetype allianceType);
		/// @CSharpLua.Template = "TriggerRegisterPlayerStateEvent({0}, {1}, {2}, {3}, {4})"
		public extern @event RegisterPlayerStateEvent(player player, playerstate playerState, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterPlayerChatEvent({0}, {1}, {2}, {3})"
		public extern @event RegisterPlayerChatEvent(player player, string chatMessage, bool exactMatch);
		/// @CSharpLua.Template = "TriggerRegisterDeathEvent({0}, {1})"
		public extern @event RegisterDeathEvent(widget widget);
		/// @CSharpLua.Template = "TriggerRegisterUnitStateEvent({0}, {1}, {2}, {3}, {4})"
		public extern @event RegisterUnitStateEvent(unit unit, unitstate unitState, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterUnitEvent({0}, {1}, {2})"
		public extern @event RegisterUnitEvent(unit unit, unitevent unitEvent);
		/// @CSharpLua.Template = "TriggerRegisterFilterUnitEvent({0}, {1}, {2}, {3})"
		public extern @event RegisterUnitEvent(unit unit, unitevent unitEvent, boolexpr filter);
		/// @CSharpLua.Template = "BlzTriggerRegisterFrameEvent({0}, {1}, {2})"
		public extern @event RegisterFrameEvent(framehandle frame, frameeventtype eventType);
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerSyncEvent({0}, {1}, {2}, {3})"
		public extern @event RegisterPlayerSyncEvent(player player, string prefix, bool fromServer);
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerKeyEvent({0}, {1}, {2}, {3}, {4})"
		public extern @event RegisterPlayerKeyEvent(player player, oskeytype osKeyType, int metaKey, bool keyDown);
	}
}
