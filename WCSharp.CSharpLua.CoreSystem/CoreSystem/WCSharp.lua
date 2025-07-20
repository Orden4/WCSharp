local define = System.defStc
local setmetatable = setmetatable

local handle = define("WCSharp.Api.handle", {
  default = function ()
    return nil
  end
})
local agent = define("WCSharp.Api.agent", {
  base = { handle }
})
local event = define("WCSharp.Api.event", {
  base = { agent }
})
local player = define("WCSharp.Api.player", {
  base = { agent }
})
local widget = define("WCSharp.Api.widget", {
  base = { agent }
})
local unit = define("WCSharp.Api.unit", {
  base = { widget }
})
local destructable = define("WCSharp.Api.destructable", {
  base = { widget }
})
local item = define("WCSharp.Api.item", {
  base = { widget }
})
local ability = define("WCSharp.Api.ability", {
  base = { agent }
})
local buff = define("WCSharp.Api.buff", {
  base = { ability }
})
local force = define("WCSharp.Api.force", {
  base = { agent }
})
local group = define("WCSharp.Api.group", {
  base = { agent }
})
local trigger = define("WCSharp.Api.trigger", {
  base = { agent }
})
local triggercondition = define("WCSharp.Api.triggercondition", {
  base = { agent }
})
local triggeraction = define("WCSharp.Api.triggeraction", {
  base = { handle }
})
local timer = define("WCSharp.Api.timer", {
  base = { agent }
})
local location = define("WCSharp.Api.location", {
  base = { agent }
})
local region = define("WCSharp.Api.region", {
  base = { agent }
})
local rect = define("WCSharp.Api.rect", {
  base = { agent }
})
local boolexpr = define("WCSharp.Api.boolexpr", {
  base = { agent }
})
local sound = define("WCSharp.Api.sound", {
  base = { agent }
})
local conditionfunc = define("WCSharp.Api.conditionfunc", {
  base = { boolexpr }
})
local filterfunc = define("WCSharp.Api.filterfunc", {
  base = { boolexpr }
})
local unitpool = define("WCSharp.Api.unitpool", {
  base = { handle }
})
local itempool = define("WCSharp.Api.itempool", {
  base = { handle }
})
local race = define("WCSharp.Api.race", {
  base = { handle }
})
local alliancetype = define("WCSharp.Api.alliancetype", {
  base = { handle }
})
local racepreference = define("WCSharp.Api.racepreference", {
  base = { handle }
})
local gamestate = define("WCSharp.Api.gamestate", {
  base = { handle }
})
local igamestate = define("WCSharp.Api.igamestate", {
  base = { gamestate }
})
local fgamestate = define("WCSharp.Api.fgamestate", {
  base = { gamestate }
})
local playerstate = define("WCSharp.Api.playerstate", {
  base = { handle }
})
local playerscore = define("WCSharp.Api.playerscore", {
  base = { handle }
})
local playergameresult = define("WCSharp.Api.playergameresult", {
  base = { handle }
})
local unitstate = define("WCSharp.Api.unitstate", {
  base = { handle }
})
local aidifficulty = define("WCSharp.Api.aidifficulty", {
  base = { handle }
})
local eventid = define("WCSharp.Api.eventid", {
  base = { handle }
})
local gameevent = define("WCSharp.Api.gameevent", {
  base = { eventid }
})
local playerevent = define("WCSharp.Api.playerevent", {
  base = { eventid }
})
local playerunitevent = define("WCSharp.Api.playerunitevent", {
  base = { eventid }
})
local unitevent = define("WCSharp.Api.unitevent", {
  base = { eventid }
})
local limitop = define("WCSharp.Api.limitop", {
  base = { eventid }
})
local widgetevent = define("WCSharp.Api.widgetevent", {
  base = { eventid }
})
local dialogevent = define("WCSharp.Api.dialogevent", {
  base = { eventid }
})
local unittype = define("WCSharp.Api.unittype", {
  base = { handle }
})
local gamespeed = define("WCSharp.Api.gamespeed", {
  base = { handle }
})
local gamedifficulty = define("WCSharp.Api.gamedifficulty", {
  base = { handle }
})
local gametype = define("WCSharp.Api.gametype", {
  base = { handle }
})
local mapflag = define("WCSharp.Api.mapflag", {
  base = { handle }
})
local mapvisibility = define("WCSharp.Api.mapvisibility", {
  base = { handle }
})
local mapsetting = define("WCSharp.Api.mapsetting", {
  base = { handle }
})
local mapdensity = define("WCSharp.Api.mapdensity", {
  base = { handle }
})
local mapcontrol = define("WCSharp.Api.mapcontrol", {
  base = { handle }
})
local minimapicon = define("WCSharp.Api.minimapicon", {
  base = { handle }
})
local playerslotstate = define("WCSharp.Api.playerslotstate", {
  base = { handle }
})
local volumegroup = define("WCSharp.Api.volumegroup", {
  base = { handle }
})
local camerafield = define("WCSharp.Api.camerafield", {
  base = { handle }
})
local camerasetup = define("WCSharp.Api.camerasetup", {
  base = { handle }
})
local playercolor = define("WCSharp.Api.playercolor", {
  base = { handle }
})
local placement = define("WCSharp.Api.placement", {
  base = { handle }
})
local startlocprio = define("WCSharp.Api.startlocprio", {
  base = { handle }
})
local raritycontrol = define("WCSharp.Api.raritycontrol", {
  base = { handle }
})
local blendmode = define("WCSharp.Api.blendmode", {
  base = { handle }
})
local texmapflags = define("WCSharp.Api.texmapflags", {
  base = { handle }
})
local effect = define("WCSharp.Api.effect", {
  base = { agent }
})
local effecttype = define("WCSharp.Api.effecttype", {
  base = { handle }
})
local weathereffect = define("WCSharp.Api.weathereffect", {
  base = { handle }
})
local terraindeformation = define("WCSharp.Api.terraindeformation", {
  base = { handle }
})
local fogstate = define("WCSharp.Api.fogstate", {
  base = { handle }
})
local fogmodifier = define("WCSharp.Api.fogmodifier", {
  base = { agent }
})
local dialog = define("WCSharp.Api.dialog", {
  base = { agent }
})
local button = define("WCSharp.Api.button", {
  base = { agent }
})
local quest = define("WCSharp.Api.quest", {
  base = { agent }
})
local questitem = define("WCSharp.Api.questitem", {
  base = { agent }
})
local defeatcondition = define("WCSharp.Api.defeatcondition", {
  base = { agent }
})
local timerdialog = define("WCSharp.Api.timerdialog", {
  base = { agent }
})
local leaderboard = define("WCSharp.Api.leaderboard", {
  base = { agent }
})
local multiboard = define("WCSharp.Api.multiboard", {
  base = { agent }
})
local multiboarditem = define("WCSharp.Api.multiboarditem", {
  base = { agent }
})
local trackable = define("WCSharp.Api.trackable", {
  base = { agent }
})
local gamecache = define("WCSharp.Api.gamecache", {
  base = { agent }
})
local version = define("WCSharp.Api.version", {
  base = { handle }
})
local itemtype = define("WCSharp.Api.itemtype", {
  base = { handle }
})
local texttag = define("WCSharp.Api.texttag", {
  base = { handle }
})
local attacktype = define("WCSharp.Api.attacktype", {
  base = { handle }
})
local damagetype = define("WCSharp.Api.damagetype", {
  base = { handle }
})
local weapontype = define("WCSharp.Api.weapontype", {
  base = { handle }
})
local soundtype = define("WCSharp.Api.soundtype", {
  base = { handle }
})
local lightning = define("WCSharp.Api.lightning", {
  base = { handle }
})
local pathingtype = define("WCSharp.Api.pathingtype", {
  base = { handle }
})
local mousebuttontype = define("WCSharp.Api.mousebuttontype", {
  base = { handle }
})
local animtype = define("WCSharp.Api.animtype", {
  base = { handle }
})
local subanimtype = define("WCSharp.Api.subanimtype", {
  base = { handle }
})
local image = define("WCSharp.Api.image", {
  base = { handle }
})
local ubersplat = define("WCSharp.Api.ubersplat", {
  base = { handle }
})
local hashtable = define("WCSharp.Api.hashtable", {
  base = { agent }
})
local framehandle = define("WCSharp.Api.framehandle", {
  base = { handle }
})
local originframetype = define("WCSharp.Api.originframetype", {
  base = { handle }
})
local framepointtype = define("WCSharp.Api.framepointtype", {
  base = { handle }
})
local textaligntype = define("WCSharp.Api.textaligntype", {
  base = { handle }
})
local frameeventtype = define("WCSharp.Api.frameeventtype", {
  base = { handle }
})
local oskeytype = define("WCSharp.Api.oskeytype", {
  base = { handle }
})
local abilityintegerfield = define("WCSharp.Api.abilityintegerfield", {
  base = { handle }
})
local abilityrealfield = define("WCSharp.Api.abilityrealfield", {
  base = { handle }
})
local abilitybooleanfield = define("WCSharp.Api.abilitybooleanfield", {
  base = { handle }
})
local abilitystringfield = define("WCSharp.Api.abilitystringfield", {
  base = { handle }
})
local abilityintegerlevelfield = define("WCSharp.Api.abilityintegerlevelfield", {
  base = { handle }
})
local abilityreallevelfield = define("WCSharp.Api.abilityreallevelfield", {
  base = { handle }
})
local abilitybooleanlevelfield = define("WCSharp.Api.abilitybooleanlevelfield", {
  base = { handle }
})
local abilitystringlevelfield = define("WCSharp.Api.abilitystringlevelfield", {
  base = { handle }
})
local abilityintegerlevelarrayfield = define("WCSharp.Api.abilityintegerlevelarrayfield", {
  base = { handle }
})
local abilityreallevelarrayfield = define("WCSharp.Api.abilityreallevelarrayfield", {
  base = { handle }
})
local abilitybooleanlevelarrayfield = define("WCSharp.Api.abilitybooleanlevelarrayfield", {
  base = { handle }
})
local abilitystringlevelarrayfield = define("WCSharp.Api.abilitystringlevelarrayfield", {
  base = { handle }
})
local unitintegerfield = define("WCSharp.Api.unitintegerfield", {
  base = { handle }
})
local unitrealfield = define("WCSharp.Api.unitrealfield", {
  base = { handle }
})
local unitbooleanfield = define("WCSharp.Api.unitbooleanfield", {
  base = { handle }
})
local unitstringfield = define("WCSharp.Api.unitstringfield", {
  base = { handle }
})
local unitweaponintegerfield = define("WCSharp.Api.unitweaponintegerfield", {
  base = { handle }
})
local unitweaponrealfield = define("WCSharp.Api.unitweaponrealfield", {
  base = { handle }
})
local unitweaponbooleanfield = define("WCSharp.Api.unitweaponbooleanfield", {
  base = { handle }
})
local unitweaponstringfield = define("WCSharp.Api.unitweaponstringfield", {
  base = { handle }
})
local itemintegerfield = define("WCSharp.Api.itemintegerfield", {
  base = { handle }
})
local itemrealfield = define("WCSharp.Api.itemrealfield", {
  base = { handle }
})
local itembooleanfield = define("WCSharp.Api.itembooleanfield", {
  base = { handle }
})
local itemstringfield = define("WCSharp.Api.itemstringfield", {
  base = { handle }
})
local movetype = define("WCSharp.Api.movetype", {
  base = { handle }
})
local targetflag = define("WCSharp.Api.targetflag", {
  base = { handle }
})
local armortype = define("WCSharp.Api.armortype", {
  base = { handle }
})
local heroattribute = define("WCSharp.Api.heroattribute", {
  base = { handle }
})
local defensetype = define("WCSharp.Api.defensetype", {
  base = { handle }
})
local regentype = define("WCSharp.Api.regentype", {
  base = { handle }
})
local unitcategory = define("WCSharp.Api.unitcategory", {
  base = { handle }
})
local pathingflag = define("WCSharp.Api.pathingflag", {
  base = { handle }
})
local commandbuttoneffect = define("WCSharp.Api.commandbuttoneffect", {
  base = { handle }
})
