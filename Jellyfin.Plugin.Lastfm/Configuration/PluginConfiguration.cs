namespace Jellyfin.Plugin.Lastfm.Configuration
{
    using Models;
    using MediaBrowser.Model.Plugins;

    /// <summary>
    /// Class PluginConfiguration
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public LastfmUser[] LastfmUsers { get; set; }

        public PluginConfiguration()
        {
            ApiKey = string.Empty;
            ApiSecret = string.Empty;
            LastfmUsers = new LastfmUser[] { };
        }
    }
}
