using Microsoft.Win32;

namespace SLWModLoader
{
    public static class Reg
    {
        // Variables/Constants
        public const string SteamPath = "SteamPath",
           SteamKey = "HKEY_CURRENT_USER\\Software\\Valve\\Steam",
           WinShell = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\Shell",
           DefBrowser = WinShell + "\\Associations\\UrlAssociations\\http\\UserChoice",
           Classes = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes";

        // Methods
        public static string GetValue(string key, string value)
        {
            return Registry.GetValue(key, value, null) as string;
        }
    }
}