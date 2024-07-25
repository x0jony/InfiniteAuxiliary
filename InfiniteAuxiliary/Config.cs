using System.ComponentModel;
using Exiled.API.Interfaces;

namespace InfiniteAuxiliary
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled on the server.")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Whether or not to show logs used for debugging.")]
        public bool Debug { get; set; } = false;
    }
}