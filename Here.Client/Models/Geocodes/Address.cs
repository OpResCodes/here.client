using Newtonsoft.Json;

namespace Here.Client.Models
{
    public class Address
    {
        public string Label { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        [JsonProperty("AdditionalData")]
        public AdditionalData[] AdditionalDataList { get; set; }

        public class AdditionalData
        {
            [JsonProperty("key")]
            public string Key { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }
    }
}