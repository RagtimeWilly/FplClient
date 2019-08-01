using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplFixtureClient : IFplFixtureClient
    {
        private readonly HttpClient _client;

        public FplFixtureClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<ICollection<FplFixture>> GetFixtures()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string url = "https://fantasy.premierleague.com/api/fixtures";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<ICollection<FplFixture>>(json);
        }

        public async Task<ICollection<FplFixture>> GetFixturesByGameweek(int id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var url = $"https://fantasy.premierleague.com/api/fixtures/?event={id}";

            var json = await _client.GetStringAsync(url);

            return JsonConvert.DeserializeObject<ICollection<FplFixture>>(json);
        }
    }
}
