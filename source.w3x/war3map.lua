gg_rct_Region_000 = nil
gg_rct_Region_001 = nil
gg_cam_Camera_001 = nil
gg_cam_Camera_001_Copy = nil
gg_trg_Melee_Initialization = nil
function InitGlobals()
end

function CreateUnitsForPlayer0()
    local p = Player(0)
    local u
    local unitID
    local t
    local life
    u = BlzCreateUnitWithSkin(p, FourCC("hfoo"), 1178.2, -369.3, 43.606, FourCC("hfoo"))
    u = BlzCreateUnitWithSkin(p, FourCC("hfoo"), 2101.0, 94.7, 43.606, FourCC("hfoo"))
    u = BlzCreateUnitWithSkin(p, FourCC("hfoo"), -207.8, -445.2, 43.606, FourCC("hfoo"))
end

function CreateUnitsForPlayer1()
    local p = Player(1)
    local u
    local unitID
    local t
    local life
    u = BlzCreateUnitWithSkin(p, FourCC("hfoo"), 786.3, 561.7, 43.610, FourCC("hfoo"))
end

function CreateUnitsForPlayer2()
    local p = Player(2)
    local u
    local unitID
    local t
    local life
    u = BlzCreateUnitWithSkin(p, FourCC("hfoo"), 973.2, 577.5, 43.610, FourCC("hfoo"))
end

function CreatePlayerBuildings()
end

function CreatePlayerUnits()
    CreateUnitsForPlayer0()
    CreateUnitsForPlayer1()
    CreateUnitsForPlayer2()
end

function CreateAllUnits()
    CreatePlayerBuildings()
    CreatePlayerUnits()
end

function CreateRegions()
    local we
    gg_rct_Region_000 = Rect(-288.0, -416.0, 480.0, 576.0)
    gg_rct_Region_001 = Rect(544.0, 32.0, 1024.0, 864.0)
end

function CreateCameras()
    gg_cam_Camera_001 = CreateCameraSetup()
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_ZOFFSET, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_ROTATION, 90.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_ANGLE_OF_ATTACK, 304.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_TARGET_DISTANCE, 1650.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_ROLL, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_FIELD_OF_VIEW, 70.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_FARZ, 5000.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_NEARZ, 16.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_LOCAL_PITCH, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_LOCAL_YAW, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001, CAMERA_FIELD_LOCAL_ROLL, 0.0, 0.0)
    CameraSetupSetDestPosition(gg_cam_Camera_001, 0.0, -576.0, 0.0)
    gg_cam_Camera_001_Copy = CreateCameraSetup()
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_ZOFFSET, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_ROTATION, 90.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_ANGLE_OF_ATTACK, 304.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_TARGET_DISTANCE, 1650.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_ROLL, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_FIELD_OF_VIEW, 70.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_FARZ, 5000.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_NEARZ, 16.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_LOCAL_PITCH, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_LOCAL_YAW, 0.0, 0.0)
    CameraSetupSetField(gg_cam_Camera_001_Copy, CAMERA_FIELD_LOCAL_ROLL, 0.0, 0.0)
    CameraSetupSetDestPosition(gg_cam_Camera_001_Copy, -444.1, -616.5, 0.0)
end

function Trig_Melee_Initialization_Actions()
    MeleeStartingVisibility()
    MeleeStartingHeroLimit()
    MeleeGrantHeroItems()
    MeleeStartingResources()
    MeleeClearExcessUnits()
    MeleeStartingUnits()
    MeleeStartingAI()
    MeleeInitVictoryDefeat()
end

function InitTrig_Melee_Initialization()
    gg_trg_Melee_Initialization = CreateTrigger()
    TriggerAddAction(gg_trg_Melee_Initialization, Trig_Melee_Initialization_Actions)
end

function InitCustomTriggers()
    InitTrig_Melee_Initialization()
end

function RunInitializationTriggers()
    ConditionalTriggerExecute(gg_trg_Melee_Initialization)
end

function InitCustomPlayerSlots()
    SetPlayerStartLocation(Player(0), 0)
    SetPlayerColor(Player(0), ConvertPlayerColor(0))
    SetPlayerRacePreference(Player(0), RACE_PREF_HUMAN)
    SetPlayerRaceSelectable(Player(0), true)
    SetPlayerController(Player(0), MAP_CONTROL_USER)
    SetPlayerStartLocation(Player(1), 1)
    SetPlayerColor(Player(1), ConvertPlayerColor(1))
    SetPlayerRacePreference(Player(1), RACE_PREF_ORC)
    SetPlayerRaceSelectable(Player(1), true)
    SetPlayerController(Player(1), MAP_CONTROL_USER)
    SetPlayerStartLocation(Player(2), 2)
    SetPlayerColor(Player(2), ConvertPlayerColor(2))
    SetPlayerRacePreference(Player(2), RACE_PREF_UNDEAD)
    SetPlayerRaceSelectable(Player(2), true)
    SetPlayerController(Player(2), MAP_CONTROL_USER)
