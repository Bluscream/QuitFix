using System.Diagnostics;
using System.Collections;
using VRCModLoader;

namespace QuitFix
{
    public static class ModInfo
    {
        public const string Name = "QuitFix";
        public const string Author = "Herp Derpinstine";
        public const string Company = "NanoNuke @ nanonuke.net";
        public const string Version = "1.0.0.1";
    }
    [VRCModInfo(ModInfo.Name, ModInfo.Version, ModInfo.Author)]

    public class QuitFix : VRCMod
    {
        private const string prefSection = "quitFix";
        void OnApplicationStart()
        {
            VRCTools.ModPrefs.RegisterCategory(prefSection, "Quit Fix");
            VRCTools.ModPrefs.RegisterPrefBool(prefSection, "enable", true, "Toggle Force Quit");
            VRCTools.ModPrefs.RegisterPrefBool(prefSection, "waitformods", true, "Let Mods Finish");
        }
        void OnApplicationQuit() {
            if (!VRCTools.ModPrefs.GetBool(prefSection, "enable")) return;
            if (VRCTools.ModPrefs.GetBool(prefSection, "waitformods"))
                ModManager.StartCoroutine(WaitForQuit());
            else
                Process.GetCurrentProcess().Kill();
        }
        public static IEnumerator WaitForQuit() { yield return 0; Process.GetCurrentProcess().Kill(); }
    }
}
