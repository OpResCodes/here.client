using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Incidents
{
    public class RdstmcLocation
    {
        [JsonProperty("RDSTMC")]
        public List<Rdstmc> RdstmcList { get; set; }
    }
}