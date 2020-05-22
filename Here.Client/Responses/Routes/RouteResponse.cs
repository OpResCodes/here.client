using Newtonsoft.Json;

namespace Here.Client.Responses.Routes
{
    public class RouteResponse
    {
        [JsonProperty("response")]
        public RouteResponseContent Content { get; set; }
    }
}