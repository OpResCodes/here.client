using Here.Client.Models.Routes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Here.Client.Responses.Routes
{
    public class RouteResult
    {
        [JsonProperty("waypoint")]
        public List<Waypoint> WaypointList { get; set; }

        public Mode Mode { get; set; }

        [JsonProperty("leg")]
        public List<Direction> DirectionList { get; set; }

        public Summary Summary { get; set; }
    }
}