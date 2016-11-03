using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEntryHistory
    {
        [JsonProperty("chips")]
        public ICollection<FplEntryHistoryChip> Chips { get; set; }

        [JsonProperty("entry")]
        public FplEntry Entry { get; set; }

        [JsonProperty("leagues")]
        public FplEntryLeagues Leagues { get; set; }

        [JsonProperty("season")]
        public ICollection<FplEntrySeasonHistory> SeasonHistory { get; set; }

        [JsonProperty("history")]
        public ICollection<FplEventEntryHistory> GameweekHistory { get; set; }
    }
}
