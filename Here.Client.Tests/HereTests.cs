using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace Here.Client.Tests
{
    [TestClass]
    public class HereTests
    {
        private static HereClient _hereClient;

        private class ApiKeys
        {
            public string AppId { get; set; }
            public string AppCode { get; set; }
        }

        private static ApiKeys LoadKeys()
        {
            var settinsFile = new System.IO.FileInfo(typeof(HereTests).Assembly.Location);
            var f = System.IO.Path.Combine(settinsFile.DirectoryName, "apikeys.json");
            using (var file = File.OpenText(f))
            {
                using (var reader = new JsonTextReader(file))
                {
                    var jsonSerializer = new JsonSerializer();
                    return jsonSerializer.Deserialize<ApiKeys>(reader);
                }
            }
        }

        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            var keys = LoadKeys(); 
            _hereClient = new HereClient(keys.AppId, keys.AppCode);
        }

        [TestMethod]
        public void Geocode_GetByAddress_Json_Pass()
        {
            var result = _hereClient.GetGeocodeByAddressJson("ADDRESS").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Geocode_GetByAddress_Pass()
        {
            var result = _hereClient.GetGeocodeByAddress("ADDRESS").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByGeocode_Json_Pass()
        {
            var result = _hereClient.GetRouteByGeocodeJson("1,1", "1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByGeocode_Pass()
        {
            var result = _hereClient.GetRouteByGeocode(
                "1,1",
                "1,1",
                new Models.Routes.RouteType
                {
                    VehicleType = Models.Routes.VehicleTypes.Car,
                    ModeType = Models.Routes.ModeTypes.Fastest,
                    HasTraffic = true
                }).Result;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByAddress_Pass()
        {
            var result = _hereClient.GetRouteByAddress(
                "Wiesenhöfen 7, 22359 Hamburg",
                "Moorweidenstraße 18, 20148 Hamburg",
                    new Models.Routes.RouteType(new Models.Routes.RouteAttributeDetails()
                    {
                        IncludeLegs = false,
                        IncludeSummary = false,
                        IncludeRouteAsPolylineShape = true
                    }){
                        VehicleType = Models.Routes.VehicleTypes.Car,
                        ModeType = Models.Routes.ModeTypes.Fastest,
                        HasTraffic = true
                    }).Result;

            

            Assert.IsTrue(result != null);

            result = _hereClient.GetRouteByAddress(
                "ADDRESS",
                "ADDRESS",
                    new Models.Routes.RouteType
                    {
                        VehicleType = Models.Routes.VehicleTypes.Car,
                        ModeType = Models.Routes.ModeTypes.Fastest,
                        HasTraffic = false
                    }).Result;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByBoundingBox_Json_Pass()
        {
            var result = _hereClient.GetIncidentsByBoundingBoxJson("1,1;1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByBoundingBox_Pass()
        {
            var result = _hereClient.GetIncidentsByBoundingBox("1,1;1,1").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Traffic_GetIncidentsByAddress_Pass()
        {
            var result = _hereClient.GetIncidentsByAddress(
                "ADDRESS",
                "ADDRESS").Result;
            Assert.IsTrue(result != null);
        }
    }
}