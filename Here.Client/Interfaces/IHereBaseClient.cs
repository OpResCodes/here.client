using RestEase;

namespace Here.Client.Interfaces
{
    public interface IHereBaseClient
    {
        [Path("apiKey")]
        string ApiKey { get; set; }

    }

}