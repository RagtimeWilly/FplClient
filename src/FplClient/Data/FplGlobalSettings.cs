using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplGlobalSettings
    {
        [JsonProperty("current-event")]
        public int CurrentEvent { get; set; }

        [JsonProperty("next-event")]
        public int NextEvent { get; set; }

        [JsonProperty("last-entry-event")]
        public int LastEntryEvent { get; set; }

        [JsonProperty("teams")]
        public ICollection<FplTeam> Teams { get; set; }

        [JsonProperty("elements")]
        public ICollection<FplPlayer> Players { get; set; }

        [JsonProperty("events")]
        public ICollection<FplEvent> Events { get; set; }

        [JsonProperty("element_types")]
        public ICollection<FplPlayerType> PlayerTypes { get; set; }

        [JsonProperty("game-settings")]
        public FplGameSettings GameSettings { get; set; }

        [JsonProperty("next_event_fixtures")]
        public ICollection<FplFixture> NextEventFixtures { get; set; }

        [JsonProperty("phases")]
        public ICollection<FplPhase> Phases { get; set; }

        [JsonProperty("stats")]
        public FplStats Stats { get; set; }

        [JsonProperty("stats_options")]
        public ICollection<FplStatsOption> StatsOptions { get; set; }

        [JsonProperty("total-players")]
        public long TotalPlayers { get; set; }
    }
}
