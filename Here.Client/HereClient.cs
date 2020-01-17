using Here.Client.Interfaces;
using Here.Client.Models.Routes;
using Here.Client.Responses.Geocodes;
using Here.Client.Responses.Incidents;
using Here.Client.Responses.Routes;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Here.Client
{
    public class HereClient
    {
        private string _appId { get; set; }
        private string _appCode { get; set; }
        private IHereBaseClient _hereClient { get; set; }

        public HereClient(string appId, string appCode)
        {
            _appId = appId;
            _appCode = appCode;
        }

        private void Initalize(string url)
        {
            _hereClient = RestClient.For<IHereBaseClient>(url);
            _hereClient.AppId = _appId;
            _hereClient.AppCode = _appCode;
        }

        public async Task<string> GetGeocodeByAddressJson(string address)
        {
            Initalize("https://geocoder.api.here.com/");

            var response = await _hereClient.GetGecodeByAddressJsonAsync(address);

            return response;
        }

        public async Task<List<GeocodeResult>> GetGeocodeByAddress(string address)
        {
            Initalize("https://geocoder.api.here.com/");

            var response = await _hereClient.GetGecodeByAddressAsync(address);

            List<GeocodeResult> result = new List<GeocodeResult>();

            response.Response.ViewList.ForEach(view =>
            {
                result.AddRange(view.ResultList);
            });

            return result;
        }

        public async Task<string> GetRouteByGeocodeJson(string originPosition, string destinationPosition, RouteType routeType = null)
        {
            Initalize("https://route.api.here.com/routing/");

            if (routeType == null)
            {
                routeType = new RouteType();
            }

            var response = await _hereClient.GetRouteByAddressJsonAsync(originPosition, destinationPosition,
                routeType.IsMetricString, routeType.ModeTypeString, routeType.VehicleTypeString, routeType.HasTrafficString);

            return response;
        }

        public async Task<List<RouteResult>> GetRouteByGeocode(string originPosition, string destinationPosition, RouteType routeType = null)
        {
            Initalize("https://route.api.here.com/routing/");

            if (routeType == null)
            {
                routeType = new RouteType();
            }

            var response = await _hereClient.GetRouteByAddressAsync(originPosition, destinationPosition,
                 routeType.IsMetricString, routeType.ModeTypeString, routeType.VehicleTypeString, routeType.HasTrafficString);

            return response.Response.ResultList;
        }

        public async Task<List<RouteResult>> GetRouteByAddress(string originAddress, string destinationAddress, RouteType routeType = null)
        {
            if (routeType == null)
            {
                routeType = new RouteType();
            }

            var originGeocodeResponse = await GetGeocodeByAddress(originAddress);
            var originGeocode = originGeocodeResponse.FirstOrDefault();

            if (originGeocode == null)
            {
                throw new Exception("Origin Address Exception");
            }

            var destinationGeocodeReponse = await GetGeocodeByAddress(destinationAddress);
            var destinationGeocode = destinationGeocodeReponse.FirstOrDefault();

            if (destinationGeocode == null)
            {
                throw new Exception("Destination Address Exception");
            }

            var originPosition = originGeocode.Location.DisplayPosition.ToString();
            var destinationPosition = destinationGeocode.Location.DisplayPosition.ToString();

            Initalize("https://route.api.here.com/routing/");

            var response = await _hereClient.GetRouteByAddressAsync(originPosition, destinationPosition,
                routeType.IsMetricString, routeType.ModeTypeString, routeType.VehicleTypeString, routeType.HasTrafficString);

            return response.Response.ResultList;
        }

        public async Task<string> GetIncidentsByBoundingBoxJson(string boundingBox)
        {
            Initalize("https://traffic.api.here.com/traffic/");

            var response = await _hereClient.GetIncidentsByBoundingBoxJsonAsync(boundingBox);

            return response;
        }

        public async Task<List<IncidentResult>> GetIncidentsByBoundingBox(string boundingBox)
        {
            Initalize("https://traffic.api.here.com/traffic/");

            var response = await _hereClient.GetIncidentsByBoundingBoxAsync(boundingBox);

            if (response.Response != null)
            {
                return response.Response.ResultList;
            }

            return new List<IncidentResult>();
        }

        public async Task<List<IncidentResult>> GetIncidentsByAddress(string originAddress, string destinationAddress)
        {
            var originGeocodeResponse = await GetGeocodeByAddress(originAddress);
            var originGeocode = originGeocodeResponse.FirstOrDefault();

            if (originGeocode == null)
            {
                throw new Exception("Origin Address Exception");
            }

            var destinationGeocodeReponse = await GetGeocodeByAddress(destinationAddress);
            var destinationGeocode = destinationGeocodeReponse.FirstOrDefault();

            if (destinationGeocode == null)
            {
                throw new Exception("Destination Address Exception");
            }

            var originPosition = originGeocode.Location.DisplayPosition.ToString();
            var destinationPosition = destinationGeocode.Location.DisplayPosition.ToString();

            // Much improvement needed
            var boundingBox = $"{originPosition};{destinationPosition}";

            Initalize("https://traffic.api.here.com/traffic/");

            var response = await _hereClient.GetIncidentsByBoundingBoxAsync(boundingBox);

            if (response.Response != null)
            {
                return response.Response.ResultList;
            }

            return new List<IncidentResult>();
        }
    }
}