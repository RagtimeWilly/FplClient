using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplClassicLeague
    {
        [JsonProperty("new_entries")]
        public FplNewLeagueEntries NewEntries { get; set; }

        [JsonProperty("league")]
        public FplClassicLeagueProperties Properties { get; set; }

        [JsonProperty("standings")]
        public FplClassicLeagueStandings Standings { get; set; }
    }
}
