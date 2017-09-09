using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEntryPicks
    {
        [JsonProperty("entry_history")]
        public FplEventEntryHistory EventEntryHistory { get; set; }

        [JsonProperty("automatic_subs")]
        public ICollection<FplAutomaticSub> AutomaticSubs { get; set; }

        [JsonProperty("picks")]
        public ICollection<FplPick> Picks { get; set; }

        [JsonProperty("active_chip")]
        public string ActiveChip { get; set; }
    }
}
