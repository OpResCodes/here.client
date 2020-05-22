using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class ScheduledEvent
    {
        [JsonProperty("SCHEDULEDCONSTRUCTIONTYPEDESC")]
        public string Type { get; set; }

        [JsonProperty("SCHEDULEDCONSTRUCTIONDETAIL")]
        public string Description { get; set; }
    }
}