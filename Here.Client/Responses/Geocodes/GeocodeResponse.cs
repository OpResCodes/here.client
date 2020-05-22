using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Geocodes
{
    public class GeocodeResponse
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public MetaInfo MetaInfo { get; set; }

        [JsonProperty("View")]
        public List<GeocodeView> ViewList { get; set; }
    }
}