using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Here.Client.Tests
{
    [TestClass]
    public class Geocoding : TestBase
    {

        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            SetupHereClient();
        }

        [TestMethod]
        public void Geocode_GetByAddress_Json_Pass()
        {
            var result = _hereClient.GetGeocodeByAddressJson("Moorweidenstraße 18, 20148 Hamburg").Result;
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Geocode_GetByAddress_Pass()
        {
            var result = _hereClient.GetGeocodeByAddress("Moorweidenstraße 18, 20148 Hamburg").Result;
            Assert.IsTrue(result != null);
        }


    }
}
