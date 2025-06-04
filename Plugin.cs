using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Model.Serialization;
using System;

namespace CustomLogoPlugin
{
    public class Plugin : BasePlugin<PluginConfiguration>, IPlugin
    {
        public static Plugin Instance { get; private set; }

        public override string Name => "Custom Logo";
        public override string Description => "Allows uploading a custom logo to replace Jellyfin branding.";

        public IApplicationPaths GetApplicationPaths() => ApplicationPaths;

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer) 
        { 
            Instance = this;
        }

        public override Guid Id => Guid.Parse("b7e8dce1-44df-4b37-91a3-15fcf9f3b76a");
    }
}
