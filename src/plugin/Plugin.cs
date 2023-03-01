using BepInEx;
using MoreSlugcats;

namespace NotReallyAGamer
{
    [BepInPlugin("com.coder23848.notreallyagamer", PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
#pragma warning disable IDE0051 // Visual Studio is whiny
        private void OnEnable()
        {
            On.Room.PlaySound_SoundID_float_float_float += Room_PlaySound_SoundID_float_float_float;
        }
#pragma warning restore IDE0051

        private void Room_PlaySound_SoundID_float_float_float(On.Room.orig_PlaySound_SoundID_float_float_float orig, Room self, SoundID soundId, float pan, float vol, float pitch)
        {
            if (soundId == MoreSlugcatsEnums.MSCSoundID.Inv_GO)
            {
                orig(self, SoundID.UI_Slugcat_Die, pan, vol, pitch);
            }
            else if (soundId == MoreSlugcatsEnums.MSCSoundID.Inv_Hit)
            {
            }
            else
            {
                orig(self, soundId, pan, vol, pitch);
            }
        }
    }
}