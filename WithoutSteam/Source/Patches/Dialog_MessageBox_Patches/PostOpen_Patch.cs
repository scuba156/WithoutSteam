using Harmony;
using Verse;

namespace WithoutSteamPatches.Dialog_MessageBox_Patches {

    [HarmonyPatch]
    [HarmonyPatch(typeof(Dialog_MessageBox))]
    [HarmonyPatch("PostOpen")]
    public static class PostOpen_Patch {

        public static void Prefix(this Dialog_MessageBox __instance) {
            string text = "SteamClientMissing".Translate();
            if (__instance.text == text) {
                __instance.Close();
                Log.Message("SteamClientMissing Dialog Window closed.");
            }
        }
    }
}