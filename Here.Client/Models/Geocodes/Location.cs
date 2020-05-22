using Newtonsoft.Json;
using System;

namespace Here.Client.Models
{
    public class Location
    {
        public string LocationId { get; set; }

        [JsonProperty("LocationType")]
        private string LocationTypeString { get; set; }

        [JsonProperty("")]
        public LocationTypes? LocationType
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(LocationTypeString))
                {
                    return (LocationTypes)Enum.Parse(typeof(LocationTypes), LocationTypeString, true);
                }

                return null;
            }
        }

        public Position DisplayPosition { get; set; }

        [JsonProperty("NavigationPosition")]
        public Position[] NavigationPositionList { get; set; }

        public Mapview MapView { get; set; }
        public Address Address { get; set; }
    }
}