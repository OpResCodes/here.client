namespace Here.Client.Test
{
    public abstract class TestBase
    {
        protected static HereClient _hereClient = null;

        protected static void SetupHereClient()
        {
            var settingsFile = new System.IO.FileInfo(typeof(TestBase).Assembly.Location);
            var f = System.IO.Path.Combine(settingsFile.DirectoryName, "apikeys.json");
            ApiKeys keys = ApiKeys.LoadFromJson(f);
            _hereClient = new HereClient(keys.ApiKey);
        }
    }

}