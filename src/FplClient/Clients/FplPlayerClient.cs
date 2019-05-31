using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplPlayerClient : IFplPlayerClient
    {
        private readonly HttpClient _client;

        public FplPlayerClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<FplPlayer>> GetAllPlayers()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/drf/elements/";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<IEnumerable<FplPlayer>>(json);
        }

        public async Task<FplPlayerSummary> GetPlayer(int playerId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = PlayerSummaryUrlFor(playerId);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplPlayerSummary>(json);
        }

        private static string PlayerSummaryUrlFor(int playerId)
        {
            return $"http://fantasy.premierleague.com/drf/element-summary/{playerId}";
        }
    }
}
