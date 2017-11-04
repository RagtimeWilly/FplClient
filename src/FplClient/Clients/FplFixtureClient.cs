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
        private readonly Func<HttpClient> _clientFactory;

        public FplFixtureClient(Func<HttpClient> clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<FplFixture>> GetFixtures()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                const string url = "https://fantasy.premierleague.com/drf/fixtures";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<IEnumerable<FplFixture>>(json);
            }
        }

        public async Task<IEnumerable<FplFixture>> GetFixturesByGameweek(int id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                string url = $"https://fantasy.premierleague.com/drf/fixtures/?event={id}";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<IEnumerable<FplFixture>>(json);
            }
        }
    }
}
