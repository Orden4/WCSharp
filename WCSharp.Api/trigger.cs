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

		/// @CSharpLua.Get = "IsTriggerEnabled({this})"
		/// @CSharpLua.Set = "if {0} then EnableTrigger({this}) else DisableTrigger({this}) end"
		public extern bool Enabled { get; set; }
		/// @CSharpLua.Get = "IsTriggerWaitOnSleeps({this})"
		/// @CSharpLua.Set = "TriggerWaitOnSleeps({this}, {0})"
		public extern bool WaitOnSleeps { get; }
		/// @CSharpLua.Get = "GetTriggerEvalCount({this})"
		public extern int EvalCount { get; }
		/// @CSharpLua.Get = "GetTriggerExecCount({this})"
		public extern int ExecCount { get; }

		/// @CSharpLua.Template = "TriggerAddCondition({this}, {1})"
		public extern triggercondition AddCondition(boolexpr condition);
		/// @CSharpLua.Template = "TriggerRemoveCondition({this}, {0})"
		public extern void RemoveCondition(triggercondition condition);
		/// @CSharpLua.Template = "TriggerClearConditions({this})"
		public extern void ClearConditions();

		/// @CSharpLua.Template = "TriggerAddAction({this}, {1})"
		public extern triggeraction AddAction(Action action);
		/// @CSharpLua.Template = "TriggerRemoveAction({this}, {0})"
		public extern void RemoveAction(triggeraction action);
		/// @CSharpLua.Template = "TriggerClearActions({this})"
		public extern void ClearActions();

		/// @CSharpLua.Template = "EnableTrigger({this})"
		public extern void Enable();
		/// @CSharpLua.Template = "DisableTrigger({this})"
		public extern void Disable();
		/// @CSharpLua.Template = "ResetTrigger({this})"
		public extern void Reset();
		/// @CSharpLua.Template = "TriggerEvaluate({this})"
		public extern void Evaluate();
		/// @CSharpLua.Template = "TriggerExecute({this})"
		public extern void Execute();
		/// @CSharpLua.Template = "TriggerExecuteWait({this})"
		public extern void ExecuteWait();
		/// @CSharpLua.Template = "DestroyTrigger({this})"
		public extern void Dispose();

		/// @CSharpLua.Template = "TriggerRegisterVariableEvent({this}, {0}, {1}, {2})"
		public extern @event RegisterVariableEvent(string varName, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterTimerEvent({this}, {0}, {1})"
		public extern @event RegisterTimerEvent(float timeout, bool periodic);
		/// @CSharpLua.Template = "TriggerRegisterTimerExpireEvent({this}, {0})"
		public extern @event RegisterTimerExpireEvent(timer timer);
		/// @CSharpLua.Template = "TriggerRegisterDialogEvent({this}, {0})"
		public extern @event RegisterDialogEvent(dialog dialog);
		/// @CSharpLua.Template = "TriggerRegisterDialogButtonEvent({this}, {0})"
		public extern @event RegisterButtonEvent(button button);
		/// @CSharpLua.Template = "TriggerRegisterGameEvent({this}, {0})"
		public extern @event RegisterGameEvent(gameevent gameEvent);
		/// @CSharpLua.Template = "TriggerRegisterEnterRegion({this}, {0}, {1})"
		public extern @event RegisterEnterRegion(region region, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterLeaveRegion({this}, {0}, {1})"
		public extern @event RegisterLeaveRegion(region region, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterTrackableHitEvent({this}, {0})"
		public extern @event RegisterTrackableHitEvent(trackable trackable);
		/// @CSharpLua.Template = "TriggerRegisterTrackableTrackEvent({this}, {0})"
		public extern @event RegisterTrackableTrackEvent(trackable trackable);
		/// @CSharpLua.Template = "TriggerRegisterCommandEvent({this}, {0}, {1})"
		public extern @event RegisterCommandEvent(int abilityId, string order);
		/// @CSharpLua.Template = "TriggerRegisterUpgradeCommandEvent({this}, {0})"
		public extern @event RegisterUpgradeCommandEvent(int upgradeId);
		/// @CSharpLua.Template = "TriggerRegisterPlayerEvent({this}, {0}, {1})"
		public extern @event RegisterPlayerEvent(player player, playerevent playerEvent);
		/// @CSharpLua.Template = "TriggerRegisterPlayerUnitEvent({this}, {0}, {1}, {2})"
		public extern @event RegisterPlayerUnitEvent(player player, playerunitevent playerUnitEvent, boolexpr filter = null);
		/// @CSharpLua.Template = "TriggerRegisterPlayerAllianceChange({this}, {0}, {1})"
		public extern @event RegisterPlayerAllianceChange(player player, alliancetype allianceType);
		/// @CSharpLua.Template = "TriggerRegisterPlayerStateEvent({this}, {0}, {1}, {2}, {3})"
		public extern @event RegisterPlayerStateEvent(player player, playerstate playerState, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterPlayerChatEvent({this}, {0}, {1}, {2})"
		public extern @event RegisterPlayerChatEvent(player player, string chatMessage, bool exactMatch);
		/// @CSharpLua.Template = "TriggerRegisterDeathEvent({this}, {0})"
		public extern @event RegisterDeathEvent(widget widget);
		/// @CSharpLua.Template = "TriggerRegisterUnitStateEvent({this}, {0}, {1}, {2}, {3})"
		public extern @event RegisterUnitStateEvent(unit unit, unitstate unitState, limitop opCode, float limitValue);
		/// @CSharpLua.Template = "TriggerRegisterUnitEvent({this}, {0}, {1})"
		public extern @event RegisterUnitEvent(unit unit, unitevent unitEvent);
		/// @CSharpLua.Template = "TriggerRegisterFilterUnitEvent({this}, {0}, {1}, {2})"
		public extern @event RegisterUnitEvent(unit unit, unitevent unitEvent, boolexpr filter);
		/// @CSharpLua.Template = "BlzTriggerRegisterFrameEvent({this}, {0}, {1})"
		public extern @event RegisterFrameEvent(framehandle frame, frameeventtype eventType);
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerSyncEvent({this}, {0}, {1}, {2})"
		public extern @event RegisterPlayerSyncEvent(player player, string prefix, bool fromServer);
		/// @CSharpLua.Template = "BlzTriggerRegisterPlayerKeyEvent({this}, {0}, {1}, {2}, {3})"
		public extern @event RegisterPlayerKeyEvent(player player, oskeytype osKeyType, int metaKey, bool keyDown);
	}
}
