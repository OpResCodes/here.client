using System.Globalization;

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
            return $"{Latitude.ToString(_ci)},{Longitude.ToString(_ci)}";
        }

        private static CultureInfo _ci = new CultureInfo("en-US");

    }
}