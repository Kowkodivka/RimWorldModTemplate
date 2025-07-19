using HarmonyLib;
using Verse;

namespace RimWorldModTemplate;

public class RimWorldModTemplate : Mod
{
    public RimWorldModTemplate(ModContentPack content) : base(content)
    {
        new Harmony("kowkodivka.rwmt").PatchAll();
        Log.Message("[RWMT] Mod has been loaded");
    }
}