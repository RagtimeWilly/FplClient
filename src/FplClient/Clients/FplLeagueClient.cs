using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplLeagueClient : IFplLeagueClient
    {
        private readonly HttpClient _client;

        public FplLeagueClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<FplClassicLeague> GetClassicLeague(int leagueId, int? page = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = ClassicLeagueUrlFor(leagueId, page);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplClassicLeague>(json);
        }

        public async Task<FplHeadToHeadLeague> GetHeadToHeadLeague(int leagueId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = HeadToHeadLeagueUrlFor(leagueId);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplHeadToHeadLeague>(json);
        }

        private static string ClassicLeagueUrlFor(int leagueId, int? page)
        {
            var baseUrl = $"http://fantasy.premierleague.com/drf/leagues-classic-standings/{leagueId}";

            return page == null ? baseUrl : $"{baseUrl}?phase=1&le-page=1&ls-page={page}";
        }

        private static string HeadToHeadLeagueUrlFor(int leagueId)
        {
            return $"http://fantasy.premierleague.com/drf/leagues-h2h-standings/{leagueId}";
        }
    }
}
