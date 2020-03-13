using HarmonyLib;
using UnityEngine;
using Verse;
using WithoutSteam.Utils;

namespace WithoutSteam.Patches.SteamUtility_Pathces {

    [HarmonyPatch]
    [HarmonyPatch(typeof(SteamUtility), "OpenUrl")]
    public static class OpenUrl_Patch {

        public static bool Prefix(string url) {
            Application.OpenURL(SteamUtils.ConvertFromSteamUrl(url));
            return false;
        }
    }
}