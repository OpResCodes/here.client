using Newtonsoft.Json;

namespace Here.Client.Models.Routes
{
    public class IsolineConnection
    {

        [JsonProperty("fromId")]
        public string FromId { get; set; }

        [JsonProperty("toId")]
        public string ToId { get; set; }

        [JsonProperty("shape")]
        public CoordinateArray Shape { get; set; }

    }


}
