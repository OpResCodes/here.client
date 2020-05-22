using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Here.Client.Tests
{
    [TestClass]
    public class Traffic : TestBase
    {
        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            SetupHereClient();
        }

        [TestMethod]
        public async Task Traffic_GetIncidentsByBoundingBox_Json_Pass()
        {
            var result = await _hereClient.GetIncidentsByBoundingBoxJson("37.7902858,-122.4027371;37.7890649,-122.3993039");
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public async Task Traffic_GetIncidentsByBoundingBox_Pass()
        {
            var result = await _hereClient.GetIncidentsByBoundingBox("37.7902858,-122.4027371;37.7890649,-122.3993039");
            Assert.IsTrue(result != null);
        }

    }

}