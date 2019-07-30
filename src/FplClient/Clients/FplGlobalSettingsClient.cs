using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplGlobalSettingsClient : IFplGlobalSettingsClient
    {
        private readonly HttpClient _client;

        public FplGlobalSettingsClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<FplGlobalSettings> GetGlobalSettings()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/api/bootstrap-static/";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplGlobalSettings>(json);
        }
    }
}
