namespace Here.Client.Models.Incidents
{
    public class DefinedPosition
    {
        public Descriptions Roadway { get; set; }
        public Descriptions Point { get; set; }
        public Descriptions Direction { get; set; }
        public Proximity Proximity { get; set; }
    }
}