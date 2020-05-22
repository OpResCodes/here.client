using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class RdstmcPosition
    {
        [JsonProperty("EBUCOUNTRYCODE")]
        public string CountryCode { get; set; }

        public int TableId { get; set; }

        public string LocationId { get; set; }

        [JsonProperty("LOCATIONDESC")]
        public string LocationDescription { get; set; }

        [JsonProperty("RDSDIRECTION")]
        public string RdsDirection { get; set; }
    }
}