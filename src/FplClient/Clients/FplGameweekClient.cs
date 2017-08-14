using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplGameweekClient : IFplGameweekClient
    {
        private readonly Func<HttpClient> _clientFactory;

        public FplGameweekClient(Func<HttpClient> clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<FplGameweek>> GetGameweeks()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                const string url = "https://fantasy.premierleague.com/drf/events";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<IEnumerable<FplGameweek>>(json);
            }
        }
    }
}
