using Newtonsoft.Json;

namespace Here.Client.Models.Routes
{
    public class Isoline
    {
        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("component")]
        public IsolineComponent[] Component { get; set; }

        [JsonProperty("connection")]
        public IsolineConnection[] Connection { get; set; }

        [JsonProperty("start")]
        public Waypoint Start { get; set; }

        [JsonProperty("destination")]
        public Waypoint Destination { get; set; }
    }


}
