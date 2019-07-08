using VRCModLoader;
using System.Diagnostics;

namespace QuitFix
{
    public static class ModInfo
    {
        public const string Name = "QuitFix";
        public const string Author = "Herp Derpinstine";
        public const string Company = "NanoNuke @ nanonuke.net";
        public const string Version = "1.0.0.0";
    }
    [VRCModInfo(ModInfo.Name, ModInfo.Version, ModInfo.Author)]

    public class QuitFix : VRCMod
    {
        void OnApplicationStart(){}
        void OnApplicationQuit() { Process.GetCurrentProcess().Kill(); }
        void OnLevelWasLoaded(int level) {}
        void OnLevelWasInitialized(int level) {}
        void OnUpdate() {}
        void OnFixedUpdate() {}
        void OnLateUpdate() {}
        void OnGUI() {}
    }
}
