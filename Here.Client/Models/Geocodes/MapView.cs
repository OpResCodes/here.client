namespace Here.Client.Models
{
    public class Mapview
    {
        public TopLeft TopLeft { get; set; }
        public BottomRight BottomRight { get; set; }
    }

    public class TopLeft
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

    public class BottomRight
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}