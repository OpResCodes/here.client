namespace Here.Client.Models.Incidents
{
    public class IntersectionPosition
    {
        public string Id { get; set; }
        public Street Street1 { get; set; }
        public Street Street2 { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public Proximity Proximity { get; set; }
    }
}