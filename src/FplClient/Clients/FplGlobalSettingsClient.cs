using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FplClient.Data;
using Newtonsoft.Json;

namespace FplClient.Clients
{
    public class FplGlobalSettingsClient : IFplGlobalSettings
    {
        private readonly Func<HttpClient> _clientFactory;

        public FplGlobalSettingsClient(Func<HttpClient> clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<FplGlobalSettings> GetGlobalSettings()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (var client = _clientFactory())
            {
                const string url = "https://fantasy.premierleague.com/drf/bootstrap-static";

                var json = await client.GetStringAsync(url);

                return JsonConvert.DeserializeObject<FplGlobalSettings>(json);
            }
        }
    }
}
