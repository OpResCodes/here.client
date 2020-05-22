using Newtonsoft.Json;

namespace Here.Client.Responses.Routes
{

    public class IsolineResponse
    {
        [JsonProperty("response")]
        public IsolineResponseContent Content { get; set; }

    }



}
