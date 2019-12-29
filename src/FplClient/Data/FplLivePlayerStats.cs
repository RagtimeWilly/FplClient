using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplLivePlayerStats
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public FplPickStats Stats { get; set; }

        [JsonProperty("explain")]
        public IList<FplLiveFixtureStats> PointsBreakdown { get; set; }
    }
}
