using Harmony;
using Verse;

namespace WithoutSteam.Patches.Dialog_MessageBox_Patches {

    [HarmonyPatch]
    [HarmonyPatch(typeof(Dialog_MessageBox))]
    [HarmonyPatch("PostOpen")]
    public static class PostOpen_Patch {
        private static bool hasAlreadyClosedWindow = false;
        public static void Prefix(this Dialog_MessageBox __instance) {
            if (hasAlreadyClosedWindow) return;
            string text = "SteamClientMissing".Translate();
            if (!__instance.text.NullOrEmpty() && __instance.text == text) {
                __instance.Close();
                hasAlreadyClosedWindow = true;
                Log.Message("SteamClientMissing Dialog Window closed.");
            }
        }
    }
}