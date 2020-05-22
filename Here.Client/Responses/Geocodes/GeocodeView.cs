using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Geocodes
{
    public class GeocodeView
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        public int ViewId { get; set; }

        [JsonProperty("Result")]
        public List<GeocodeResult> ResultList { get; set; }
    }
}