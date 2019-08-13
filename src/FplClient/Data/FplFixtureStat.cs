using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplFixtureStat
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("a")]
        public ICollection<FplFixtureStatValue> AwayStats { get; set; }

        [JsonProperty("h")]
        public ICollection<FplFixtureStatValue> HomeStats { get; set; }
    }
}
