using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplPlayerSummary
    {
        [JsonProperty("history_past")]
        public ICollection<FplPlayerSeasonHistory> SeasonHistory { get; set; }

        [JsonProperty("fixtures")]
        public ICollection<FplPlayerFixture> Fixtures { get; set; }

        [JsonProperty("history")]
        public ICollection<FplPlayerMatchStats> MatchStats { get; set; }
    }
}
