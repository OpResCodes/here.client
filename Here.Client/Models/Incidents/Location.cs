using Newtonsoft.Json;

namespace Here.Client.Models.Incidents
{
    public class Location
    {
        public Defined Defined { get; set; }

        [JsonProperty("GEOLOC")]
        public GeoLocation GeoLocation { get; set; }

        public Intersection Intersection { get; set; }

        public PoliticalBoundary PoliticalBoundary { get; set; }
    }
}