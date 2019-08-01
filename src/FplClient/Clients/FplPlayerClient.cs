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

        public async Task<ICollection<FplPlayer>> GetAllPlayers()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/api/bootstrap-static";

            var json = await _client.GetStringAsync(url);

            var data = JsonConvert.DeserializeObject<FplGlobalSettings>(json);

            return data.Players;
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
            return $"http://fantasy.premierleague.com/api/element-summary/{playerId}";
        }
    }
}
