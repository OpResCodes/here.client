using System.Collections.Generic;
using System.Text;

namespace Here.Client.Models.Routes
{
    public class RouteAttributeDetails
    {
        private HashSet<string> _values = new HashSet<string>();

        private bool check(string value) => _values.Contains(value);
        private void edit(bool add, string value)
        {
            if (add)
                _values.Add(value);
            else
                _values.Remove(value);
        }
        public static RouteAttributeDetails Defaults()
        {
            var detail = new RouteAttributeDetails();
            detail.IncludeSummary = true;
            detail.IncludeWaypoints = true;
            detail.IncludeLegs = true;
            return detail;
        }

        /// <summary>
        /// Indicates whether via points shall be included in the route.
        /// </summary>
        public bool IncludeWaypoints { get => check("wp"); set => edit(value, "wp"); }
        
        /// <summary>
        /// Indicates whether a route summary shall be provided for the route.
        /// </summary>
        public bool IncludeSummary { get => check("sm"); set => edit(value,"sm"); }

        /// <summary>
        /// Indicates whether a country-based route summary shall be provided for the route
        /// </summary>
        public bool IncludeSummaryByCountry { get => check("sc"); set => edit(value,"sc"); }

        /// <summary>
        /// Indicates whether the shape of the route shall be provided for the route.
        /// </summary>
        public bool IncludeRouteAsPolylineShape { get => check("sh"); set => edit(value,"sh"); }

        /// <summary>
        /// Indicates whether the bounding box of the route shall be provided for the route.
        /// </summary>
        public bool IncludeBoundingBox { get => check("bb"); set => edit(value,"bb"); }

        /// <summary>
        /// Indicates whether the legs of the route shall be provided for the route.
        /// </summary>
        public bool IncludeLegs { get => check("lg"); set => edit(value,"lg"); }

        /// <summary>
        /// Indicates whether additional notes shall be provided for the route.
        /// </summary>
        public bool IncludeNotes { get => check("no"); set => edit(value,"no"); }

        /// <summary>
        /// Indicates whether PublicTransportLines shall be provided for the route.
        /// </summary>
        public bool IncludeLines { get => check("li"); set => edit(value,"li"); }

        /// <summary>
        /// Indicates whether Labels shall be provided for the route. Labels are useful to distinguish between alternative routes.
        /// </summary>
        public bool IncludeLabels { get => check("la"); set => edit(value,"la"); }

        /// <summary>
        /// Indicates whether RouteId shall be calculated and provided for the route. There are cases when RouteId calculation is not possible (for example PublicTransport) or fails even though the rest of the route is properly calculated.
        /// </summary>
        public bool IncludeRouteId { get => check("ri"); set => edit(value,"ri"); }

        /// <summary>
        /// Indicates whether Maneuver Groups should be included in the route. Maneuver Groups are useful for multi modal routes.
        /// </summary>
        public bool Includegroups { get => check("gr"); set => edit(value,"gr"); }

        /// <summary>
        /// Indicates whether Incidents on the route shall be provided for the route.
        /// </summary>
        public bool IncludeIncidents { get => check("ic"); set => edit(value,"ic"); }

        /// <summary>
        /// Indicates whether crossed zones shall be provided for the route.
        /// </summary>
        public bool IncludeZones { get => check("zo"); set => edit(value,"zo"); }
        
        internal string AttributesString
        {
            get
            {
                if (_values.Count == 0)
                    return string.Empty;
                StringBuilder b = new StringBuilder(_values.Count*3 -1);
                int c = _values.Count;
                foreach (string s in _values)
                {
                    b.Append(s);
                    c--;
                    if (c > 0)
                        b.Append(",");
                }
                return b.ToString();
            }
        }

    }

}
 