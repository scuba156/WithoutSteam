using System;
using Verse;

namespace WithoutSteam.Utils {

    public static class SteamUtils {
        public static readonly string RimWorldAppId = "294100";
        public static readonly string RimWorldSteamWorkshopUrl = "https://steamcommunity.com/workshop/browse/?appid=" + RimWorldAppId;
        private const string STEAM_APP_URL = "https://store.steampowered.com/app/";
        private const string STEAM_SHAREDFILE_URL = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
        private const string STEAM_URL_PREFIX = "steam://url";

        public static string ConvertFromSteamUrl(string url) {
            if (!url.NullOrEmpty() && url.StartsWith(STEAM_URL_PREFIX, StringComparison.OrdinalIgnoreCase)) {
                int idStartIndex = url.TrimEnd('/').LastIndexOf('/');
                int urlTypeStartIndex = STEAM_URL_PREFIX.Length + 1;
                string id = url.TrimEnd('/').Substring(idStartIndex + 1);

                int urlTypeLength = url.Length - (id.Length + STEAM_URL_PREFIX.Length + 1) - 1;
                string urlType = url.Substring(urlTypeStartIndex, urlTypeLength);

                switch (urlType) {
                    case "StoreAppPage":
                        return STEAM_APP_URL + id;

                    case "CommunityFilePage":
                        return STEAM_SHAREDFILE_URL + id;

                    default:
                        Log.Error("WithoutSteam -- Unknown url type: " + urlType);
                        break;
                }
            }
            return url;
        }
    }
}