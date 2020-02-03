using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Routes
{
    public class RouteResponseContent
    {
        [JsonProperty("metaInfo")]
        public MetaInfo MetaInfo { get; set; }

        [JsonProperty("Route")]
        public List<RouteResult> ResultList { get; set; }

        public string Language { get; set; }
    }
}