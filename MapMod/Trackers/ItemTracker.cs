﻿using Vasi;

namespace VanillaMapMod.Trackers
{
    public static class ItemTracker
    {
        public static void Hook()
        {
            On.PlayMakerFSM.OnEnable += PlayMakerFSM_OnEnable;
        }

        // Called after every time the map is opened
        public static void UpdateObtainedItems()
        {
            if (PlayerData.instance.hasDash)
            {
                VanillaMapMod.LS.ObtainedItems["Mothwing_Cloak" + "Fungus1_04"] = true;
            }

            if (PlayerData.instance.hasWalljump)
            {
                VanillaMapMod.LS.ObtainedItems["Mantis_Claw" + "Fungus2_14"] = true;
            }

            if (PlayerData.instance.hasSuperDash)
            {
                VanillaMapMod.LS.ObtainedItems["Crystal_Heart" + "Mines_31"] = true;
            }

            if (PlayerData.instance.hasDoubleJump)
            {
                VanillaMapMod.LS.ObtainedItems["Monarch_Wings" + "Abyss_21"] = true;
            }

            if (PlayerData.instance.hasShadowDash)
            {
                VanillaMapMod.LS.ObtainedItems["Shade_Cloak" + "Abyss_10"] = true;
            }

            if (PlayerData.instance.hasAcidArmour)
            {
                VanillaMapMod.LS.ObtainedItems["Isma's_Tear" + "Waterways_13"] = true;
            }

            if (PlayerData.instance.hasDreamNail)
            {
                VanillaMapMod.LS.ObtainedItems["Dream_Nail" + "Dream_Nailcollection"] = true;
            }

            if (PlayerData.instance.fireballLevel != 0)
            {
                VanillaMapMod.LS.ObtainedItems["Vengeful_Spirit" + "Crossroads_ShamanTemple"] = true;
            }

            if (PlayerData.instance.fireballLevel == 2)
            {
                VanillaMapMod.LS.ObtainedItems["Shade_Soul" + "Ruins1_31b"] = true;
            }

            if (PlayerData.instance.quakeLevel != 0)
            {
                VanillaMapMod.LS.ObtainedItems["Desolate_Dive" + "Ruins1_24"] = true;
            }

            if (PlayerData.instance.quakeLevel == 2)
            {
                VanillaMapMod.LS.ObtainedItems["Descending_Dark" + "Mines_35"] = true;
            }

            if (PlayerData.instance.screamLevel != 0)
            {
                VanillaMapMod.LS.ObtainedItems["Howling_Wraiths" + "Room_Fungus_Shaman"] = true;
            }

            if (PlayerData.instance.screamLevel == 2)
            {
                VanillaMapMod.LS.ObtainedItems["Abyss_Shriek" + "Abyss_12"] = true;
            }

            if (PlayerData.instance.hasCyclone)
            {
                VanillaMapMod.LS.ObtainedItems["Cyclone_Slash" + "Room_nailmaster"] = true;
            }

            // PlayerData has these two the wrong way around
            if (PlayerData.instance.hasUpwardSlash)
            {
                VanillaMapMod.LS.ObtainedItems["Dash_Slash" + "Room_nailmaster_03"] = true;
            }

            if (PlayerData.instance.hasDashSlash)
            {
                VanillaMapMod.LS.ObtainedItems["Great_Slash" + "Room_nailmaster_02"] = true;
            }

            if (PlayerData.instance.gotCharm_5)
            {
                VanillaMapMod.LS.ObtainedItems["Baldur_Shell" + "Fungus1_28"] = true;
            }

            if (PlayerData.instance.gotCharm_6)
            {
                VanillaMapMod.LS.ObtainedItems["Fury_of_the_Fallen" + "Tutorial_01"] = true;
            }

            if (PlayerData.instance.gotCharm_9)
            {
                VanillaMapMod.LS.ObtainedItems["Lifeblood_Core" + "Abyss_08"] = true;
            }

            if (PlayerData.instance.gotCharm_10)
            {
                VanillaMapMod.LS.ObtainedItems["Defender's_Crest" + "Waterways_05"] = true;
            }

            if (PlayerData.instance.gotCharm_11)
            {
                VanillaMapMod.LS.ObtainedItems["Flukenest" + "Waterways_12"] = true;
            }

            if (PlayerData.instance.gotCharm_12)
            {
                VanillaMapMod.LS.ObtainedItems["Thorns_of_Agony" + "Fungus1_14"] = true;
            }

            if (PlayerData.instance.gotCharm_13)
            {
                VanillaMapMod.LS.ObtainedItems["Mark_of_Pride" + "Fungus2_31"] = true;
            }

            if (PlayerData.instance.gotCharm_16)
            {
                VanillaMapMod.LS.ObtainedItems["Sharp_Shadow" + "Deepnest_44"] = true;
            }

            if (PlayerData.instance.gotCharm_17)
            {
                VanillaMapMod.LS.ObtainedItems["Spore_Shroom" + "Fungus2_20"] = true;
            }

            if (PlayerData.instance.gotCharm_20)
            {
                VanillaMapMod.LS.ObtainedItems["Soul_Catcher" + "Crossroads_ShamanTemple"] = true;
            }

            if (PlayerData.instance.gotCharm_21)
            {
                VanillaMapMod.LS.ObtainedItems["Soul_Eater" + "RestingGrounds_10"] = true;
            }

            if (PlayerData.instance.gotCharm_22)
            {
                VanillaMapMod.LS.ObtainedItems["Glowing_Womb" + "Crossroads_22"] = true;
            }

            if (PlayerData.instance.gotCharm_26)
            {
                VanillaMapMod.LS.ObtainedItems["Nailmaster's_Glory" + "Room_Sly_Storeroom"] = true;
            }

            if (PlayerData.instance.gotCharm_27)
            {
                VanillaMapMod.LS.ObtainedItems["Joni's_Blessing" + "Cliffs_05"] = true;
            }

            if (PlayerData.instance.gotCharm_28)
            {
                VanillaMapMod.LS.ObtainedItems["Shape_of_Unn" + "Fungus1_Slug"] = true;
            }

            if (PlayerData.instance.gotCharm_29)
            {
                VanillaMapMod.LS.ObtainedItems["Hiveblood" + "Hive_05"] = true;
            }

            if (PlayerData.instance.gotCharm_30)
            {
                VanillaMapMod.LS.ObtainedItems["Dream_Wielder" + "RestingGrounds_07"] = true;
            }

            if (PlayerData.instance.gotCharm_31)
            {
                VanillaMapMod.LS.ObtainedItems["Dashmaster" + "Fungus2_23"] = true;
            }

            if (PlayerData.instance.gotCharm_32)
            {
                VanillaMapMod.LS.ObtainedItems["Quick_Slash" + "Deepnest_East_14b"] = true;
            }

            if (PlayerData.instance.gotCharm_33)
            {
                VanillaMapMod.LS.ObtainedItems["Spell_Twister" + "Ruins1_30"] = true;
            }

            if (PlayerData.instance.gotCharm_34)
            {
                VanillaMapMod.LS.ObtainedItems["Deep_Focus" + "Mines_36"] = true;
            }

            if (PlayerData.instance.gotQueenFragment)
            {
                VanillaMapMod.LS.ObtainedItems["Queen_Fragment" + "Room_Queen"] = true;
            }

            if (PlayerData.instance.gotKingFragment)
            {
                VanillaMapMod.LS.ObtainedItems["King_Fragment" + "White_Palace_09"] = true;
            }

            if (PlayerData.instance.royalCharmState == 4)
            {
                VanillaMapMod.LS.ObtainedItems["Void_Heart" + "Abyss_15"] = true;
            }

            if (PlayerData.instance.gotCharm_38)
            {
                VanillaMapMod.LS.ObtainedItems["Dreamshield" + "RestingGrounds_17"] = true;
            }

            if (PlayerData.instance.gotCharm_39)
            {
                VanillaMapMod.LS.ObtainedItems["Weaversong" + "Deepnest_45_v02"] = true;
            }

            if (PlayerData.instance.gotCharm_40)
            {
                VanillaMapMod.LS.ObtainedItems["Grimmchild" + "Grimm_Main_Tent"] = true;
            }

            if (PlayerData.instance.hasCityKey || PlayerData.instance.openedCityGate)
            {
                VanillaMapMod.LS.ObtainedItems["City_Crest" + "Crossroads_10"] = true;
            }

            if (PlayerData.instance.hasTramPass)
            {
                VanillaMapMod.LS.ObtainedItems["Tram_Pass" + "Deepnest_26b"] = true;
            }

            if (PlayerData.instance.gotLurkerKey)
            {
                VanillaMapMod.LS.ObtainedItems["Simple_Key-Lurker" + "GG_Lurker"] = true;
            }

            if (PlayerData.instance.hasSlykey || PlayerData.instance.gaveSlykey)
            {
                VanillaMapMod.LS.ObtainedItems["Shopkeeper's_Key" + "Mines_11"] = true;
            }

            if (PlayerData.instance.hasLoveKey || PlayerData.instance.openedLoveDoor)
            {
                VanillaMapMod.LS.ObtainedItems["Love_Key" + "Fungus3_39"] = true;
            }

            if (PlayerData.instance.hasKingsBrand)
            {
                VanillaMapMod.LS.ObtainedItems["King's_Brand" + "Room_Wyrm"] = true;
            }

            if (PlayerData.instance.falseKnightOrbsCollected)
            {
                VanillaMapMod.LS.ObtainedItems["Boss_Essence-Failed_Champion" + "Crossroads_10"] = true;
            }

            if (PlayerData.instance.mageLordOrbsCollected)
            {
                VanillaMapMod.LS.ObtainedItems["Boss_Essence-Soul_Tyrant" + "Ruins1_24_boss_defeated"] = true;
            }

            if (PlayerData.instance.infectedKnightOrbsCollected)
            {
                VanillaMapMod.LS.ObtainedItems["Boss_Essence-Lost_Kin" + "Abyss_19"] = true;
            }

            if (PlayerData.instance.whiteDefenderOrbsCollected)
            {
                VanillaMapMod.LS.ObtainedItems["Boss_Essence-White_Defender" + "Waterways_15"] = true;
            }

            if (PlayerData.instance.greyPrinceOrbsCollected)
            {
                VanillaMapMod.LS.ObtainedItems["Boss_Essence-Grey_Prince_Zote" + "Room_Bretta_Basement"] = true;
            }

            // Team Cherry, why...?
            if (PlayerData.instance.vesselFragStagNest)
            {
                VanillaMapMod.LS.ObtainedItems["Vessel Fragment Stagnest (1)" + "Cliffs_03"] = true;
            }

            if (PlayerData.instance.notchFogCanyon)
            {
                VanillaMapMod.LS.ObtainedItems["Charm Notch" + "Fungus3_28"] = true;
            }

            if (PlayerData.instance.nightmareLanternLit)
            {
                VanillaMapMod.LS.ObtainedItems["Grimm Troupe Lantern" + "Cliffs_06"] = true;
            }

            if (PlayerData.instance.hasPinGrub)
            {
                VanillaMapMod.LS.ObtainedItems["Collector's_Map" + "Ruins2_11"] = true;
            }

            if (PlayerData.instance.mapCrossroads)
            {
                VanillaMapMod.LS.ObtainedItems["Crossroads_Map" + "Crossroads_33"] = true;
            }

            if (PlayerData.instance.mapGreenpath)
            {
                VanillaMapMod.LS.ObtainedItems["Greenpath_Map" + "Fungus1_06"] = true;
            }

            if (PlayerData.instance.mapFogCanyon)
            {
                VanillaMapMod.LS.ObtainedItems["Fog_Canyon_Map" + "Fungus3_25"] = true;
            }

            if (PlayerData.instance.mapFungalWastes)
            {
                VanillaMapMod.LS.ObtainedItems["Fungal_Wastes_Map" + "Fungus2_18"] = true;
            }

            if (PlayerData.instance.mapDeepnest)
            {
                VanillaMapMod.LS.ObtainedItems["Deepnest_Map" + "Deepnest_01b"] = true;
                VanillaMapMod.LS.ObtainedItems["Deepnest_Map" + "Fungus2_25"] = true;
            }

            if (PlayerData.instance.mapAbyss)
            {
                VanillaMapMod.LS.ObtainedItems["Ancient_Basin_Map" + "Abyss_04"] = true;
            }

            if (PlayerData.instance.mapOutskirts)
            {
                VanillaMapMod.LS.ObtainedItems["Kingdom's_Edge_Map" + "Deepnest_East_03"] = true;
            }

            if (PlayerData.instance.mapCity)
            {
                VanillaMapMod.LS.ObtainedItems["City_of_Tears_Map" + "Ruins1_31"] = true;
            }

            if (PlayerData.instance.mapWaterways)
            {
                VanillaMapMod.LS.ObtainedItems["Royal_Waterways_Map" + "Waterways_09"] = true;
            }

            if (PlayerData.instance.mapCliffs)
            {
                VanillaMapMod.LS.ObtainedItems["Howling_Cliffs_Map" + "Cliffs_01"] = true;
            }

            if (PlayerData.instance.mapMines)
            {
                VanillaMapMod.LS.ObtainedItems["Crystal_Peak_Map" + "Mines_30"] = true;
            }

            if (PlayerData.instance.mapRoyalGardens)
            {
                VanillaMapMod.LS.ObtainedItems["Queen's_Gardens_Map" + "Fungus1_24"] = true;
            }

            if (PlayerData.instance.mapRestingGrounds)
            {
                VanillaMapMod.LS.ObtainedItems["Resting_Grounds_Map" + "RestingGrounds_09"] = true;
            }

            // The following is needed in case the mod is installed halfway through an existing vanilla save
            foreach (GeoRockData grd in GameManager.instance.sceneData.geoRocks)
            {
                if (grd.hitsLeft == 0)
                {
                    VanillaMapMod.LS.ObtainedItems[grd.id + grd.sceneName] = true;
                }
            }

            foreach (PersistentBoolData pbd in GameManager.instance.sceneData.persistentBoolItems)
            {
                if (pbd.id.Contains("Shiny Item") && pbd.activated
                    || pbd.id == "Heart Piece" && pbd.activated
                    || pbd.id == "Vessel Fragment" && pbd.activated
                    || pbd.id.Contains("Chest") && pbd.activated)
                {
                    VanillaMapMod.LS.ObtainedItems[pbd.id + pbd.sceneName] = true;
                }
            }
        }

        // sceneData doesn't immediately get updated when items are picked up,
        // therefore we need to use the item FSMs to determine this
        private static void PlayMakerFSM_OnEnable(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
        {
            orig(self);

            string goName = self.gameObject.name;

            // Most items: charms, charm notches, pale ore, rancid eggs, relics
            if (self.FsmName == "Shiny Control")
            {
                FsmUtil.AddAction(FsmUtil.GetState(self, "Finish"), new TrackItem(goName));
            }

            // Mask/Vessel
            else if (goName == "Heart Piece"
                || goName == "Vessel Fragment")
            {
                FsmUtil.AddAction(FsmUtil.GetState(self, "Get"), new TrackItem(goName));
            }

            // Geo Chests
            else if (goName.Contains("Chest"))
            {
                FsmUtil.AddAction(FsmUtil.GetState(self, "Open"), new TrackItem(goName));
            }
        }
    }
}