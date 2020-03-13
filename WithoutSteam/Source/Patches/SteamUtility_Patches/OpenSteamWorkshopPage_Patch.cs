using Harmony;
using UnityEngine;
using Verse;
using WithoutSteam.Utils;

namespace WithoutSteam.Patches.SteamUtility_Pathces {

    [HarmonyPatch]
    [HarmonyPatch(typeof(SteamUtility), "OpenSteamWorkshopPage")]
    public static class OpenSteamWorkshopPage_Patch {

        public static bool Prefix() {
            Application.OpenURL(SteamUtils.RimWorldSteamWorkshopUrl);
            return false;
        }
    }
}