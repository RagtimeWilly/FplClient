using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplEntryHistoryClient : IFplEntryHistoryClient
    {
        private readonly HttpClient _client;

        public FplEntryHistoryClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<FplEntryHistory> GetHistory(int teamId)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = HistoryUrlFor(teamId);

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<FplEntryHistory>(json);
        }

        private static string HistoryUrlFor(int teamId)
        {
            return $"https://fantasy.premierleague.com/api/entry/{teamId}/history/";
        }
    }
}
