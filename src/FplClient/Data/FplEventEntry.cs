using System.Collections.Generic;
using Newtonsoft.Json;

namespace FplClient.Data
{
    public class FplEventEntry
    {
        [JsonProperty("leagues")]
        public FplEntryLeagues Leagues { get; set; }

        [JsonProperty("entry_history")]
        public FplEventEntryHistory EventEntryHistory { get; set; }

        [JsonProperty("ce")]
        public string Ce { get; set; }

        [JsonProperty("automatic_subs")]
        public ICollection<FplAutomaticSub> AutomaticSubs { get; set; }

        [JsonProperty("fixtures")]
        public ICollection<FplFixture> Fixture { get; set; }

        [JsonProperty("can_change_captain")]
        public bool CanChangeCaptain { get; set; }

        [JsonProperty("entry")]
        public FplEntry Entry { get; set; }

        [JsonProperty("picks")]
        public ICollection<FplPick> Picks { get; set; }

        [JsonProperty("own_entry")]
        public bool OwnEntry { get; set; }

        [JsonProperty("state")]
        public FplEventEntryState State {get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("active_chip")]
        public string ActiveChip { get; set; }
    }
}
