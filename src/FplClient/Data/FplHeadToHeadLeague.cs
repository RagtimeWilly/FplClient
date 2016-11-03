using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplHeadToHeadLeague
    {
        [JsonProperty("new_entries")]
        public FplNewLeagueEntries NewEntries { get; set; }

        [JsonProperty("league")]
        public FplHeadToHeadLeagueProperties Properties { get; set; }

        [JsonProperty("standings")]
        public FplHeadToHeadLeagueStandings Standings { get; set; }

        [JsonProperty("matches_next")]
        public FplHeadToHeadLeagueMatches Next { get; set; }

        [JsonProperty("matches_this")]
        public FplHeadToHeadLeagueMatches Current { get; set; }
    }
}
