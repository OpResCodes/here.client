using RestEase;

namespace Here.Client.Interfaces
{
    public interface IHereBaseClient
    {
        [Path("appId")]
        string AppId { get; set; }

        [Path("appCode")]
        string AppCode { get; set; }

    }

}