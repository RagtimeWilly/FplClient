using System;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplEntryHistoryClient : IFplEntryHistoryClient
    {
        private readonly Func<HttpClient> _clientFactory;

        public FplEntryHistoryClient(Func<HttpClient> clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<FplEntryHistory> GetHistory(int teamId)
        {
            using (var client = _clientFactory())
            {
                var url = HistoryUrlFor(teamId);

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplEntryHistory>(json);
            }
        }

        private static string HistoryUrlFor(int teamId)
        {
            return $"https://fantasy.premierleague.com/drf/entry/{teamId}/history";
        }
    }
}
