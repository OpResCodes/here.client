using Here.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Here.Client.Test
{
    [TestClass]
    public class Routing : TestBase
    {
        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            SetupHereClient();
        }

        private Tuple<Position,Position> GetPositions()
        {
            return Tuple.Create(new Position(53.565214f, 9.987793f), new Position(53.563995f, 9.990151f));
        }

        [TestMethod]
        public void Route_GetByPosition_Json_Pass()
        {
            var pos = GetPositions();
            var result = _hereClient.GetRouteByPositionJson(pos.Item1,pos.Item2).Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByPosition_Pass()
        {
            var pos = GetPositions();
            var result = _hereClient.GetRouteByPosition(
                pos.Item1,pos.Item2,
                new Models.Routes.RouteType
                {
                    VehicleType = Models.Routes.VehicleTypes.Pedestrian,
                    ModeType = Models.Routes.ModeTypes.Fastest,
                    HasTraffic = true
                }).Result;

            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Route_GetByAddress_Pass()
        {
            var result = _hereClient.GetRouteByAddress(
                "Von-Melle-Park 5, Hamburg",
                "Moorweidenstraße 18, 20148 Hamburg",
                    new Models.Routes.RouteType(new Models.Routes.RouteAttributeDetails()
                    {
                        IncludeLegs = false,
                        IncludeSummary = true,
                        IncludeRouteAsPolylineShape = true
                    })
                    {
                        VehicleType = Models.Routes.VehicleTypes.Pedestrian,
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

    }
}
