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

        public async Task<FplBasicEntry> Get(int teamId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                var url = $"https://fantasy.premierleague.com/drf/entry/{teamId}";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplBasicEntry>(json);
            }
        }

        [Obsolete("This no longer appears to return data as of September 2017.", false)]
        public async Task<FplEventEntry> GetEventEntry(int teamId, int gameweek)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                var url = $"https://fantasy.premierleague.com/drf/entry/{teamId}/event/{gameweek}";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplEventEntry>(json);
            }
        }

        public async Task<FplEntryPicks> GetPicks(int teamId, int gameweek)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                var url = $"https://fantasy.premierleague.com/drf/entry/{teamId}/event/{gameweek}/picks";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplEntryPicks>(json);
            }
        }
    }
}
