using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Event
    {
        [JsonProperty("EVENTITEMCANCELLED")]
        public bool IsCanceled { get; set; }

        [JsonProperty("SCHEDULEDCONSTRUCTIONEVENT")]
        public ScheduledEvent ScheduledEvent { get; set; }
    }
}