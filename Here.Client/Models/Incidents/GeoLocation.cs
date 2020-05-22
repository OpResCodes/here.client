using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Incidents
{
    public class GeoLocation
    {
        public Position Origin { get; set; }

        [JsonProperty("TO")]
        public List<Position> ToList { get; set; }
    }
}