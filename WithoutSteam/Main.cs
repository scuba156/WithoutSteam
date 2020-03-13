using HarmonyLib;
using Verse;

namespace WithoutSteam {

    [StaticConstructorOnStartup]
    public class Main : Mod {

        public Main(ModContentPack content) : base(content) {
            var harmony = new Harmony("com.scuba156.WithoutSteam");
            harmony.PatchAll();
        }
    }
}