using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEntryHistory
    {
        [JsonProperty("chips")]
        public ICollection<FplEntryHistoryChip> Chips { get; set; }

        [JsonProperty("past")]
        public ICollection<FplEntrySeasonHistory> SeasonHistory { get; set; }

        [JsonProperty("current")]
        public ICollection<FplEventEntryHistory> GameweekHistory { get; set; }
    }
}
