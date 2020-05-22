using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Alert
    {
        public int TrafficCode { get; set; }

        public int Quantifiers { get; set; }
        public string Description { get; set; }

        [JsonProperty("ALERTCDURATION")]
        public string AlertDuration { get; set; }

        [JsonProperty("ALERTCDIRECTION")]
        public int AlertDirection { get; set; }

        public int UpdateClass { get; set; }
        public string PhraseCode { get; set; }
        public string Extent { get; set; }
        public int Duration { get; set; }
    }
}