using Here.Client.Interfaces;
using Here.Client.Models;
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
        protected string _apiKey { get; set; }
        private IHereClient _hereClient { get; set; }

        public HereClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        private void Initalize(string url)
        {
            _hereClient = RestClient.For<IHereClient>(url, new RequestModifier((a, b) =>
           {
               System.Diagnostics.Debug.WriteLine(a.RequestUri.ToString());
               return Task.CompletedTask;
           }));
            _hereClient.ApiKey = _apiKey;
        }

        #region GeoCoding

        public async Task<string> GetGeocodeByAddressJson(string address)
        {
            Initalize(HereApiBaseUrl.GeocodeApiBase);
            var response = await _hereClient.GetGecodeByAddressJsonAsync(address);
            return response;
        }

        public async Task<List<GeocodeResult>> GetGeocodeByAddress(string address)
        {
            Initalize(HereApiBaseUrl.GeocodeApiBase);

            var response = await _hereClient.GetGecodeByAddressAsync(address);
            List<GeocodeResult> result = new List<GeocodeResult>();
            response.Response.ViewList.ForEach(view =>
            {
                result.AddRange(view.ResultList);
            });
            return result;
        }

        #endregion

        #region Routing

        public async Task<string> GetRouteByPositionJson(Position origin, Position destination, RouteType routeType = null)
        {            
            if (routeType == null)
            {
                routeType = new RouteType();
            }
            Initalize(HereApiBaseUrl.RoutingApiBase);
            var response = await _hereClient.GetRouteByPositionJsonAsync(origin.ToString(), destination.ToString(),
                routeType.IsMetricString, routeType.ModeTypeString, routeType.VehicleTypeString, routeType.HasTrafficString);
            return response;
        }

        public async Task<List<RouteResult>> GetRouteByPosition(Position origin, Position destination, RouteType routeType = null)
        {
            if (routeType == null)
            {
                routeType = new RouteType();
            }
            Initalize(HereApiBaseUrl.RoutingApiBase);
            var response = await _hereClient.GetRouteByPositionAsync(origin.ToString(), destination.ToString(),
                 routeType.IsMetricString, routeType.ModeTypeString, routeType.VehicleTypeString, routeType.HasTrafficString,
                 routeType.RouteAttributeString);
            return response.Response.ResultList;
        }

        public async Task<List<RouteResult>> GetRouteByAddress(string originAddress, string destinationAddress, RouteType routeType = null)
        {
            if (routeType == null)
            {
                routeType = new RouteType();
            }
            //get geolocations of addresses:
            var positions = await GetPositions(originAddress, destinationAddress);
            //get routing result:
            return await GetRouteByPosition(positions.Item1, positions.Item2, routeType);
        }
        
        private async Task<Tuple<Position, Position>> GetPositions(string o, string d)
        {
            var originGeocodeResponse = GetGeocodeByAddress(o);
            var destinationGeocodeReponse = GetGeocodeByAddress(d);
            await Task.WhenAll(originGeocodeResponse, destinationGeocodeReponse);
            var originGeocode = originGeocodeResponse.Result.FirstOrDefault();
            var destinationGeocode = destinationGeocodeReponse.Result.FirstOrDefault();
            if (originGeocode == null)
            {
                throw new ArgumentException($"Origin Address Exception. Address: {o}");
            }
            if (destinationGeocode == null)
            {
                throw new ArgumentException($"Destination Address Exception. Address: {d}");
            }
            return Tuple.Create(
                originGeocode.Location.DisplayPosition,
                destinationGeocode.Location.DisplayPosition);
        }

        #endregion

        #region Traffic

        public async Task<string> GetIncidentsByBoundingBoxJson(string boundingBox)
        {
            Initalize(HereApiBaseUrl.TrafficApiBase);
            var response = await _hereClient.GetIncidentsByBoundingBoxJsonAsync(boundingBox);
            return response;
        }

        public async Task<List<IncidentResult>> GetIncidentsByBoundingBox(string boundingBox)
        {
            Initalize(HereApiBaseUrl.TrafficApiBase);
            var response = await _hereClient.GetIncidentsByBoundingBoxAsync(boundingBox);
            if (response.Response != null)
            {
                return response.Response.ResultList;
            }
            return new List<IncidentResult>();
        }



        #endregion

    }
}