using System;

namespace Here.Client.Responses.Routes
{
    public class MetaInfo
    {
        public DateTime Timestamp { get; set; }
        public string MapVersion { get; set; }
        public string ModuleVersion { get; set; }
        public string InterfaceVersion { get; set; }
        public string[] AvailableMapVersion { get; set; }
    }
}