namespace Here.Client.Models
{
    public class MatchQuality
    {
        public float State { get; set; }
        public float City { get; set; }
        public float[] Street { get; set; }
        public float HouseNumber { get; set; }
        public float PostalCode { get; set; }
    }
}