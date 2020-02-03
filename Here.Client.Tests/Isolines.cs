using Here.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Here.Client.Tests
{
    [TestClass]
    public class Isolines : TestBase
    {
        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            SetupHereClient();
        }


        private static Position _center = new Position(53.565214f, 9.987793f);

        [TestMethod]
        public async Task Can_Request_Isoline()
        {
            var isoline = await _hereClient.GetIsoline(_center, Models.Routes.RangeType.time, 600,
                new Models.Routes.RouteType()
                {
                    VehicleType = Models.Routes.VehicleTypes.Pedestrian,
                    HasTraffic = false,
                    ModeType = Models.Routes.ModeTypes.Shortest,
                    IsMetric = true,
                });
            Assert.IsNotNull(isoline);
            Assert.AreNotEqual(0, isoline.Count);
        }
    }
}
