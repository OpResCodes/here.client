namespace Here.Client.Models
{
    public class Position
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public Position() : this(default(float),default(float)) { }

        public Position(float lat, float lng)
        {
            Latitude = lat;
            Longitude = lng;
        }


        public override string ToString()
        {
            return $"{Latitude},{Longitude}";
        }
    }
}