namespace WCSharp.Api
{
	/// @CSharpLua.Ignore
	public class @event : agent
	{
		internal @event()
		{
		}

		/// @CSharpLua.Get = "BlzGetAbsorbingItem()"
		public static extern item AbsorbingItem { get; }
		/// @CSharpLua.Get = "GetAttacker()"
		public static extern unit Attacker { get; }
		/// @CSharpLua.Get = "BlzGetEventAttackType()"
		public static extern attacktype AttackType { get; }
		/// @CSharpLua.Get = "GetBuyingUnit()"
		public static extern unit BuyingUnit { get; }
		/// @CSharpLua.Get = "GetCancelledStructure()"
		public static extern unit CancelledStructure { get; }
		/// @CSharpLua.Get = "GetChangingUnit()"
		public static extern unit ChangingUnit { get; }
		/// @CSharpLua.Get = "GetChangingUnitPrevOwner()"
		public static extern player ChangingUnitPrevOwner { get; }
		/// @CSharpLua.Get = "GetClickedButton()"
		public static extern button ClickedButton { get; }
		/// @CSharpLua.Get = "GetClickedDialog()"
		public static extern dialog ClickedDialog { get; }
		/// @CSharpLua.Get = "GetConstructedStructure()"
		public static extern unit ConstructedStructure { get; }
		/// @CSharpLua.Get = "GetConstructingStructure()"
		public static extern unit ConstructingStructure { get; }
		/// @CSharpLua.Get = "GetEventDamage()"
		public static extern float Damage { get; }
		/// @CSharpLua.Get = "GetEventDamageSource()"
		public static extern unit DamageSource { get; }
		/// @CSharpLua.Get = "BlzGetEventDamageTarget()"
		public static extern unit DamageTarget { get; }
		/// @CSharpLua.Get = "BlzGetEventDamageType()"
		public static extern damagetype DamageType { get; }
		/// @CSharpLua.Get = "GetDecayingUnit()"
		public static extern unit DecayingUnit { get; }
		/// @CSharpLua.Get = "GetTriggerDestructable()"
		public static extern destructable Destructable { get; }
		/// @CSharpLua.Get = "GetDetectedUnit()"
		public static extern unit DetectedUnit { get; }
		/// @CSharpLua.Get = "GetEventDetectingPlayer()"
		public static extern player DetectingPlayer { get; }
		/// @CSharpLua.Get = "GetDyingUnit()"
		public static extern unit DyingUnit { get; }
		/// @CSharpLua.Get = "GetEnteringUnit()"
		public static extern unit EnteringUnit { get; }
		/// @CSharpLua.Get = "GetTriggerEventId()"
		public static extern eventid EventId { get; }
		/// @CSharpLua.Get = "GetExpiredTimer()"
		public static extern timer ExpiredTimer { get; }
		/// @CSharpLua.Get = "BlzGetTriggerFrame()"
		public static extern framehandle Frame { get; }
		/// @CSharpLua.Get = "BlzGetTriggerFrameEvent()"
		public static extern frameeventtype FrameEvent { get; }
		/// @CSharpLua.Get = "BlzGetTriggerFrameText()"
		public static extern string FrameText { get; }
		/// @CSharpLua.Get = "BlzGetTriggerFrameValue()"
		public static extern float FrameValue { get; }
		/// @CSharpLua.Get = "GetEventGameState()"
		public static extern gamestate GameState { get; }
		/// @CSharpLua.Get = "BlzGetEventIsAttack()"
		public static extern bool IsAttack { get; }
		/// @CSharpLua.Get = "GetIssuedOrderId()"
		public static extern int IssuedOrderId { get; }
		/// @CSharpLua.Get = "GetKillingUnit()"
		public static extern unit KillingUnit { get; }
		/// @CSharpLua.Get = "GetLearnedSkill()"
		public static extern int LearnedSkill { get; }
		/// @CSharpLua.Get = "GetLearnedSkillLevel()"
		public static extern int LearnedSkillLevel { get; }
		/// @CSharpLua.Get = "GetLearningUnit()"
		public static extern unit LearningUnit { get; }
		/// @CSharpLua.Get = "GetLeavingUnit()"
		public static extern unit LeavingUnit { get; }
		/// @CSharpLua.Get = "GetLevelingUnit()"
		public static extern unit LevelingUnit { get; }
		/// @CSharpLua.Get = "GetLoadedUnit()"
		public static extern unit LoadedUnit { get; }
		/// @CSharpLua.Get = "GetManipulatedItem()"
		public static extern item ManipulatedItem { get; }
		/// @CSharpLua.Get = "BlzGetManipulatedItemWasAbsorbed()"
		public static extern bool ManipulatedItemWasAbsorbed { get; }
		/// @CSharpLua.Get = "GetManipulatingUnit()"
		public static extern unit ManipulatingUnit { get; }
		/// @CSharpLua.Get = "GetOrderedUnit()"
		public static extern unit OrderedUnit { get; }
		/// @CSharpLua.Get = "GetOrderPointLoc()"
		public static extern location OrderPointLoc { get; }
		/// @CSharpLua.Get = "GetOrderPointX()"
		public static extern float OrderPointX { get; }
		/// @CSharpLua.Get = "GetOrderPointY()"
		public static extern float OrderPointY { get; }
		/// @CSharpLua.Get = "GetOrderTarget()"
		public static extern widget OrderTarget { get; }
		/// @CSharpLua.Get = "GetOrderTargetDestructable()"
		public static extern destructable OrderTargetDestructable { get; }
		/// @CSharpLua.Get = "GetOrderTargetItem()"
		public static extern item OrderTargetItem { get; }
		/// @CSharpLua.Get = "GetOrderTargetUnit()"
		public static extern unit OrderTargetUnit { get; }
		/// @CSharpLua.Get = "GetTriggerPlayer()"
		public static extern player Player { get; }
		/// @CSharpLua.Get = "GetEventPlayerChatString()"
		public static extern string PlayerChatString { get; }
		/// @CSharpLua.Get = "GetEventPlayerChatStringMatched()"
		public static extern string PlayerChatStringMatched { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerIsKeyDown()"
		public static extern bool PlayerIsKeyDown { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerKey()"
		public static extern oskeytype PlayerKey { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerMetaKey()"
		public static extern int PlayerMetaKey { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerMouseButton()"
		public static extern mousebuttontype PlayerMouseButton { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerMousePosition()"
		public static extern location PlayerMousePosition { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerMouseX()"
		public static extern float PlayerMouseX { get; }
		/// @CSharpLua.Get = "BlzGetTriggerPlayerMouseY()"
		public static extern float PlayerMouseY { get; }
		/// @CSharpLua.Get = "GetEventPlayerState()"
		public static extern playerstate PlayerState { get; }
		/// @CSharpLua.Get = "GetTriggeringRegion()"
		public static extern region Region { get; }
		/// @CSharpLua.Get = "GetRescuer()"
		public static extern unit Rescuer { get; }
		/// @CSharpLua.Get = "GetResearched()"
		public static extern int Researched { get; }
		/// @CSharpLua.Get = "GetResearchingUnit()"
		public static extern unit ResearchingUnit { get; }
		/// @CSharpLua.Get = "GetRevivableUnit()"
		public static extern unit RevivableUnit { get; }
		/// @CSharpLua.Get = "GetRevivingUnit()"
		public static extern unit RevivingUnit { get; }
		/// @CSharpLua.Get = "GetSellingUnit()"
		public static extern unit SellingUnit { get; }
		/// @CSharpLua.Get = "GetSoldItem()"
		public static extern item SoldItem { get; }
		/// @CSharpLua.Get = "GetSoldUnit()"
		public static extern unit SoldUnit { get; }
		/// @CSharpLua.Get = "GetSpellAbility()"
		public static extern ability SpellAbility { get; }
		/// @CSharpLua.Get = "GetSpellAbilityId()"
		public static extern int SpellAbilityId { get; }
		/// @CSharpLua.Get = "GetSpellAbilityUnit()"
		public static extern unit SpellAbilityUnit { get; }
		/// @CSharpLua.Get = "GetSpellTargetDestructable()"
		public static extern destructable SpellTargetDestructable { get; }
		/// @CSharpLua.Get = "GetSpellTargetItem()"
		public static extern item SpellTargetItem { get; }
		/// @CSharpLua.Get = "GetSpellTargetLoc()"
		public static extern location SpellTargetLoc { get; }
		/// @CSharpLua.Get = "GetSpellTargetUnit()"
		public static extern unit SpellTargetUnit { get; }
		/// @CSharpLua.Get = "GetSpellTargetX()"
		public static extern float SpellTargetX { get; }
		/// @CSharpLua.Get = "GetSpellTargetY()"
		public static extern float SpellTargetY { get; }
		/// @CSharpLua.Get = "BlzGetStackingItemSource()"
		public static extern item StackingItemSource { get; }
		/// @CSharpLua.Get = "BlzGetStackingItemTarget()"
		public static extern item StackingItemTarget { get; }
		/// @CSharpLua.Get = "BlzGetStackingItemTargetPreviousCharges()"
		public static extern int StackingItemTargetPreviousCharges { get; }
		/// @CSharpLua.Get = "GetSummonedUnit()"
		public static extern unit SummonedUnit { get; }
		/// @CSharpLua.Get = "GetSummoningUnit()"
		public static extern unit SummoningUnit { get; }
		/// @CSharpLua.Get = "BlzGetTriggerSyncData()"
		public static extern string SyncData { get; }
		/// @CSharpLua.Get = "BlzGetTriggerSyncPrefix()"
		public static extern string SyncPrefix { get; }
		/// @CSharpLua.Get = "GetEventTargetUnit()"
		public static extern unit TargetUnit { get; }
		/// @CSharpLua.Get = "GetTournamentFinishNowPlayer()"
		public static extern player TournamentFinishNowPlayer { get; }
		/// @CSharpLua.Get = "GetTournamentFinishNowRule()"
		public static extern int TournamentFinishNowRule { get; }
		/// @CSharpLua.Get = "GetTournamentFinishSoonTimeRemaining()"
		public static extern float TournamentFinishSoonTimeRemaining { get; }
		/// @CSharpLua.Get = "GetTriggeringTrackable()"
		public static extern trackable Trackable { get; }
		/// @CSharpLua.Get = "GetTrainedUnit()"
		public static extern unit TrainedUnit { get; }
		/// @CSharpLua.Get = "GetTrainedUnitType()"
		public static extern int TrainedUnitType { get; }
		/// @CSharpLua.Get = "GetTransportUnit()"
		public static extern unit TransportUnit { get; }
		/// @CSharpLua.Get = "GetTriggeringTrigger()"
		public static extern trigger Trigger { get; }
		/// @CSharpLua.Get = "GetTriggerUnit()"
		public static extern unit Unit { get; }
		/// @CSharpLua.Get = "GetEventUnitState()"
		public static extern unitstate UnitState { get; }
		/// @CSharpLua.Get = "BlzGetEventWeaponType()"
		public static extern weapontype WeaponType { get; }
		/// @CSharpLua.Get = "GetTriggerWidget()"
		public static extern widget Widget { get; }
		/// @CSharpLua.Get = "GetWinningPlayer()"
		public static extern player WinningPlayer { get; }

		/// @CSharpLua.Get = "GetTournamentScore()"
		public static extern int GetTournamentScore(player player);
	}
}
