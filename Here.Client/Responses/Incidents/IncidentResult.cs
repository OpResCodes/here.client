using Here.Client.Models.Incidents;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Incidents
{
    public class IncidentResult
    {
        [JsonProperty("TRAFFICITEMID")]
        public long TrafficItemId { get; set; }

        [JsonProperty("ORIGINALTRAFFICITEMID")]
        public long OriginalTrafficItemId { get; set; }

        [JsonProperty("TRAFFICITEMSTATUSSHORTDESC")]
        public string Description { get; set; }

        [JsonProperty("TRAFFICITEMTYPEDESC")]
        public string Type { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string EntryTime { get; set; }
        public Criticality Criticality { get; set; }

        [JsonProperty("VERIFIED")]
        public bool IsVerified { get; set; }

        public Abbreviation Abbreviation { get; set; }

        public RdstmcLocation RdstmcLocations { get; set; }

        public Location Location { get; set; }

        [JsonProperty("TRAFFICITEMDETAIL")]
        public IncidentItemDetail Detail { get; set; }

        [JsonProperty("TRAFFICITEMDESCRIPTION")]
        public List<Description> DescriptionList { get; set; }
    }
}