namespace Jellyfin.Plugin.Lastfm.Resources
{
    public static class Strings
    {
        public static class Endpoints
        {
            public static string LastfmApi  = "ws.audioscrobbler.com";
        }

        public static class Methods
        {
            // Last.FM API specs located at https://www.last.fm/api
            public static string Scrobble         = "track.scrobble";
            public static string NowPlaying       = "track.updateNowPlaying";
            public static string GetMobileSession = "auth.getMobileSession";
            public static string TrackLove        = "track.love";
            public static string TrackUnlove      = "track.unlove";
            public static string GetLovedTracks   = "user.getLovedTracks";
            public static string GetTracks        = "library.getTracks";
        }

        public static class Keys
        {
            public static string LastfmApiKey
            {
                get
                {
                    var key = Plugin.Instance?.PluginConfiguration?.ApiKey;
                    return string.IsNullOrWhiteSpace(key) ? "LASTFM_API_KEY_REMOVED" : key;
                }
            }

            public static string LastfmApiSeceret
            {
                get
                {
                    var secret = Plugin.Instance?.PluginConfiguration?.ApiSecret;
                    return string.IsNullOrWhiteSpace(secret) ? "LASTFM_API_SECRET_REMOVED" : secret;
                }
            }
        }
    }
}
