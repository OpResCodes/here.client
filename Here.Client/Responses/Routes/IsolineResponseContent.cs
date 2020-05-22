using Here.Client.Models;
using Here.Client.Models.Routes;
using Newtonsoft.Json;

namespace Here.Client.Responses.Routes
{
    public class IsolineResponseContent
    {
        [JsonProperty("metaInfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonProperty("center")]
        public Position Center { get; set; }

        [JsonProperty("isoline")]
        public Isoline[] Isoline { get; set; }

    }

}
