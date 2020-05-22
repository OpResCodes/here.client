using Here.Client.Responses.Geocodes;
using RestEase;
using System.Threading.Tasks;

namespace Here.Client.Interfaces
{
    public interface IHereGeocodeClient : IHereBaseClient
    {
        [Get("6.2/geocode.json?apiKey={apiKey}&searchtext={address}")]
        Task<string> GetGecodeByAddressJsonAsync([Path] string address);

        [Get("6.2/geocode.json?apiKey={apiKey}&searchtext={address}")]
        Task<GeocodeResponse> GetGecodeByAddressAsync([Path] string address);

    }



}