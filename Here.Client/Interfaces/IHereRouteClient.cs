using Here.Client.Responses.Incidents;
using Here.Client.Responses.Routes;
using RestEase;
using System.Threading.Tasks;

namespace Here.Client.Interfaces
{
    public interface IHereRouteClient : IHereBaseClient
    {

        [Get("7.2/calculateroute.json?waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}&app_id={appId}&app_code={appCode}")]
        Task<string> GetRouteByAddressJsonAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic);

        [Get("7.2/calculateroute.json?waypoint0=geo!{originGeocode}&waypoint1=geo!{destinationGeocode}&metricSystem={units}&mode={mode};{vehicle};traffic:{traffic}&app_id={appId}&app_code={appCode}")]
        Task<RouteResponse> GetRouteByAddressAsync([Path] string originGeocode, [Path] string destinationGeocode, [Path] string units, [Path] string mode, [Path] string vehicle, [Path] string traffic);

        [Get("6.0/incidents.json?bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact&app_id={appId}&app_code={appCode}")]
        Task<string> GetIncidentsByBoundingBoxJsonAsync([Path] string boundingBox);

        [Get("6.0/incidents.json?bbox={boundingBox}&criticality=critical%2Cmajor%2Cminor%2ClowImpact&app_id={appId}&app_code={appCode}")]
        Task<IncidentResponse> GetIncidentsByBoundingBoxAsync([Path] string boundingBox);

    }



}