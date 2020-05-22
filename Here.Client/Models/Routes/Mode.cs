using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Routes
{
    public class Mode
    {
        public string Type { get; set; }

        [JsonProperty("transportModes")]
        public List<string> TransportList { get; set; }

        public string TrafficMode { get; set; }

        [JsonProperty("feature")]
        public List<object> FeatureList { get; set; }
    }
}