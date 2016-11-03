using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplFixtureStat
    {
        [JsonProperty("a")]
        public ICollection<FplFixtureStatValue> AwayStats { get; set; }

        [JsonProperty("h")]
        public ICollection<FplFixtureStatValue> HomeStats { get; set; }
    }
}
