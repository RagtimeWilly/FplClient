using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplLiveGameweekStats
    {
        [JsonProperty("elements")]
        public IList<FplLivePlayerStats> Elements { get; set; }
    }
}
