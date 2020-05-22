using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class IncidentItemDetail
    {
        [JsonProperty("ROADCLOSED")]
        public bool IsClosed { get; set; }

        public Event Event { get; set; }
    }
}