end

function InitCustomTeams()
    SetPlayerTeam(Player(0), 0)
    SetPlayerState(Player(0), PLAYER_STATE_ALLIED_VICTORY, 1)
    SetPlayerTeam(Player(1), 0)
    SetPlayerState(Player(1), PLAYER_STATE_ALLIED_VICTORY, 1)
    SetPlayerTeam(Player(2), 0)
    SetPlayerState(Player(2), PLAYER_STATE_ALLIED_VICTORY, 1)
    SetPlayerAllianceStateAllyBJ(Player(0), Player(1), true)
    SetPlayerAllianceStateAllyBJ(Player(0), Player(2), true)
    SetPlayerAllianceStateAllyBJ(Player(1), Player(0), true)
    SetPlayerAllianceStateAllyBJ(Player(1), Player(2), true)
    SetPlayerAllianceStateAllyBJ(Player(2), Player(0), true)
    SetPlayerAllianceStateAllyBJ(Player(2), Player(1), true)
    SetPlayerAllianceStateVisionBJ(Player(0), Player(1), true)
    SetPlayerAllianceStateVisionBJ(Player(0), Player(2), true)
    SetPlayerAllianceStateVisionBJ(Player(1), Player(0), true)
    SetPlayerAllianceStateVisionBJ(Player(1), Player(2), true)
    SetPlayerAllianceStateVisionBJ(Player(2), Player(0), true)
    SetPlayerAllianceStateVisionBJ(Player(2), Player(1), true)
end

function InitAllyPriorities()
    SetStartLocPrioCount(0, 2)
    SetStartLocPrio(0, 0, 1, MAP_LOC_PRIO_HIGH)
    SetStartLocPrio(0, 1, 2, MAP_LOC_PRIO_HIGH)
    SetStartLocPrioCount(1, 1)
    SetStartLocPrio(1, 0, 2, MAP_LOC_PRIO_HIGH)
    SetStartLocPrioCount(2, 1)
    SetStartLocPrio(2, 0, 1, MAP_LOC_PRIO_HIGH)
end

function main()
    SetCameraBounds(-3328.0 + GetCameraMargin(CAMERA_MARGIN_LEFT), -3584.0 + GetCameraMargin(CAMERA_MARGIN_BOTTOM), 3328.0 - GetCameraMargin(CAMERA_MARGIN_RIGHT), 3072.0 - GetCameraMargin(CAMERA_MARGIN_TOP), -3328.0 + GetCameraMargin(CAMERA_MARGIN_LEFT), 3072.0 - GetCameraMargin(CAMERA_MARGIN_TOP), 3328.0 - GetCameraMargin(CAMERA_MARGIN_RIGHT), -3584.0 + GetCameraMargin(CAMERA_MARGIN_BOTTOM))
    SetDayNightModels("Environment\\DNC\\DNCLordaeron\\DNCLordaeronTerrain\\DNCLordaeronTerrain.mdl", "Environment\\DNC\\DNCLordaeron\\DNCLordaeronUnit\\DNCLordaeronUnit.mdl")
    NewSoundEnvironment("Default")
    SetAmbientDaySound("LordaeronSummerDay")
    SetAmbientNightSound("LordaeronSummerNight")
    SetMapMusic("Music", true, 0)
    CreateRegions()
    CreateCameras()
    CreateAllUnits()
    InitBlizzard()
    InitGlobals()
    InitCustomTriggers()
    RunInitializationTriggers()
end

function config()
    SetMapName("TRIGSTR_003")
    SetMapDescription("TRIGSTR_005")
    SetPlayers(3)
    SetTeams(3)
    SetGamePlacement(MAP_PLACEMENT_TEAMS_TOGETHER)
    DefineStartLocation(0, 1088.0, -384.0)
    DefineStartLocation(1, 704.0, 640.0)
    DefineStartLocation(2, 1088.0, 640.0)
    InitCustomPlayerSlots()
    InitCustomTeams()
    InitAllyPriorities()
end

