using Harmony;
using Verse;

namespace WithoutSteam.Patches.Dialog_MessageBox_Patches {

    [HarmonyPatch]
    [HarmonyPatch(typeof(Dialog_MessageBox))]
    [HarmonyPatch("PostOpen")]
    public static class PostOpen_Patch {
        public static void Prefix(this Dialog_MessageBox __instance) {
            string text = "SteamClientMissing".Translate();
            if (!__instance.text.NullOrEmpty() && __instance.text == text) {
                __instance.Close();
                Log.Message("SteamClientMissing Dialog Window closed.");
            }
        }
    }
}