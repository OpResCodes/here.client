using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Here.Client.Test
{

    [TestClass]
    public class HereTests : TestBase
    {

        [ClassInitialize]
        public static void SetupClient(TestContext con)
        {
            SetupHereClient();
        }


        [TestMethod]
        public void HereClientHasApiKeys()
        {
            Assert.IsNotNull(_hereClient);
        }

    }

}