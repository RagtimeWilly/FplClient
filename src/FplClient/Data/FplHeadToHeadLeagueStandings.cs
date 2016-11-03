using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplHeadToHeadLeagueStandings
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("results")]
        public ICollection<FplHeadToHeadLeagueEntry> Entries { get; set; }
    }
}
