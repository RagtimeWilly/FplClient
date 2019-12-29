using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplLiveGameweekStatsClient : IFplLiveGameweekStatsClient
    {
        private readonly HttpClient _client;

        public FplLiveGameweekStatsClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<FplLiveGameweekStats> Get(int gameweek)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = $"https://fantasy.premierleague.com/api/event/{gameweek}/live";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplLiveGameweekStats>(json);
        }
    }
}
