using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Incidents
{
    public class IncidentResponse
    {
        public string Timestamp { get; set; }
        public float Version { get; set; }

        [JsonProperty("TRAFFICITEMS")]
        public Response Response { get; set; }
    }

    public class Response
    {
        [JsonProperty("TRAFFICITEM")]
        public List<IncidentResult> ResultList { get; set; }
    }
}