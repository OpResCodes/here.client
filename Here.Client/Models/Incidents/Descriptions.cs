using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Models.Incidents
{
    public class Descriptions
    {
        public int Id { get; set; }

        [JsonProperty("DESCRIPTION")]
        public List<Description> DescriptionList { get; set; }
    }
}