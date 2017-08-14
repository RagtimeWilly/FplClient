using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplEntryClient : IFplEntryClient
    {
        private readonly Func<HttpClient> _clientFactory;

        public FplEntryClient(Func<HttpClient> clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<FplEventEntry> GetTeam(int teamId, int gameweek)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                var url = TeamUrlFor(teamId, gameweek);

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplEventEntry>(json);
            }
        }

        private static string TeamUrlFor(int teamId, int gameweek)
        {
            return $"https://fantasy.premierleague.com/drf/entry/{teamId}/event/{gameweek}";
        }
    }
}
