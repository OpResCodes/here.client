using Here.Client.Models;

namespace Here.Client.Responses.Geocodes
{
    public class GeocodeResult
    {
        public float Relevance { get; set; }
        public string MatchLevel { get; set; }
        public MatchQuality MatchQuality { get; set; }
        public string MatchType { get; set; }
        public Location Location { get; set; }
    }
}