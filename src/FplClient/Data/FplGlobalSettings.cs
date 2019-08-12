using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplGlobalSettings
    {
        [JsonProperty("teams")]
        public ICollection<FplTeam> Teams { get; set; }

        [JsonProperty("elements")]
        public ICollection<FplPlayer> Players { get; set; }

        [JsonProperty("events")]
        public ICollection<FplGameweek> Events { get; set; }

        [JsonProperty("element_types")]
        public ICollection<FplPlayerType> PlayerTypes { get; set; }

        [JsonProperty("game_settings")]
        public FplGameSettings GameSettings { get; set; }

        [JsonProperty("phases")]
        public ICollection<FplPhase> Phases { get; set; }

        [JsonProperty("element_stats")]
        public ICollection<FplElementStats> StatsOptions { get; set; }

        [JsonProperty("total_players")]
        public long TotalPlayers { get; set; }
    }
}
