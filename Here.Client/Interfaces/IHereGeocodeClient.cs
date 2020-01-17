using Here.Client.Responses.Geocodes;
using RestEase;
using System.Threading.Tasks;

namespace Here.Client.Interfaces
{
    public interface IHereGeocodeClient : IHereBaseClient
    {
        [Get("6.2/geocode.json?searchtext={address}&app_id={appId}&app_code={appCode}")]
        Task<string> GetGecodeByAddressJsonAsync([Path] string address);

        [Get("6.2/geocode.json?searchtext={address}&app_id={appId}&app_code={appCode}")]
        Task<GeocodeResponse> GetGecodeByAddressAsync([Path] string address);

    }



}