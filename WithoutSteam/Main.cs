using Harmony;
using System.Reflection;
using Verse;

namespace WithoutSteam {

    [StaticConstructorOnStartup]
    public class Main : Mod {

        public Main(ModContentPack content) : base(content) {
            var harmony = HarmonyInstance.Create("com.scuba156.WithoutSteam");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}