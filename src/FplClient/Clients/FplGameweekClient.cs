using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplGameweekClient : IFplGameweekClient
    {
        private readonly HttpClient _client;

        public FplGameweekClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<ICollection<FplGameweek>> GetGameweeks()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/api/bootstrap-static";

            var json = await _client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<FplGlobalSettings>(json);

            return data.Events;
        }
    }
}
