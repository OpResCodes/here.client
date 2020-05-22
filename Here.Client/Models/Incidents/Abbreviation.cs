using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Abbreviation
    {
        public string Description { get; set; }

        [JsonProperty("SHORTDESC")]
        public string ShortDescription { get; set; }
    }
}