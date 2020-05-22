using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Routes
{
    public class Direction
    {
        public Location Start { get; set; }
        public Location End { get; set; }
        public int Length { get; set; }
        public int TravelTime { get; set; }

        [JsonProperty("shape")]
        public List<string> Shape { get; set; }

        public int MyProperty { get; set; }

        [JsonProperty("maneuver")]
        public List<Maneuver> ManeuverList { get; set; }
    }

}