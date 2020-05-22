using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Street
    {
        [JsonProperty("ADDRESS1")]
        public string Address { get; set; }
    }
}