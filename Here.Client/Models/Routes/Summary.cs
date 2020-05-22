using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Routes
{
    public class Summary
    {
        public int Distance { get; set; }
        public int TrafficTime { get; set; }
        public int BaseTime { get; set; }

        [JsonProperty("flags")]
        public List<string> FlagList { get; set; }

        public string Text { get; set; }
        public int TravelTime { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }
    }
}