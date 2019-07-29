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

        public async Task<FplClassicLeague> GetClassicLeague(int leagueId, int page = 1)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = ClassicLeagueUrlFor(leagueId, page);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplClassicLeague>(json);
        }

        public async Task<FplHeadToHeadLeague> GetHeadToHeadLeague(int leagueId, int page = 1)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = HeadToHeadLeagueUrlFor(leagueId, page);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplHeadToHeadLeague>(json);
        }

        private static string ClassicLeagueUrlFor(int leagueId, int? page)
        {
            var baseUrl = $"http://fantasy.premierleague.com/api/leagues-classic/{leagueId}/standings/";

            var suffix = $"?page_new_entries={page ?? 1}&page_standings={page ?? 1}";

            return $"{baseUrl}{suffix}";
        }

        private static string HeadToHeadLeagueUrlFor(int leagueId, int? page)
        {
            var baseUrl = $"http://fantasy.premierleague.com/api/leagues-h2h/{leagueId}/standings/";

            var suffix = $"?page_new_entries={page ?? 1}&page_standings={page ?? 1}";

            return $"{baseUrl}{suffix}";
        }
    }
}
