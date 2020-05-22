using Newtonsoft.Json;

namespace Here.Client.Models.Routes
{
    public class Maneuver
    {
        public Position Position { get; set; }
        public string Instruction { get; set; }
        public int TravelTime { get; set; }
        public int Length { get; set; }
        public string Id { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }
    }
}