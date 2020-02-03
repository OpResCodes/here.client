using Newtonsoft.Json;

namespace Here.Client.Models.Routes
{
    public class IsolineComponent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shape")]
        public CoordinateArray Shape { get; set; }

    }


}
