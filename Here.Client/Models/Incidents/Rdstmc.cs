using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Rdstmc
    {
        public RdstmcPosition Origin { get; set; }

        public RdstmcPosition To { get; set; }

        public string Direction { get; set; }

        [JsonProperty("ALERTC")]
        public Alert Alert { get; set; }
    }
}