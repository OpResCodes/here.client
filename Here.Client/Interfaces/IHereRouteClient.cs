using Here.Client.Responses.Incidents;
using Here.Client.Responses.Routes;
using RestEase;
using System.Threading.Tasks;

namespace Here.Client.Interfaces
{
    public interface IHereRouteClient : IHereBaseClient
    {

        [Get("7.2/calculateroute.json?apiKey={apiKey}&waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}")]
        Task<string> GetRouteByPositionJsonAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic);

        [Get("7.2/calculateroute.json?apiKey={apiKey}&waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}&routeAttributes={routeAttributes}")]
        Task<RouteResponse> GetRouteByPositionAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic, [Path] string routeAttributes);

        [Get("6.3/incidents.json?apiKey={apiKey}&bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact&apiKey={apiKey}")]
        Task<string> GetIncidentsByBoundingBoxJsonAsync([Path] string boundingBox);

        [Get("6.3/incidents.json?apiKey={apiKey}&bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact")]
        Task<IncidentResponse> GetIncidentsByBoundingBoxAsync([Path] string boundingBox);

        [Get("7.2/calculateisoline.json?apiKey={apiKey}&start={start}&rangetype={rangetype}&range={range}&mode={mode};{vehicle};traffic:{traffic}&singlecomponent=true")]
        Task<IsolineResponse> GetIsolineAsync([Path] string start, [Path] string rangetype, [Path] string range,
            [Path] string mode, [Path] string vehicle, [Path] string traffic);


    }



}